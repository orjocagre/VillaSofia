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
        int tipo_usuario;
        public CduMenuPrincipal(VillaSofia vs, int tipo_usuario)
        { this.tipo_usuario = tipo_usuario;
            this.vs = vs;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduCalendario(vs,tipo_usuario));
            this.Dispose();
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMostrarReceta(vs,tipo_usuario));
            this.Dispose();

        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduFacturacion(vs,tipo_usuario));
            this.Dispose();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMenuPrincipal(vs,tipo_usuario));
            this.Dispose();

        }

        private void pnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }


        void Mostrar()
        {

            if (tipo_usuario==1)
            { //dami

                
            }
            if (tipo_usuario == 2)
            { //cajero
                this.btnCaja.Visible = true;
                this.btnMenu.Visible = false;
                this.btnVentas.Visible = false;
                
            }
            if (tipo_usuario==3)
            {//jefe de cocina


                this.btnCaja.Visible = false;
                this.btnMenu.Visible = true;
                this.btnVentas.Visible = false;

            }


        }
    }
}
