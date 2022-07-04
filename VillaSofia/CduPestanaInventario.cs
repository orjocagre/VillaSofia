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
    public partial class CduPestanaInventario : UserControl
    {
        public CduPestanaInventario()
        {
            InitializeComponent();
            llenarDgvInventario();
        }

        void llenarDgvInventario()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();

            if (rdbPresentacion.Checked)
            {
                dgvInventario.Columns.Clear();
                DataTable dt = inventario.mostrarInventarioActualEnUds();
                dgvInventario.Columns.Add("id", "ID");
                dgvInventario.Columns[0].Visible = false;
                dgvInventario.Columns.Add("nombre", "NOMBRE");
                dgvInventario.Columns.Add("cantidad", "CANTIDAD");
                dgvInventario.Columns.Add("presentacion", "PRESENTACION");
                dgvInventario.Columns.Add("um", "UM");

                for(int i=0; i<dt.Rows.Count; i++)
                {
                    dgvInventario.Rows.Add();
                    dgvInventario.Rows[i].Cells[0].Value = dt.Rows[i].Field<int>(0);
                    dgvInventario.Rows[i].Cells[1].Value = dt.Rows[i].Field<String>(1);
                    dgvInventario.Rows[i].Cells[2].Value = dt.Rows[i].Field<double>(2);
                    dgvInventario.Rows[i].Cells[3].Value = dt.Rows[i].Field<String>(3) + " de " + dt.Rows[i].Field<double>(4).ToString("#.#");
                    if (dt.Rows[i].Field<String>(3) == "um")
                        dgvInventario.Rows[i].Cells[3].Value = "";
                    dgvInventario.Rows[i].Cells[4].Value = dt.Rows[i].Field<String>(5);
                }
            }
            else
            {
                dgvInventario.Columns.Clear();
                DataTable dt = inventario.mostrarInventarioActualEnUm();
                dgvInventario.Columns.Add("id", "ID");
                dgvInventario.Columns[0].Visible = false;
                dgvInventario.Columns.Add("nombre", "NOMBRE");
                dgvInventario.Columns.Add("cantidad", "CANTIDAD");
                dgvInventario.Columns.Add("um", "UM");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvInventario.Rows.Add();
                    dgvInventario.Rows[i].Cells[0].Value = dt.Rows[i].Field<int>(0);
                    dgvInventario.Rows[i].Cells[1].Value = dt.Rows[i].Field<String>(1);
                    dgvInventario.Rows[i].Cells[2].Value = dt.Rows[i].Field<double>(2);
                    dgvInventario.Rows[i].Cells[3].Value = dt.Rows[i].Field<String>(3);
                }
            }


        }

        private void rdbUm_CheckedChanged(object sender, EventArgs e)
        {
            llenarDgvInventario();

        }

        private void rdbPresentacion_CheckedChanged(object sender, EventArgs e)
        {
            llenarDgvInventario();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
