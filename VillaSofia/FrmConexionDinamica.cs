using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VillaSofia
{
    public partial class FrmConexionDinamica : Form
    {
        public FrmConexionDinamica()
        {
            InitializeComponent();
        }

        private void FrmConexionDinamica_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarConexion_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\credenciales.txt");
            try
            {
                escribir.WriteLine("host:" + txtHost.Text);

                escribir.WriteLine("usuario:" + txtUsuario.Text);
               
                escribir.WriteLine("Clave:" + txtClave.Text);
              
                escribir.WriteLine("Base de Datos:" + txtNombre_bd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Eror al guardar la conexion");

                throw;
            }
           escribir.Close();




            


            


                
            

    }    }
}
