﻿namespace VillaSofia
{
    partial class CduMostrarReceta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelReceta = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblBusqueda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAtras = new Guna.UI2.WinForms.Guna2Button();
            this.btnCalcular = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.txtCalcularPorciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblCalcularPorciones = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.LblIngredientes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.lblNumPorc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPorciones = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtProcedimiento = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblProcedimiento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblNombreReceta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvInsumos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DgvRecetas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TxtBuscarReceta = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelReceta
            // 
            this.PanelReceta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelReceta.Controls.Add(this.lblBusqueda);
            this.PanelReceta.Controls.Add(this.btnAtras);
            this.PanelReceta.Controls.Add(this.btnCalcular);
            this.PanelReceta.Controls.Add(this.btnEliminar);
            this.PanelReceta.Controls.Add(this.btnImprimir);
            this.PanelReceta.Controls.Add(this.txtCalcularPorciones);
            this.PanelReceta.Controls.Add(this.LblCalcularPorciones);
            this.PanelReceta.Controls.Add(this.BtnEditar);
            this.PanelReceta.Controls.Add(this.LblIngredientes);
            this.PanelReceta.Controls.Add(this.BtnBuscar);
            this.PanelReceta.Controls.Add(this.lblNumPorc);
            this.PanelReceta.Controls.Add(this.lblPorciones);
            this.PanelReceta.Controls.Add(this.txtProcedimiento);
            this.PanelReceta.Controls.Add(this.LblProcedimiento);
            this.PanelReceta.Controls.Add(this.LblNombreReceta);
            this.PanelReceta.Controls.Add(this.DgvInsumos);
            this.PanelReceta.Controls.Add(this.DgvRecetas);
            this.PanelReceta.Controls.Add(this.TxtBuscarReceta);
            this.PanelReceta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelReceta.FillColor = System.Drawing.Color.Lavender;
            this.PanelReceta.FillColor2 = System.Drawing.Color.Lavender;
            this.PanelReceta.Location = new System.Drawing.Point(0, 0);
            this.PanelReceta.Name = "PanelReceta";
            this.PanelReceta.ShadowDecoration.Parent = this.PanelReceta;
            this.PanelReceta.Size = new System.Drawing.Size(1203, 700);
            this.PanelReceta.TabIndex = 0;
            this.PanelReceta.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelReceta_Paint);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBusqueda.Location = new System.Drawing.Point(991, 37);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(84, 22);
            this.lblBusqueda.TabIndex = 19;
            this.lblBusqueda.Text = "Busqueda";
            this.lblBusqueda.Click += new System.EventHandler(this.lblBusqueda_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.CheckedState.Parent = this.btnAtras;
            this.btnAtras.CustomImages.Parent = this.btnAtras;
            this.btnAtras.FillColor = System.Drawing.Color.Transparent;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.HoverState.Parent = this.btnAtras;
            this.btnAtras.Image = global::VillaSofia.Properties.Resources.atrasAzul32;
            this.btnAtras.ImageSize = new System.Drawing.Size(36, 36);
            this.btnAtras.Location = new System.Drawing.Point(13, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.ShadowDecoration.Parent = this.btnAtras;
            this.btnAtras.Size = new System.Drawing.Size(55, 49);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.CheckedState.Parent = this.btnCalcular;
            this.btnCalcular.CustomImages.Parent = this.btnCalcular;
            this.btnCalcular.FillColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.HoverState.Parent = this.btnCalcular;
            this.btnCalcular.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCalcular.Location = new System.Drawing.Point(674, 641);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.ShadowDecoration.Parent = this.btnCalcular;
            this.btnCalcular.Size = new System.Drawing.Size(107, 40);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEliminar.Location = new System.Drawing.Point(286, 642);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(107, 40);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.FillColor = System.Drawing.Color.SteelBlue;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.ImageSize = new System.Drawing.Size(32, 32);
            this.btnImprimir.Location = new System.Drawing.Point(173, 642);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(107, 40);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            // 
            // txtCalcularPorciones
            // 
            this.txtCalcularPorciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCalcularPorciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCalcularPorciones.DefaultText = "";
            this.txtCalcularPorciones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCalcularPorciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCalcularPorciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalcularPorciones.DisabledState.Parent = this.txtCalcularPorciones;
            this.txtCalcularPorciones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCalcularPorciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalcularPorciones.FocusedState.Parent = this.txtCalcularPorciones;
            this.txtCalcularPorciones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCalcularPorciones.HoverState.Parent = this.txtCalcularPorciones;
            this.txtCalcularPorciones.Location = new System.Drawing.Point(557, 642);
            this.txtCalcularPorciones.Name = "txtCalcularPorciones";
            this.txtCalcularPorciones.PasswordChar = '\0';
            this.txtCalcularPorciones.PlaceholderText = "";
            this.txtCalcularPorciones.SelectedText = "";
            this.txtCalcularPorciones.ShadowDecoration.Parent = this.txtCalcularPorciones;
            this.txtCalcularPorciones.Size = new System.Drawing.Size(111, 36);
            this.txtCalcularPorciones.TabIndex = 14;
            this.txtCalcularPorciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalcularPorciones_KeyPress);
            // 
            // LblCalcularPorciones
            // 
            this.LblCalcularPorciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCalcularPorciones.BackColor = System.Drawing.Color.Transparent;
            this.LblCalcularPorciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalcularPorciones.Location = new System.Drawing.Point(400, 642);
            this.LblCalcularPorciones.Name = "LblCalcularPorciones";
            this.LblCalcularPorciones.Size = new System.Drawing.Size(154, 39);
            this.LblCalcularPorciones.TabIndex = 13;
            this.LblCalcularPorciones.Text = "Porciones:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.CheckedState.Parent = this.BtnEditar;
            this.BtnEditar.CustomImages.Parent = this.BtnEditar;
            this.BtnEditar.FillColor = System.Drawing.Color.SteelBlue;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnEditar.HoverState.Parent = this.BtnEditar;
            this.BtnEditar.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnEditar.Location = new System.Drawing.Point(23, 642);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ShadowDecoration.Parent = this.BtnEditar;
            this.BtnEditar.Size = new System.Drawing.Size(144, 40);
            this.BtnEditar.TabIndex = 12;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // LblIngredientes
            // 
            this.LblIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIngredientes.BackColor = System.Drawing.Color.Transparent;
            this.LblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngredientes.Location = new System.Drawing.Point(658, 30);
            this.LblIngredientes.Name = "LblIngredientes";
            this.LblIngredientes.Size = new System.Drawing.Size(177, 39);
            this.LblIngredientes.TabIndex = 11;
            this.LblIngredientes.Text = "Ingredientes";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.CustomImages.Parent = this.BtnBuscar;
            this.BtnBuscar.FillColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Image = global::VillaSofia.Properties.Resources.buscar;
            this.BtnBuscar.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnBuscar.Location = new System.Drawing.Point(1078, 26);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.ShadowDecoration.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(36, 36);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblNumPorc
            // 
            this.lblNumPorc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumPorc.AutoSize = false;
            this.lblNumPorc.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPorc.Location = new System.Drawing.Point(557, 30);
            this.lblNumPorc.Name = "lblNumPorc";
            this.lblNumPorc.Size = new System.Drawing.Size(65, 39);
            this.lblNumPorc.TabIndex = 9;
            this.lblNumPorc.Text = "0";
            this.lblNumPorc.Click += new System.EventHandler(this.lblNumPorc_Click);
            // 
            // lblPorciones
            // 
            this.lblPorciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorciones.BackColor = System.Drawing.Color.Transparent;
            this.lblPorciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorciones.Location = new System.Drawing.Point(397, 30);
            this.lblPorciones.Name = "lblPorciones";
            this.lblPorciones.Size = new System.Drawing.Size(154, 39);
            this.lblPorciones.TabIndex = 8;
            this.lblPorciones.Text = "Porciones:";
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcedimiento.BackColor = System.Drawing.Color.Transparent;
            this.txtProcedimiento.BorderColor = System.Drawing.Color.Lavender;
            this.txtProcedimiento.BorderThickness = 0;
            this.txtProcedimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcedimiento.DefaultText = "";
            this.txtProcedimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProcedimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProcedimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcedimiento.DisabledState.Parent = this.txtProcedimiento;
            this.txtProcedimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProcedimiento.FillColor = System.Drawing.Color.Lavender;
            this.txtProcedimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcedimiento.FocusedState.Parent = this.txtProcedimiento;
            this.txtProcedimiento.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.ForeColor = System.Drawing.Color.Black;
            this.txtProcedimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProcedimiento.HoverState.Parent = this.txtProcedimiento;
            this.txtProcedimiento.Location = new System.Drawing.Point(23, 132);
            this.txtProcedimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.PasswordChar = '\0';
            this.txtProcedimiento.PlaceholderText = "";
            this.txtProcedimiento.ReadOnly = true;
            this.txtProcedimiento.SelectedText = "";
            this.txtProcedimiento.ShadowDecoration.Parent = this.txtProcedimiento;
            this.txtProcedimiento.Size = new System.Drawing.Size(540, 494);
            this.txtProcedimiento.TabIndex = 7;
            // 
            // LblProcedimiento
            // 
            this.LblProcedimiento.BackColor = System.Drawing.Color.Transparent;
            this.LblProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProcedimiento.Location = new System.Drawing.Point(23, 81);
            this.LblProcedimiento.Name = "LblProcedimiento";
            this.LblProcedimiento.Size = new System.Drawing.Size(207, 39);
            this.LblProcedimiento.TabIndex = 6;
            this.LblProcedimiento.Text = "Procedimiento";
            // 
            // LblNombreReceta
            // 
            this.LblNombreReceta.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreReceta.Location = new System.Drawing.Point(74, 30);
            this.LblNombreReceta.Name = "LblNombreReceta";
            this.LblNombreReceta.Size = new System.Drawing.Size(317, 39);
            this.LblNombreReceta.TabIndex = 5;
            this.LblNombreReceta.Text = "Seleccione una receta";
            this.LblNombreReceta.Click += new System.EventHandler(this.LblNombreReceta_Click);
            // 
            // DgvInsumos
            // 
            this.DgvInsumos.AllowUserToAddRows = false;
            this.DgvInsumos.AllowUserToDeleteRows = false;
            this.DgvInsumos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.DgvInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvInsumos.BackgroundColor = System.Drawing.Color.Lavender;
            this.DgvInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvInsumos.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInsumos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvInsumos.EnableHeadersVisualStyles = false;
            this.DgvInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DgvInsumos.Location = new System.Drawing.Point(572, 71);
            this.DgvInsumos.Name = "DgvInsumos";
            this.DgvInsumos.ReadOnly = true;
            this.DgvInsumos.RowHeadersVisible = false;
            this.DgvInsumos.RowTemplate.Height = 24;
            this.DgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInsumos.Size = new System.Drawing.Size(331, 555);
            this.DgvInsumos.TabIndex = 2;
            this.DgvInsumos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.DgvInsumos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.DgvInsumos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvInsumos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvInsumos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvInsumos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvInsumos.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.DgvInsumos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DgvInsumos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.DgvInsumos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvInsumos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInsumos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvInsumos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvInsumos.ThemeStyle.HeaderStyle.Height = 20;
            this.DgvInsumos.ThemeStyle.ReadOnly = true;
            this.DgvInsumos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.DgvInsumos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInsumos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInsumos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvInsumos.ThemeStyle.RowsStyle.Height = 24;
            this.DgvInsumos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.DgvInsumos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // DgvRecetas
            // 
            this.DgvRecetas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.DgvRecetas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvRecetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRecetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRecetas.BackgroundColor = System.Drawing.Color.Lavender;
            this.DgvRecetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvRecetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvRecetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Edwardian Script ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRecetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvRecetas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRecetas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRecetas.EnableHeadersVisualStyles = false;
            this.DgvRecetas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DgvRecetas.Location = new System.Drawing.Point(918, 132);
            this.DgvRecetas.Name = "DgvRecetas";
            this.DgvRecetas.ReadOnly = true;
            this.DgvRecetas.RowHeadersVisible = false;
            this.DgvRecetas.RowTemplate.Height = 24;
            this.DgvRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRecetas.Size = new System.Drawing.Size(271, 565);
            this.DgvRecetas.TabIndex = 2;
            this.DgvRecetas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.DgvRecetas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.DgvRecetas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvRecetas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvRecetas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvRecetas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvRecetas.ThemeStyle.BackColor = System.Drawing.Color.Lavender;
            this.DgvRecetas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.DgvRecetas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.DgvRecetas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvRecetas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Edwardian Script ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRecetas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvRecetas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvRecetas.ThemeStyle.HeaderStyle.Height = 4;
            this.DgvRecetas.ThemeStyle.ReadOnly = true;
            this.DgvRecetas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.DgvRecetas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvRecetas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvRecetas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DgvRecetas.ThemeStyle.RowsStyle.Height = 24;
            this.DgvRecetas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.DgvRecetas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvRecetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRecetas_CellContentClick);
            // 
            // TxtBuscarReceta
            // 
            this.TxtBuscarReceta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarReceta.BackColor = System.Drawing.Color.Lavender;
            this.TxtBuscarReceta.BorderColor = System.Drawing.Color.Gray;
            this.TxtBuscarReceta.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.TxtBuscarReceta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBuscarReceta.DefaultText = "";
            this.TxtBuscarReceta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtBuscarReceta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtBuscarReceta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscarReceta.DisabledState.Parent = this.TxtBuscarReceta;
            this.TxtBuscarReceta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtBuscarReceta.FillColor = System.Drawing.Color.Lavender;
            this.TxtBuscarReceta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscarReceta.FocusedState.Parent = this.TxtBuscarReceta;
            this.TxtBuscarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarReceta.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscarReceta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtBuscarReceta.HoverState.Parent = this.TxtBuscarReceta;
            this.TxtBuscarReceta.Location = new System.Drawing.Point(918, 71);
            this.TxtBuscarReceta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtBuscarReceta.Name = "TxtBuscarReceta";
            this.TxtBuscarReceta.PasswordChar = '\0';
            this.TxtBuscarReceta.PlaceholderText = "";
            this.TxtBuscarReceta.SelectedText = "";
            this.TxtBuscarReceta.ShadowDecoration.Parent = this.TxtBuscarReceta;
            this.TxtBuscarReceta.Size = new System.Drawing.Size(271, 36);
            this.TxtBuscarReceta.TabIndex = 1;
            this.TxtBuscarReceta.TextChanged += new System.EventHandler(this.TxtBuscarReceta_TextChanged);
            this.TxtBuscarReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarReceta_KeyPress);
            // 
            // CduMostrarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelReceta);
            this.Name = "CduMostrarReceta";
            this.Size = new System.Drawing.Size(1203, 700);
            this.Load += new System.EventHandler(this.CduMostrarReceta_Load);
            this.PanelReceta.ResumeLayout(false);
            this.PanelReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PanelReceta;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblNombreReceta;
        private Guna.UI2.WinForms.Guna2DataGridView DgvInsumos;
        private Guna.UI2.WinForms.Guna2DataGridView DgvRecetas;
        private Guna.UI2.WinForms.Guna2TextBox TxtBuscarReceta;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumPorc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPorciones;
        private Guna.UI2.WinForms.Guna2TextBox txtProcedimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblProcedimiento;
        private Guna.UI2.WinForms.Guna2Button BtnBuscar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblIngredientes;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private Guna.UI2.WinForms.Guna2TextBox txtCalcularPorciones;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCalcularPorciones;
        private Guna.UI2.WinForms.Guna2Button BtnEditar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnCalcular;
        private Guna.UI2.WinForms.Guna2Button btnAtras;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBusqueda;
    }
}
