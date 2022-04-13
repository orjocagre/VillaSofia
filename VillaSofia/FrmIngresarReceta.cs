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
using System.Globalization;
namespace VillaSofia
{
    public partial class FrmIngresarReceta : Form
    {
        VillaSofia VS;
        int idreceta;
        Boolean edicion;
        int tipo_usurio;
        public FrmIngresarReceta(VillaSofia VS, int tipo_usurio)
        { this.tipo_usurio = tipo_usurio; 
            edicion = false;
            this.VS = VS;
            InitializeComponent();



            this.ttipMensaje.SetToolTip(this.txtNombreReceta,"Ingrese el nombre de la nueva Receta");
            this.ttipMensaje.SetToolTip(this.txtPorciones,"Ingre las porciones de esta Receta");
            this.ttipMensaje.SetToolTip(this.txtProcedimiento,"Escriba los pasos a seguir para realizar \n Esta Receta");
            this.ttipMensaje.SetToolTip(this.TxtCantidades,"Ingrese la cantidad de Ingre");
            this.ttipMensaje.SetToolTip(this.dgvIngredientes,"Muestra los Ingredientes Ingresados");
            this.ttipMensaje.SetToolTip(this.btnSiguiente,"Ingresar los Ingredientes");
            this.ttipMensaje.SetToolTip(this.btnguardarIgredientes, "Guarda un Nuevo Ingrediente");
            this.ttipMensaje.SetToolTip(this.cmbUM,"Unidades de Medida");
            this.ttipMensaje.SetToolTip(this.BtnAgregarMas,"Agregar una nueva unidad de medida");
            this.ttipMensaje.SetToolTip(this.btnEditar,"Editar la Receta");
            this.ttipMensaje.SetToolTip(this.BtnEliminar,"Eliminar ingrediente");
            this.ttipMensaje.SetToolTip(this.txtNombreIngrediente, "Ingrese el nuevo ingrediente");










        }

        public FrmIngresarReceta(int idreceta, VillaSofia VS , int tipo_usurio)
        {
            this.tipo_usurio = tipo_usurio;
            this.VS = VS;
            this.idreceta = idreceta;
            edicion = true;
            InitializeComponent();
            llenarCampos();
        }

        void llenarCampos()
        {
           
                ClsLogicaAddReceta receta = new ClsLogicaAddReceta();
                DataTable DT = receta.RecetaLista(idreceta.ToString());

                txtNombreReceta.Text = DT.Rows[0].Field<String>("nombre_receta");
                txtPorciones.Text = DT.Rows[0].Field<int>("num_porciones").ToString();
                txtProcedimiento.Text = DT.Rows[0].Field<String>("procedimiento");

                LoadIngredientes(idreceta.ToString());
            
            
            
        }

        //MOTRAR DATOS EN EL FORMULARIO
        private void FrmIngresarReceta_Load(object sender, EventArgs e)
        {
            comboUM();
            
        }
        //MOSTRAR INGREDIENTES
        void LoadIngredientes(String x)
        {
           CLsLogicaIngredienteReceta Load = new CLsLogicaIngredienteReceta();

            dgvIngredientes.DataSource = Load.ListarIngredientes(x);
            dgvIngredientes.Columns[0].Visible = false;
            dgvIngredientes.Columns[1].Visible = false;
            dgvIngredientes.Columns[2].Visible = false;
            dgvIngredientes.Columns[2].Visible = false;
            dgvIngredientes.Columns[6].Visible = false;
            dgvIngredientes.Columns[7].Visible = false;
        }
        //VALIDAR TEXBOX VACIOS
        Boolean validarTexboxReceta()
        {

            if (txtNombreReceta.Text != "" && txtPorciones.Text != "" && txtProcedimiento.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        Boolean validarTexboxIngredientes()
        {

            if (txtNombreIngrediente.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //METODO PARA INGRESAR DATOS
        void IngresarReceta()
        {
            string resp;
            CLsLogicaIngredienteReceta Receta = new CLsLogicaIngredienteReceta();
            resp = Receta.ingresarDatosReceta(txtNombreReceta.Text,Convert.ToInt32( txtPorciones.Text), txtProcedimiento.Text);
            idreceta = Convert.ToInt32(resp);
        }

        void editarReceta()
        {

            
            string resp;
            ClsLogicaAddReceta Receta = new ClsLogicaAddReceta();
            Receta.editarReceta(idreceta,txtNombreReceta.Text, Convert.ToInt32(txtPorciones.Text), txtProcedimiento.Text);
        }

        //METODO PARA INGRESAR DATOS
        string IngresarIngrediente()
        {
            string resp;
            CLsLogicaIngredienteReceta AddIngrediente = new CLsLogicaIngredienteReceta();
            resp = AddIngrediente.ingresarDatosIngrediente( txtNombreIngrediente.Text);

            return resp;

        }

     //MOSTRAR UNIDADES DE MEDIDA DISPONIBLES
        public void comboUM()
        {
            ClsLogicaUM UM = new ClsLogicaUM();
            cmbUM.DataSource = UM.UM();
            cmbUM.ValueMember = "ID";
            cmbUM.DisplayMember = "DESCRIPCION";

        }
        
       


        //Boton para guardar recetas
        private void btnguardarIgredientes_Click(object sender, EventArgs e)
        {
           

            if (validarTexboxIngredientes() && validarTexboxReceta())
            {
                string msj;
                 int y = Convert.ToInt32(IngresarIngrediente());
                 int x = idreceta;
                this.idreceta = x;

                
                 CLsLogicaIngredienteReceta addRECETAinGRE = new CLsLogicaIngredienteReceta();
                  msj = addRECETAinGRE.AddIngredienteR(y, x,Convert.ToDouble( TxtCantidades.Text),Convert.ToInt32( cmbUM.SelectedValue));
                
                MessageBox.Show(msj);
                LoadIngredientes(x.ToString());



                txtNombreIngrediente.Clear();
                TxtCantidades.Clear();
            }
            else
            {
                MessageBox.Show("No supero la validaciòn");
            }
        }
        //Validacion de letras
        private void txtNombreIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre el ingrediente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        }


        //Validacion de numeros
        private void txtPorciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Validacion de letras
        private void txtNombreReceta_KeyPress(object sender, KeyPressEventArgs e)
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
        void eliminarIngrediente(int idIng, int idreceta)
        {
            CLsLogicaIngredienteReceta eliminarIngrediente = new CLsLogicaIngredienteReceta();

            String msj = eliminarIngrediente.EliminarRecetaIngrediente(idIng, idreceta);

            
        }

      

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String iding = dgvIngredientes.SelectedRows[0].Cells[7].Value.ToString();
            int ingreId = Convert.ToInt32( iding);
           ClsLogicaAddReceta ingrediente = new ClsLogicaAddReceta();
           

            eliminarIngrediente(ingreId, idreceta);

            LoadIngredientes(idreceta.ToString());


        }

       

        private void BtnAgregarMas_Click(object sender, EventArgs e)
        {
            FrmUM receta = new FrmUM(this);
            receta.Show();
            receta.BringToFront();

           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(edicion)
            {
                
                editarReceta();
            }
            else
            {
                IngresarReceta();
                edicion = true;
            }
            txtProcedimiento.Enabled = false;
            txtNombreReceta.Enabled = false;
            txtPorciones.Enabled = false;
            txtNombreIngrediente.Focus();
            btnSiguiente.Enabled = false;
            txtNombreIngrediente.Enabled = true;
            TxtCantidades.Enabled = true;
            dgvIngredientes.Enabled = true;
            cmbUM.Enabled = true;
            BtnAgregarMas.Enabled = true;
            BtnEliminar.Enabled = true;
            btnguardarIgredientes.Enabled = true;
            btnListo.Enabled = true;


        }

        private void btnMostrarRecetas_Click(object sender, EventArgs e)
        {
            this.Close();
            CduMostrarReceta rec = new CduMostrarReceta(VS,tipo_usurio);
            VS.Controls.Add(rec);
            rec.BringToFront();

        }

        private void TxtCantidades_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;


            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back))
            {

                e.Handled = false;


            }
            else
            {
                MessageBox.Show("Solo se permiten numeros, ingrese nuevamente los digitos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }

          
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1)) 
            {

                MessageBox.Show("Formato incorecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }


        }
           
       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmIngresarReceta ingr = new FrmIngresarReceta(idreceta, VS,tipo_usurio);
            ingr.Visible = true;
            this.Close();

        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}






