namespace SistemaParqueoAdministracion.Forms
{
    partial class Empresa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.direccion_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.telefono_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.correo_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.Empresa_dtg = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Empresa_dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "REGISTRO DE EMPRESA";
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Nombre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_txt.Location = new System.Drawing.Point(111, 50);
            this.Nombre_txt.Multiline = true;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(266, 31);
            this.Nombre_txt.TabIndex = 27;
            this.Nombre_txt.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "NOMBRE:";
            // 
            // direccion_txt
            // 
            this.direccion_txt.BackColor = System.Drawing.SystemColors.Info;
            this.direccion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_txt.Location = new System.Drawing.Point(111, 87);
            this.direccion_txt.Multiline = true;
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(266, 88);
            this.direccion_txt.TabIndex = 29;
            this.direccion_txt.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "DIRECCIÓN:";
            // 
            // telefono_txt
            // 
            this.telefono_txt.BackColor = System.Drawing.SystemColors.Info;
            this.telefono_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_txt.Location = new System.Drawing.Point(111, 181);
            this.telefono_txt.Multiline = true;
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(266, 31);
            this.telefono_txt.TabIndex = 31;
            this.telefono_txt.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "TELÉFONO:";
            // 
            // correo_txt
            // 
            this.correo_txt.BackColor = System.Drawing.SystemColors.Info;
            this.correo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_txt.Location = new System.Drawing.Point(111, 218);
            this.correo_txt.Multiline = true;
            this.correo_txt.Name = "correo_txt";
            this.correo_txt.Size = new System.Drawing.Size(266, 31);
            this.correo_txt.TabIndex = 33;
            this.correo_txt.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "CORREO:";
            // 
            // Empresa_dtg
            // 
            this.Empresa_dtg.AllowUserToAddRows = false;
            this.Empresa_dtg.AllowUserToDeleteRows = false;
            this.Empresa_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Empresa_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.usuario,
            this.clave,
            this.tipo});
            this.Empresa_dtg.Location = new System.Drawing.Point(397, 50);
            this.Empresa_dtg.MultiSelect = false;
            this.Empresa_dtg.Name = "Empresa_dtg";
            this.Empresa_dtg.ReadOnly = true;
            this.Empresa_dtg.RowHeadersWidth = 10;
            this.Empresa_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Empresa_dtg.Size = new System.Drawing.Size(360, 199);
            this.Empresa_dtg.TabIndex = 160;
            this.Empresa_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Empresa_dtg_CellDoubleClick);
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "IDEMPRESA";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "DIRECCIÓN";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "TELÉFONO";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "CORREO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Info;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.BorderSize = 2;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.exit;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_btn.Location = new System.Drawing.Point(387, 265);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 57);
            this.exit_btn.TabIndex = 164;
            this.exit_btn.Text = "SALIR";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            // 
            // saveSettings_btn
            // 
            this.saveSettings_btn.BackColor = System.Drawing.SystemColors.Info;
            this.saveSettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveSettings_btn.FlatAppearance.BorderSize = 2;
            this.saveSettings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.saveSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.save;
            this.saveSettings_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveSettings_btn.Location = new System.Drawing.Point(298, 265);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(83, 57);
            this.saveSettings_btn.TabIndex = 163;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(769, 334);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.Empresa_dtg);
            this.Controls.Add(this.correo_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE EMPRESA";
            this.Load += new System.EventHandler(this.Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Empresa_dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controles.textbox Nombre_txt;
        private System.Windows.Forms.Label label6;
        private Controles.textbox direccion_txt;
        private System.Windows.Forms.Label label2;
        private Controles.textbox telefono_txt;
        private System.Windows.Forms.Label label3;
        private Controles.textbox correo_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Empresa_dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}