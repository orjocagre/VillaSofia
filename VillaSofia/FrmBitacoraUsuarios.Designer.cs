
namespace VillaSofia
{
    partial class FrmBitacoraUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbxHistorial = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblBusquedaUsuario = new System.Windows.Forms.Label();
            this.txtBusquedaUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvHistorialBitacora = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GbxHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorialBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxHistorial
            // 
            this.GbxHistorial.Controls.Add(this.dtgvHistorialBitacora);
            this.GbxHistorial.Controls.Add(this.lblBusquedaUsuario);
            this.GbxHistorial.Controls.Add(this.txtBusquedaUsuario);
            this.GbxHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbxHistorial.ForeColor = System.Drawing.Color.Black;
            this.GbxHistorial.Location = new System.Drawing.Point(12, 12);
            this.GbxHistorial.Name = "GbxHistorial";
            this.GbxHistorial.ShadowDecoration.Parent = this.GbxHistorial;
            this.GbxHistorial.Size = new System.Drawing.Size(790, 466);
            this.GbxHistorial.TabIndex = 17;
            this.GbxHistorial.Text = "Data Grid Bitacora";
            // 
            // lblBusquedaUsuario
            // 
            this.lblBusquedaUsuario.AutoSize = true;
            this.lblBusquedaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblBusquedaUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblBusquedaUsuario.Location = new System.Drawing.Point(34, 75);
            this.lblBusquedaUsuario.Name = "lblBusquedaUsuario";
            this.lblBusquedaUsuario.Size = new System.Drawing.Size(161, 15);
            this.lblBusquedaUsuario.TabIndex = 4;
            this.lblBusquedaUsuario.Text = "Filtro para Busqueda Usuario ";
            // 
            // txtBusquedaUsuario
            // 
            this.txtBusquedaUsuario.BorderColor = System.Drawing.Color.Black;
            this.txtBusquedaUsuario.BorderRadius = 3;
            this.txtBusquedaUsuario.BorderThickness = 2;
            this.txtBusquedaUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusquedaUsuario.DefaultText = "";
            this.txtBusquedaUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusquedaUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusquedaUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaUsuario.DisabledState.Parent = this.txtBusquedaUsuario;
            this.txtBusquedaUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusquedaUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaUsuario.FocusedState.Parent = this.txtBusquedaUsuario;
            this.txtBusquedaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusquedaUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusquedaUsuario.HoverState.Parent = this.txtBusquedaUsuario;
            this.txtBusquedaUsuario.Location = new System.Drawing.Point(204, 66);
            this.txtBusquedaUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.PasswordChar = '\0';
            this.txtBusquedaUsuario.PlaceholderText = "";
            this.txtBusquedaUsuario.SelectedText = "";
            this.txtBusquedaUsuario.ShadowDecoration.Parent = this.txtBusquedaUsuario;
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(548, 33);
            this.txtBusquedaUsuario.TabIndex = 3;
            this.txtBusquedaUsuario.TextChanged += new System.EventHandler(this.txtBusquedaUsuario_TextChanged);
            // 
            // dtgvHistorialBitacora
            // 
            this.dtgvHistorialBitacora.AllowUserToAddRows = false;
            this.dtgvHistorialBitacora.AllowUserToDeleteRows = false;
            this.dtgvHistorialBitacora.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dtgvHistorialBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvHistorialBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistorialBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHistorialBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHistorialBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHistorialBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHistorialBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvHistorialBitacora.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHistorialBitacora.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvHistorialBitacora.EnableHeadersVisualStyles = false;
            this.dtgvHistorialBitacora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dtgvHistorialBitacora.Location = new System.Drawing.Point(3, 125);
            this.dtgvHistorialBitacora.Name = "dtgvHistorialBitacora";
            this.dtgvHistorialBitacora.ReadOnly = true;
            this.dtgvHistorialBitacora.RowHeadersVisible = false;
            this.dtgvHistorialBitacora.RowHeadersWidth = 55;
            this.dtgvHistorialBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHistorialBitacora.Size = new System.Drawing.Size(784, 338);
            this.dtgvHistorialBitacora.TabIndex = 15;
            this.dtgvHistorialBitacora.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            this.dtgvHistorialBitacora.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dtgvHistorialBitacora.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvHistorialBitacora.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvHistorialBitacora.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvHistorialBitacora.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvHistorialBitacora.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHistorialBitacora.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvHistorialBitacora.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgvHistorialBitacora.ThemeStyle.ReadOnly = true;
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dtgvHistorialBitacora.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // FrmBitacoraUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 490);
            this.Controls.Add(this.GbxHistorial);
            this.Name = "FrmBitacoraUsuarios";
            this.Text = "FrmBitacoraUsuarios";
            this.Load += new System.EventHandler(this.FrmBitacoraUsuarios_Load);
            this.GbxHistorial.ResumeLayout(false);
            this.GbxHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistorialBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbxHistorial;
        private System.Windows.Forms.Label lblBusquedaUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtBusquedaUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvHistorialBitacora;
    }
}