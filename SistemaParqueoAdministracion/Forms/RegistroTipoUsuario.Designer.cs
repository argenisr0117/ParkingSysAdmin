namespace SistemaParqueoAdministracion.Forms
{
    partial class RegistroTipoUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verStatusEntrada_chbox = new System.Windows.Forms.CheckBox();
            this.cerrarEntrada_chbox = new System.Windows.Forms.CheckBox();
            this.tiempoPrecio_chbox = new System.Windows.Forms.CheckBox();
            this.ticketPerdido_chbox = new System.Windows.Forms.CheckBox();
            this.ticketManual_chbox = new System.Windows.Forms.CheckBox();
            this.cerrarSalida_chbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarUsuario_chbox = new System.Windows.Forms.CheckBox();
            this.generarReportes_chbox = new System.Windows.Forms.CheckBox();
            this.dtgTipoUsuario = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_ent_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_ent_salir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_salida_cerrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_perdido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_manual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar_usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "TIPO USUARIO:";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.txtTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUsuario.Location = new System.Drawing.Point(149, 41);
            this.txtTipoUsuario.Multiline = true;
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(211, 37);
            this.txtTipoUsuario.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "REGISTRO TIPO USUARIO";
            // 
            // verStatusEntrada_chbox
            // 
            this.verStatusEntrada_chbox.AutoSize = true;
            this.verStatusEntrada_chbox.Location = new System.Drawing.Point(6, 19);
            this.verStatusEntrada_chbox.Name = "verStatusEntrada_chbox";
            this.verStatusEntrada_chbox.Size = new System.Drawing.Size(286, 17);
            this.verStatusEntrada_chbox.TabIndex = 22;
            this.verStatusEntrada_chbox.Text = "VER STATUS PERIFÉRICOS - ESTACION ENTRADA";
            this.verStatusEntrada_chbox.UseVisualStyleBackColor = true;
            // 
            // cerrarEntrada_chbox
            // 
            this.cerrarEntrada_chbox.AutoSize = true;
            this.cerrarEntrada_chbox.Location = new System.Drawing.Point(6, 42);
            this.cerrarEntrada_chbox.Name = "cerrarEntrada_chbox";
            this.cerrarEntrada_chbox.Size = new System.Drawing.Size(255, 17);
            this.cerrarEntrada_chbox.TabIndex = 23;
            this.cerrarEntrada_chbox.Text = "CERRAR APLICACIÓN - ESTACIÓN ENTRADA";
            this.cerrarEntrada_chbox.UseVisualStyleBackColor = true;
            // 
            // tiempoPrecio_chbox
            // 
            this.tiempoPrecio_chbox.AutoSize = true;
            this.tiempoPrecio_chbox.Location = new System.Drawing.Point(6, 134);
            this.tiempoPrecio_chbox.Name = "tiempoPrecio_chbox";
            this.tiempoPrecio_chbox.Size = new System.Drawing.Size(202, 17);
            this.tiempoPrecio_chbox.TabIndex = 24;
            this.tiempoPrecio_chbox.Text = "CONFIGURACIÓN PRECIO X HORA";
            this.tiempoPrecio_chbox.UseVisualStyleBackColor = true;
            // 
            // ticketPerdido_chbox
            // 
            this.ticketPerdido_chbox.AutoSize = true;
            this.ticketPerdido_chbox.Location = new System.Drawing.Point(6, 65);
            this.ticketPerdido_chbox.Name = "ticketPerdido_chbox";
            this.ticketPerdido_chbox.Size = new System.Drawing.Size(286, 17);
            this.ticketPerdido_chbox.TabIndex = 25;
            this.ticketPerdido_chbox.Text = "REGISTRAR TICKET PERDIDO - ESTACIÓN SALIDA";
            this.ticketPerdido_chbox.UseVisualStyleBackColor = true;
            // 
            // ticketManual_chbox
            // 
            this.ticketManual_chbox.AutoSize = true;
            this.ticketManual_chbox.Location = new System.Drawing.Point(6, 88);
            this.ticketManual_chbox.Name = "ticketManual_chbox";
            this.ticketManual_chbox.Size = new System.Drawing.Size(281, 17);
            this.ticketManual_chbox.TabIndex = 26;
            this.ticketManual_chbox.Text = "REGISTRAT TICKET MANUAL - ESTACIÓN SALIDA";
            this.ticketManual_chbox.UseVisualStyleBackColor = true;
            // 
            // cerrarSalida_chbox
            // 
            this.cerrarSalida_chbox.AutoSize = true;
            this.cerrarSalida_chbox.Location = new System.Drawing.Point(6, 111);
            this.cerrarSalida_chbox.Name = "cerrarSalida_chbox";
            this.cerrarSalida_chbox.Size = new System.Drawing.Size(241, 17);
            this.cerrarSalida_chbox.TabIndex = 27;
            this.cerrarSalida_chbox.Text = "CERRAR APLICACIÓN - ESTACIÓN SALIDA";
            this.cerrarSalida_chbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarUsuario_chbox);
            this.groupBox1.Controls.Add(this.generarReportes_chbox);
            this.groupBox1.Controls.Add(this.cerrarSalida_chbox);
            this.groupBox1.Controls.Add(this.ticketManual_chbox);
            this.groupBox1.Controls.Add(this.verStatusEntrada_chbox);
            this.groupBox1.Controls.Add(this.ticketPerdido_chbox);
            this.groupBox1.Controls.Add(this.cerrarEntrada_chbox);
            this.groupBox1.Controls.Add(this.tiempoPrecio_chbox);
            this.groupBox1.Location = new System.Drawing.Point(15, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 204);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERMISOS";
            // 
            // agregarUsuario_chbox
            // 
            this.agregarUsuario_chbox.AutoSize = true;
            this.agregarUsuario_chbox.Location = new System.Drawing.Point(6, 180);
            this.agregarUsuario_chbox.Name = "agregarUsuario_chbox";
            this.agregarUsuario_chbox.Size = new System.Drawing.Size(171, 17);
            this.agregarUsuario_chbox.TabIndex = 29;
            this.agregarUsuario_chbox.Text = "AÑADIR/EDITAR USUARIOS";
            this.agregarUsuario_chbox.UseVisualStyleBackColor = true;
            // 
            // generarReportes_chbox
            // 
            this.generarReportes_chbox.AutoSize = true;
            this.generarReportes_chbox.Location = new System.Drawing.Point(6, 157);
            this.generarReportes_chbox.Name = "generarReportes_chbox";
            this.generarReportes_chbox.Size = new System.Drawing.Size(141, 17);
            this.generarReportes_chbox.TabIndex = 28;
            this.generarReportes_chbox.Text = "GENERAR REPORTES";
            this.generarReportes_chbox.UseVisualStyleBackColor = true;
            // 
            // dtgTipoUsuario
            // 
            this.dtgTipoUsuario.AllowUserToAddRows = false;
            this.dtgTipoUsuario.AllowUserToDeleteRows = false;
            this.dtgTipoUsuario.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipoUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.menu_ent_status,
            this.menu_ent_salir,
            this.tiempo_precio,
            this.menu_salida_cerrar,
            this.ticket_perdido,
            this.ticket_manual,
            this.reportes,
            this.agregar_usuarios});
            this.dtgTipoUsuario.Location = new System.Drawing.Point(15, 310);
            this.dtgTipoUsuario.MultiSelect = false;
            this.dtgTipoUsuario.Name = "dtgTipoUsuario";
            this.dtgTipoUsuario.ReadOnly = true;
            this.dtgTipoUsuario.RowHeadersWidth = 10;
            this.dtgTipoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoUsuario.Size = new System.Drawing.Size(274, 170);
            this.dtgTipoUsuario.TabIndex = 30;
            this.dtgTipoUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipoUsuario_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "DESCRIPCIÓN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // menu_ent_status
            // 
            this.menu_ent_status.HeaderText = "Menu Entrada Status";
            this.menu_ent_status.Name = "menu_ent_status";
            this.menu_ent_status.ReadOnly = true;
            this.menu_ent_status.Visible = false;
            // 
            // menu_ent_salir
            // 
            this.menu_ent_salir.HeaderText = "Menu Entrada Cerrar";
            this.menu_ent_salir.Name = "menu_ent_salir";
            this.menu_ent_salir.ReadOnly = true;
            this.menu_ent_salir.Visible = false;
            // 
            // tiempo_precio
            // 
            this.tiempo_precio.HeaderText = "Tiempo Precio";
            this.tiempo_precio.Name = "tiempo_precio";
            this.tiempo_precio.ReadOnly = true;
            this.tiempo_precio.Visible = false;
            // 
            // menu_salida_cerrar
            // 
            this.menu_salida_cerrar.HeaderText = "Menu Salida Cerrar";
            this.menu_salida_cerrar.Name = "menu_salida_cerrar";
            this.menu_salida_cerrar.ReadOnly = true;
            this.menu_salida_cerrar.Visible = false;
            // 
            // ticket_perdido
            // 
            this.ticket_perdido.HeaderText = "Ticket Perdido";
            this.ticket_perdido.Name = "ticket_perdido";
            this.ticket_perdido.ReadOnly = true;
            this.ticket_perdido.Visible = false;
            // 
            // ticket_manual
            // 
            this.ticket_manual.HeaderText = "Ticket Manual";
            this.ticket_manual.Name = "ticket_manual";
            this.ticket_manual.ReadOnly = true;
            this.ticket_manual.Visible = false;
            // 
            // reportes
            // 
            this.reportes.HeaderText = "Reportes";
            this.reportes.Name = "reportes";
            this.reportes.ReadOnly = true;
            this.reportes.Visible = false;
            // 
            // agregar_usuarios
            // 
            this.agregar_usuarios.HeaderText = "Agregar Usuarios";
            this.agregar_usuarios.Name = "agregar_usuarios";
            this.agregar_usuarios.ReadOnly = true;
            this.agregar_usuarios.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "__________________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 34);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DOBLE CLICK PARA EDITAR";
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
            this.exit_btn.Location = new System.Drawing.Point(295, 423);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 57);
            this.exit_btn.TabIndex = 34;
            this.exit_btn.Text = "SALIR";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Info;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancel_btn.FlatAppearance.BorderSize = 2;
            this.cancel_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.cancel;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel_btn.Location = new System.Drawing.Point(295, 365);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 57);
            this.cancel_btn.TabIndex = 33;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
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
            this.saveSettings_btn.Location = new System.Drawing.Point(295, 307);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(83, 57);
            this.saveSettings_btn.TabIndex = 32;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // RegistroTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(394, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgTipoUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO TIPO USUARIO & PERMISOS";
            this.Load += new System.EventHandler(this.RegistroTipoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox verStatusEntrada_chbox;
        private System.Windows.Forms.CheckBox cerrarEntrada_chbox;
        private System.Windows.Forms.CheckBox tiempoPrecio_chbox;
        private System.Windows.Forms.CheckBox ticketPerdido_chbox;
        private System.Windows.Forms.CheckBox ticketManual_chbox;
        private System.Windows.Forms.CheckBox cerrarSalida_chbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgTipoUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox agregarUsuario_chbox;
        private System.Windows.Forms.CheckBox generarReportes_chbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_ent_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_ent_salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_salida_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_perdido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregar_usuarios;
    }
}