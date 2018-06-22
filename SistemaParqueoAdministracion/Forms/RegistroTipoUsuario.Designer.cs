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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.verStatusEntrada_chbox = new System.Windows.Forms.CheckBox();
            this.cerrarEntrada_chbox = new System.Windows.Forms.CheckBox();
            this.tiempoPrecio_chbox = new System.Windows.Forms.CheckBox();
            this.ticketPerdido_chbox = new System.Windows.Forms.CheckBox();
            this.ticketManual_chbox = new System.Windows.Forms.CheckBox();
            this.cerrarSalida_chbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarUsuario_chbox = new System.Windows.Forms.CheckBox();
            this.generarReportes_chbox = new System.Windows.Forms.CheckBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dtgTipoUsuario = new System.Windows.Forms.DataGridView();
            this.DatosUser_pn = new System.Windows.Forms.Panel();
            this.txtTipoUsuario = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer5 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoUsuario)).BeginInit();
            this.DatosUser_pn.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // verStatusEntrada_chbox
            // 
            this.verStatusEntrada_chbox.AutoSize = true;
            this.verStatusEntrada_chbox.Location = new System.Drawing.Point(6, 19);
            this.verStatusEntrada_chbox.Name = "verStatusEntrada_chbox";
            this.verStatusEntrada_chbox.Size = new System.Drawing.Size(264, 17);
            this.verStatusEntrada_chbox.TabIndex = 22;
            this.verStatusEntrada_chbox.Text = "VER STATUS PERIFÉRICOS - ESTACION ENTRADA";
            this.verStatusEntrada_chbox.UseVisualStyleBackColor = true;
            // 
            // cerrarEntrada_chbox
            // 
            this.cerrarEntrada_chbox.AutoSize = true;
            this.cerrarEntrada_chbox.Location = new System.Drawing.Point(6, 42);
            this.cerrarEntrada_chbox.Name = "cerrarEntrada_chbox";
            this.cerrarEntrada_chbox.Size = new System.Drawing.Size(243, 17);
            this.cerrarEntrada_chbox.TabIndex = 23;
            this.cerrarEntrada_chbox.Text = "CERRAR APLICACIÓN - ESTACIÓN ENTRADA";
            this.cerrarEntrada_chbox.UseVisualStyleBackColor = true;
            // 
            // tiempoPrecio_chbox
            // 
            this.tiempoPrecio_chbox.AutoSize = true;
            this.tiempoPrecio_chbox.Location = new System.Drawing.Point(6, 134);
            this.tiempoPrecio_chbox.Name = "tiempoPrecio_chbox";
            this.tiempoPrecio_chbox.Size = new System.Drawing.Size(200, 17);
            this.tiempoPrecio_chbox.TabIndex = 24;
            this.tiempoPrecio_chbox.Text = "CONFIGURACIÓN PRECIO X HORA";
            this.tiempoPrecio_chbox.UseVisualStyleBackColor = true;
            // 
            // ticketPerdido_chbox
            // 
            this.ticketPerdido_chbox.AutoSize = true;
            this.ticketPerdido_chbox.Location = new System.Drawing.Point(6, 65);
            this.ticketPerdido_chbox.Name = "ticketPerdido_chbox";
            this.ticketPerdido_chbox.Size = new System.Drawing.Size(266, 17);
            this.ticketPerdido_chbox.TabIndex = 25;
            this.ticketPerdido_chbox.Text = "REGISTRAR TICKET PERDIDO - ESTACIÓN SALIDA";
            this.ticketPerdido_chbox.UseVisualStyleBackColor = true;
            // 
            // ticketManual_chbox
            // 
            this.ticketManual_chbox.AutoSize = true;
            this.ticketManual_chbox.Location = new System.Drawing.Point(6, 88);
            this.ticketManual_chbox.Name = "ticketManual_chbox";
            this.ticketManual_chbox.Size = new System.Drawing.Size(261, 17);
            this.ticketManual_chbox.TabIndex = 26;
            this.ticketManual_chbox.Text = "REGISTRAT TICKET MANUAL - ESTACIÓN SALIDA";
            this.ticketManual_chbox.UseVisualStyleBackColor = true;
            // 
            // cerrarSalida_chbox
            // 
            this.cerrarSalida_chbox.AutoSize = true;
            this.cerrarSalida_chbox.Location = new System.Drawing.Point(6, 111);
            this.cerrarSalida_chbox.Name = "cerrarSalida_chbox";
            this.cerrarSalida_chbox.Size = new System.Drawing.Size(231, 17);
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
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.groupBox1.Location = new System.Drawing.Point(28, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 204);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERMISOS";
            // 
            // agregarUsuario_chbox
            // 
            this.agregarUsuario_chbox.AutoSize = true;
            this.agregarUsuario_chbox.Location = new System.Drawing.Point(6, 180);
            this.agregarUsuario_chbox.Name = "agregarUsuario_chbox";
            this.agregarUsuario_chbox.Size = new System.Drawing.Size(162, 17);
            this.agregarUsuario_chbox.TabIndex = 29;
            this.agregarUsuario_chbox.Text = "AÑADIR/EDITAR USUARIOS";
            this.agregarUsuario_chbox.UseVisualStyleBackColor = true;
            // 
            // generarReportes_chbox
            // 
            this.generarReportes_chbox.AutoSize = true;
            this.generarReportes_chbox.Location = new System.Drawing.Point(6, 157);
            this.generarReportes_chbox.Name = "generarReportes_chbox";
            this.generarReportes_chbox.Size = new System.Drawing.Size(130, 17);
            this.generarReportes_chbox.TabIndex = 28;
            this.generarReportes_chbox.Text = "GENERAR REPORTES";
            this.generarReportes_chbox.UseVisualStyleBackColor = true;
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
            this.exit_btn.Location = new System.Drawing.Point(795, 18);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 30);
            this.exit_btn.TabIndex = 163;
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.saveSettings_btn);
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Controls.Add(this.dtgTipoUsuario);
            this.panel2.Controls.Add(this.DatosUser_pn);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 622);
            this.panel2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(487, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 26);
            this.label3.TabIndex = 179;
            this.label3.Text = "                DOBLE CLICK EN REGISTRO \r\nPARA EDITAR PERMISOS DE TIPO DE USUARIO" +
    ".";
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
            this.saveSettings_btn.Location = new System.Drawing.Point(57, 438);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(112, 51);
            this.saveSettings_btn.TabIndex = 177;
            this.saveSettings_btn.Text = "GUARDAR";
            this.saveSettings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveSettings_btn.UseVisualStyleBackColor = false;
            this.saveSettings_btn.Click += new System.EventHandler(this.saveSettings_btn_Click);
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
            this.cancel_btn.Location = new System.Drawing.Point(231, 438);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 51);
            this.cancel_btn.TabIndex = 178;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // dtgTipoUsuario
            // 
            this.dtgTipoUsuario.AllowUserToAddRows = false;
            this.dtgTipoUsuario.AllowUserToDeleteRows = false;
            this.dtgTipoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTipoUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTipoUsuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTipoUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipoUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTipoUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.usuario,
            this.clave,
            this.tipo,
            this.estado,
            this.ticket_p,
            this.ticket_m,
            this.reportes,
            this.agregar_usuario});
            this.dtgTipoUsuario.EnableHeadersVisualStyles = false;
            this.dtgTipoUsuario.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dtgTipoUsuario.Location = new System.Drawing.Point(450, 111);
            this.dtgTipoUsuario.MultiSelect = false;
            this.dtgTipoUsuario.Name = "dtgTipoUsuario";
            this.dtgTipoUsuario.ReadOnly = true;
            this.dtgTipoUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipoUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTipoUsuario.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.dtgTipoUsuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTipoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoUsuario.Size = new System.Drawing.Size(311, 248);
            this.dtgTipoUsuario.TabIndex = 176;
            this.dtgTipoUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipoUsuario_CellDoubleClick);
            // 
            // DatosUser_pn
            // 
            this.DatosUser_pn.Controls.Add(this.txtTipoUsuario);
            this.DatosUser_pn.Controls.Add(this.label2);
            this.DatosUser_pn.Controls.Add(this.shapeContainer4);
            this.DatosUser_pn.Location = new System.Drawing.Point(28, 111);
            this.DatosUser_pn.Name = "DatosUser_pn";
            this.DatosUser_pn.Size = new System.Drawing.Size(370, 37);
            this.DatosUser_pn.TabIndex = 175;
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.BackColor = System.Drawing.Color.White;
            this.txtTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUsuario.Location = new System.Drawing.Point(128, 3);
            this.txtTipoUsuario.Multiline = true;
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtTipoUsuario.TabIndex = 25;
            this.txtTipoUsuario.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "TIPO USUARIO:";
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer4.Size = new System.Drawing.Size(370, 37);
            this.shapeContainer4.TabIndex = 159;
            this.shapeContainer4.TabStop = false;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.shapeContainer1);
            this.panel5.Location = new System.Drawing.Point(461, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 57);
            this.panel5.TabIndex = 173;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(26, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "LISTADO DE TIPO USUARIO";
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
            this.lineShape10.X1 = 34;
            this.lineShape10.X2 = 266;
            this.lineShape10.Y1 = 35;
            this.lineShape10.Y2 = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.shapeContainer5);
            this.panel4.Location = new System.Drawing.Point(35, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 57);
            this.panel4.TabIndex = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "REGISTRO DE TIPO USUARIO";
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
            this.lineShape1.X1 = 33;
            this.lineShape1.X2 = 282;
            this.lineShape1.Y1 = 35;
            this.lineShape1.Y2 = 35;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape11});
            this.shapeContainer2.Size = new System.Drawing.Size(843, 622);
            this.shapeContainer2.TabIndex = 174;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape11
            // 
            this.lineShape11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 421;
            this.lineShape11.X2 = 421;
            this.lineShape11.Y1 = 2;
            this.lineShape11.Y2 = 621;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "DESCRIPCIÓN";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Menu Entrada Status";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // clave
            // 
            this.clave.HeaderText = "Menu Entrada Cerrar";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tiempo Precio";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Menu Salida Cerrar";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            // 
            // ticket_p
            // 
            this.ticket_p.HeaderText = "Ticket Perdido";
            this.ticket_p.Name = "ticket_p";
            this.ticket_p.ReadOnly = true;
            this.ticket_p.Visible = false;
            // 
            // ticket_m
            // 
            this.ticket_m.HeaderText = "Ticket Manual";
            this.ticket_m.Name = "ticket_m";
            this.ticket_m.ReadOnly = true;
            this.ticket_m.Visible = false;
            // 
            // reportes
            // 
            this.reportes.HeaderText = "Reportes";
            this.reportes.Name = "reportes";
            this.reportes.ReadOnly = true;
            this.reportes.Visible = false;
            // 
            // agregar_usuario
            // 
            this.agregar_usuario.HeaderText = "Agregar Usuarios";
            this.agregar_usuario.Name = "agregar_usuario";
            this.agregar_usuario.ReadOnly = true;
            this.agregar_usuario.Visible = false;
            // 
            // RegistroTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RegistroTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO TIPO USUARIO & PERMISOS";
            this.Load += new System.EventHandler(this.RegistroTipoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoUsuario)).EndInit();
            this.DatosUser_pn.ResumeLayout(false);
            this.DatosUser_pn.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox verStatusEntrada_chbox;
        private System.Windows.Forms.CheckBox cerrarEntrada_chbox;
        private System.Windows.Forms.CheckBox tiempoPrecio_chbox;
        private System.Windows.Forms.CheckBox ticketPerdido_chbox;
        private System.Windows.Forms.CheckBox ticketManual_chbox;
        private System.Windows.Forms.CheckBox cerrarSalida_chbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox agregarUsuario_chbox;
        private System.Windows.Forms.CheckBox generarReportes_chbox;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private System.Windows.Forms.Panel DatosUser_pn;
        private Controles.textbox txtTipoUsuario;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.DataGridView dtgTipoUsuario;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregar_usuario;
    }
}