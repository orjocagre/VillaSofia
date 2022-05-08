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
    public partial class FrmCancelarFactura : Form
    {
        int idFactura;
        double total;
        double tipoCambio;
        double faltante;
        Boolean deshabilitarEventoChb;
        CduFacturacion fact;
        public FrmCancelarFactura(double total, CduFacturacion fact, int idFactura)
        {
            this.idFactura = idFactura;
            this.total = this.faltante = total;
            this.fact = fact;
            this.deshabilitarEventoChb = false;
            InitializeComponent();

            txtTotal.Text = "C$ " + total.ToString("#,0.00");
            SRtipoCambio.Tipo_Cambio_BCNSoapClient tc = new SRtipoCambio.Tipo_Cambio_BCNSoapClient();
            DateTime hoy = DateTime.Now;
            tipoCambio = tc.RecuperaTC_Dia(hoy.Year, hoy.Month, hoy.Day);
            txtTotalDolares.Text = "$ " + (total / tipoCambio).ToString("#,0.00");

        }
        void mostrarFaltante()
        {
            double tarjeta = txtTarjeta.Text == "" ? 0 : Convert.ToDouble(txtTarjeta.Text);
            double cordobas = txtEfectivoCordobas.Text == "" ? 0 : Convert.ToDouble(txtEfectivoCordobas.Text);
            double dolares = txtEfectivoDolares.Text == "" ? 0 : Convert.ToDouble(txtEfectivoDolares.Text);
            faltante = total - tarjeta - cordobas - (dolares * tipoCambio);

            if (faltante <= 0)
            {
                btnListo.Enabled = true;
                lblFaltante.Visible = false;
            }
            else
            {
                btnListo.Enabled = false;
                lblFaltante.Visible = true;
            }
            if (dolares > 0)
            {
                lblFaltante.Text = "*faltan C$ " + faltante.ToString("#,0.00") + " o " + (faltante / tipoCambio).ToString("#,0.00");
            }
            else
            {
                lblFaltante.Text = "*faltan C$ " + faltante.ToString("#,0.00");
            }
        }


        private void chbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!deshabilitarEventoChb)
            {
                if (chbEfectivo.Checked)
                {
                    if (txtEfectivoCordobas.Text == "" && txtEfectivoDolares.Text == "")
                    {
                        if (txtTarjeta.Text == "")
                        {
                            txtEfectivoCordobas.Text = total.ToString("0.00");
                        }
                        else
                        {
                            txtEfectivoCordobas.Text = faltante.ToString("0.00");
                        }
                    }
                }
                else
                {
                    txtEfectivoCordobas.Text = "";
                    txtEfectivoDolares.Text = "";
                }
            }
        }

        private void chbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (!deshabilitarEventoChb)
            {
                if (chbTarjeta.Checked)
                {
                    if (txtTarjeta.Text == "")
                    {
                        if (txtEfectivoCordobas.Text == "" && txtEfectivoDolares.Text == "")
                        {
                            txtTarjeta.Text = total.ToString("0.00");
                        }
                        else
                        {
                            txtTarjeta.Text = faltante.ToString("0.00");
                        }
                    }
                }
                else
                {
                    txtTarjeta.Text = "";
                }
            }
        }
        void listo()
        {
            double tarjeta = txtTarjeta.Text == "" ? 0 : Convert.ToDouble(txtTarjeta.Text);
            double cordobas = txtEfectivoCordobas.Text == "" ? 0 : Convert.ToDouble(txtEfectivoCordobas.Text);
            double dolares = txtEfectivoDolares.Text == "" ? 0 : Convert.ToDouble(txtEfectivoDolares.Text) * tipoCambio;
            double vuelto = tarjeta + cordobas + dolares - total;

            ClsLogicaFactura factura = new ClsLogicaFactura();
            factura.agregarPagoFactura(idFactura, cordobas + dolares, tarjeta);

            if (vuelto > 0)
            {
                MessageBox.Show("Vuelto: " + vuelto);
            }
            this.Close();
            fact.cancelarFactura();
        }
        private void btnListo_Click(object sender, EventArgs e)
        {
            listo();
        }

        private void txtEfectivoCordobas_TextChanged(object sender, EventArgs e)
        {
            deshabilitarEventoChb = true;
            
            if (txtEfectivoDolares.Text != "" || txtEfectivoCordobas.Text != "")
            {
                chbEfectivo.Checked = true;
            }
            else
            {
                chbEfectivo.Checked = false;
            }
            deshabilitarEventoChb = false;
            mostrarFaltante();
        }

        private void txtEfectivoDolares_TextChanged(object sender, EventArgs e)
        {
            deshabilitarEventoChb = true;

            if (txtEfectivoDolares.Text != "" || txtEfectivoCordobas.Text != "")
            {
                chbEfectivo.Checked = true;
            }
            else
            {
                chbEfectivo.Checked = false;
            }
            deshabilitarEventoChb = false;

            mostrarFaltante();

        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {
            deshabilitarEventoChb = true;

            if (txtTarjeta.Text != "")
            {
                chbTarjeta.Checked = true;
            }
            else
            {
                chbTarjeta.Checked = false;
            }
            deshabilitarEventoChb = false;
            mostrarFaltante();

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
        private void txtTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            //si no es un numero y no es borrar
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.Back)
            {
                //si es un punto
                if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    //si ya habia un punto
                    if (txtTarjeta.Text.Contains("."))
                    {
                        e.SuppressKeyPress = true;
                    }
                    //si no habia ningun numero antes de ese punto
                    else if (txtTarjeta.Text == "")
                    {
                        e.SuppressKeyPress = true;
                        txtTarjeta.Text = "0.";
                        txtTarjeta.SelectionStart = txtTarjeta.Text.Length;
                    }
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            //si es borrar y al borrar solo va a quedar un punto
            else if(e.KeyCode == Keys.Back && txtTarjeta.Text.Length == 2 && txtTarjeta.Text.Substring(0, 1) == "." && txtTarjeta.SelectionStart == 2)
            {
                e.SuppressKeyPress = true;
                txtTarjeta.Text = "";
            }
        }

        private void txtEfectivoCordobas_KeyDown(object sender, KeyEventArgs e)
        {
            //si no es un numero y no es borrar
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.Back)
            {
                //si es un punto
                if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    //si ya habia un punto
                    if (txtEfectivoCordobas.Text.Contains("."))
                    {
                        e.SuppressKeyPress = true;
                    }
                    //si no habia ningun numero antes de ese punto
                    else if (txtEfectivoCordobas.Text == "")
                    {
                        e.SuppressKeyPress = true;
                        txtEfectivoCordobas.Text = "0.";
                        txtEfectivoCordobas.SelectionStart = txtEfectivoCordobas.Text.Length;
                    }
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            //si es borrar y al borrar solo va a quedar un punto
            else if (e.KeyCode == Keys.Back && txtEfectivoCordobas.Text.Length == 2 && txtEfectivoCordobas.Text.Substring(0, 1) == "." && txtEfectivoCordobas.SelectionStart == 2)
            {
                e.SuppressKeyPress = true;
                txtEfectivoCordobas.Text = "";
            }
        }

        private void txtEfectivoDolares_KeyDown(object sender, KeyEventArgs e)
        {
            //si no es un numero y no es borrar
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) && !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) && e.KeyCode != Keys.Back)
            {
                //si es un punto
                if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    //si ya habia un punto
                    if (txtEfectivoDolares.Text.Contains("."))
                    {
                        e.SuppressKeyPress = true;
                    }
                    //si no habia ningun numero antes de ese punto
                    else if (txtEfectivoDolares.Text == "")
                    {
                        e.SuppressKeyPress = true;
                        txtEfectivoDolares.Text = "0.";
                        txtEfectivoDolares.SelectionStart = txtEfectivoDolares.Text.Length;
                    }
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
            //si es borrar y al borrar solo va a quedar un punto
            else if (e.KeyCode == Keys.Back && txtEfectivoDolares.Text.Length == 2 && txtEfectivoDolares.Text.Substring(0, 1) == "." && txtEfectivoDolares.SelectionStart == 2)
            {
                e.SuppressKeyPress = true;
                txtEfectivoDolares.Text = "";
            }
        }


    }
}
