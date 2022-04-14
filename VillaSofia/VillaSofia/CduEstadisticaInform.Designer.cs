namespace VillaSofia
{
    partial class CduEstadisticaInform
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
            this.RPTVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTimeDesde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DataTimeHasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnGenInfor = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // RPTVentas
            // 
            this.RPTVentas.LocalReport.ReportEmbeddedResource = "VillaSofia.ReportEstadistic.rdlc";
            this.RPTVentas.Location = new System.Drawing.Point(230, 3);
            this.RPTVentas.Name = "RPTVentas";
            this.RPTVentas.ServerReport.BearerToken = null;
            this.RPTVentas.Size = new System.Drawing.Size(731, 460);
            this.RPTVentas.TabIndex = 0;
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(36, 41);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(39, 13);
            this.LblD.TabIndex = 1;
            this.LblD.Text = "desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hasta:";
            // 
            // DataTimeDesde
            // 
            this.DataTimeDesde.CheckedState.Parent = this.DataTimeDesde;
            this.DataTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataTimeDesde.HoverState.Parent = this.DataTimeDesde;
            this.DataTimeDesde.Location = new System.Drawing.Point(24, 57);
            this.DataTimeDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DataTimeDesde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DataTimeDesde.Name = "DataTimeDesde";
            this.DataTimeDesde.ShadowDecoration.Parent = this.DataTimeDesde;
            this.DataTimeDesde.Size = new System.Drawing.Size(200, 36);
            this.DataTimeDesde.TabIndex = 3;
            this.DataTimeDesde.Value = new System.DateTime(2022, 4, 13, 12, 34, 38, 13);
            // 
            // DataTimeHasta
            // 
            this.DataTimeHasta.CheckedState.Parent = this.DataTimeHasta;
            this.DataTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DataTimeHasta.HoverState.Parent = this.DataTimeHasta;
            this.DataTimeHasta.Location = new System.Drawing.Point(24, 112);
            this.DataTimeHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DataTimeHasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DataTimeHasta.Name = "DataTimeHasta";
            this.DataTimeHasta.ShadowDecoration.Parent = this.DataTimeHasta;
            this.DataTimeHasta.Size = new System.Drawing.Size(200, 36);
            this.DataTimeHasta.TabIndex = 4;
            this.DataTimeHasta.Value = new System.DateTime(2022, 4, 13, 12, 34, 38, 13);
            // 
            // BtnGenInfor
            // 
            this.BtnGenInfor.CheckedState.Parent = this.BtnGenInfor;
            this.BtnGenInfor.CustomImages.Parent = this.BtnGenInfor;
            this.BtnGenInfor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGenInfor.ForeColor = System.Drawing.Color.White;
            this.BtnGenInfor.HoverState.Parent = this.BtnGenInfor;
            this.BtnGenInfor.Location = new System.Drawing.Point(24, 167);
            this.BtnGenInfor.Name = "BtnGenInfor";
            this.BtnGenInfor.ShadowDecoration.Parent = this.BtnGenInfor;
            this.BtnGenInfor.Size = new System.Drawing.Size(162, 31);
            this.BtnGenInfor.TabIndex = 5;
            this.BtnGenInfor.Text = "Generar Informe";
            this.BtnGenInfor.Click += new System.EventHandler(this.BtnGenInfor_Click);
            // 
            // CduEstadisticaInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnGenInfor);
            this.Controls.Add(this.DataTimeHasta);
            this.Controls.Add(this.DataTimeDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.RPTVentas);
            this.Name = "CduEstadisticaInform";
            this.Size = new System.Drawing.Size(964, 466);
            this.Load += new System.EventHandler(this.CduPanelVacio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPTVentas;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DataTimeDesde;
        private Guna.UI2.WinForms.Guna2DateTimePicker DataTimeHasta;
        private Guna.UI2.WinForms.Guna2Button BtnGenInfor;
    }
}
