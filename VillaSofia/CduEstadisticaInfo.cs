using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
namespace VillaSofia
{
    public partial class CduEstadisticaInfo : UserControl
    {
        public CduEstadisticaInfo()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; user id = root; password = root; persistsecurityinfo = True; database = Villasofia");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from facturacion", conexion);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt); //DatasetEstaditic
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.Refresh();
        }
    }
}
