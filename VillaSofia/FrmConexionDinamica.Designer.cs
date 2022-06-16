namespace VillaSofia
{
    partial class FrmConexionDinamica
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
            this.btnGuardarConexion = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblnombre_bd = new System.Windows.Forms.Label();
            this.lblhost = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre_bd = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarConexion
            // 
            this.btnGuardarConexion.CheckedState.Parent = this.btnGuardarConexion;
            this.btnGuardarConexion.CustomImages.Parent = this.btnGuardarConexion;
            this.btnGuardarConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardarConexion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarConexion.HoverState.Parent = this.btnGuardarConexion;
            this.btnGuardarConexion.Location = new System.Drawing.Point(206, 117);
            this.btnGuardarConexion.Name = "btnGuardarConexion";
            this.btnGuardarConexion.ShadowDecoration.Parent = this.btnGuardarConexion;
            this.btnGuardarConexion.Size = new System.Drawing.Size(120, 29);
            this.btnGuardarConexion.TabIndex = 0;
            this.btnGuardarConexion.Text = "Guardar";
            this.btnGuardarConexion.Click += new System.EventHandler(this.btnGuardarConexion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Clave";
            // 
            // lblnombre_bd
            // 
            this.lblnombre_bd.AutoSize = true;
            this.lblnombre_bd.Location = new System.Drawing.Point(271, 31);
            this.lblnombre_bd.Name = "lblnombre_bd";
            this.lblnombre_bd.Size = new System.Drawing.Size(117, 13);
            this.lblnombre_bd.TabIndex = 3;
            this.lblnombre_bd.Text = "Nombre Base de Datos";
            // 
            // lblhost
            // 
            this.lblhost.AutoSize = true;
            this.lblhost.Location = new System.Drawing.Point(307, 70);
            this.lblhost.Name = "lblhost";
            this.lblhost.Size = new System.Drawing.Size(29, 13);
            this.lblhost.TabIndex = 4;
            this.lblhost.Text = "Host";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(72, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(179, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(72, 63);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(179, 20);
            this.txtClave.TabIndex = 6;
            // 
            // txtNombre_bd
            // 
            this.txtNombre_bd.Location = new System.Drawing.Point(394, 31);
            this.txtNombre_bd.Name = "txtNombre_bd";
            this.txtNombre_bd.Size = new System.Drawing.Size(166, 20);
            this.txtNombre_bd.TabIndex = 7;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(394, 70);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(166, 20);
            this.txtHost.TabIndex = 8;
            // 
            // FrmConexionDinamica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 320);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.txtNombre_bd);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblhost);
            this.Controls.Add(this.lblnombre_bd);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGuardarConexion);
            this.Name = "FrmConexionDinamica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexion";
            this.Load += new System.EventHandler(this.FrmConexionDinamica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGuardarConexion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblnombre_bd;
        private System.Windows.Forms.Label lblhost;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre_bd;
        private System.Windows.Forms.TextBox txtHost;
    }
}