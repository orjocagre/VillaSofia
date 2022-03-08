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
    public partial class FrmCierreCaja : Form
    {
        public FrmCierreCaja()
        {
            InitializeComponent();
            llenarDgvFacturas();
        }

        void llenarDgvFacturas()
        {
            ClsLogicaFactura factura = new ClsLogicaFactura();
            DataTable DT = factura.listarFacturas(DateTime.Now);
           

            double tot = 0;
            double efe = 0;
            double tar = 0;

            for(int i=0; i<DT.Rows.Count; i++)
            {
                dgvFacturas.Rows.Add();
                dgvFacturas.Rows[i].Cells[0].Value = DT.Rows[i][0];
                dgvFacturas.Rows[i].Cells[1].Value = DT.Rows[i].Field<double>(1).ToString("#,#.00");

                tot += DT.Rows[i].Field<double>("TOTAL");
                efe += DT.Rows[i].Field<double>("EFECTIVO");
                tar += DT.Rows[i].Field<double>("TARJETA");

            }

            txtFacturado.Text = "C$   " + tot.ToString("#,#.00");
            txtEfectivo.Text = "C$   " + efe.ToString("#,#.00");
            txtTarjeta.Text = "C$   " + tar.ToString("#,#.00");
            txtNumMesas.Text = DT.Rows.Count.ToString();

        }


        private void FrmCierreCaja_Load(object sender, EventArgs e)
        {

        }
    }
}
