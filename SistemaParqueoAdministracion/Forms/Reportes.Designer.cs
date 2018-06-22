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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaFinal_dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaInicial_dtp = new System.Windows.Forms.DateTimePicker();
            this.Buscar_btn = new System.Windows.Forms.Button();
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_Maximize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Restaurar);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Controls.Add(this.btn_Close);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA FINAL";
            // 
            // FechaFinal_dtp
            // 
            this.FechaFinal_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaFinal_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFinal_dtp.Location = new System.Drawing.Point(110, 32);
            this.FechaFinal_dtp.Name = "FechaFinal_dtp";
            this.FechaFinal_dtp.Size = new System.Drawing.Size(96, 22);
            this.FechaFinal_dtp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA INICIAL";
            // 
            // FechaInicial_dtp
            // 
            this.FechaInicial_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaInicial_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicial_dtp.Location = new System.Drawing.Point(110, 6);
            this.FechaInicial_dtp.Name = "FechaInicial_dtp";
            this.FechaInicial_dtp.Size = new System.Drawing.Size(96, 22);
            this.FechaInicial_dtp.TabIndex = 0;
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.Buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Buscar_btn.FlatAppearance.BorderSize = 2;
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.print_preview;
            this.Buscar_btn.Location = new System.Drawing.Point(224, 7);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(68, 46);
            this.Buscar_btn.TabIndex = 7;
            this.Buscar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_btn.UseVisualStyleBackColor = false;
            this.Buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.Image = global::SistemaParqueoAdministracion.Properties.Resources.multi_tab;
            this.btn_Restaurar.Location = new System.Drawing.Point(809, 4);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(15, 15);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Restaurar.TabIndex = 48;
            this.btn_Restaurar.TabStop = false;
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = global::SistemaParqueoAdministracion.Properties.Resources.minimize;
            this.btn_minimize.Location = new System.Drawing.Point(788, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(15, 15);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 49;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximize.Image = global::SistemaParqueoAdministracion.Properties.Resources.blank_check_box;
            this.btn_Maximize.Location = new System.Drawing.Point(809, 4);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(15, 15);
            this.btn_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Maximize.TabIndex = 50;
            this.btn_Maximize.TabStop = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Image = global::SistemaParqueoAdministracion.Properties.Resources.cancel1;
            this.btn_Close.Location = new System.Drawing.Point(830, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(15, 15);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 47;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 470);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
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
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_Maximize;
        private System.Windows.Forms.PictureBox btn_Close;
    }
}