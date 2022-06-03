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

        ClsLogicaUsuario logicUser = new ClsLogicaUsuario();
        private void dtgvHistorialBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusquedaUsuario_TextChanged(object sender, EventArgs e)
        {
           // dtgvHistorialBitacora.DataSource = logicUser.HistorialBitacora(txtBusquedaUsuario.Text);
        }

        private void FrmBitacoraUsuarios_Load(object sender, EventArgs e)
        {
           // dtgvHistorialBitacora.DataSource = logicUser.HistorialBitacora("");
        }
    }
}
