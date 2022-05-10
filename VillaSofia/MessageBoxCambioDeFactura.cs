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
    public partial class MessageBoxCambioDeFactura : Form
    {
        CduFacturacion fact;
        VillaSofia vs;
        public MessageBoxCambioDeFactura(CduFacturacion fact, VillaSofia vs)
        {
            InitializeComponent();
            this.fact = fact;
            this.vs = vs;
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            fact.cerrarFacturaMessageBox();
            this.Close();
        }

        private void MessageBoxCambioDeFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            vs.Enabled = true;
        }

        private void btnDejarAbierta_Click(object sender, EventArgs e)
        {
            fact.dejarAbiertaMessageBox();
            this.Close();
        }
    }
}
