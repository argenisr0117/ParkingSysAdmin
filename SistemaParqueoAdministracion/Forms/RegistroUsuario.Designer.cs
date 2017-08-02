namespace SistemaParqueoAdministracion.Forms
{
    partial class RegistroUsuario
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoUsuario_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Users_dtg = new System.Windows.Forms.DataGridView();
            this.inactivate_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.update_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.changePass_chbox = new System.Windows.Forms.CheckBox();
            this.registrar_panel = new System.Windows.Forms.Panel();
            this.claveNuevaUpd_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.confirmarClaveUpd_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.clave_anterior = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.Clave_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.confirmarClave_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.Usuario_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.Nombre_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.registrar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLAVE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "CONFIRMAR CLAVE:";
            // 
            // tipoUsuario_cb
            // 
            this.tipoUsuario_cb.BackColor = System.Drawing.SystemColors.Info;
            this.tipoUsuario_cb.DropDownHeight = 80;
            this.tipoUsuario_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuario_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_cb.ForeColor = System.Drawing.Color.Black;
            this.tipoUsuario_cb.FormattingEnabled = true;
            this.tipoUsuario_cb.IntegralHeight = false;
            this.tipoUsuario_cb.Location = new System.Drawing.Point(167, 105);
            this.tipoUsuario_cb.Name = "tipoUsuario_cb";
            this.tipoUsuario_cb.Size = new System.Drawing.Size(198, 24);
            this.tipoUsuario_cb.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 158;
            this.label5.Text = "TIPO USUARIO:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Users_dtg
            // 
            this.Users_dtg.AllowUserToAddRows = false;
            this.Users_dtg.AllowUserToDeleteRows = false;
            this.Users_dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.usuario,
            this.clave,
            this.tipo,
            this.estado});
            this.Users_dtg.Location = new System.Drawing.Point(397, 68);
            this.Users_dtg.MultiSelect = false;
            this.Users_dtg.Name = "Users_dtg";
            this.Users_dtg.ReadOnly = true;
            this.Users_dtg.RowHeadersWidth = 10;
            this.Users_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_dtg.Size = new System.Drawing.Size(360, 172);
            this.Users_dtg.TabIndex = 159;
            this.Users_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dtg_CellDoubleClick);
            // 
            // inactivate_btn
            // 
            this.inactivate_btn.BackColor = System.Drawing.SystemColors.Info;
            this.inactivate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inactivate_btn.FlatAppearance.BorderSize = 2;
            this.inactivate_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.inactivate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactivate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivate_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.refresh;
            this.inactivate_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inactivate_btn.Location = new System.Drawing.Point(308, 312);
            this.inactivate_btn.Name = "inactivate_btn";
            this.inactivate_btn.Size = new System.Drawing.Size(83, 57);
            this.inactivate_btn.TabIndex = 163;
            this.inactivate_btn.Text = "INACTIVAR";
            this.inactivate_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inactivate_btn.UseVisualStyleBackColor = false;
            this.inactivate_btn.Click += new System.EventHandler(this.inactivate_btn_Click);
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
            this.exit_btn.Location = new System.Drawing.Point(486, 312);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 57);
            this.exit_btn.TabIndex = 162;
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
            this.cancel_btn.Location = new System.Drawing.Point(397, 312);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(83, 57);
            this.cancel_btn.TabIndex = 161;
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
            this.saveSettings_btn.Location = new System.Drawing.Point(219, 312);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(83, 57);
            this.saveSettings_btn.TabIndex = 160;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbInactivo);
            this.panel1.Controls.Add(this.rbActivo);
            this.panel1.Location = new System.Drawing.Point(662, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 50);
            this.panel1.TabIndex = 164;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(3, 27);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(68, 17);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivos";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(4, 4);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(60, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activos";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 34);
            this.panel2.TabIndex = 165;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(272, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "DOBLE CLICK A REGISTRO PARA EDITAR";
            // 
            // update_panel
            // 
            this.update_panel.Controls.Add(this.changePass_chbox);
            this.update_panel.Controls.Add(this.claveNuevaUpd_txt);
            this.update_panel.Controls.Add(this.label10);
            this.update_panel.Controls.Add(this.confirmarClaveUpd_txt);
            this.update_panel.Controls.Add(this.label9);
            this.update_panel.Controls.Add(this.clave_anterior);
            this.update_panel.Controls.Add(this.label8);
            this.update_panel.Location = new System.Drawing.Point(3, 172);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(376, 134);
            this.update_panel.TabIndex = 167;
            this.update_panel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 168;
            this.label8.Text = "CLAVE ANTERIOR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 170;
            this.label9.Text = "CONFIRMAR CLAVE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 172;
            this.label10.Text = "CLAVE NUEVA:";
            // 
            // changePass_chbox
            // 
            this.changePass_chbox.AutoSize = true;
            this.changePass_chbox.Location = new System.Drawing.Point(4, 7);
            this.changePass_chbox.Name = "changePass_chbox";
            this.changePass_chbox.Size = new System.Drawing.Size(94, 17);
            this.changePass_chbox.TabIndex = 174;
            this.changePass_chbox.Text = "Cambiar Clave";
            this.changePass_chbox.UseVisualStyleBackColor = true;
            this.changePass_chbox.CheckedChanged += new System.EventHandler(this.changePass_chbox_CheckedChanged);
            // 
            // registrar_panel
            // 
            this.registrar_panel.Controls.Add(this.Clave_txt);
            this.registrar_panel.Controls.Add(this.confirmarClave_txt);
            this.registrar_panel.Controls.Add(this.label4);
            this.registrar_panel.Controls.Add(this.label3);
            this.registrar_panel.Location = new System.Drawing.Point(0, 175);
            this.registrar_panel.Name = "registrar_panel";
            this.registrar_panel.Size = new System.Drawing.Size(365, 86);
            this.registrar_panel.TabIndex = 168;
            // 
            // claveNuevaUpd_txt
            // 
            this.claveNuevaUpd_txt.BackColor = System.Drawing.SystemColors.Info;
            this.claveNuevaUpd_txt.Enabled = false;
            this.claveNuevaUpd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveNuevaUpd_txt.Location = new System.Drawing.Point(162, 74);
            this.claveNuevaUpd_txt.Name = "claveNuevaUpd_txt";
            this.claveNuevaUpd_txt.PasswordChar = '*';
            this.claveNuevaUpd_txt.Size = new System.Drawing.Size(198, 21);
            this.claveNuevaUpd_txt.TabIndex = 173;
            this.claveNuevaUpd_txt.Validar = true;
            // 
            // confirmarClaveUpd_txt
            // 
            this.confirmarClaveUpd_txt.BackColor = System.Drawing.SystemColors.Info;
            this.confirmarClaveUpd_txt.Enabled = false;
            this.confirmarClaveUpd_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClaveUpd_txt.Location = new System.Drawing.Point(162, 104);
            this.confirmarClaveUpd_txt.Name = "confirmarClaveUpd_txt";
            this.confirmarClaveUpd_txt.PasswordChar = '*';
            this.confirmarClaveUpd_txt.Size = new System.Drawing.Size(198, 21);
            this.confirmarClaveUpd_txt.TabIndex = 171;
            this.confirmarClaveUpd_txt.Validar = true;
            // 
            // clave_anterior
            // 
            this.clave_anterior.BackColor = System.Drawing.SystemColors.Info;
            this.clave_anterior.Enabled = false;
            this.clave_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_anterior.Location = new System.Drawing.Point(162, 40);
            this.clave_anterior.Name = "clave_anterior";
            this.clave_anterior.PasswordChar = '*';
            this.clave_anterior.Size = new System.Drawing.Size(198, 21);
            this.clave_anterior.TabIndex = 169;
            this.clave_anterior.Validar = true;
            // 
            // Clave_txt
            // 
            this.Clave_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Clave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave_txt.Location = new System.Drawing.Point(167, 5);
            this.Clave_txt.Name = "Clave_txt";
            this.Clave_txt.PasswordChar = '*';
            this.Clave_txt.Size = new System.Drawing.Size(198, 21);
            this.Clave_txt.TabIndex = 29;
            this.Clave_txt.Validar = true;
            // 
            // confirmarClave_txt
            // 
            this.confirmarClave_txt.BackColor = System.Drawing.SystemColors.Info;
            this.confirmarClave_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave_txt.Location = new System.Drawing.Point(167, 46);
            this.confirmarClave_txt.Name = "confirmarClave_txt";
            this.confirmarClave_txt.PasswordChar = '*';
            this.confirmarClave_txt.Size = new System.Drawing.Size(198, 21);
            this.confirmarClave_txt.TabIndex = 31;
            this.confirmarClave_txt.Validar = true;
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Usuario_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(167, 135);
            this.Usuario_txt.Multiline = true;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(198, 31);
            this.Usuario_txt.TabIndex = 27;
            this.Usuario_txt.Validar = true;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.BackColor = System.Drawing.SystemColors.Info;
            this.Nombre_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_txt.Location = new System.Drawing.Point(167, 68);
            this.Nombre_txt.Multiline = true;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(198, 31);
            this.Nombre_txt.TabIndex = 25;
            this.Nombre_txt.Validar = true;
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "IDUSUARIO";
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
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.update_panel);
            this.Controls.Add(this.registrar_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inactivate_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.saveSettings_btn);
            this.Controls.Add(this.Users_dtg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipoUsuario_cb);
            this.Controls.Add(this.Usuario_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.registrar_panel.ResumeLayout(false);
            this.registrar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Controles.textbox Nombre_txt;
        private Controles.textbox Usuario_txt;
        private System.Windows.Forms.Label label2;
        private Controles.textbox Clave_txt;
        private System.Windows.Forms.Label label3;
        private Controles.textbox confirmarClave_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoUsuario_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView Users_dtg;
        private System.Windows.Forms.Button inactivate_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel update_panel;
        private Controles.textbox claveNuevaUpd_txt;
        private System.Windows.Forms.Label label10;
        private Controles.textbox confirmarClaveUpd_txt;
        private System.Windows.Forms.Label label9;
        private Controles.textbox clave_anterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox changePass_chbox;
        private System.Windows.Forms.Panel registrar_panel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}