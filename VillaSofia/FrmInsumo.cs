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
    public partial class FrmInsumo : Form
    {
        VillaSofia vs;
        public FrmInsumo(VillaSofia vs)
        {
            this.vs = vs;
            InitializeComponent();
            llenarCmbUm();
            llenarDgvInsumo("");
        }

        void agregarInsumo()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            String msj = insumo.AgregarInsumo(txtNombre.Text, Convert.ToInt32(cmbUm.SelectedValue), Convert.ToDouble(txtPresentacion.Text), Convert.ToDouble(txtPrecio.Text), 0, txtEnvase.Text);
            if (validarint(msj))
                MessageBox.Show("Insumo guardado correctamente");
            else
                MessageBox.Show(msj);
        }

        void llenarCmbUm()
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            cmbUm.DataSource = insumo.cmbUm();
            cmbUm.ValueMember = "ID";
            cmbUm.DisplayMember = "DESCRIPCION";
        }

        void llenarDgvInsumo(String nombre)
        {
            ClsLogicaInsumo insumo = new ClsLogicaInsumo();
            dgvInsumo.DataSource = insumo.dgvInsumo(nombre);
        }

        Boolean validarint(String a)
        {
            if (a != "")
            {
                try
                {
                    int b = Convert.ToInt32(a);
                    return true;
                }
                catch (FormatException e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarInsumo();
            txtNombre.Text = "";
            txtEnvase.Text = "";
            txtPrecio.Text = "";
            txtPresentacion.Text = "";
            llenarDgvInsumo("");
        }

        private void FrmInsumo_FormClosed(object sender, FormClosedEventArgs e)
        {
            vs.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarDgvInsumo(txtBuscar.Text);
        }
    }
}
