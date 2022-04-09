using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Guna.UI2.WinForms;

namespace VillaSofia
{
    public partial class FrmDividirCuenta : Form
    {
        int idFactura;
        int idNuevaFactura;
        int idCmbMesero;
        Boolean todos;

        public FrmDividirCuenta(int idFactura, int idCmbMesero)
        {
            this.idCmbMesero = idCmbMesero;
            this.idFactura = idFactura;
            todos = false;
            InitializeComponent();
            mostrarFactura();
        }
        void mostrarFactura()
        {
            dgvCuenta.Rows.Clear();
            ClsLogicaOrden orden = new ClsLogicaOrden();
            ClsLogicaFactura factura = new ClsLogicaFactura();
            DataTable DT = factura.infoFactura(idFactura);
            MessageBox.Show("Mesero " + DT.Rows[0][5]);
            MessageBox.Show("Nombre" + DT.Rows[0].Field<String>(3));
            MessageBox.Show("RUC " + DT.Rows[0].Field<String>(4));

            DT = orden.listarOrdenes(idFactura);
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                dgvCuenta.Rows.Add();
                //MessageBox.Show(DT.Rows[i].Field<int>("ID")+" "+ DT.Rows[i].Field<double>("CANTIDAD")+" "+ DT.Rows[i].Field<int>("NOMBRE")+" "+ DT.Rows[i].Field<int>("PRECIO"));

                dgvCuenta.Rows[i].Cells[0].Value = DT.Rows[i].Field<int>("ID");
                dgvCuenta.Rows[i].Cells[1].Value = DT.Rows[i].Field<int>("CANTIDAD");
                dgvCuenta.Rows[i].Cells[2].Value = DT.Rows[i].Field<String>("NOMBRE");
                dgvCuenta.Rows[i].Cells[3].Value = DT.Rows[i].Field<double>("PRECIO");
            }

            calcularTotalesFactura(dgvCuenta, txtTotal);

        }

        void calcularTotalesFactura(Guna2DataGridView dataGrid, Guna2TextBox txt)
        {
            try
            {
                double total = 0;
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    dataGrid.Rows[i].Cells[4].Value = Convert.ToDouble(dataGrid.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGrid.Rows[i].Cells[3].Value);
                    total += (double)dataGrid.Rows[i].Cells[4].Value;

                }
                txt.Text = total.ToString("0,0.##");

                lblError.Visible = false;

            }
            catch (FormatException ex)
            {
                lblError.Visible = true;
                txt.Text = "";
            }
        }

        void agregarASubCuenta()
        {
            if (dgvCuenta.SelectedRows.Count > 0)
            {
                int posicion = -1;
                for (int i = 0; i < dgvSubCuenta.RowCount; i++)
                {
                    if (dgvSubCuenta.Rows[i].Cells[0].Value == dgvCuenta.SelectedRows[0].Cells[0].Value)
                    {
                        posicion = i;
                        i = dgvSubCuenta.RowCount;
                    }
                }
                // si no esta en la sub cuenta
                if (posicion == -1)
                {
                    dgvSubCuenta.Rows.Add();
                    posicion = dgvSubCuenta.RowCount - 1;

                    dgvSubCuenta.Rows[posicion].Cells[0].Value = dgvCuenta.SelectedRows[0].Cells[0].Value;
                    dgvSubCuenta.Rows[posicion].Cells[1].Value = 0;
                    dgvSubCuenta.Rows[posicion].Cells[2].Value = dgvCuenta.SelectedRows[0].Cells[2].Value;
                    dgvSubCuenta.Rows[posicion].Cells[3].Value = dgvCuenta.SelectedRows[0].Cells[3].Value;
                }

                int cantActualDestino = Convert.ToInt32(dgvSubCuenta.Rows[posicion].Cells[1].Value);
                int cantActualOrigen = Convert.ToInt32(dgvCuenta.SelectedRows[0].Cells[1].Value);

                if (todos)
                {
                    dgvSubCuenta.Rows[posicion].Cells[1].Value = cantActualDestino + cantActualOrigen;
                    dgvCuenta.Rows.Remove(dgvCuenta.SelectedRows[0]);
                }
                else
                {
                    dgvSubCuenta.Rows[posicion].Cells[1].Value = ++cantActualDestino;
                    dgvCuenta.SelectedRows[0].Cells[1].Value = --cantActualOrigen;

                    if (cantActualOrigen < 1)
                    {
                        dgvCuenta.Rows.Remove(dgvCuenta.SelectedRows[0]);
                    }
                }
                calcularTotalesFactura(dgvCuenta, txtTotal);
                calcularTotalesFactura(dgvSubCuenta, txtTotalSC);
            }
        }
        void agregarNuevaFactura()
        {
            ClsLogicaFactura fact = new ClsLogicaFactura();
            int msj = fact.agregarFactura(DateTime.Now, 1, "", "", -1, 1);
            if (msj == -3)
            {
                MessageBox.Show("Error en sintaxis Sql");
            }
            else
            {
                idNuevaFactura = msj;
            }
        }
        void guardarFacturas()
        {
            ClsLogicaOrden orden = new ClsLogicaOrden();
            ClsLogicaFactura factura = new ClsLogicaFactura();

            orden.vaciarFactura(idFactura);
            for (int i = 0; i < dgvCuenta.RowCount; i++)
            {
                orden.agregarOrden(Convert.ToInt32(dgvCuenta.Rows[i].Cells[0].Value), idFactura, Convert.ToDouble(dgvCuenta.Rows[i].Cells[1].Value), Convert.ToDouble(dgvCuenta.Rows[i].Cells[3].Value));
            }
            factura.guardarTotalFactura(idFactura, Convert.ToDouble(txtTotal.Text));

            for (int i = 0; i < dgvSubCuenta.RowCount; i++)
            {
                orden.agregarOrden(Convert.ToInt32(dgvSubCuenta.Rows[i].Cells[0].Value), idNuevaFactura, Convert.ToDouble(dgvSubCuenta.Rows[i].Cells[1].Value), Convert.ToDouble(dgvSubCuenta.Rows[i].Cells[3].Value));
            }
            factura.guardarTotalFactura(idNuevaFactura, Convert.ToDouble(txtTotalSC.Text));

            factura.agregarDatosFactura(idNuevaFactura, "", "", idCmbMesero);
        }

        void quitarDeSubCuenta()
        {
            if (dgvSubCuenta.SelectedRows.Count > 0)
            {
                int posicion = -1;
                for (int i = 0; i < dgvCuenta.RowCount; i++)
                {
                    if (dgvCuenta.Rows[i].Cells[0].Value == dgvSubCuenta.SelectedRows[0].Cells[0].Value)
                    {
                        posicion = i;
                        i = dgvCuenta.RowCount;
                    }
                }
                // si no esta en la sub cuenta
                if (posicion == -1)
                {
                    dgvCuenta.Rows.Add();
                    posicion = dgvCuenta.RowCount - 1;

                    dgvCuenta.Rows[posicion].Cells[0].Value = dgvSubCuenta.SelectedRows[0].Cells[0].Value;
                    dgvCuenta.Rows[posicion].Cells[1].Value = 0;
                    dgvCuenta.Rows[posicion].Cells[2].Value = dgvSubCuenta.SelectedRows[0].Cells[2].Value;
                    dgvCuenta.Rows[posicion].Cells[3].Value = dgvSubCuenta.SelectedRows[0].Cells[3].Value;
                }

                int cantActualDestino = Convert.ToInt32(dgvCuenta.Rows[posicion].Cells[1].Value);
                int cantActualOrigen = Convert.ToInt32(dgvSubCuenta.SelectedRows[0].Cells[1].Value);

                if (todos)
                {
                    dgvCuenta.Rows[posicion].Cells[1].Value = cantActualDestino + cantActualOrigen;
                    dgvSubCuenta.Rows.Remove(dgvSubCuenta.SelectedRows[0]);
                }
                else
                {
                    dgvCuenta.Rows[posicion].Cells[1].Value = ++cantActualDestino;
                    dgvSubCuenta.SelectedRows[0].Cells[1].Value = --cantActualOrigen;

                    if (cantActualOrigen < 1)
                    {
                        dgvSubCuenta.Rows.Remove(dgvSubCuenta.SelectedRows[0]);
                    }
                }
                calcularTotalesFactura(dgvCuenta, txtTotal);
                calcularTotalesFactura(dgvSubCuenta, txtTotalSC);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarASubCuenta();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            quitarDeSubCuenta();
        }

        private void dgvSubCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            quitarDeSubCuenta();
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            agregarASubCuenta();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            if (btnTodos.Text == "TODOS")
            {
                btnTodos.Text = "UNO";
                todos = false;
            }
            else
            {
                btnTodos.Text = "TODOS";
                todos = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (dgvSubCuenta.RowCount > 0)
            {
                agregarNuevaFactura();
                guardarFacturas();
                dgvSubCuenta.Rows.Clear();
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
