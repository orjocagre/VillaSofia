﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace VillaSofia
{
    public partial class CduMostrarReceta : UserControl
    {

        int idReceta;
        VillaSofia principal;
        int tipo_usuario;
        public CduMostrarReceta(VillaSofia principal, int tipo_usuario)
        {     this.tipo_usuario = tipo_usuario;
            this.principal = principal;
            idReceta = -1;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            this.tipo_usuario = tipo_usuario;
        }





        private void CduMostrarReceta_Load(object sender, EventArgs e)
        {
            LoadRecetas("");
           

        }

        void LoadRecetas(String x)
        {
            ClsLogicaAddReceta Load = new ClsLogicaAddReceta();

            DgvRecetas.DataSource = Load.RecetaListaConNom(x);
            DgvRecetas.Columns[0].Visible = false;
            DgvRecetas.Columns[2].Visible = false;
            DgvRecetas.Columns[3].Visible = false;
        }
        void LoadInsumos(String x)
        {
            CLsLogicaInsumoReceta Load = new CLsLogicaInsumoReceta();

            DgvInsumos.DataSource = Load.ListarInsumos(x);
           
            DgvInsumos.Columns[0].Visible = false;
            DgvInsumos.Columns[1].Visible = false;
            DgvInsumos.Columns[2].Visible = false;
            DgvInsumos.Columns[6].Visible = false;
            DgvInsumos.Columns[7].Visible = false;

            DgvInsumos.Columns[3].FillWeight = 2;
            DgvInsumos.Columns[4].FillWeight = 0.5F;
            DgvInsumos.Columns[5].FillWeight = 1;

        }

        void eliminarReceta()
        {
            ClsLogicaAddReceta receta = new ClsLogicaAddReceta();
            receta.eliminarReceta(idReceta);
            LblNombreReceta.Text = "Seleccione una receta";
            lblNumPorc.Text = "0";
            txtProcedimiento.Text = "";
            idReceta = -1;
            LoadInsumos("-1");
            LoadRecetas("");
        }

     
        private void TxtBuscarReceta_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarReceta.Text == " ")
            {
                try
                {
                    DgvRecetas.Columns.Clear();
                }
                catch (Exception er)
                {


                }

            }
            else
            {
                LoadRecetas(TxtBuscarReceta.Text);
            }
        }

      
        private void TxtBuscarReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre de la Receta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                    
                }

            }
        }

        private void DgvRecetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = DgvRecetas.SelectedRows[0].Cells[0].Value.ToString();
            idReceta = Convert.ToInt32(id);
            Convert.ToInt32(id);
            ClsLogicaAddReceta producto = new ClsLogicaAddReceta();
            DataTable DT = producto.RecetaLista(id);
            LblNombreReceta.Text = DT.Rows[0].Field<String>("nombre_receta");

            txtProcedimiento.Text= DT.Rows[0].Field<String>("procedimiento");

            lblNumPorc.Text = DT.Rows[0].Field<int>("num_porciones").ToString();

            LoadInsumos(id);
        }

     

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarReceta();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (LblNombreReceta.Text!= "Seleccione una receta")
            {
                FrmIngresarReceta ingr = new FrmIngresarReceta(idReceta, principal, tipo_usuario);
                ingr.Visible = true;
            }
            else
            {
                MessageBox.Show("No selecciono la Receta");
            }
                
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for(int i=0; i<DgvInsumos.RowCount; i++)
            {
                DgvInsumos.Rows[i].Cells[4].Value = (Convert.ToDouble(DgvInsumos.Rows[i].Cells[4].Value)) / Convert.ToDouble(lblNumPorc.Text) * Convert.ToDouble(txtCalcularPorciones.Text);

            }
            
            lblNumPorc.Text = txtCalcularPorciones.Text;
            txtCalcularPorciones.Clear();

        }

        private void txtCalcularPorciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
        //Boton para regresar al menu
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
            principal.Controls.Add(new CduMenuPrincipal(principal,tipo_usuario));
            
        }

        private void PanelReceta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblNombreReceta_Click(object sender, EventArgs e)
        {

        }

        private void lblNumPorc_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
