namespace VillaSofia
{
    partial class CduMenuPrincipal
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
            this.pnPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInventario = new Guna.UI2.WinForms.Guna2Button();
            this.btnEventos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaja = new Guna.UI2.WinForms.Guna2Button();
            this.btnVentas = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnConexion = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackgroundImage = global::VillaSofia.Properties.Resources.fondogris;
            this.pnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPrincipal.Controls.Add(this.btnConexion);
            this.pnPrincipal.Controls.Add(this.btnInventario);
            this.pnPrincipal.Controls.Add(this.btnEventos);
            this.pnPrincipal.Controls.Add(this.btnCaja);
            this.pnPrincipal.Controls.Add(this.btnVentas);
            this.pnPrincipal.Controls.Add(this.btnMenu);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.ShadowDecoration.Parent = this.pnPrincipal;
            this.pnPrincipal.Size = new System.Drawing.Size(1221, 678);
            this.pnPrincipal.TabIndex = 4;
            this.pnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPrincipal_Paint);
            // 
            // btnInventario
            // 
            this.btnInventario.CheckedState.Parent = this.btnInventario;
            this.btnInventario.CustomImages.Parent = this.btnInventario;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.HoverState.Parent = this.btnInventario;
            this.btnInventario.Location = new System.Drawing.Point(478, 122);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.ShadowDecoration.Parent = this.btnInventario;
            this.btnInventario.Size = new System.Drawing.Size(180, 45);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEventos.Animated = true;
            this.btnEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnEventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEventos.CheckedState.Parent = this.btnEventos;
            this.btnEventos.CustomImages.Parent = this.btnEventos;
            this.btnEventos.FillColor = System.Drawing.Color.Transparent;
            this.btnEventos.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold);
            this.btnEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEventos.HoverState.Parent = this.btnEventos;
            this.btnEventos.Image = global::VillaSofia.Properties.Resources.eventos256;
            this.btnEventos.ImageOffset = new System.Drawing.Point(0, -20);
            this.btnEventos.ImageSize = new System.Drawing.Size(200, 200);
            this.btnEventos.Location = new System.Drawing.Point(615, 198);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.ShadowDecoration.Parent = this.btnEventos;
            this.btnEventos.Size = new System.Drawing.Size(250, 303);
            this.btnEventos.TabIndex = 1;
            this.btnEventos.Text = "EVENTOS";
            this.btnEventos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEventos.TextOffset = new System.Drawing.Point(10, 115);
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCaja.Animated = true;
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaja.CheckedState.Parent = this.btnCaja;
            this.btnCaja.CustomImages.Parent = this.btnCaja;
            this.btnCaja.FillColor = System.Drawing.Color.Transparent;
            this.btnCaja.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold);
            this.btnCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.btnCaja.HoverState.Parent = this.btnCaja;
            this.btnCaja.Image = global::VillaSofia.Properties.Resources.caja256;
            this.btnCaja.ImageOffset = new System.Drawing.Point(0, -20);
            this.btnCaja.ImageSize = new System.Drawing.Size(200, 200);
            this.btnCaja.Location = new System.Drawing.Point(359, 198);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.ShadowDecoration.Parent = this.btnCaja;
            this.btnCaja.Size = new System.Drawing.Size(250, 303);
            this.btnCaja.TabIndex = 3;
            this.btnCaja.Text = "CAJA";
            this.btnCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaja.TextOffset = new System.Drawing.Point(45, 115);
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentas.Animated = true;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.CheckedState.Parent = this.btnVentas;
            this.btnVentas.CustomImages.Parent = this.btnVentas;
            this.btnVentas.FillColor = System.Drawing.Color.Transparent;
            this.btnVentas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(0)))));
            this.btnVentas.HoverState.Parent = this.btnVentas;
            this.btnVentas.Image = global::VillaSofia.Properties.Resources.ventas256;
            this.btnVentas.ImageOffset = new System.Drawing.Point(0, -20);
            this.btnVentas.ImageSize = new System.Drawing.Size(200, 200);
            this.btnVentas.Location = new System.Drawing.Point(871, 198);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.ShadowDecoration.Parent = this.btnVentas;
            this.btnVentas.Size = new System.Drawing.Size(250, 303);
            this.btnVentas.TabIndex = 0;
            this.btnVentas.Text = "VENTAS";
            this.btnVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVentas.TextOffset = new System.Drawing.Point(25, 115);
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.Animated = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.btnMenu.CustomImages.Parent = this.btnMenu;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Tw Cen MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(0)))), ((int)(((byte)(201)))));
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Image = global::VillaSofia.Properties.Resources.recetas256;
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, -20);
            this.btnMenu.ImageSize = new System.Drawing.Size(200, 200);
            this.btnMenu.Location = new System.Drawing.Point(103, 198);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(250, 303);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "RECETAS";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(15, 115);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnConexion
            // 
            this.btnConexion.CheckedState.Parent = this.btnConexion;
            this.btnConexion.CustomImages.Parent = this.btnConexion;
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConexion.ForeColor = System.Drawing.Color.White;
            this.btnConexion.HoverState.Parent = this.btnConexion;
            this.btnConexion.Location = new System.Drawing.Point(751, 44);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnConexion.ShadowDecoration.Parent = this.btnConexion;
            this.btnConexion.Size = new System.Drawing.Size(148, 148);
            this.btnConexion.TabIndex = 5;
            this.btnConexion.Text = "Conexion";
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // CduMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnPrincipal);
            this.Name = "CduMenuPrincipal";
            this.Size = new System.Drawing.Size(1221, 678);
            this.pnPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVentas;
        private Guna.UI2.WinForms.Guna2Button btnEventos;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnCaja;
        private Guna.UI2.WinForms.Guna2Panel pnPrincipal;
        private Guna.UI2.WinForms.Guna2Button btnInventario;
        private Guna.UI2.WinForms.Guna2CircleButton btnConexion;
    }
}
