namespace VillaSofia
{
    partial class MessageBoxCambioDeFactura
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCerrarCuenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnDejarAbierta = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(324, 75);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "No se especificó el estado de la cuenta";
            // 
            // btnCerrarCuenta
            // 
            this.btnCerrarCuenta.BorderColor = System.Drawing.Color.White;
            this.btnCerrarCuenta.CheckedState.Parent = this.btnCerrarCuenta;
            this.btnCerrarCuenta.CustomImages.Parent = this.btnCerrarCuenta;
            this.btnCerrarCuenta.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarCuenta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarCuenta.HoverState.Parent = this.btnCerrarCuenta;
            this.btnCerrarCuenta.Location = new System.Drawing.Point(0, 107);
            this.btnCerrarCuenta.Name = "btnCerrarCuenta";
            this.btnCerrarCuenta.ShadowDecoration.Parent = this.btnCerrarCuenta;
            this.btnCerrarCuenta.Size = new System.Drawing.Size(180, 64);
            this.btnCerrarCuenta.TabIndex = 1;
            this.btnCerrarCuenta.Text = "CERRAR CUENTA";
            this.btnCerrarCuenta.Click += new System.EventHandler(this.btnCerrarCuenta_Click);
            // 
            // btnDejarAbierta
            // 
            this.btnDejarAbierta.CheckedState.Parent = this.btnDejarAbierta;
            this.btnDejarAbierta.CustomImages.Parent = this.btnDejarAbierta;
            this.btnDejarAbierta.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDejarAbierta.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDejarAbierta.ForeColor = System.Drawing.Color.Black;
            this.btnDejarAbierta.HoverState.Parent = this.btnDejarAbierta;
            this.btnDejarAbierta.Location = new System.Drawing.Point(180, 107);
            this.btnDejarAbierta.Name = "btnDejarAbierta";
            this.btnDejarAbierta.ShadowDecoration.Parent = this.btnDejarAbierta;
            this.btnDejarAbierta.Size = new System.Drawing.Size(180, 64);
            this.btnDejarAbierta.TabIndex = 1;
            this.btnDejarAbierta.Text = "DEJAR ABIERTA";
            this.btnDejarAbierta.Click += new System.EventHandler(this.btnDejarAbierta_Click);
            // 
            // MessageBoxCambioDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 171);
            this.Controls.Add(this.btnDejarAbierta);
            this.Controls.Add(this.btnCerrarCuenta);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxCambioDeFactura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageBoxCambioDeFactura_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCerrarCuenta;
        private Guna.UI2.WinForms.Guna2Button btnDejarAbierta;
    }
}