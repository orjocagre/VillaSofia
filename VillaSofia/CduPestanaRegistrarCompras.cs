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
    public partial class CduPestanaRegistrarCompras : UserControl
    {
        int tipo_usuario;
        VillaSofia vs;
        List<int> coincidencias;
        int cantTxt;
        String nomTxt;
        DataTable insumos;
        DataTable umInsumos;
        DataTable umUnidad;
        DataTable umPeso;
        DataTable umVolumen;
        DataTable unidadesdm;


        public CduPestanaRegistrarCompras(VillaSofia vs, int tipo_usuario)
        {
            this.tipo_usuario = tipo_usuario;
            this.vs = vs;
            cantTxt = 0;
            nomTxt = "";
            coincidencias = new List<int>();
            llenarUnidadesdm();
            llenarinsumos();
            llenarUmInsumos();
            InitializeComponent();
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
            for(int i=0; i<insumos.Rows.Count; i++)
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
            txtPresentacion.Focus();
            ocultarOpciones();

            llenarCmbUM(indexInsumo);
            
        }

        void llenarCmbUM(int indexInsumo)
        {
            if ((int)umInsumos.Rows[indexInsumo][2] == 1)
            {
                cmbUm.DataSource = umUnidad;
                cmbUm.DisplayMember = "UM";
                cmbUm.ValueMember = "ID";
            }
            else if ((int)umInsumos.Rows[indexInsumo][2] == 2)
            {
                cmbUm.DataSource = umPeso;
                cmbUm.DisplayMember = "UM";
                cmbUm.ValueMember = "ID";
            }
            else
            {
                cmbUm.DataSource = umVolumen;
                cmbUm.DisplayMember = "UM";
                cmbUm.ValueMember = "ID";
            }
        }

        void guardar()
        {
            ClsLogicaInventario inventario = new ClsLogicaInventario();
           

            for(int i=0; i<dgvInsumo.RowCount; i++)
            {
                //MessageBox.Show(dgvInsumo.Rows[i].Cells["id"].Value.ToString());
                //MessageBox.Show(dgvInsumo.Rows[i].Cells["cantidad"].Value.ToString());
                //MessageBox.Show(dgvInsumo.Rows[i].Cells["precio"].Value.ToString());



                inventario.agregarEntrada(Convert.ToInt32(dgvInsumo.Rows[i].Cells["id"].Value.ToString()), Convert.ToDouble(dgvInsumo.Rows[i].Cells["cantidad"].Value.ToString()), DateTime.Now, Convert.ToDouble(dgvInsumo.Rows[i].Cells["precio"].Value.ToString()), Convert.ToInt32(dgvInsumo.Rows[i].Cells["idum"].Value.ToString()), Convert.ToDouble(dgvInsumo.Rows[i].Cells["presentacion"].Value.ToString()));
            }
            MessageBox.Show("Inventario Actualizado!");
            dgvInsumo.Rows.Clear();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvInsumo.Rows.Remove(dgvInsumo.SelectedRows[0]);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Ese insumo no existe en inventario, si desea puede agregarlo en el formulario de insumos");
            }
            else
            {

                dgvInsumo.Rows.Add();
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[0].Value = insumos.Rows[x][4].ToString();
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[1].Value = cmbUm.SelectedValue;
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[2].Value = txtCantidad.Text;
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[3].Value = insumos.Rows[x][2].ToString();
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[4].Value = txtPresentacion.Text;
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[5].Value = cmbUm.Text;
                dgvInsumo.Rows[dgvInsumo.RowCount - 1].Cells[6].Value = txtPrecio.Text;
            }


            txtCantidad.Text = "";
            txtBusqueda.Text = "";
            txtPrecio.Text = "";
            txtPresentacion.Text = "";
            txtCantidad.Focus();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            btnAgregar.BorderThickness = 1;
        }

        private void btnAgregar_Leave(object sender, EventArgs e)
        {
            btnAgregar.BorderThickness = 0;
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (!lsbInsumo.Focused)
            {
                if (lsbInsumo.Visible)
                {
                    autoCompletar();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"));
        }
    }
}
