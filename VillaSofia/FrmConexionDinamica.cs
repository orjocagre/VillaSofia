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

            

            String rt = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,"credenciales.txt");
            MessageBox.Show(rt);
            StreamWriter escribir = new StreamWriter(rt);
            try
            {
                escribir.WriteLine(txtHost.Text);

                escribir.WriteLine(txtUsuario.Text);
               
                escribir.WriteLine(txtClave.Text);
              
                escribir.WriteLine(txtNombre_bd.Text);

                MessageBox.Show("Se guardo con Exito el Nuevo servidor! :D");

            }
            catch (Exception)
            {
                MessageBox.Show("Eror al guardar la conexion");

                throw;
            }
           escribir.Close();




            


            


                
            

    }    }
}
