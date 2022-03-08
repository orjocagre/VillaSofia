using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillaSofia
{
    public partial class CduMenuPrincipal : UserControl
    {
        VillaSofia vs;
        public CduMenuPrincipal(VillaSofia vs)
        {
            this.vs = vs;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduCalendario(vs));
            this.Dispose();
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMostrarReceta(vs));
            this.Dispose();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduFacturacion(vs));
            this.Dispose();
        }

        
    }
}
