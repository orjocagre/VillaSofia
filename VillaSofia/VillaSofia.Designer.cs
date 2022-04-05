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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminstrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LblUsuario = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.lblJefeCocina = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
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
            this.adminstrarUsuariosToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.Color.Gainsboro;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(81, 24);
            this.fileMenu.Text = "Registro";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // trabajadorToolStripMenuItem
            // 
            this.trabajadorToolStripMenuItem.Name = "trabajadorToolStripMenuItem";
            this.trabajadorToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.trabajadorToolStripMenuItem.Text = "Trabajador";
            this.trabajadorToolStripMenuItem.Click += new System.EventHandler(this.trabajadorToolStripMenuItem_Click);
            // 
            // recetaToolStripMenuItem
            // 
            this.recetaToolStripMenuItem.Name = "recetaToolStripMenuItem";
            this.recetaToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.recetaToolStripMenuItem.Text = "Receta";
            this.recetaToolStripMenuItem.Click += new System.EventHandler(this.recetaToolStripMenuItem_Click);
            // 
            // adminstrarUsuariosToolStripMenuItem
            // 
            this.adminstrarUsuariosToolStripMenuItem.Name = "adminstrarUsuariosToolStripMenuItem";
            this.adminstrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.adminstrarUsuariosToolStripMenuItem.Text = "Adminstrar Usuarios";
            this.adminstrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.adminstrarUsuariosToolStripMenuItem_Click);
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
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.White;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(987, 4);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(107, 20);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Administrador";
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.BackColor = System.Drawing.Color.White;
            this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.Location = new System.Drawing.Point(1014, 7);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(55, 20);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Cajero";
            // 
            // lblJefeCocina
            // 
            this.lblJefeCocina.AutoSize = true;
            this.lblJefeCocina.BackColor = System.Drawing.Color.White;
            this.lblJefeCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefeCocina.Location = new System.Drawing.Point(987, 4);
            this.lblJefeCocina.Name = "lblJefeCocina";
            this.lblJefeCocina.Size = new System.Drawing.Size(115, 20);
            this.lblJefeCocina.TabIndex = 10;
            this.lblJefeCocina.Text = "Jefe de Cocina";
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.Color.White;
            this.btnSesion.Location = new System.Drawing.Point(1116, 4);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(75, 23);
            this.btnSesion.TabIndex = 8;
            this.btnSesion.Text = "CerrarSesion";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // VillaSofia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 593);
            this.Controls.Add(this.lblJefeCocina);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.lblCajero);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VillaSofia";
            this.Text = "VillaSofia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label lblJefeCocina;
        private System.Windows.Forms.Button btnSesion;
    }
}



