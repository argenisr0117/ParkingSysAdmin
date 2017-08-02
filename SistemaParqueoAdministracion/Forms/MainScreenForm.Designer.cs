namespace SistemaParqueoAdministracion.Forms
{
    partial class MainScreenForm
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
            this.agregarUsuario_btn = new System.Windows.Forms.Button();
            this.tipoUsuario_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Usuario_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoUsuario_lbl = new System.Windows.Forms.Label();
            this.cerrarSesion_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // agregarUsuario_btn
            // 
            this.agregarUsuario_btn.BackColor = System.Drawing.SystemColors.Info;
            this.agregarUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregarUsuario_btn.FlatAppearance.BorderSize = 2;
            this.agregarUsuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.agregarUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarUsuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.agregar_usuario;
            this.agregarUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregarUsuario_btn.Location = new System.Drawing.Point(62, 146);
            this.agregarUsuario_btn.Name = "agregarUsuario_btn";
            this.agregarUsuario_btn.Size = new System.Drawing.Size(142, 86);
            this.agregarUsuario_btn.TabIndex = 35;
            this.agregarUsuario_btn.Text = "AGREGAR USUARIOS";
            this.agregarUsuario_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarUsuario_btn.UseVisualStyleBackColor = false;
            this.agregarUsuario_btn.Click += new System.EventHandler(this.agregarUsuario_btn_Click);
            // 
            // tipoUsuario_btn
            // 
            this.tipoUsuario_btn.BackColor = System.Drawing.SystemColors.Info;
            this.tipoUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tipoUsuario_btn.FlatAppearance.BorderSize = 2;
            this.tipoUsuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.tipoUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoUsuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.tipoUsuario__1_;
            this.tipoUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tipoUsuario_btn.Location = new System.Drawing.Point(62, 29);
            this.tipoUsuario_btn.Name = "tipoUsuario_btn";
            this.tipoUsuario_btn.Size = new System.Drawing.Size(142, 86);
            this.tipoUsuario_btn.TabIndex = 34;
            this.tipoUsuario_btn.Text = "TIPOS USUARIOS";
            this.tipoUsuario_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tipoUsuario_btn.UseVisualStyleBackColor = false;
            this.tipoUsuario_btn.Click += new System.EventHandler(this.tipoUsuario_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cerrarSesion_btn);
            this.panel1.Controls.Add(this.tipoUsuario_lbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Usuario_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 33);
            this.panel1.TabIndex = 36;
            // 
            // Usuario_lbl
            // 
            this.Usuario_lbl.AutoSize = true;
            this.Usuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_lbl.Location = new System.Drawing.Point(87, 8);
            this.Usuario_lbl.Name = "Usuario_lbl";
            this.Usuario_lbl.Size = new System.Drawing.Size(14, 13);
            this.Usuario_lbl.TabIndex = 1;
            this.Usuario_lbl.Text = "u";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 250);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipoUsuario_btn);
            this.groupBox2.Controls.Add(this.agregarUsuario_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(357, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 250);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONFIGURACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TIPO USUARIO:";
            // 
            // tipoUsuario_lbl
            // 
            this.tipoUsuario_lbl.AutoSize = true;
            this.tipoUsuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_lbl.Location = new System.Drawing.Point(352, 8);
            this.tipoUsuario_lbl.Name = "tipoUsuario_lbl";
            this.tipoUsuario_lbl.Size = new System.Drawing.Size(0, 13);
            this.tipoUsuario_lbl.TabIndex = 5;
            // 
            // cerrarSesion_btn
            // 
            this.cerrarSesion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_btn.Location = new System.Drawing.Point(484, 4);
            this.cerrarSesion_btn.Name = "cerrarSesion_btn";
            this.cerrarSesion_btn.Size = new System.Drawing.Size(108, 23);
            this.cerrarSesion_btn.TabIndex = 6;
            this.cerrarSesion_btn.Text = "Cerrar Sesión";
            this.cerrarSesion_btn.UseVisualStyleBackColor = true;
            this.cerrarSesion_btn.Click += new System.EventHandler(this.cerrarSesion_btn_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(606, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA ADMINISTRATIVO PARQUEO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreenForm_FormClosing);
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tipoUsuario_btn;
        private System.Windows.Forms.Button agregarUsuario_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Usuario_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cerrarSesion_btn;
        private System.Windows.Forms.Label tipoUsuario_lbl;
        private System.Windows.Forms.Label label2;
    }
}