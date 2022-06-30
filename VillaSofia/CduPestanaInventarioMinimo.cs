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
    public partial class CduPestanaInventarioMinimo : UserControl
    {
        DataTable dtMinimos;
        public CduPestanaInventarioMinimo()
        {
            InitializeComponent();
            llenarDgvMinimos("");
        }

        void llenarDgvMinimos(String nombre)
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            dgvMinimos.DataSource = inventario.listarMinimos(nombre);
            dtMinimos = inventario.listarMinimos(nombre);

            for(int i=0; i<dgvMinimos.Rows.Count; i++)
            {
                if(Convert.ToDouble(dgvMinimos.Rows[i].Cells[2].Value) == 0)
                {
                    dgvMinimos.Rows[i].Cells[2].Style.BackColor = Color.MistyRose;

                }

            }

            if(dgvMinimos.Rows.Count == 0)
            {
                if(txtBusqueda.Text.Trim() != "")
                {
                    MessageBox.Show("No se encontraron coincidencias");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarDgvMinimos(txtBusqueda.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();

            for(int i=0; i<dgvMinimos.Rows.Count; i++)
            {
                if ((double)dtMinimos.Rows[i][2] != (double)dgvMinimos.Rows[i].Cells[2].Value)
                {
                    int msj = inventario.editarMinimoInsumo((int)(dgvMinimos.Rows[i].Cells[0].Value), (double)(dgvMinimos.Rows[i].Cells[2].Value));
                    MessageBox.Show(msj.ToString()+" "+ dtMinimos.Rows[i][2]+" "+dgvMinimos.Rows[i].Cells[2].Value);
                }
            }
        }
    }
}
