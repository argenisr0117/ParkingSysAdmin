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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarSesion_btn = new System.Windows.Forms.Button();
            this.tipoUsuario_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notActivated_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.empresa_btn = new System.Windows.Forms.Button();
            this.tiempo_precio_txt = new System.Windows.Forms.Button();
            this.otherSettings_btn = new System.Windows.Forms.Button();
            this.tipoUsuario_btn = new System.Windows.Forms.Button();
            this.agregarUsuario_btn = new System.Windows.Forms.Button();
            this.cierre_diario_btn = new System.Windows.Forms.Button();
            this.Reporte_btn = new System.Windows.Forms.Button();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIVARSOFTWAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 33);
            this.panel1.TabIndex = 36;
            // 
            // cerrarSesion_btn
            // 
            this.cerrarSesion_btn.BackColor = System.Drawing.SystemColors.Info;
            this.cerrarSesion_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cerrarSesion_btn.FlatAppearance.BorderSize = 2;
            this.cerrarSesion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_btn.Location = new System.Drawing.Point(504, 1);
            this.cerrarSesion_btn.Name = "cerrarSesion_btn";
            this.cerrarSesion_btn.Size = new System.Drawing.Size(108, 26);
            this.cerrarSesion_btn.TabIndex = 6;
            this.cerrarSesion_btn.Text = "CERRAR SESIÓN";
            this.cerrarSesion_btn.UseVisualStyleBackColor = false;
            this.cerrarSesion_btn.Click += new System.EventHandler(this.cerrarSesion_btn_Click);
            // 
            // tipoUsuario_lbl
            // 
            this.tipoUsuario_lbl.AutoSize = true;
            this.tipoUsuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tipoUsuario_lbl.Location = new System.Drawing.Point(352, 8);
            this.tipoUsuario_lbl.Name = "tipoUsuario_lbl";
            this.tipoUsuario_lbl.Size = new System.Drawing.Size(11, 13);
            this.tipoUsuario_lbl.TabIndex = 5;
            this.tipoUsuario_lbl.Text = "t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(234, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TIPO USUARIO:";
            // 
            // Usuario_lbl
            // 
            this.Usuario_lbl.AutoSize = true;
            this.Usuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cierre_diario_btn);
            this.groupBox1.Controls.Add(this.Reporte_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 302);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empresa_btn);
            this.groupBox2.Controls.Add(this.tiempo_precio_txt);
            this.groupBox2.Controls.Add(this.otherSettings_btn);
            this.groupBox2.Controls.Add(this.tipoUsuario_btn);
            this.groupBox2.Controls.Add(this.agregarUsuario_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(453, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 302);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONFIGURACIONES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notActivated_lbl
            // 
            this.notActivated_lbl.AutoSize = true;
            this.notActivated_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notActivated_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.notActivated_lbl.Location = new System.Drawing.Point(454, 9);
            this.notActivated_lbl.Name = "notActivated_lbl";
            this.notActivated_lbl.Size = new System.Drawing.Size(312, 20);
            this.notActivated_lbl.TabIndex = 40;
            this.notActivated_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO";
            // 
            // empresa_btn
            // 
            this.empresa_btn.BackColor = System.Drawing.SystemColors.Info;
            this.empresa_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.empresa_btn.FlatAppearance.BorderSize = 2;
            this.empresa_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.empresa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empresa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.empresa_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.gohome;
            this.empresa_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.empresa_btn.Location = new System.Drawing.Point(165, 111);
            this.empresa_btn.Name = "empresa_btn";
            this.empresa_btn.Size = new System.Drawing.Size(129, 86);
            this.empresa_btn.TabIndex = 38;
            this.empresa_btn.Text = "AGREGAR/EDITAR EMPRESA";
            this.empresa_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.empresa_btn.UseVisualStyleBackColor = false;
            this.empresa_btn.Click += new System.EventHandler(this.empresa_btn_Click);
            // 
            // tiempo_precio_txt
            // 
            this.tiempo_precio_txt.BackColor = System.Drawing.SystemColors.Info;
            this.tiempo_precio_txt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tiempo_precio_txt.FlatAppearance.BorderSize = 2;
            this.tiempo_precio_txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.tiempo_precio_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiempo_precio_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_precio_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tiempo_precio_txt.Image = global::SistemaParqueoAdministracion.Properties.Resources.clock;
            this.tiempo_precio_txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tiempo_precio_txt.Location = new System.Drawing.Point(165, 19);
            this.tiempo_precio_txt.Name = "tiempo_precio_txt";
            this.tiempo_precio_txt.Size = new System.Drawing.Size(129, 86);
            this.tiempo_precio_txt.TabIndex = 37;
            this.tiempo_precio_txt.Text = "CONFIGURAR TIEMPO/PRECIO";
            this.tiempo_precio_txt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tiempo_precio_txt.UseVisualStyleBackColor = false;
            this.tiempo_precio_txt.Click += new System.EventHandler(this.tiempo_precio_txt_Click);
            // 
            // otherSettings_btn
            // 
            this.otherSettings_btn.BackColor = System.Drawing.SystemColors.Info;
            this.otherSettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.otherSettings_btn.FlatAppearance.BorderSize = 2;
            this.otherSettings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.otherSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherSettings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherSettings_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otherSettings_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.configure;
            this.otherSettings_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.otherSettings_btn.Location = new System.Drawing.Point(30, 203);
            this.otherSettings_btn.Name = "otherSettings_btn";
            this.otherSettings_btn.Size = new System.Drawing.Size(129, 86);
            this.otherSettings_btn.TabIndex = 36;
            this.otherSettings_btn.Text = "OTRAS CONFIGURACIONES";
            this.otherSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.otherSettings_btn.UseVisualStyleBackColor = false;
            this.otherSettings_btn.Click += new System.EventHandler(this.otherSettings_btn_Click);
            // 
            // tipoUsuario_btn
            // 
            this.tipoUsuario_btn.BackColor = System.Drawing.SystemColors.Info;
            this.tipoUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tipoUsuario_btn.FlatAppearance.BorderSize = 2;
            this.tipoUsuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.tipoUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoUsuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tipoUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.tipoUsuario__1_;
            this.tipoUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tipoUsuario_btn.Location = new System.Drawing.Point(30, 19);
            this.tipoUsuario_btn.Name = "tipoUsuario_btn";
            this.tipoUsuario_btn.Size = new System.Drawing.Size(129, 86);
            this.tipoUsuario_btn.TabIndex = 34;
            this.tipoUsuario_btn.Text = "AGREAGAR/EDITAR TIPOS USUARIOS";
            this.tipoUsuario_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tipoUsuario_btn.UseVisualStyleBackColor = false;
            this.tipoUsuario_btn.Click += new System.EventHandler(this.tipoUsuario_btn_Click);
            // 
            // agregarUsuario_btn
            // 
            this.agregarUsuario_btn.BackColor = System.Drawing.SystemColors.Info;
            this.agregarUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregarUsuario_btn.FlatAppearance.BorderSize = 2;
            this.agregarUsuario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.agregarUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarUsuario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuario_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agregarUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.agregar_usuario;
            this.agregarUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.agregarUsuario_btn.Location = new System.Drawing.Point(30, 111);
            this.agregarUsuario_btn.Name = "agregarUsuario_btn";
            this.agregarUsuario_btn.Size = new System.Drawing.Size(129, 86);
            this.agregarUsuario_btn.TabIndex = 35;
            this.agregarUsuario_btn.Text = "AGREGAR/EDITAR USUARIOS";
            this.agregarUsuario_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarUsuario_btn.UseVisualStyleBackColor = false;
            this.agregarUsuario_btn.Click += new System.EventHandler(this.agregarUsuario_btn_Click);
            // 
            // cierre_diario_btn
            // 
            this.cierre_diario_btn.BackColor = System.Drawing.SystemColors.Info;
            this.cierre_diario_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cierre_diario_btn.FlatAppearance.BorderSize = 2;
            this.cierre_diario_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.cierre_diario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cierre_diario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cierre_diario_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cierre_diario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.statistics__2_;
            this.cierre_diario_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cierre_diario_btn.Location = new System.Drawing.Point(141, 19);
            this.cierre_diario_btn.Name = "cierre_diario_btn";
            this.cierre_diario_btn.Size = new System.Drawing.Size(129, 66);
            this.cierre_diario_btn.TabIndex = 39;
            this.cierre_diario_btn.Text = "CIERRE DIARIO";
            this.cierre_diario_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cierre_diario_btn.UseVisualStyleBackColor = false;
            this.cierre_diario_btn.Click += new System.EventHandler(this.cierre_diario_btn_Click);
            // 
            // Reporte_btn
            // 
            this.Reporte_btn.BackColor = System.Drawing.SystemColors.Info;
            this.Reporte_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Reporte_btn.FlatAppearance.BorderSize = 2;
            this.Reporte_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.Reporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporte_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reporte_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.statistics__2_;
            this.Reporte_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reporte_btn.Location = new System.Drawing.Point(6, 19);
            this.Reporte_btn.Name = "Reporte_btn";
            this.Reporte_btn.Size = new System.Drawing.Size(129, 66);
            this.Reporte_btn.TabIndex = 38;
            this.Reporte_btn.Text = "HISTORIAL TICKETS";
            this.Reporte_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reporte_btn.UseVisualStyleBackColor = false;
            this.Reporte_btn.Click += new System.EventHandler(this.Reporte_btn_Click);
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIVARSOFTWAREToolStripMenuItem});
            this.mENUToolStripMenuItem.Image = global::SistemaParqueoAdministracion.Properties.Resources.menu;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // aCTIVARSOFTWAREToolStripMenuItem
            // 
            this.aCTIVARSOFTWAREToolStripMenuItem.Image = global::SistemaParqueoAdministracion.Properties.Resources.key;
            this.aCTIVARSOFTWAREToolStripMenuItem.Name = "aCTIVARSOFTWAREToolStripMenuItem";
            this.aCTIVARSOFTWAREToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aCTIVARSOFTWAREToolStripMenuItem.Text = "ACTIVAR SOFTWARE";
            this.aCTIVARSOFTWAREToolStripMenuItem.Click += new System.EventHandler(this.aCTIVARSOFTWAREToolStripMenuItem_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(778, 382);
            this.Controls.Add(this.notActivated_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA ADMINISTRATIVO PARQUEO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreenForm_FormClosing);
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button otherSettings_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTIVARSOFTWAREToolStripMenuItem;
        private System.Windows.Forms.Label notActivated_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button tiempo_precio_txt;
        private System.Windows.Forms.Button Reporte_btn;
        private System.Windows.Forms.Button cierre_diario_btn;
        private System.Windows.Forms.Button empresa_btn;
    }
}