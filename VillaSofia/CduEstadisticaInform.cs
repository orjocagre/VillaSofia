using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace VillaSofia
{
    public partial class CduEstadisticaInform : UserControl
    {
        int tipo_usuario;
        VillaSofia vs;
        public CduEstadisticaInform(VillaSofia vs,int tipo_usuario)
        {
            this.vs = vs;
            this.tipo_usuario = tipo_usuario;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
        }

        private void CduPanelVacio_Load(object sender, EventArgs e)
        {
            //this.RPTVentas.RefreshReport();
        }

        private void BtnGenInfor_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = bxz5oysljxjxpbctsnrf-mysql.services.clever-cloud.com; user id = ut6e1oluo4pqdxba; password = 7Vhkn5USbmWWqfmijAJO; persistsecurityinfo = True; database = bxz5oysljxjxpbctsnrf");

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from factura", conexion);//o VISTA
            da.Fill(dt);

            RPTVentas.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DsInforme", dt); //DatasetEstaditic
            RPTVentas.LocalReport.DataSources.Add(rp);
            RPTVentas.RefreshReport();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            vs.Controls.Remove(this);
            vs.Controls.Add(new CduMenuPrincipal(vs, tipo_usuario));
            this.Dispose();
        }
    }
}
