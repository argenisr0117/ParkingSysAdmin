namespace SistemaParqueoAdministracion.Forms
{
    partial class CierreDiario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuarios_dtg = new System.Windows.Forms.DataGridView();
            this.Buscar_btn = new System.Windows.Forms.Button();
            this.Resumen_btn = new System.Windows.Forms.Button();
            this.FechaInicial_dtp = new System.Windows.Forms.DateTimePicker();
            this.FechaFinal_dtp = new System.Windows.Forms.DateTimePicker();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "FILTRO DE CIERRE DIARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(120, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "FECHA FINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "FECHA INICIAL";
            // 
            // Usuarios_dtg
            // 
            this.Usuarios_dtg.AllowUserToAddRows = false;
            this.Usuarios_dtg.AllowUserToDeleteRows = false;
            this.Usuarios_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuarios_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.idusuario,
            this.nombre,
            this.idturno});
            this.Usuarios_dtg.Location = new System.Drawing.Point(12, 105);
            this.Usuarios_dtg.MultiSelect = false;
            this.Usuarios_dtg.Name = "Usuarios_dtg";
            this.Usuarios_dtg.ReadOnly = true;
            this.Usuarios_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios_dtg.Size = new System.Drawing.Size(447, 150);
            this.Usuarios_dtg.TabIndex = 28;
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.BackColor = System.Drawing.SystemColors.Info;
            this.Buscar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Buscar_btn.FlatAppearance.BorderSize = 2;
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.file_find__2_;
            this.Buscar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_btn.Location = new System.Drawing.Point(225, 54);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(114, 45);
            this.Buscar_btn.TabIndex = 27;
            this.Buscar_btn.Text = "BUSCAR";
            this.Buscar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Buscar_btn.UseVisualStyleBackColor = false;
            this.Buscar_btn.Click += new System.EventHandler(this.Buscar_btn_Click);
            // 
            // Resumen_btn
            // 
            this.Resumen_btn.BackColor = System.Drawing.SystemColors.Info;
            this.Resumen_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Resumen_btn.FlatAppearance.BorderSize = 2;
            this.Resumen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resumen_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resumen_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.print_preview;
            this.Resumen_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Resumen_btn.Location = new System.Drawing.Point(345, 54);
            this.Resumen_btn.Name = "Resumen_btn";
            this.Resumen_btn.Size = new System.Drawing.Size(114, 45);
            this.Resumen_btn.TabIndex = 29;
            this.Resumen_btn.Text = "RESUMEN";
            this.Resumen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resumen_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Resumen_btn.UseVisualStyleBackColor = false;
            this.Resumen_btn.Click += new System.EventHandler(this.Resumen_btn_Click);
            // 
            // FechaInicial_dtp
            // 
            this.FechaInicial_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaInicial_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicial_dtp.Location = new System.Drawing.Point(12, 70);
            this.FechaInicial_dtp.Name = "FechaInicial_dtp";
            this.FechaInicial_dtp.Size = new System.Drawing.Size(92, 20);
            this.FechaInicial_dtp.TabIndex = 30;
            // 
            // FechaFinal_dtp
            // 
            this.FechaFinal_dtp.CustomFormat = "dd/MM/yyyy";
            this.FechaFinal_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFinal_dtp.Location = new System.Drawing.Point(121, 70);
            this.FechaFinal_dtp.Name = "FechaFinal_dtp";
            this.FechaFinal_dtp.Size = new System.Drawing.Size(92, 20);
            this.FechaFinal_dtp.TabIndex = 31;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "ID_USUARIO";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // idturno
            // 
            this.idturno.HeaderText = "TURNO";
            this.idturno.Name = "idturno";
            this.idturno.ReadOnly = true;
            // 
            // CierreDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(469, 271);
            this.Controls.Add(this.FechaFinal_dtp);
            this.Controls.Add(this.FechaInicial_dtp);
            this.Controls.Add(this.Resumen_btn);
            this.Controls.Add(this.Usuarios_dtg);
            this.Controls.Add(this.Buscar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CierreDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FILTRO CIERRE DARIO";
            this.Load += new System.EventHandler(this.CierreDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Usuarios_dtg;
        private System.Windows.Forms.Button Resumen_btn;
        private System.Windows.Forms.DateTimePicker FechaInicial_dtp;
        private System.Windows.Forms.DateTimePicker FechaFinal_dtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturno;
    }
}