namespace VillaSofia
{
    partial class VillaSofia
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillaSofia));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblSuperAdmin = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblJefeCocina = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1191, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.trabajadorToolStripMenuItem,
            this.recetaToolStripMenuItem,
            this.adminstrarUsuariosToolStripMenuItem,
            this.bitacoraDeActividadesToolStripMenuItem,
            this.insumoToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Gainsboro;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(81, 24);
            this.fileMenu.Text = "Registro";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // trabajadorToolStripMenuItem
            // 
            this.trabajadorToolStripMenuItem.Name = "trabajadorToolStripMenuItem";
            this.trabajadorToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.trabajadorToolStripMenuItem.Text = "Trabajador";
            this.trabajadorToolStripMenuItem.Click += new System.EventHandler(this.trabajadorToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.recetaToolStripMenuItem.Text = "Receta";
            this.recetaToolStripMenuItem.Click += new System.EventHandler(this.recetaToolStripMenuItem_Click);
            // 
            // adminstrarUsuariosToolStripMenuItem
            // 
            this.adminstrarUsuariosToolStripMenuItem.Name = "adminstrarUsuariosToolStripMenuItem";
            this.adminstrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.adminstrarUsuariosToolStripMenuItem.Text = "Adminstrar Usuarios";
            this.adminstrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.adminstrarUsuariosToolStripMenuItem_Click);
            // 
            // bitacoraDeActividadesToolStripMenuItem
            // 
            this.bitacoraDeActividadesToolStripMenuItem.Name = "bitacoraDeActividadesToolStripMenuItem";
            this.bitacoraDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.bitacoraDeActividadesToolStripMenuItem.Text = "Bitacora de actividades";
            this.bitacoraDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.bitacoraDeActividadesToolStripMenuItem_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(79, 9);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSuperAdmin
            // 
            this.lblSuperAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuperAdmin.AutoSize = true;
            this.lblSuperAdmin.BackColor = System.Drawing.Color.Lavender;
            this.lblSuperAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperAdmin.Location = new System.Drawing.Point(465, 6);
            this.lblSuperAdmin.Name = "lblSuperAdmin";
            this.lblSuperAdmin.Size = new System.Drawing.Size(97, 20);
            this.lblSuperAdmin.TabIndex = 4;
            this.lblSuperAdmin.Text = "SuperAdmin";
            // 
            // lblCajero
            // 
            this.lblCajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajero.AutoSize = true;
            this.lblCajero.BackColor = System.Drawing.Color.Lavender;
            this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.Location = new System.Drawing.Point(488, 4);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(55, 20);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Cajero";
            // 
            // lblJefeCocina
            // 
            this.lblJefeCocina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJefeCocina.AutoSize = true;
            this.lblJefeCocina.BackColor = System.Drawing.Color.Lavender;
            this.lblJefeCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefeCocina.Location = new System.Drawing.Point(465, 6);
            this.lblJefeCocina.Name = "lblJefeCocina";
            this.lblJefeCocina.Size = new System.Drawing.Size(115, 20);
            this.lblJefeCocina.TabIndex = 10;
            this.lblJefeCocina.Text = "Jefe de Cocina";
            this.lblJefeCocina.Click += new System.EventHandler(this.lblJefeCocina_Click);
            // 
            // btnSesion
            // 
            this.btnSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSesion.BackColor = System.Drawing.Color.Firebrick;
            this.btnSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesion.ForeColor = System.Drawing.Color.White;
            this.btnSesion.Location = new System.Drawing.Point(1086, 4);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(105, 24);
            this.btnSesion.TabIndex = 8;
            this.btnSesion.Text = "Cerrar Sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.BackColor = System.Drawing.Color.Lavender;
            this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(473, 6);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(107, 20);
            this.lblAdministrador.TabIndex = 12;
            this.lblAdministrador.Text = "Administrador";
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.insumoToolStripMenuItem.Text = "Insumo";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // VillaSofia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 593);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblJefeCocina);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.lblCajero);
            this.Controls.Add(this.lblSuperAdmin);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VillaSofia";
            this.Text = "VillaSofia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VillaSofia_FormClosed);
            this.Load += new System.EventHandler(this.VillaSofia_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recetaToolStripMenuItem;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.ToolStripMenuItem adminstrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label lblSuperAdmin;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblJefeCocina;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.ToolStripMenuItem bitacoraDeActividadesToolStripMenuItem;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
    }
}



