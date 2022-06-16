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
using Logica;

namespace VillaSofia
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsModeloUsuario usuario = new ClsModeloUsuario();
            usuario.Usuario1 = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConfirmarPassword.Text;
            usuario.Nombre = txtNombreUsuario.Text;
            usuario.Id_tpo = cmbx_Tipousuario.SelectedIndex + 2;

            try
            {


                ClsLogicaUsuario control = new ClsLogicaUsuario();
                String respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("HOAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
