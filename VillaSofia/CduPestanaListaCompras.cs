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
            dtpRegistroLista.Visible = !dtpRegistroLista.Visible;
        }
    }
}
