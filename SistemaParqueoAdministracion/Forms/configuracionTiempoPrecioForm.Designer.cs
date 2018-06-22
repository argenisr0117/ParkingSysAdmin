namespace SistemaParqueoAdministracion.Forms
{
    partial class configuracionTiempoPrecioForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosUser_pn = new System.Windows.Forms.Panel();
            this.txtPrecio = new SistemaParqueoAdministracion.Controles.textboxN(this.components);
            this.txtTiempo = new SistemaParqueoAdministracion.Controles.textboxN(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.saveSettings_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.dtgTiempoPrecio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer5 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DatosUser_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoPrecio)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DatosUser_pn);
            this.panel1.Controls.Add(this.saveSettings_btn);
            this.panel1.Controls.Add(this.cancel_btn);
            this.panel1.Controls.Add(this.dtgTiempoPrecio);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 622);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(487, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 26);
            this.label3.TabIndex = 182;
            this.label3.Text = "                DOBLE CLICK EN REGISTRO \r\nPARA EDITAR PERMISOS DE TIPO DE USUARIO" +
    ".";
            // 
            // DatosUser_pn
            // 
            this.DatosUser_pn.Controls.Add(this.txtPrecio);
            this.DatosUser_pn.Controls.Add(this.txtTiempo);
            this.DatosUser_pn.Controls.Add(this.label6);
            this.DatosUser_pn.Controls.Add(this.label5);
            this.DatosUser_pn.Controls.Add(this.cbPosicion);
            this.DatosUser_pn.Controls.Add(this.label7);
            this.DatosUser_pn.Controls.Add(this.shapeContainer4);
            this.DatosUser_pn.Location = new System.Drawing.Point(25, 141);
            this.DatosUser_pn.Name = "DatosUser_pn";
            this.DatosUser_pn.Size = new System.Drawing.Size(370, 113);
            this.DatosUser_pn.TabIndex = 181;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(129, 66);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(196, 22);
            this.txtPrecio.TabIndex = 161;
            this.txtPrecio.Valor = SistemaParqueoAdministracion.Controles.textboxN.Tipo.Números;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(128, 36);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(196, 22);
            this.txtTiempo.TabIndex = 160;
            this.txtTiempo.Valor = SistemaParqueoAdministracion.Controles.textboxN.Tipo.Números;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "POSICIÓN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "PRECIO:";
            // 
            // cbPosicion
            // 
            this.cbPosicion.BackColor = System.Drawing.Color.White;
            this.cbPosicion.DropDownHeight = 80;
            this.cbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPosicion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosicion.ForeColor = System.Drawing.Color.Black;
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.IntegralHeight = false;
            this.cbPosicion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPosicion.Location = new System.Drawing.Point(129, 3);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(198, 21);
            this.cbPosicion.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 158;
            this.label7.Text = "TIEMPO (MIN):";
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
            this.shapeContainer4.Size = new System.Drawing.Size(370, 113);
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
            this.lineShape3.Y1 = 26;
            this.lineShape3.Y2 = 26;
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
            this.saveSettings_btn.Location = new System.Drawing.Point(56, 338);
            this.saveSettings_btn.Name = "saveSettings_btn";
            this.saveSettings_btn.Size = new System.Drawing.Size(112, 51);
            this.saveSettings_btn.TabIndex = 179;
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
            this.cancel_btn.Location = new System.Drawing.Point(231, 338);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(112, 51);
            this.cancel_btn.TabIndex = 180;
            this.cancel_btn.Text = "CANCELAR";
            this.cancel_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // dtgTiempoPrecio
            // 
            this.dtgTiempoPrecio.AllowUserToAddRows = false;
            this.dtgTiempoPrecio.AllowUserToDeleteRows = false;
            this.dtgTiempoPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTiempoPrecio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTiempoPrecio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgTiempoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTiempoPrecio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTiempoPrecio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTiempoPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nombre,
            this.reportes,
            this.agregar_usuario});
            this.dtgTiempoPrecio.EnableHeadersVisualStyles = false;
            this.dtgTiempoPrecio.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dtgTiempoPrecio.Location = new System.Drawing.Point(458, 141);
            this.dtgTiempoPrecio.MultiSelect = false;
            this.dtgTiempoPrecio.Name = "dtgTiempoPrecio";
            this.dtgTiempoPrecio.ReadOnly = true;
            this.dtgTiempoPrecio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTiempoPrecio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTiempoPrecio.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.dtgTiempoPrecio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgTiempoPrecio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTiempoPrecio.Size = new System.Drawing.Size(311, 248);
            this.dtgTiempoPrecio.TabIndex = 177;
            this.dtgTiempoPrecio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTiempoPrecio_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 150F;
            this.nombre.HeaderText = "POSICIÓN";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // reportes
            // 
            this.reportes.HeaderText = "TIEMPO(MIN)";
            this.reportes.Name = "reportes";
            this.reportes.ReadOnly = true;
            // 
            // agregar_usuario
            // 
            this.agregar_usuario.HeaderText = "PRECIO";
            this.agregar_usuario.Name = "agregar_usuario";
            this.agregar_usuario.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.shapeContainer5);
            this.panel4.Location = new System.Drawing.Point(231, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 57);
            this.panel4.TabIndex = 173;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONFIGURACIÓN PRECIO/TIEMPO";
            // 
            // shapeContainer5
            // 
            this.shapeContainer5.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer5.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer5.Name = "shapeContainer5";
            this.shapeContainer5.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer5.Size = new System.Drawing.Size(331, 57);
            this.shapeContainer5.TabIndex = 25;
            this.shapeContainer5.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 12;
            this.lineShape1.X2 = 310;
            this.lineShape1.Y1 = 41;
            this.lineShape1.Y2 = 41;
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
            this.exit_btn.TabIndex = 164;
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // configuracionTiempoPrecioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 622);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "configuracionTiempoPrecioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACIÓN DE TIEMPO-PRECIO";
            this.Load += new System.EventHandler(this.configuracionTiempoPrecioForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DatosUser_pn.ResumeLayout(false);
            this.DatosUser_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiempoPrecio)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView dtgTiempoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregar_usuario;
        private System.Windows.Forms.Button saveSettings_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Panel DatosUser_pn;
        private Controles.textboxN txtPrecio;
        private Controles.textboxN txtTiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label3;
    }
}