namespace SistemaParqueoAdministracion.Forms
{
    partial class Reportes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FechaInicial_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaFinal_dtp = new System.Windows.Forms.DateTimePicker();
            this.Buscar_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(854, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Buscar_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FechaFinal_dtp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FechaInicial_dtp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 65);
            this.panel1.TabIndex = 1;
            // 
            // FechaInicial_dtp
            // 
            this.FechaInicial_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaInicial_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicial_dtp.Location = new System.Drawing.Point(110, 3);
            this.FechaInicial_dtp.Name = "FechaInicial_dtp";
            this.FechaInicial_dtp.Size = new System.Drawing.Size(96, 20);
            this.FechaInicial_dtp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA FINAL";
            // 
            // FechaFinal_dtp
            // 
            this.FechaFinal_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaFinal_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFinal_dtp.Location = new System.Drawing.Point(110, 29);
            this.FechaFinal_dtp.Name = "FechaFinal_dtp";
            this.FechaFinal_dtp.Size = new System.Drawing.Size(96, 20);
            this.FechaFinal_dtp.TabIndex = 2;
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.BackColor = System.Drawing.SystemColors.Info;
            this.Buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Buscar_btn.FlatAppearance.BorderSize = 2;
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.print_preview;
            this.Buscar_btn.Location = new System.Drawing.Point(328, 3);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(68, 46);
            this.Buscar_btn.TabIndex = 7;
            this.Buscar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_btn.UseVisualStyleBackColor = false;
            this.Buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(212, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGRUPAR";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 470);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaFinal_dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaInicial_dtp;
        private System.Windows.Forms.Button Buscar_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}