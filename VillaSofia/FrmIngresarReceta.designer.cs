﻿namespace VillaSofia
{
    partial class FrmIngresarReceta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbxReceta = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnListo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnMostrarRecetas = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSiguiente = new Guna.UI2.WinForms.Guna2Button();
            this.btnguardarInsumo = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInsumos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtProcedimiento = new Guna.UI.WinForms.GunaTextBox();
            this.lblProcedimiento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtCantidades = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNombreIngrediente = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbUM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPorciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.SpdrReceta = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblPorciones = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombreReceta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombreReceta = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ttipMensaje = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsbInsumo = new System.Windows.Forms.ListBox();
            this.GbxReceta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxReceta
            // 
            this.GbxReceta.BackColor = System.Drawing.Color.White;
            this.GbxReceta.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.GbxReceta.Controls.Add(this.lsbInsumo);
            this.GbxReceta.Controls.Add(this.txtBusqueda);
            this.GbxReceta.Controls.Add(this.btnListo);
            this.GbxReceta.Controls.Add(this.btnEditar);
            this.GbxReceta.Controls.Add(this.btnMostrarRecetas);
            this.GbxReceta.Controls.Add(this.BtnEliminar);
            this.GbxReceta.Controls.Add(this.btnSiguiente);
            this.GbxReceta.Controls.Add(this.btnguardarInsumo);
            this.GbxReceta.Controls.Add(this.dgvInsumos);
            this.GbxReceta.Controls.Add(this.txtProcedimiento);
            this.GbxReceta.Controls.Add(this.lblProcedimiento);
            this.GbxReceta.Controls.Add(this.TxtCantidades);
            this.GbxReceta.Controls.Add(this.lblCantidad);
            this.GbxReceta.Controls.Add(this.lblNombreIngrediente);
            this.GbxReceta.Controls.Add(this.cmbUM);
            this.GbxReceta.Controls.Add(this.txtPorciones);
            this.GbxReceta.Controls.Add(this.SpdrReceta);
            this.GbxReceta.Controls.Add(this.lblPorciones);
            this.GbxReceta.Controls.Add(this.txtNombreReceta);
            this.GbxReceta.Controls.Add(this.lblNombreReceta);
            this.GbxReceta.CustomBorderColor = System.Drawing.Color.Blue;
            this.GbxReceta.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.GbxReceta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxReceta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.GbxReceta.Location = new System.Drawing.Point(2, 1);
            this.GbxReceta.Name = "GbxReceta";
            this.GbxReceta.ShadowDecoration.Parent = this.GbxReceta;
            this.GbxReceta.Size = new System.Drawing.Size(1101, 597);
            this.GbxReceta.TabIndex = 0;
            this.GbxReceta.Text = "Agregar Datos de Receta";
            this.GbxReceta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Transparent;
            this.btnListo.BorderColor = System.Drawing.Color.Teal;
            this.btnListo.BorderRadius = 1;
            this.btnListo.BorderThickness = 1;
            this.btnListo.CheckedState.Parent = this.btnListo;
            this.btnListo.CustomImages.Parent = this.btnListo;
            this.btnListo.Enabled = false;
            this.btnListo.FillColor = System.Drawing.Color.MintCream;
            this.btnListo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.Color.Black;
            this.btnListo.HoverState.Parent = this.btnListo;
            this.btnListo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListo.ImageSize = new System.Drawing.Size(32, 32);
            this.btnListo.Location = new System.Drawing.Point(996, 542);
            this.btnListo.Name = "btnListo";
            this.btnListo.ShadowDecoration.Parent = this.btnListo;
            this.btnListo.Size = new System.Drawing.Size(71, 47);
            this.btnListo.TabIndex = 25;
            this.btnListo.Text = "LISTO";
            this.btnListo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditar.BorderRadius = 1;
            this.btnEditar.BorderThickness = 1;
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Image = global::VillaSofia.Properties.Resources.editar__1_;
            this.btnEditar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnEditar.Location = new System.Drawing.Point(431, 532);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(62, 54);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnMostrarRecetas
            // 
            this.btnMostrarRecetas.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarRecetas.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarRecetas.BorderRadius = 2;
            this.btnMostrarRecetas.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btnMostrarRecetas.CheckedState.Parent = this.btnMostrarRecetas;
            this.btnMostrarRecetas.CustomImages.Parent = this.btnMostrarRecetas;
            this.btnMostrarRecetas.FillColor = System.Drawing.Color.Transparent;
            this.btnMostrarRecetas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMostrarRecetas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarRecetas.HoverState.Parent = this.btnMostrarRecetas;
            this.btnMostrarRecetas.Image = global::VillaSofia.Properties.Resources.receta__1_;
            this.btnMostrarRecetas.ImageSize = new System.Drawing.Size(84, 84);
            this.btnMostrarRecetas.Location = new System.Drawing.Point(3, 3);
            this.btnMostrarRecetas.Name = "btnMostrarRecetas";
            this.btnMostrarRecetas.ShadowDecoration.Parent = this.btnMostrarRecetas;
            this.btnMostrarRecetas.Size = new System.Drawing.Size(85, 89);
            this.btnMostrarRecetas.TabIndex = 22;
            this.btnMostrarRecetas.Click += new System.EventHandler(this.btnMostrarRecetas_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.CheckedState.Parent = this.BtnEliminar;
            this.BtnEliminar.CustomImages.Parent = this.BtnEliminar;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FillColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.HoverState.Parent = this.BtnEliminar;
            this.BtnEliminar.Image = global::VillaSofia.Properties.Resources.cancelar__1_;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(32, 32);
            this.BtnEliminar.Location = new System.Drawing.Point(1064, 311);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ShadowDecoration.Parent = this.BtnEliminar;
            this.BtnEliminar.Size = new System.Drawing.Size(32, 46);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BorderColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BorderRadius = 1;
            this.btnSiguiente.BorderThickness = 1;
            this.btnSiguiente.CheckedState.Parent = this.btnSiguiente;
            this.btnSiguiente.CustomImages.Parent = this.btnSiguiente;
            this.btnSiguiente.FillColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.HoverState.Parent = this.btnSiguiente;
            this.btnSiguiente.Image = global::VillaSofia.Properties.Resources.siguienteBtn;
            this.btnSiguiente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSiguiente.ImageSize = new System.Drawing.Size(72, 72);
            this.btnSiguiente.Location = new System.Drawing.Point(166, 532);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.ShadowDecoration.Parent = this.btnSiguiente;
            this.btnSiguiente.Size = new System.Drawing.Size(179, 62);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnguardarInsumo
            // 
            this.btnguardarInsumo.BorderColor = System.Drawing.Color.Teal;
            this.btnguardarInsumo.BorderRadius = 1;
            this.btnguardarInsumo.BorderThickness = 1;
            this.btnguardarInsumo.CheckedState.Parent = this.btnguardarInsumo;
            this.btnguardarInsumo.CustomImages.Parent = this.btnguardarInsumo;
            this.btnguardarInsumo.Enabled = false;
            this.btnguardarInsumo.FillColor = System.Drawing.Color.MintCream;
            this.btnguardarInsumo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarInsumo.ForeColor = System.Drawing.Color.Black;
            this.btnguardarInsumo.HoverState.Parent = this.btnguardarInsumo;
            this.btnguardarInsumo.Image = global::VillaSofia.Properties.Resources.save64;
            this.btnguardarInsumo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnguardarInsumo.ImageSize = new System.Drawing.Size(32, 32);
            this.btnguardarInsumo.Location = new System.Drawing.Point(798, 205);
            this.btnguardarInsumo.Name = "btnguardarInsumo";
            this.btnguardarInsumo.ShadowDecoration.Parent = this.btnguardarInsumo;
            this.btnguardarInsumo.Size = new System.Drawing.Size(176, 47);
            this.btnguardarInsumo.TabIndex = 20;
            this.btnguardarInsumo.Text = "AGREGAR INGREDIENTE";
            this.btnguardarInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnguardarInsumo.Click += new System.EventHandler(this.btnguardarIgredientes_Click);
            // 
            // dgvInsumos
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvInsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInsumos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInsumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvInsumos.ColumnHeadersHeight = 65;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInsumos.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvInsumos.Enabled = false;
            this.dgvInsumos.EnableHeadersVisualStyles = false;
            this.dgvInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInsumos.Location = new System.Drawing.Point(577, 258);
            this.dgvInsumos.Name = "dgvInsumos";
            this.dgvInsumos.RowHeadersVisible = false;
            this.dgvInsumos.RowHeadersWidth = 20;
            this.dgvInsumos.RowTemplate.Height = 26;
            this.dgvInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInsumos.Size = new System.Drawing.Size(481, 268);
            this.dgvInsumos.TabIndex = 18;
            this.dgvInsumos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Indigo;
            this.dgvInsumos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.dgvInsumos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInsumos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInsumos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInsumos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInsumos.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvInsumos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(201)))), ((int)(((byte)(231)))));
            this.dgvInsumos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.dgvInsumos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInsumos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInsumos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInsumos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInsumos.ThemeStyle.HeaderStyle.Height = 65;
            this.dgvInsumos.ThemeStyle.ReadOnly = false;
            this.dgvInsumos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.dgvInsumos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInsumos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInsumos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvInsumos.ThemeStyle.RowsStyle.Height = 26;
            this.dgvInsumos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(139)))), ((int)(((byte)(205)))));
            this.dgvInsumos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtProcedimiento
            // 
            this.txtProcedimiento.BaseColor = System.Drawing.Color.White;
            this.txtProcedimiento.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.txtProcedimiento.BorderSize = 1;
            this.txtProcedimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProcedimiento.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProcedimiento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtProcedimiento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProcedimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimiento.Location = new System.Drawing.Point(29, 258);
            this.txtProcedimiento.Multiline = true;
            this.txtProcedimiento.Name = "txtProcedimiento";
            this.txtProcedimiento.PasswordChar = '\0';
            this.txtProcedimiento.SelectedText = "";
            this.txtProcedimiento.Size = new System.Drawing.Size(444, 268);
            this.txtProcedimiento.TabIndex = 1;
            // 
            // lblProcedimiento
            // 
            this.lblProcedimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblProcedimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedimiento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProcedimiento.Location = new System.Drawing.Point(29, 205);
            this.lblProcedimiento.Name = "lblProcedimiento";
            this.lblProcedimiento.Size = new System.Drawing.Size(134, 27);
            this.lblProcedimiento.TabIndex = 17;
            this.lblProcedimiento.Text = "Procedimiento";
            // 
            // TxtCantidades
            // 
            this.TxtCantidades.BackColor = System.Drawing.Color.Transparent;
            this.TxtCantidades.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCantidades.DefaultText = "";
            this.TxtCantidades.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCantidades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCantidades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCantidades.DisabledState.Parent = this.TxtCantidades;
            this.TxtCantidades.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCantidades.Enabled = false;
            this.TxtCantidades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCantidades.FocusedState.Parent = this.TxtCantidades;
            this.TxtCantidades.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCantidades.HoverState.Parent = this.TxtCantidades;
            this.TxtCantidades.Location = new System.Drawing.Point(761, 146);
            this.TxtCantidades.Margin = new System.Windows.Forms.Padding(0);
            this.TxtCantidades.Name = "TxtCantidades";
            this.TxtCantidades.PasswordChar = '\0';
            this.TxtCantidades.PlaceholderText = "";
            this.TxtCantidades.SelectedText = "";
            this.TxtCantidades.ShadowDecoration.Parent = this.TxtCantidades;
            this.TxtCantidades.Size = new System.Drawing.Size(105, 36);
            this.TxtCantidades.TabIndex = 14;
            this.TxtCantidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidades_KeyPress_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCantidad.Location = new System.Drawing.Point(574, 135);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 27);
            this.lblCantidad.TabIndex = 13;
            this.lblCantidad.Text = "Cantidades:";
            // 
            // lblNombreIngrediente
            // 
            this.lblNombreIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreIngrediente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreIngrediente.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombreIngrediente.Location = new System.Drawing.Point(577, 82);
            this.lblNombreIngrediente.Name = "lblNombreIngrediente";
            this.lblNombreIngrediente.Size = new System.Drawing.Size(112, 27);
            this.lblNombreIngrediente.TabIndex = 12;
            this.lblNombreIngrediente.Text = "Ingrediente:";
            // 
            // cmbUM
            // 
            this.cmbUM.BackColor = System.Drawing.Color.Transparent;
            this.cmbUM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUM.Enabled = false;
            this.cmbUM.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUM.FocusedState.Parent = this.cmbUM;
            this.cmbUM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUM.FormattingEnabled = true;
            this.cmbUM.HoverState.Parent = this.cmbUM;
            this.cmbUM.ItemHeight = 30;
            this.cmbUM.ItemsAppearance.Parent = this.cmbUM;
            this.cmbUM.Location = new System.Drawing.Point(875, 146);
            this.cmbUM.Name = "cmbUM";
            this.cmbUM.ShadowDecoration.Parent = this.cmbUM;
            this.cmbUM.Size = new System.Drawing.Size(183, 36);
            this.cmbUM.TabIndex = 10;
            // 
            // txtPorciones
            // 
            this.txtPorciones.BackColor = System.Drawing.Color.Transparent;
            this.txtPorciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorciones.DefaultText = "";
            this.txtPorciones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPorciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPorciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPorciones.DisabledState.Parent = this.txtPorciones;
            this.txtPorciones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPorciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPorciones.FocusedState.Parent = this.txtPorciones;
            this.txtPorciones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPorciones.HoverState.Parent = this.txtPorciones;
            this.txtPorciones.Location = new System.Drawing.Point(273, 150);
            this.txtPorciones.Margin = new System.Windows.Forms.Padding(0);
            this.txtPorciones.Name = "txtPorciones";
            this.txtPorciones.PasswordChar = '\0';
            this.txtPorciones.PlaceholderText = "";
            this.txtPorciones.SelectedText = "";
            this.txtPorciones.ShadowDecoration.Parent = this.txtPorciones;
            this.txtPorciones.Size = new System.Drawing.Size(254, 32);
            this.txtPorciones.TabIndex = 8;
            this.txtPorciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorciones_KeyPress);
            // 
            // SpdrReceta
            // 
            this.SpdrReceta.BackColor = System.Drawing.Color.Transparent;
            this.SpdrReceta.FillColor = System.Drawing.Color.LightSeaGreen;
            this.SpdrReceta.Location = new System.Drawing.Point(539, 65);
            this.SpdrReceta.Name = "SpdrReceta";
            this.SpdrReceta.Size = new System.Drawing.Size(19, 478);
            this.SpdrReceta.TabIndex = 7;
            // 
            // lblPorciones
            // 
            this.lblPorciones.BackColor = System.Drawing.Color.Transparent;
            this.lblPorciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorciones.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPorciones.Location = new System.Drawing.Point(29, 135);
            this.lblPorciones.Name = "lblPorciones";
            this.lblPorciones.Size = new System.Drawing.Size(128, 27);
            this.lblPorciones.TabIndex = 2;
            this.lblPorciones.Text = "No .Porciones";
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreReceta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreReceta.DefaultText = "";
            this.txtNombreReceta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreReceta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreReceta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreReceta.DisabledState.Parent = this.txtNombreReceta;
            this.txtNombreReceta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreReceta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreReceta.FocusedState.Parent = this.txtNombreReceta;
            this.txtNombreReceta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreReceta.HoverState.Parent = this.txtNombreReceta;
            this.txtNombreReceta.Location = new System.Drawing.Point(323, 92);
            this.txtNombreReceta.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.PasswordChar = '\0';
            this.txtNombreReceta.PlaceholderText = "";
            this.txtNombreReceta.SelectedText = "";
            this.txtNombreReceta.ShadowDecoration.Parent = this.txtNombreReceta;
            this.txtNombreReceta.Size = new System.Drawing.Size(204, 37);
            this.txtNombreReceta.TabIndex = 1;
            this.txtNombreReceta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreReceta_KeyPress);
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreReceta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReceta.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNombreReceta.Location = new System.Drawing.Point(29, 82);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(167, 27);
            this.lblNombreReceta.TabIndex = 0;
            this.lblNombreReceta.Text = "Nombre de Receta";
            // 
            // ttipMensaje
            // 
            this.ttipMensaje.AllowLinksHandling = true;
            this.ttipMensaje.BackColor = System.Drawing.Color.Lavender;
            this.ttipMensaje.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.ttipMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttipMensaje.IsBalloon = true;
            this.ttipMensaje.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderRadius = 2;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.Parent = this.txtBusqueda;
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.FocusedState.Parent = this.txtBusqueda;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.HoverState.Parent = this.txtBusqueda;
            this.txtBusqueda.Location = new System.Drawing.Point(761, 71);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderText = "";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Parent = this.txtBusqueda;
            this.txtBusqueda.Size = new System.Drawing.Size(297, 38);
            this.txtBusqueda.TabIndex = 26;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // lsbInsumo
            // 
            this.lsbInsumo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbInsumo.FormattingEnabled = true;
            this.lsbInsumo.ItemHeight = 25;
            this.lsbInsumo.Location = new System.Drawing.Point(592, 205);
            this.lsbInsumo.Name = "lsbInsumo";
            this.lsbInsumo.Size = new System.Drawing.Size(129, 29);
            this.lsbInsumo.TabIndex = 43;
            this.lsbInsumo.Visible = false;
            this.lsbInsumo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lsbInsumo_MouseDown);
            // 
            // FrmIngresarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1104, 602);
            this.Controls.Add(this.GbxReceta);
            this.Name = "FrmIngresarReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Recetas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIngresarReceta_FormClosed);
            this.Load += new System.EventHandler(this.FrmIngresarReceta_Load);
            this.GbxReceta.ResumeLayout(false);
            this.GbxReceta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbxReceta;
        private Guna.UI2.WinForms.Guna2VSeparator SpdrReceta;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPorciones;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreReceta;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreReceta;
        private Guna.UI2.WinForms.Guna2TextBox TxtCantidades;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCantidad;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreIngrediente;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUM;
        private Guna.UI2.WinForms.Guna2TextBox txtPorciones;
        private Guna.UI.WinForms.GunaTextBox txtProcedimiento;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProcedimiento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInsumos;
        private Guna.UI2.WinForms.Guna2Button btnSiguiente;
        private Guna.UI2.WinForms.Guna2Button btnguardarInsumo;
        private Guna.UI2.WinForms.Guna2Button BtnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnMostrarRecetas;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ttipMensaje;
        private Guna.UI2.WinForms.Guna2Button btnListo;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private System.Windows.Forms.ListBox lsbInsumo;
    }
}