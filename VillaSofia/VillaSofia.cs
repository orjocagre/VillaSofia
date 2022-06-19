using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace VillaSofia
{
    public partial class VillaSofia : Form
    {
        int tipousuario = ClsSession.id_tipo;
        private int childFormNumber = 0;
        bool sesionExit;
        public VillaSofia()
        { 

            InitializeComponent();
            sesionExit = false;
        }
       
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void VillaSofia_Load(object sender, EventArgs e)
        {
            

            CduMenuPrincipal mp = new CduMenuPrincipal(this, tipousuario);
            this.Controls.Add(mp);
            
            
            if (tipousuario == 1)
            {
                this.lblAdministrador.Visible = false;
                this.lblCajero.Visible = false;
                this.lblJefeCocina.Visible = false;

                

            }
            else if (tipousuario == 2)
            {
                this.lblCajero.Visible = true;
                this.lblSuperAdmin.Visible = false;
                this.fileMenu.Visible = false;
                this.lblAdministrador.Visible = false;
            }
            else if (tipousuario == 3)
            {
                this.lblJefeCocina.Visible = true;
                this.lblSuperAdmin.Visible = false;
                this.fileMenu.Visible = false;
                this.lblAdministrador.Visible = false;
                this.lblCajero.Visible = false;

            }
            else if (tipousuario == 4)
            {
                this.lblJefeCocina.Visible = true;
                this.lblSuperAdmin.Visible = false;
                this.lblCajero.Visible = false;
            }





        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new FrmProducto(this);
            producto.Show();
            producto.BringToFront();
        }

        private void trabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroTrabajador trabajador = new FrmRegistroTrabajador(this);
            trabajador.Show();
            trabajador.BringToFront();


        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarReceta receta = new FrmIngresarReceta(this,tipousuario);
            receta.Show();
            receta.BringToFront();
        }

        private void inicioSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminstrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.Show();
            registro.BringToFront();
               
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            sesionExit=true;
            this.Close();
            FrmLoginUsuario sesion = new FrmLoginUsuario();
            sesion.Visible = true;

            ClsSession ses=new ClsSession();
           
                
        }

       
        private void VillaSofia_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            if (sesionExit==false)
            {
                Application.Exit();
            }
            

        }

        private void bitacoraDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBitacoraUsuarios bitacora = new FrmBitacoraUsuarios();
            bitacora.Show();
            bitacora.BringToFront();
        }

        private void lblJefeCocina_Click(object sender, EventArgs e)
        {

        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsumo insumo = new FrmInsumo(this);
            this.AddOwnedForm(insumo);
            insumo.Show();
            this.Enabled = false;
        }
    }
}
