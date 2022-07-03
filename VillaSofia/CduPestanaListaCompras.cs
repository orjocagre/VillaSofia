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
    public partial class CduPestanaListaCompras : UserControl
    {
        Boolean esAntigua;
        DataTable dtPresentacionCompras, dtPresentacionTodos, dtUMCompras, dtUMTodos;
        public CduPestanaListaCompras()
        {
            esAntigua = false;
            InitializeComponent();
            llenarDgvRegistroListas();
            dtpRegistroLista.Value = DateTime.Now;
        }

        void actualizarDatatables()
        {
            int pos = dgvCompras.SelectedRows[0].Index;

            if (rdbTodos.Checked)
            {
                if (rdbPresentacion.Checked)
                {

                    double precioPrecentacion = ((double)dtUMTodos.Rows[pos][6] / (double)dtUMTodos.Rows[pos][5]) * (double)dtUMTodos.Rows[pos][7];

                    double compra = (double)dgvCompras.Rows[pos].Cells[5].Value;

                    dgvCompras.Rows[pos].Cells[6].Value = compra * precioPrecentacion;

                    recalcularUM(pos);
                }
                else
                {
                    double precioUM = ((double)dtPresentacionTodos.Rows[pos][6] / (double)dtPresentacionTodos.Rows[pos][5]) / (double)dtPresentacionTodos.Rows[pos][7];

                    double compra = (double)dgvCompras.Rows[pos].Cells[5].Value;

                    dgvCompras.Rows[pos].Cells[6].Value = compra * precioUM;

                    recalcularPresentacion(pos);
                }
            }
            else
            {
                if (rdbPresentacion.Checked)
                {
                    int posDtTodos = 0;
                    for(int i=0; i<dtPresentacionTodos.Rows.Count; i++)
                    {
                        if((int)dtPresentacionTodos.Rows[i][0] == (int)dgvCompras.Rows[pos].Cells[0].Value)
                        {
                            posDtTodos = i;
                            i = dtPresentacionTodos.Rows.Count;
                        }
                    }

                    double precioPrecentacion = ((double)dtUMTodos.Rows[posDtTodos][6] / (double)dtUMTodos.Rows[posDtTodos][5]) * (double)dtUMTodos.Rows[posDtTodos][7];

                    double compra = (double)dgvCompras.Rows[pos].Cells[5].Value;

                    dtPresentacionTodos.Rows[posDtTodos][5] = compra;
                    dtPresentacionTodos.Rows[posDtTodos][6] = compra * precioPrecentacion;

                    recalcularUM(posDtTodos);
                }
                else
                {
                    int posDtTodos = 0;
                    for (int i = 0; i < dtUMTodos.Rows.Count; i++)
                    {
                        if ((int)dtUMTodos.Rows[i][0] == (int)dgvCompras.Rows[pos].Cells[0].Value)
                        {
                            posDtTodos = i;
                            i = dtUMTodos.Rows.Count;
                        }
                    }

                    double precioUm = ((double)dtPresentacionTodos.Rows[posDtTodos][6] / (double)dtPresentacionTodos.Rows[posDtTodos][5]) / (double)dtPresentacionTodos.Rows[posDtTodos][7];

                    double compra = (double)dgvCompras.Rows[pos].Cells[5].Value;

                    dtUMTodos.Rows[posDtTodos][5] = compra;
                    dtUMTodos.Rows[posDtTodos][6] = compra * precioUm;

                    recalcularPresentacion(posDtTodos);
                }
            }


            calcularTotal();
        }

        void calcularTotal()
        {
            double total = 0;

            for (int i = 0; i < dgvCompras.Rows.Count; i++)
            {
                total += (double)dgvCompras.Rows[i].Cells[6].Value;
            }
            lblCostoEstimado.Text = "COSTO ESTIMADO: C$ " + total.ToString("#,0.00");
        }
        


        void generarListaCompras()
        {
            esAntigua = false;
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dtPresentacionCompras = inventario.generarListaComprasPresentacion();
            dtPresentacionTodos = inventario.generarListaComprasPresentacionTodos();
            dtUMCompras = inventario.generarListaComprasUM();
            dtUMTodos = inventario.generarListaComprasUMTodos();



            for (int i = 0; i < dtPresentacionTodos.Rows.Count; i++)
            {
               


                if (Convert.ToDouble(dtPresentacionTodos.Rows[i][5]) <= 0)
                {
                    dtPresentacionTodos.Rows[i][5] = 0;
                    dtUMTodos.Rows[i][5] = 0;
                    dtPresentacionTodos.Rows[i][6] = 0;
                    dtUMTodos.Rows[i][6] = 0;

                }
            }

            llenarDgvCompras();
        }


        void recalcularUM(int indexDT)
        {
            dtUMTodos.Rows[indexDT][5] = (double)dtPresentacionTodos.Rows[indexDT][5] * (double)dtUMTodos.Rows[indexDT][7];
            dtUMTodos.Rows[indexDT][6] = (double)dtPresentacionTodos.Rows[indexDT][6];
        
            generarListaComprasResumidas();
        }

        void recalcularPresentacion(int indexDT)
        {
            dtPresentacionTodos.Rows[indexDT][5] = (double)dtUMTodos.Rows[indexDT][5] / (double)dtPresentacionTodos.Rows[indexDT][7];
            dtPresentacionTodos.Rows[indexDT][6] = (double)dtUMTodos.Rows[indexDT][6];

            generarListaComprasResumidas();
        }


        void generarListaComprasResumidas()
        {
            dtPresentacionCompras.Rows.Clear();
            
            for(int i=0; i<dtPresentacionTodos.Rows.Count; i++)
            {
                if((double)dtPresentacionTodos.Rows[i][5] > 0)
                {
                    dtPresentacionCompras.Rows.Add();
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][0] = (int)(dtPresentacionTodos.Rows[i][0]);
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][1] = (dtPresentacionTodos.Rows[i][1]).ToString();
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][2] = (dtPresentacionTodos.Rows[i][2]).ToString();
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][3] = (double)(dtPresentacionTodos.Rows[i][3]);
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][4] = (double)(dtPresentacionTodos.Rows[i][4]);
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][5] = (double)(dtPresentacionTodos.Rows[i][5]);
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][6] = (double)(dtPresentacionTodos.Rows[i][6]);
                    dtPresentacionCompras.Rows[dtPresentacionCompras.Rows.Count - 1][7] = (double)(dtPresentacionTodos.Rows[i][7]);
                }
            }

            dtUMCompras.Rows.Clear();

            for (int i = 0; i < dtUMTodos.Rows.Count; i++)
            {
                if ((double)dtUMTodos.Rows[i][5] > 0)
                {
                    dtUMCompras.Rows.Add();
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][0] = (int)(dtUMTodos.Rows[i][0]);
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][1] = (dtUMTodos.Rows[i][1]).ToString();
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][2] = (dtUMTodos.Rows[i][2]).ToString();
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][3] = (double)(dtUMTodos.Rows[i][3]);
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][4] = (double)(dtUMTodos.Rows[i][4]);
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][5] = (double)(dtUMTodos.Rows[i][5]);
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][6] = (double)(dtUMTodos.Rows[i][6]);
                    dtUMCompras.Rows[dtUMCompras.Rows.Count - 1][7] = (double)(dtUMTodos.Rows[i][7]);
                }
            }
        }

        void cargarListaCompras(int idListaCompras)
        {
            esAntigua = true;
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dtPresentacionCompras = inventario.generarListaComprasPresentacion(idListaCompras);
            dtPresentacionTodos = inventario.generarListaComprasPresentacionTodos(idListaCompras);
            dtUMCompras = inventario.generarListaComprasUM(idListaCompras);
            dtUMTodos = inventario.generarListaComprasUMTodos(idListaCompras);


            //for(int i=0; i<dtPresentacionTodos.Rows.Count; i++)
            //{
            //    if(Convert.ToDouble(dtPresentacionTodos.Rows[i][5]) <= 0)
            //    {
            //        dtPresentacionTodos.Rows[i][5] = 0;
            //        dtUMTodos.Rows[i][5] = 0;
            //        dtPresentacionTodos.Rows[i][6] = 0;
            //        dtUMTodos.Rows[i][6] = 0;

            //    }
            //}

            llenarDgvCompras();
        }

        

        void llenarDgvCompras()
        {
            if (rdbPresentacion.Checked)
            {
                if (rdbCompras.Checked)
                {
                    dgvCompras.DataSource = dtPresentacionCompras;
                }
                else
                {
                    dgvCompras.DataSource = dtPresentacionTodos;
                }
            }
            else
            {
                if (rdbCompras.Checked)
                {
                    dgvCompras.DataSource = dtUMCompras;
                }
                else
                {
                    dgvCompras.DataSource = dtUMTodos;
                }
            }
            dgvCompras.Columns[0].ReadOnly = true;
            dgvCompras.Columns[1].ReadOnly = true;
            dgvCompras.Columns[2].ReadOnly = true;
            dgvCompras.Columns[3].ReadOnly = true;
            dgvCompras.Columns[4].ReadOnly = true;
            dgvCompras.Columns[5].ReadOnly = esAntigua;
            dgvCompras.Columns[6].ReadOnly = true;
            dgvCompras.Columns[7].Visible = false;

            calcularTotal();
        }

        void llenarDgvRegistroListas(DateTime fecha)
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dgvRegistroListas.DataSource = inventario.listarListasCompras(fecha);
            dgvRegistroListas.Columns[0].Visible = false;
        }
        void llenarDgvRegistroListas()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dgvRegistroListas.DataSource = inventario.listarListasCompras();
            dgvRegistroListas.Columns[0].Visible = false;

        }

        private void btnBuscarLista_Click(object sender, EventArgs e)
        {
            if(dtpRegistroLista.Visible)
            {
                dtpRegistroLista.Visible = false;
                btnBuscarLista.Image = Properties.Resources.buscarNegro;
                dgvRegistroListas.Location = new Point(dgvRegistroListas.Location.X, dgvRegistroListas.Location.Y - dtpRegistroLista.Height - 2);
                dgvRegistroListas.Height = dgvRegistroListas.Height + dtpRegistroLista.Height;
                llenarDgvRegistroListas();
            }
            else
            {
                dtpRegistroLista.Visible = true;
                btnBuscarLista.Image = Properties.Resources.buscarAzul;
                dgvRegistroListas.Location = new Point(dgvRegistroListas.Location.X, dgvRegistroListas.Location.Y + dtpRegistroLista.Height + 2);
                dgvRegistroListas.Height = dgvRegistroListas.Height - dtpRegistroLista.Height;

            }

        }

     

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            Boolean primero = true;

            for (int i=0; i<dgvCompras.Rows.Count; i++)
            {

                if (dgvCompras.Rows[i].Cells[1].Value.ToString().Contains(txtBusqueda.Text))
                {
                    
                    dgvCompras.Rows[i].Cells[0].Style.BackColor = Color.Yellow;
                    dgvCompras.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                    dgvCompras.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                    dgvCompras.Rows[i].Cells[3].Style.BackColor = Color.Yellow;
                    dgvCompras.Rows[i].Cells[4].Style.BackColor = Color.Yellow;
                    dgvCompras.Rows[i].Cells[5].Style.BackColor = Color.Yellow;


                    if (primero)
                    {
                        dgvCompras.Rows[i].Selected = true;
                        dgvCompras.FirstDisplayedScrollingRowIndex = i;
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

        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCompras.CurrentCell = dgvCompras.SelectedRows[0].Cells[5];
            dgvCompras.BeginEdit(true);

            
        }

        private void dgvCompras_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

       

        private void dgvCompras_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Errores de escritura en el numero ingresado");
        }

        private void dgvCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actualizarDatatables();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rdbTodos.Checked = true;
            rdbPresentacion.Checked = true;

            ClsLogicaInventario inventario = new ClsLogicaInventario();
            int idListaCompras = inventario.agregarListaCompras();
            Boolean error = false;
            for(int i=0; i<dgvCompras.Rows.Count; i++)
            {
                int x = inventario.agregarInsumoListaCompras((int)dtPresentacionTodos.Rows[i][0], idListaCompras, dtPresentacionTodos.Rows[0][2].ToString(), (double)dtUMTodos.Rows[i][3], (double)dtPresentacionTodos.Rows[i][7],(double)(dgvCompras.Rows[i].Cells[6].Value), (double)dtUMTodos.Rows[i][4], (double)(dgvCompras.Rows[i].Cells[5].Value));
                if(x == 3 || x == 2)
                {
                    error = true;
                }                
            }
            if (error)
                MessageBox.Show("Hubo un problema al guardar los datos, por favor intente de nuevo");
            else
            {
                MessageBox.Show("Lista de compras guardada correctamente");
                llenarDgvRegistroListas();
            }
        }

        private void dgvRegistroListas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarListaCompras(Convert.ToInt32(dgvRegistroListas.Rows[dgvRegistroListas.SelectedRows[0].Index].Cells[0].Value));
        }

        private void dtpRegistroLista_ValueChanged(object sender, EventArgs e)
        {
            if (dtpRegistroLista.Visible)
            {
                llenarDgvRegistroListas(dtpRegistroLista.Value);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            generarListaCompras();
        }

        private void rdbPresentacion_CheckedChanged(object sender, EventArgs e)
        {
            int posi = dgvCompras.FirstDisplayedScrollingRowIndex;
            int seleccionado = dgvCompras.SelectedRows[0].Index;
            llenarDgvCompras();
            dgvCompras.FirstDisplayedScrollingRowIndex = posi;
            dgvCompras.Rows[seleccionado].Selected = true;

        }

        private void rdbCompras_CheckedChanged(object sender, EventArgs e)
        {
            llenarDgvCompras();
        }



       
    }
}
