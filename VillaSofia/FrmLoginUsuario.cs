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
using System.Windows;
using System.Net.NetworkInformation;

namespace VillaSofia
{
    public partial class FrmLoginUsuario : Form
    {
        Logica.ClsLogicaUsuario objetoN = new Logica.ClsLogicaUsuario();

        Boolean clave_visible = false;

        public FrmLoginUsuario()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registro = new FrmRegistroUsuario();
            registro.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLoginUsuario_Load(object sender, EventArgs e)
        {
            //this.btnregistro.Visible = false;
            //this.lblregistro.Visible = false;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.Text = "CONTRASEÑA";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtpassword.Text;

            try
            {
                ClsLogicaUsuario ctrl = new ClsLogicaUsuario();
                DataTable DT = new DataTable();


                DT = objetoN.LoginSis(usuario, password);
                //---------
                string respuesta = ctrl.crtlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VillaSofia frm = new VillaSofia();
                    frm.Visible = true;
                    this.Visible = false;


                }
                //--------
                
                if (DT.Rows.Count == 1)
                {
                    string Logueo = DT.Rows[0][6].ToString();
                    if (Logueo != "True")
                    { //revision de estos apartados
                        string id = DT.Rows[0][0].ToString();
                        string rol = DT.Rows[0][4].ToString();
                        string nombre = DT.Rows[0][5].ToString();
                        string apellido = DT.Rows[0][6].ToString();

                        CambiarEstado(id, "Activado");

                        String fecha = DateTime.Now.ToString("yyy/MM/dd");
                        String hora = DateTime.Now.ToString("HH:m:s");
                        String mac = ObtenerIp();

                        objetoN.IniciarSesion(Convert.ToInt32(id), fecha, hora, mac);

                        //MessageBox.Show("Bienvenido " + rol.ToString());
                        //                                ant (TxtUsuario.Text)
                        VillaSofia SESION = new VillaSofia();
                        //CduMenuPrincipal SESSION = new CduMenuPrincipal();
                        //SESION.setUserLabel(infoUser);

                        //SESION.AsignarID(id);
                        //SESSION.Mostrar();


                        //SESION.Show();
                       //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una sesión iniciada para este usuario");
                    }
                }
                else
                {
                    //revisar esta mierda
                    MessageBox.Show("No existen coincidencias");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }/*catch (MySql.Data.MySqlClient.MySqlException exc)
            {
                MessageBox.Show("Revisa la conexión a internet para accesar al sistema");
            }*/

        }


        //si aja 
        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BorderThickness = 1;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BorderThickness = 0;
        }
       
        private void FrmLoginUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        //si aja


        //practicamente el trigger que se ativa al iniciar session bitacora
        void CambiarEstado(string id, string accion)
        {
            ClsLogicaUsuario objeto = new ClsLogicaUsuario();

            string mensaje = objeto.Lou(id, accion);
        }

        //ocultacion de la contraseña
        private void txtpassword_IconRightClick(object sender, EventArgs e)
        {
            clave_visible = (!clave_visible);
            if(clave_visible) {
                txtpassword.IconRight = Properties.Resources.ojo_Abierto;
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.IconRight = Properties.Resources.ojo_Cerrado;
                txtpassword.UseSystemPasswordChar = true;
            }
           
        }

        public static string ObtenerIp()
        {
            string Mac = "";
            foreach (NetworkInterface NIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (NIC.OperationalStatus == OperationalStatus.Up)
                {
                    Mac += NIC.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return Mac;
        }
    }
}
