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

namespace VillaSofia
{
    public partial class FrmBitacoraUsuarios : Form
    {
        public FrmBitacoraUsuarios()
        {
            InitializeComponent();
        }

        ClsLogicaUsuario BitUser = new ClsLogicaUsuario();

        private void txtBusquedaUsuario_TextChanged(object sender, EventArgs e)
        {
             dtgvHistorialBitacora.DataSource = BitUser.HistorialBitacora(txtBusquedaUsuario.Text);
        }

        private void FrmBitacoraUsuarios_Load(object sender, EventArgs e)
        {
             dtgvHistorialBitacora.DataSource = BitUser.HistorialBitacora("");
        }

        private void dtgvHistorialBitacora_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
