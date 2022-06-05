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
    public partial class CduInventario : UserControl
    {
        int seleccionMenu;
        CduPestanaInventario pinv;
        CduPestanaListaCompras plc;
        CduPestanaRegistrarCompras prc;

        public CduInventario(VillaSofia vs, int tipo_usuario)
        {
            Dock = DockStyle.Fill;
            seleccionMenu = 0;

            

            InitializeComponent();


            //panel de pestana de inventario 
            pinv = new CduPestanaInventario();
            this.Controls.Add(pinv);
            pinv.Location = new Point(0, 110);
            pinv.Size = new Size(this.Width, this.Height - 110);
            pinv.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            pinv.SendToBack();

            //panel de pestana de lista compras 
            plc = new CduPestanaListaCompras();
            this.Controls.Add(plc);
            plc.Location = new Point(0, 110);
            plc.Size = new Size(this.Width, this.Height - 110);
            plc.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            plc.SendToBack();

            //panel de pestana de registrar compras 
            prc = new CduPestanaRegistrarCompras();
            this.Controls.Add(prc);
            prc.Location = new Point(0, 110);
            prc.Size = new Size(this.Width, this.Height - 110);
            prc.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            prc.SendToBack();


            pinv.BringToFront();

        }

        void posicionarSepMenu()
        {
            int ancho, x;
            switch (seleccionMenu)
            {
                case 0:
                    ancho = btnInventario.Width;
                    x = btnInventario.Location.X;
                    break;
                case 1:
                    ancho = btnListaCompras.Width;
                    x = btnListaCompras.Location.X;
                    break;
                case 2:
                    ancho = btnRegistrarCompras.Width;
                    x = btnRegistrarCompras.Location.X;
                    break;
                case 3:
                    ancho = btnAjusteInventario.Width;
                    x = btnAjusteInventario.Location.X;
                    break;
                case 4:
                    ancho = btnKardex.Width;
                    x = btnKardex.Location.X;
                    break;
                case 5:
                    ancho = btnInventarioMinimo.Width;
                    x = btnInventarioMinimo.Location.X;
                    break;
                default:
                    ancho = 1;
                    x = 0;
                    break;
            }
            sepMenu.Width = (int)(ancho * 0.8);
            sepMenu.Location = new Point(x + (int)(ancho * 0.1), sepMenu.Location.Y);
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            seleccionMenu = 0;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Black;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Gray;

         
            
            pinv.BringToFront();
            plc.SendToBack();
            prc.SendToBack();

        }

        private void btnListaCompras_Click(object sender, EventArgs e)
        {
            seleccionMenu = 1;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Gray;
            btnListaCompras.ForeColor = Color.Black;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Gray;

            plc.BringToFront();
            pinv.SendToBack();
            prc.SendToBack();

        }

        private void btnRegistrarCompras_Click(object sender, EventArgs e)
        {
            seleccionMenu = 2;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Gray;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Black;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Gray;

            prc.BringToFront();
            pinv.SendToBack();
            plc.SendToBack();
        }

        private void btnAjusteInventario_Click(object sender, EventArgs e)
        {
            seleccionMenu = 3;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Gray;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Black;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Gray;
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            seleccionMenu = 4;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Gray;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Black;
            btnInventarioMinimo.ForeColor = Color.Gray;
        }

        private void btnInventarioMinimo_Click(object sender, EventArgs e)
        {
            seleccionMenu = 5;
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Gray;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Black;
        }

        private void CduInventario_SizeChanged(object sender, EventArgs e)
        {
            posicionarSepMenu();
            btnInventario.ForeColor = Color.Black;
            btnListaCompras.ForeColor = Color.Gray;
            btnRegistrarCompras.ForeColor = Color.Gray;
            btnAjusteInventario.ForeColor = Color.Gray;
            btnKardex.ForeColor = Color.Gray;
            btnInventarioMinimo.ForeColor = Color.Gray;
        }
    }
}
