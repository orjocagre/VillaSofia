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
        List<int> coincidencias;
        int cantTxt;
        String nomTxt;
        DataTable insumos;
        DataTable umInsumos;
        DataTable umUnidad;
        DataTable umPeso;
        DataTable umVolumen;
        DataTable unidadesdm;


        VillaSofia VS;
        int idreceta;
        Boolean edicion;
        int tipo_usurio;
        FrmProducto frmpro;
        Boolean recetaDeProducto;
        int idProducto;
        public FrmIngresarReceta(VillaSofia VS, int tipo_usurio)
        {


            recetaDeProducto = false;
            cantTxt = 0;
            nomTxt = "";
            coincidencias = new List<int>();
            llenarUnidadesdm();
            llenarinsumos();
            llenarUmInsumos();

            this.tipo_usurio = tipo_usurio; 
            edicion = false;
            this.VS = VS;
            InitializeComponent();

            ubicarLsbProducto();


            this.ttipMensaje.SetToolTip(this.txtNombreReceta,"Ingrese el nombre de la nueva Receta");
            this.ttipMensaje.SetToolTip(this.txtPorciones,"Ingre las porciones de esta Receta");
            this.ttipMensaje.SetToolTip(this.txtProcedimiento,"Escriba los pasos a seguir para realizar \n Esta Receta");
            this.ttipMensaje.SetToolTip(this.TxtCantidades,"Ingrese la cantidad de Ingre");
            this.ttipMensaje.SetToolTip(this.dgvInsumos,"Muestra los Insumos Ingresados");
            this.ttipMensaje.SetToolTip(this.btnSiguiente,"Ingresar los Insumos");
            this.ttipMensaje.SetToolTip(this.btnguardarInsumo, "Guarda un Nuevo Insumo");
            this.ttipMensaje.SetToolTip(this.cmbUM,"Unidades de Medida");
            this.ttipMensaje.SetToolTip(this.btnEditar,"Editar la Receta");
            this.ttipMensaje.SetToolTip(this.BtnEliminar,"Eliminar insumo");
            this.ttipMensaje.SetToolTip(this.txtBusqueda, "Ingrese el nuevo insumo");










        }
        public FrmIngresarReceta(VillaSofia VS, int tipo_usurio, String nomProd, FrmProducto frmpro, int idProducto)
        {
            recetaDeProducto = true;
            cantTxt = 0;
            nomTxt = "";
            coincidencias = new List<int>();
            llenarUnidadesdm();
            llenarinsumos();
            llenarUmInsumos();

            this.frmpro = frmpro;
            this.tipo_usurio = tipo_usurio;
            edicion = false;
            this.VS = VS;
            this.idProducto = idProducto;
            InitializeComponent();

            ubicarLsbProducto();


            this.ttipMensaje.SetToolTip(this.txtNombreReceta, "Ingrese el nombre de la nueva Receta");
            this.ttipMensaje.SetToolTip(this.txtPorciones, "Ingre las porciones de esta Receta");
            this.ttipMensaje.SetToolTip(this.txtProcedimiento, "Escriba los pasos a seguir para realizar \n Esta Receta");
            this.ttipMensaje.SetToolTip(this.TxtCantidades, "Ingrese la cantidad de Ingre");
            this.ttipMensaje.SetToolTip(this.dgvInsumos, "Muestra los Insumos Ingresados");
            this.ttipMensaje.SetToolTip(this.btnSiguiente, "Ingresar los Insumos");
            this.ttipMensaje.SetToolTip(this.btnguardarInsumo, "Guarda un Nuevo Insumo");
            this.ttipMensaje.SetToolTip(this.cmbUM, "Unidades de Medida");
            this.ttipMensaje.SetToolTip(this.btnEditar, "Editar la Receta");
            this.ttipMensaje.SetToolTip(this.BtnEliminar, "Eliminar insumo");
            this.ttipMensaje.SetToolTip(this.txtBusqueda, "Ingrese el nuevo insumo");



            txtNombreReceta.Text = nomProd;






        }

        public FrmIngresarReceta(int idreceta, VillaSofia VS , int tipo_usurio)
        {
            recetaDeProducto = false;
            cantTxt = 0;
            nomTxt = "";
            coincidencias = new List<int>();
            llenarUnidadesdm();
            llenarinsumos();
            llenarUmInsumos();

            this.tipo_usurio = tipo_usurio;
            this.VS = VS;
            this.idreceta = idreceta;
            edicion = true;
            InitializeComponent();
            llenarCampos();
            ubicarLsbProducto();

        }


        void ubicarLsbProducto()
        {
            lsbInsumo.Location = new Point(txtBusqueda.Location.X, txtBusqueda.Location.Y + txtBusqueda.Size.Height);
            redimensionarLsbInsumo();
        }
        void llenarUmInsumos()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
            umInsumos = inventario.listarUMInsumos();


        }

        void llenarinsumos()
        {
            ClsLogicaInventario registro = new ClsLogicaInventario();
            insumos = registro.listarInsumos();
            for (int i = 0; i < insumos.Rows.Count; i++)
            {
                insumos.Rows[i][0] = insumos.Rows[i][0].ToString().Trim().ToLower().Replace(" ", "");
            }
            DataColumn DC = new DataColumn("cod", System.Type.GetType("System.Int32"));
            insumos.Columns.Add(DC);
            DC.SetOrdinal(0);

            for (int i = 0; i < insumos.Rows.Count; i++)
            {
                insumos.Rows[i]["cod"] = i;
            }
        }
        void llenarUnidadesdm()
        {
            ClsLogicaUM um = new ClsLogicaUM();
            unidadesdm = um.listarUm();


            umUnidad = new DataTable();
            umPeso = new DataTable();
            umVolumen = new DataTable();

            umUnidad.Columns.Add("ID");
            umUnidad.Columns.Add("UM");
            umUnidad.Columns.Add("TIPO");
            umUnidad.Columns.Add("CONVERSION");

            umPeso.Columns.Add("ID");
            umPeso.Columns.Add("UM");
            umPeso.Columns.Add("TIPO");
            umPeso.Columns.Add("CONVERSION");

            umVolumen.Columns.Add("ID");
            umVolumen.Columns.Add("UM");
            umVolumen.Columns.Add("TIPO");
            umVolumen.Columns.Add("CONVERSION");


            for (int i = 0; i < unidadesdm.Rows.Count; i++)
            {
                if ((int)unidadesdm.Rows[i][2] == 1)
                {
                    umUnidad.Rows.Add();
                    umUnidad.Rows[umUnidad.Rows.Count - 1][0] = unidadesdm.Rows[i][0];
                    umUnidad.Rows[umUnidad.Rows.Count - 1][1] = unidadesdm.Rows[i][1];
                    umUnidad.Rows[umUnidad.Rows.Count - 1][2] = unidadesdm.Rows[i][2];
                    umUnidad.Rows[umUnidad.Rows.Count - 1][3] = unidadesdm.Rows[i][3];
                }
                else if ((int)unidadesdm.Rows[i][2] == 2)
                {
                    umPeso.Rows.Add();
                    umPeso.Rows[umPeso.Rows.Count - 1][0] = unidadesdm.Rows[i][0];
                    umPeso.Rows[umPeso.Rows.Count - 1][1] = unidadesdm.Rows[i][1];
                    umPeso.Rows[umPeso.Rows.Count - 1][2] = unidadesdm.Rows[i][2];
                    umPeso.Rows[umPeso.Rows.Count - 1][3] = unidadesdm.Rows[i][3];
                }
                else if ((int)unidadesdm.Rows[i][2] == 3)
                {
                    umVolumen.Rows.Add();
                    umVolumen.Rows[umVolumen.Rows.Count - 1][0] = unidadesdm.Rows[i][0];
                    umVolumen.Rows[umVolumen.Rows.Count - 1][1] = unidadesdm.Rows[i][1];
                    umVolumen.Rows[umVolumen.Rows.Count - 1][2] = unidadesdm.Rows[i][2];
                    umVolumen.Rows[umVolumen.Rows.Count - 1][3] = unidadesdm.Rows[i][3];
                }
            }
        }

        void redimensionarLsbInsumo()
        {
            if (lsbInsumo.Items.Count > 0)
            {
                lsbInsumo.Visible = true;
                lsbInsumo.Enabled = true;
                lsbInsumo.Size = new Size(txtBusqueda.Size.Width, (lsbInsumo.Items.Count + 1) * lsbInsumo.ItemHeight);
            }
            else
            {
                lsbInsumo.Enabled = false;
                lsbInsumo.Visible = false;
            }

        }


        Boolean validarEntero(String t)
        {
            try
            {
                int n = Convert.ToInt32(t);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

        String formatear(String x)
        {
            String txt = x.Trim().Replace(" ", "").ToLower();
            txt.Replace("á", "a");
            txt.Replace("é", "e");
            txt.Replace("í", "i");
            txt.Replace("ó", "o");
            txt.Replace("ú", "u");

            return txt;


        }

        Boolean validarTxtBusqueda()
        {
            String txt = txtBusqueda.Text;
            if (txt != "")
            {
                if (validarEntero(txt.Substring(0, 1)))
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (!validarEntero(txt.Substring(i, 1)))
                        {
                            cantTxt = Convert.ToInt32(txt.Substring(0, i));
                            nomTxt = txt.Substring(i);
                            return true;
                        }
                    }
                    lsbInsumo.Enabled = false;
                    lsbInsumo.Visible = false;
                    return false;
                }
                else
                {
                    cantTxt = -1;
                    nomTxt = txt;
                    return true;


                    //lsbProducto.Enabled = false;
                    //lsbProducto.Visible = false;
                    //return false;
                }
            }
            else
            {
                lsbInsumo.Enabled = false;
                lsbInsumo.Visible = false;
                return false;
            }
        }
        void ocultarOpciones()
        {
            this.coincidencias.Clear();
            lsbInsumo.Items.Clear();
            redimensionarLsbInsumo();
        }

        void mostrarOpciones()
        {
            this.coincidencias.Clear();
            if (validarTxtBusqueda())
            {

                ClsLogicaBuscador buscador = new ClsLogicaBuscador();
                int[] coincidencias;
                String[] sinF = new String[insumos.Rows.Count];

                for (int i = 0; i < sinF.Length; i++)
                {
                    sinF[i] = insumos.Rows[i]["sinF"].ToString();
                }

                coincidencias = buscador.ordenarElementos(sinF, formatear(nomTxt));

                if (coincidencias.Length > 0)
                {
                    lsbInsumo.Items.Clear();

                    for (int i = 0; i < coincidencias.Length; i++)
                    {
                        lsbInsumo.Items.Add(insumos.Rows[coincidencias[i]]["sin"]);
                        this.coincidencias.Add(coincidencias.ElementAt(i));
                    }

                    redimensionarLsbInsumo();
                    lsbInsumo.SelectedIndex = 0;
                }
                else
                {
                    lsbInsumo.Items.Clear();
                    redimensionarLsbInsumo();
                }
            }
        }

        void autoCompletar()
        {
            int indexInsumo = coincidencias.ElementAt<int>(lsbInsumo.SelectedIndex);
            txtBusqueda.Text = insumos.Rows[indexInsumo][2].ToString();
            TxtCantidades.Focus();
            ocultarOpciones();

            llenarCmbUM(indexInsumo);

        }

        void llenarCmbUM(int indexInsumo)
        {
            if ((int)umInsumos.Rows[indexInsumo][2] == 1)
            {
                cmbUM.DataSource = umUnidad;
                cmbUM.DisplayMember = "UM";
                cmbUM.ValueMember = "ID";
            }
            else if ((int)umInsumos.Rows[indexInsumo][2] == 2)
            {
                cmbUM.DataSource = umPeso;
                cmbUM.DisplayMember = "UM";
                cmbUM.ValueMember = "ID";
            }
            else
            {
                cmbUM.DataSource = umVolumen;
                cmbUM.DisplayMember = "UM";
                cmbUM.ValueMember = "ID";
            }
        }

        
       
        void llenarCampos()
        {
           
                ClsLogicaAddReceta receta = new ClsLogicaAddReceta();
                DataTable DT = receta.RecetaLista(idreceta.ToString());

                txtNombreReceta.Text = DT.Rows[0].Field<String>("nombre_receta");
                txtPorciones.Text = DT.Rows[0].Field<int>("num_porciones").ToString();
                txtProcedimiento.Text = DT.Rows[0].Field<String>("procedimiento");

                LoadInsumos(idreceta.ToString());
            
            
            
        }

        //MOTRAR DATOS EN EL FORMULARIO
        private void FrmIngresarReceta_Load(object sender, EventArgs e)
        {
            comboUM();
            
        }
        //MOSTRAR INGREDIENTES
        void LoadInsumos(String x)
        {
           CLsLogicaInsumoReceta Load = new CLsLogicaInsumoReceta();

            dgvInsumos.DataSource = Load.ListarInsumos(x);
            dgvInsumos.Columns[0].Visible = false;
            dgvInsumos.Columns[1].Visible = false;
            dgvInsumos.Columns[2].Visible = false;
            dgvInsumos.Columns[6].Visible = false;
            dgvInsumos.Columns[7].Visible = false;
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
        Boolean validarTexboxInsumos()
        {

            if (txtBusqueda.Text != "")
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
            CLsLogicaInsumoReceta Receta = new CLsLogicaInsumoReceta();
            resp = Receta.ingresarDatosReceta(txtNombreReceta.Text,Convert.ToInt32( txtPorciones.Text), txtProcedimiento.Text);
            idreceta = Convert.ToInt32(resp);

            ClsLogicaProducto producto = new ClsLogicaProducto();
            producto.vincularRecetaProducto(idProducto, idreceta);
        }

        void editarReceta()
        {

            
            string resp;
            ClsLogicaAddReceta Receta = new ClsLogicaAddReceta();
            Receta.editarReceta(idreceta,txtNombreReceta.Text, Convert.ToInt32(txtPorciones.Text), txtProcedimiento.Text);
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
            int x = -1;
            for (int i = 0; i < insumos.Rows.Count; i++)
            {
                if (insumos.Rows[i][2].ToString() == txtBusqueda.Text)
                {
                    x = i;
                }
            }

            if (x == -1)
            {
                MessageBox.Show("Ese ingrediente no existe en inventario, si desea puede agregarlo en el formulario de insumos");
            }
            else if(validarTexboxInsumos() && validarTexboxReceta())
            {
                string msj;
                int y = Convert.ToInt32(insumos.Rows[x][4].ToString());
                int z = idreceta;
                this.idreceta = x;


                CLsLogicaInsumoReceta addRECETAinGRE = new CLsLogicaInsumoReceta();
                msj = addRECETAinGRE.AddInsumoR(y, z, Convert.ToDouble(TxtCantidades.Text), Convert.ToInt32(cmbUM.SelectedValue));

                MessageBox.Show(msj);
                LoadInsumos(z.ToString());

                txtBusqueda.Clear();
                TxtCantidades.Clear();
                txtBusqueda.Focus();

            } 
            else
            {
                MessageBox.Show("No supero la validaciòn");

            }



           
        }
        //Validacion de letras
        private void txtNombreInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space)
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    MessageBox.Show("Solo se permiten letras, ingrese nuevamente el Nombre el insumo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        void eliminarInsumo(int idIng, int idreceta)
        {
            CLsLogicaInsumoReceta eliminarInsumo = new CLsLogicaInsumoReceta();

            String msj = eliminarInsumo.EliminarRecetaInsumo(idIng, idreceta);

            
        }

      

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String iding = dgvInsumos.SelectedRows[0].Cells[7].Value.ToString();
            int ingreId = Convert.ToInt32( iding);
           ClsLogicaAddReceta insumo = new ClsLogicaAddReceta();
           

            eliminarInsumo(ingreId, idreceta);

            LoadInsumos(idreceta.ToString());


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
            txtBusqueda.Focus();
            btnSiguiente.Enabled = false;
            txtBusqueda.Enabled = true;
            TxtCantidades.Enabled = true;
            dgvInsumos.Enabled = true;
            cmbUM.Enabled = true;
            BtnEliminar.Enabled = true;
            btnguardarInsumo.Enabled = true;
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

        private void FrmIngresarReceta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(recetaDeProducto == true)
            {
                frmpro.Enabled = true;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            mostrarOpciones();

        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Up" || e.KeyCode.ToString() == "Down")
            {
                e.Handled = true;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lsbInsumo.Visible && (int)e.KeyChar == (int)Keys.Enter)
            {
                autoCompletar();
                e.Handled = true;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (lsbInsumo.Visible)
            {
                if (e.KeyCode.ToString() == "Up")
                {
                    if (lsbInsumo.SelectedIndex != 0)
                    {
                        lsbInsumo.SelectedIndex -= 1;
                    }
                }
                if (e.KeyCode.ToString() == "Down")
                {
                    if (lsbInsumo.SelectedIndex < lsbInsumo.Items.Count - 1)
                    {
                        lsbInsumo.SelectedIndex += 1;
                    }
                }
            }
        }

        private void lsbInsumo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                autoCompletar();
            }
        }


    }
}






