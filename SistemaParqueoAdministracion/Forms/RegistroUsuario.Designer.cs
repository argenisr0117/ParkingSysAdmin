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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoUsuario_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Users_dtg = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.update_panel = new System.Windows.Forms.Panel();
            this.changePass_chbox = new System.Windows.Forms.CheckBox();
            this.claveNuevaUpd_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.confirmarClaveUpd_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.clave_anterior = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.registrar_panel = new System.Windows.Forms.Panel();
            this.Clave_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.confirmarClave_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel4 = new System.Windows.Forms.Panel();
            this.shapeContainer5 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.DatosUser_pn = new System.Windows.Forms.Panel();
            this.Nombre_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.Usuario_txt = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.exit_btn = new System.Windows.Forms.Button();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.inactivate_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.shapeContainer6 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).BeginInit();
            this.panel1.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.registrar_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.DatosUser_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLAVE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "CONFIRMAR CLAVE:";
            // 
            // tipoUsuario_cb
            // 
            this.tipoUsuario_cb.BackColor = System.Drawing.Color.White;
            this.tipoUsuario_cb.DropDownHeight = 80;
            this.tipoUsuario_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuario_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoUsuario_cb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_cb.ForeColor = System.Drawing.Color.Black;
            this.tipoUsuario_cb.FormattingEnabled = true;
            this.tipoUsuario_cb.IntegralHeight = false;
            this.tipoUsuario_cb.Location = new System.Drawing.Point(128, 36);
            this.tipoUsuario_cb.Name = "tipoUsuario_cb";
            this.tipoUsuario_cb.Size = new System.Drawing.Size(198, 21);
            this.tipoUsuario_cb.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
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
            this.Users_dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Users_dtg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Users_dtg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Users_dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Users_dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Users_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Users_dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.nombre,
            this.usuario,
            this.clave,
            this.tipo,
            this.estado});
            this.Users_dtg.EnableHeadersVisualStyles = false;
            this.Users_dtg.GridColor = System.Drawing.Color.LightSteelBlue;
            this.Users_dtg.Location = new System.Drawing.Point(434, 124);
            this.Users_dtg.MultiSelect = false;
            this.Users_dtg.Name = "Users_dtg";
            this.Users_dtg.ReadOnly = true;
            this.Users_dtg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Users_dtg.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Users_dtg.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.Users_dtg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Users_dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_dtg.Size = new System.Drawing.Size(350, 248);
            this.Users_dtg.TabIndex = 159;
            this.Users_dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_dtg_CellDoubleClick);
            // 
            // idusuario
            // 
            this.idusuario.HeaderText = "IDUSUARIO";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Width = 89;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 78;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 78;
            // 
            // clave
            // 
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            this.clave.Width = 63;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "TIPO";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 54;
            // 
            // estado
            // 
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            this.estado.Width = 71;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInactivo);
            this.panel1.Controls.Add(this.rbActivo);
            this.panel1.Location = new System.Drawing.Point(620, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 24);
            this.panel1.TabIndex = 164;
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.rbInactivo.Location = new System.Drawing.Point(79, 4);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(80, 17);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVOS";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.rbActivo.Location = new System.Drawing.Point(4, 4);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(69, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVOS";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
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
            this.update_panel.Controls.Add(this.shapeContainer2);
            this.update_panel.Location = new System.Drawing.Point(9, 242);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(370, 134);
            this.update_panel.TabIndex = 167;
            this.update_panel.Visible = false;
            // 
            // changePass_chbox
            // 
            this.changePass_chbox.AutoSize = true;
            this.changePass_chbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass_chbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.changePass_chbox.Location = new System.Drawing.Point(4, 7);
            this.changePass_chbox.Name = "changePass_chbox";
            this.changePass_chbox.Size = new System.Drawing.Size(108, 17);
            this.changePass_chbox.TabIndex = 174;
            this.changePass_chbox.Text = "CAMBIAR CLAVE";
            this.changePass_chbox.UseVisualStyleBackColor = true;
            this.changePass_chbox.CheckedChanged += new System.EventHandler(this.changePass_chbox_CheckedChanged);
            // 
            // claveNuevaUpd_txt
            // 
            this.claveNuevaUpd_txt.BackColor = System.Drawing.Color.White;
            this.claveNuevaUpd_txt.Enabled = false;
            this.claveNuevaUpd_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveNuevaUpd_txt.Location = new System.Drawing.Point(128, 60);
            this.claveNuevaUpd_txt.Name = "claveNuevaUpd_txt";
            this.claveNuevaUpd_txt.PasswordChar = '*';
            this.claveNuevaUpd_txt.Size = new System.Drawing.Size(198, 22);
            this.claveNuevaUpd_txt.TabIndex = 173;
            this.claveNuevaUpd_txt.Validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label10.Location = new System.Drawing.Point(12, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 172;
            this.label10.Text = "CLAVE NUEVA:";
            // 
            // confirmarClaveUpd_txt
            // 
            this.confirmarClaveUpd_txt.BackColor = System.Drawing.Color.White;
            this.confirmarClaveUpd_txt.Enabled = false;
            this.confirmarClaveUpd_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClaveUpd_txt.Location = new System.Drawing.Point(128, 90);
            this.confirmarClaveUpd_txt.Name = "confirmarClaveUpd_txt";
            this.confirmarClaveUpd_txt.PasswordChar = '*';
            this.confirmarClaveUpd_txt.Size = new System.Drawing.Size(198, 22);
            this.confirmarClaveUpd_txt.TabIndex = 171;
            this.confirmarClaveUpd_txt.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label9.Location = new System.Drawing.Point(12, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 170;
            this.label9.Text = "CONFIRMAR CLAVE:";
            // 
            // clave_anterior
            // 
            this.clave_anterior.BackColor = System.Drawing.Color.White;
            this.clave_anterior.Enabled = false;
            this.clave_anterior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clave_anterior.Location = new System.Drawing.Point(128, 27);
            this.clave_anterior.Name = "clave_anterior";
            this.clave_anterior.PasswordChar = '*';
            this.clave_anterior.Size = new System.Drawing.Size(198, 22);
            this.clave_anterior.TabIndex = 169;
            this.clave_anterior.Validar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 168;
            this.label8.Text = "CLAVE ANTERIOR:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape7});
            this.shapeContainer2.Size = new System.Drawing.Size(370, 134);
            this.shapeContainer2.TabIndex = 175;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape6.X1 = 128;
            this.lineShape6.X2 = 323;
            this.lineShape6.Y1 = 112;
            this.lineShape6.Y2 = 112;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape5.X1 = 128;
            this.lineShape5.X2 = 323;
            this.lineShape5.Y1 = 82;
            this.lineShape5.Y2 = 82;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape7.BorderWidth = 2;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape7.X1 = 129;
            this.lineShape7.X2 = 324;
            this.lineShape7.Y1 = 49;
            this.lineShape7.Y2 = 49;
            // 
            // registrar_panel
            // 
            this.registrar_panel.Controls.Add(this.Clave_txt);
            this.registrar_panel.Controls.Add(this.confirmarClave_txt);
            this.registrar_panel.Controls.Add(this.label4);
            this.registrar_panel.Controls.Add(this.label3);
            this.registrar_panel.Controls.Add(this.shapeContainer3);
            this.registrar_panel.Location = new System.Drawing.Point(9, 241);
            this.registrar_panel.Name = "registrar_panel";
            this.registrar_panel.Size = new System.Drawing.Size(370, 72);
            this.registrar_panel.TabIndex = 168;
            // 
            // Clave_txt
            // 
            this.Clave_txt.BackColor = System.Drawing.Color.White;
            this.Clave_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave_txt.Location = new System.Drawing.Point(128, 7);
            this.Clave_txt.Name = "Clave_txt";
            this.Clave_txt.PasswordChar = '*';
            this.Clave_txt.Size = new System.Drawing.Size(198, 22);
            this.Clave_txt.TabIndex = 29;
            this.Clave_txt.Validar = true;
            // 
            // confirmarClave_txt
            // 
            this.confirmarClave_txt.BackColor = System.Drawing.Color.White;
            this.confirmarClave_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmarClave_txt.Location = new System.Drawing.Point(128, 39);
            this.confirmarClave_txt.Name = "confirmarClave_txt";
            this.confirmarClave_txt.PasswordChar = '*';
            this.confirmarClave_txt.Size = new System.Drawing.Size(198, 22);
            this.confirmarClave_txt.TabIndex = 31;
            this.confirmarClave_txt.Validar = true;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape9});
            this.shapeContainer3.Size = new System.Drawing.Size(370, 72);
            this.shapeContainer3.TabIndex = 32;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape8.BorderWidth = 2;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape8.X1 = 128;
            this.lineShape8.X2 = 323;
            this.lineShape8.Y1 = 61;
            this.lineShape8.Y2 = 61;
            // 
            // lineShape9
            // 
            this.lineShape9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape9.BorderWidth = 2;
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape9.X1 = 128;
            this.lineShape9.X2 = 323;
            this.lineShape9.Y1 = 29;
            this.lineShape9.Y2 = 29;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.update_panel);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.DatosUser_pn);
            this.panel3.Controls.Add(this.Users_dtg);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.exit_btn);
            this.panel3.Controls.Add(this.saveSettings_btn);
            this.panel3.Controls.Add(this.inactivate_btn);
            this.panel3.Controls.Add(this.cancel_btn);
            this.panel3.Controls.Add(this.registrar_panel);
            this.panel3.Controls.Add(this.shapeContainer6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 622);
            this.panel3.TabIndex = 169;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.shapeContainer1);
            this.panel5.Location = new System.Drawing.Point(479, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 57);
            this.panel5.TabIndex = 172;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(32, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "LISTADO DE USUARIOS";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape10});
            this.shapeContainer1.Size = new System.Drawing.Size(300, 57);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape10
            // 
            this.lineShape10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape10.Name = "lineShape1";
            this.lineShape10.X1 = 26;
            this.lineShape10.X2 = 250;
            this.lineShape10.Y1 = 35;
            this.lineShape10.Y2 = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.shapeContainer5);
            this.panel4.Location = new System.Drawing.Point(37, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 57);
            this.panel4.TabIndex = 171;
            // 
            // shapeContainer5
            // 
            this.shapeContainer5.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer5.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer5.Name = "shapeContainer5";
            this.shapeContainer5.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer5.Size = new System.Drawing.Size(317, 57);
            this.shapeContainer5.TabIndex = 25;
            this.shapeContainer5.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 46;
            this.lineShape1.X2 = 270;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // DatosUser_pn
            // 
            this.DatosUser_pn.Controls.Add(this.Nombre_txt);
            this.DatosUser_pn.Controls.Add(this.label6);
            this.DatosUser_pn.Controls.Add(this.label2);
            this.DatosUser_pn.Controls.Add(this.Usuario_txt);
            this.DatosUser_pn.Controls.Add(this.tipoUsuario_cb);
            this.DatosUser_pn.Controls.Add(this.label5);
            this.DatosUser_pn.Controls.Add(this.shapeContainer4);
            this.DatosUser_pn.Location = new System.Drawing.Point(9, 127);
            this.DatosUser_pn.Name = "DatosUser_pn";
            this.DatosUser_pn.Size = new System.Drawing.Size(370, 108);
            this.DatosUser_pn.TabIndex = 170;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.BackColor = System.Drawing.Color.White;
            this.Nombre_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_txt.Location = new System.Drawing.Point(128, 3);
            this.Nombre_txt.Multiline = true;
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(198, 20);
            this.Nombre_txt.TabIndex = 25;
            this.Nombre_txt.Validar = true;
            // 
            // Usuario_txt
            // 
            this.Usuario_txt.BackColor = System.Drawing.Color.White;
            this.Usuario_txt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_txt.Location = new System.Drawing.Point(128, 68);
            this.Usuario_txt.Multiline = true;
            this.Usuario_txt.Name = "Usuario_txt";
            this.Usuario_txt.Size = new System.Drawing.Size(198, 20);
            this.Usuario_txt.TabIndex = 27;
            this.Usuario_txt.Validar = true;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape4,
            this.lineShape3});
            this.shapeContainer4.Size = new System.Drawing.Size(370, 108);
            this.shapeContainer4.TabIndex = 159;
            this.shapeContainer4.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape2.X1 = 129;
            this.lineShape2.X2 = 324;
            this.lineShape2.Y1 = 88;
            this.lineShape2.Y2 = 88;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape4.X1 = 128;
            this.lineShape4.X2 = 323;
            this.lineShape4.Y1 = 58;
            this.lineShape4.Y2 = 58;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape3.X1 = 129;
            this.lineShape3.X2 = 324;
            this.lineShape3.Y1 = 23;
            this.lineShape3.Y2 = 23;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exit_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.close;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_btn.Location = new System.Drawing.Point(793, 18);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 30);
            this.exit_btn.TabIndex = 162;
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // saveSettings_btn
            // 
            this.saveSettings_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveSettings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveSettings_btn.FlatAppearance.BorderSize = 2;
            this.saveSettings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.saveSettings_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.save1;
            this.saveSettings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveSettings_btn.Location = new System.Drawing.Point(65, 421);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(112, 40);
            this.saveSettings_btn.TabIndex = 160;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
            // 
            // inactivate_btn
            // 
            this.inactivate_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inactivate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.inactivate_btn.FlatAppearance.BorderSize = 2;
            this.inactivate_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.inactivate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inactivate_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactivate_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.inactivate_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.loop;
            this.inactivate_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inactivate_btn.Location = new System.Drawing.Point(560, 421);
            this.inactivate_btn.Name = "inactivate_btn";
            this.inactivate_btn.Size = new System.Drawing.Size(112, 40);
            this.inactivate_btn.TabIndex = 163;
            this.inactivate_btn.Text = "INACTIVAR";
            this.inactivate_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inactivate_btn.UseVisualStyleBackColor = false;
            this.inactivate_btn.Click += new System.EventHandler(this.inactivate_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancel_btn.FlatAppearance.BorderSize = 2;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cancel_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.signal;
            this.cancel_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_btn.Location = new System.Drawing.Point(183, 421);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 40);
            this.cancel_btn.TabIndex = 161;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // shapeContainer6
            // 
            this.shapeContainer6.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer6.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer6.Name = "shapeContainer6";
            this.shapeContainer6.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape11});
            this.shapeContainer6.Size = new System.Drawing.Size(841, 620);
            this.shapeContainer6.TabIndex = 173;
            this.shapeContainer6.TabStop = false;
            // 
            // lineShape11
            // 
            this.lineShape11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 409;
            this.lineShape11.X2 = 409;
            this.lineShape11.Y1 = 1;
            this.lineShape11.Y2 = 620;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Users_dtg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.registrar_panel.ResumeLayout(false);
            this.registrar_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.DatosUser_pn.ResumeLayout(false);
            this.DatosUser_pn.PerformLayout();
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
        private System.Windows.Forms.Panel update_panel;
        private Controles.textbox claveNuevaUpd_txt;
        private System.Windows.Forms.Label label10;
        private Controles.textbox confirmarClaveUpd_txt;
        private System.Windows.Forms.Label label9;
        private Controles.textbox clave_anterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox changePass_chbox;
        private System.Windows.Forms.Panel registrar_panel;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private System.Windows.Forms.Panel DatosUser_pn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}