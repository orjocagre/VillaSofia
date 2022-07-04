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

namespace VillaSofia
{
    public partial class CduPestanaAjusteInventario : UserControl
    {
        public CduPestanaAjusteInventario()
        {
            InitializeComponent();
            llenarDgvInventario();
        }

        void llenarDgvInventario()
        {
            //0id 1nombre 2envase 3presentacion 4um 5inventario
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dgvInventario.DataSource = inventario.listarInventarioReajuste();

            dgvInventario.Columns[0].ReadOnly = true;
            dgvInventario.Columns[1].ReadOnly = true;
            dgvInventario.Columns[2].ReadOnly = true;
            dgvInventario.Columns[3].ReadOnly = true;
            dgvInventario.Columns[4].ReadOnly = true;
            dgvInventario.Columns[5].ReadOnly = false;

            dgvInventario.Columns[0].Visible = false;

        }

        void compararTablas()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            DataTable dtInventarioViejo = inventario.listarInventarioReajusteConPrecio();

            DataTable dtComparacion = new DataTable();
            dtComparacion.Columns.Add("ID", typeof(int));
            dtComparacion.Columns.Add("NOMBRE", typeof(String));
            dtComparacion.Columns.Add("ENVASE", typeof(String));
            dtComparacion.Columns.Add("PRESENTACION", typeof(double));
            dtComparacion.Columns.Add("UM", typeof(String));
            dtComparacion.Columns.Add("INV. SISTEMA", typeof(double));
            dtComparacion.Columns.Add("INV. REAL", typeof(double));
            dtComparacion.Columns.Add("FALTANTE(-) / SOBRENTE", typeof(double));
            dtComparacion.Columns.Add("DIFERENCIA EN DINERO", typeof(double));

            



            for(int i = 0; i < dtInventarioViejo.Rows.Count; i++)
            {
                dtComparacion.Rows.Add();
                dtComparacion.Rows[i][0] = (int)dtInventarioViejo.Rows[i][0];
                dtComparacion.Rows[i][1] = dtInventarioViejo.Rows[i][1].ToString();
                dtComparacion.Rows[i][2] = dtInventarioViejo.Rows[i][2].ToString();
                dtComparacion.Rows[i][3] = (double)dtInventarioViejo.Rows[i][3];
                dtComparacion.Rows[i][4] = dtInventarioViejo.Rows[i][4].ToString();
                dtComparacion.Rows[i][5] = (double)dtInventarioViejo.Rows[i][5];
                dtComparacion.Rows[i][6] = (double)dgvInventario.Rows[i].Cells[5].Value;
                dtComparacion.Rows[i][7] = Math.Round(((double)dtComparacion.Rows[i][6] - (double)dtInventarioViejo.Rows[i][5]),2);
                dtComparacion.Rows[i][8] = Math.Round(((double)dtComparacion.Rows[i][7] * (double)dtInventarioViejo.Rows[i][6]),2);

                if((double)dtComparacion.Rows[i][7] != 0)
                {
                    int msj = inventario.editarExistenciaInsumo((int)dtComparacion.Rows[i][0], (double)dtComparacion.Rows[i][6]);
                    if(msj == 3)
                    {
                        MessageBox.Show("Hubo un error al registrar los datos, por favor intente de nuevo");
                    }

                }

            }

            dgvInventario.DataSource = dtComparacion;
            dgvInventario.ReadOnly = true;
            dgvInventario.Columns[0].Visible = false;
            dgvInventario.Sort(dgvInventario.Columns[7], ListSortDirection.Ascending);
            


        }

        private void dgvInsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInventario.CurrentCell = dgvInventario.SelectedRows[0].Cells[5];
            dgvInventario.BeginEdit(true);
        }

        private void dgvInsumo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(celdaDGVText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(celdaDGVText_KeyPress);
        }

        void celdaDGVText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (Char)46) //punto
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvInsumo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Errores de escritura en el numero ingresado");
        }

        private void btnLimpiarValores_Click(object sender, EventArgs e)
        {
            for(int i=0; i<dgvInventario.Rows.Count; i++)
            {
                dgvInventario.Rows[i].Cells[5].Value = 0;
            }
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            llenarDgvInventario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            compararTablas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean primero = true;

            for (int i = 0; i < dgvInventario.Rows.Count; i++)
            {

                if (dgvInventario.Rows[i].Cells[1].Value.ToString().Contains(txtBusqueda.Text))
                {

                    if (primero)
                    {
                        dgvInventario.Rows[i].Selected = true;
                        dgvInventario.FirstDisplayedScrollingRowIndex = i;
                        primero = false;
                    }
                }
            }

            if (primero)
            {
                MessageBox.Show("No se encontraron coincidencias");
                txtBusqueda.Focus();
                txtBusqueda.SelectionStart = 0;
                txtBusqueda.SelectionLength = txtBusqueda.Text.Length;
            }
        }
    }
}
