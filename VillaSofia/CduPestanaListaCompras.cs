using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaSofia
{
    public partial class CduPestanaListaCompras : UserControl
    {
        public CduPestanaListaCompras()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarLista_Click(object sender, EventArgs e)
        {
            if(dtpRegistroLista.Visible)
            {
                dtpRegistroLista.Visible = false;
                btnBuscarLista.Image = Properties.Resources.buscarNegro;
                dgvRegistroListas.Location = new Point(dgvRegistroListas.Location.X, dgvRegistroListas.Location.Y - dtpRegistroLista.Height - 2);
                dgvRegistroListas.Height = dgvRegistroListas.Height + dtpRegistroLista.Height;
            }
            else
            {
                dtpRegistroLista.Visible = true;
                btnBuscarLista.Image = Properties.Resources.buscarAzul;
                dgvRegistroListas.Location = new Point(dgvRegistroListas.Location.X, dgvRegistroListas.Location.Y + dtpRegistroLista.Height + 2);
                dgvRegistroListas.Height = dgvRegistroListas.Height - dtpRegistroLista.Height;

            }

        }
    }
}
