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
using System.Reflection;
using System.IO;

namespace VillaSofia
{
    public partial class CduEstadisticaInform : UserControl
    {
        int tipo_usuario;
        VillaSofia vs;

        static String rt = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "credenciales.txt");
        static string[] lineas = File.ReadAllLines(rt);
        public CduEstadisticaInform(VillaSofia vs,int tipo_usuario)
        {
            this.vs = vs;
            this.tipo_usuario = tipo_usuario;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            
        }

        static string host = lineas[0];
        static string usuario = lineas[1];
        static string clave = lineas[2];
        static string BaseDatos = lineas[3];

        private void CduPanelVacio_Load(object sender, EventArgs e)
        {
            //this.RPTVentas.RefreshReport();
        }

        private void BtnGenInfor_Click(object sender, EventArgs e)
        {
            //MySqlConnection conexion = new MySqlConnection("server = bxz5oysljxjxpbctsnrf-mysql.services.clever-cloud.com; user id = ut6e1oluo4pqdxba; password = 7Vhkn5USbmWWqfmijAJO; persistsecurityinfo = True; database = bxz5oysljxjxpbctsnrf");
            MySqlConnection conexion = new MySqlConnection("datasource=" + host + ";username=" + usuario + ";password=" + clave + ";database=" + BaseDatos);

        
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
