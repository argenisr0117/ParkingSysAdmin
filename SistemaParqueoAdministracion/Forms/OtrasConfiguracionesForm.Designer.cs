namespace SistemaParqueoAdministracion.Forms
{
    partial class OtrasConfiguracionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtrasConfiguracionesForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promo_txt = new System.Windows.Forms.TextBox();
            this.guardarConfig_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.precioTicket_txt = new SistemaParqueoAdministracion.Controles.textboxN(this.components);
            this.txt_MontoVal = new SistemaParqueoAdministracion.Controles.textboxN(this.components);
            this.txt_NombreEmpresa = new SistemaParqueoAdministracion.Controles.textbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.chb_Estado = new System.Windows.Forms.CheckBox();
            this.btn_GuardarValidacion = new System.Windows.Forms.Button();
            this.dtg_Validaciones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Validaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 46);
            this.panel1.TabIndex = 39;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(183, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONFIGURACIONES";
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.exit_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.close;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit_btn.Location = new System.Drawing.Point(484, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(36, 30);
            this.exit_btn.TabIndex = 165;
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 367);
            this.tabControl1.TabIndex = 181;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.promo_txt);
            this.tabPage1.Controls.Add(this.guardarConfig_btn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.precioTicket_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROMO/TICKET PERDIDO";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.dtg_Validaciones);
            this.tabPage2.Controls.Add(this.btn_GuardarValidacion);
            this.tabPage2.Controls.Add(this.chb_Estado);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_NombreEmpresa);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_MontoVal);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VALIDACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRECIO TICKET PERDIDO($RD):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROMOCIÓN TICKET:";
            this.toolTip1.SetToolTip(this.label2, "ESTE MENSAJE SERA VISIBLE EN LA PARTE INFERIOR DE LOS TICKETS ");
            // 
            // promo_txt
            // 
            this.promo_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promo_txt.Location = new System.Drawing.Point(209, 92);
            this.promo_txt.Multiline = true;
            this.promo_txt.Name = "promo_txt";
            this.promo_txt.Size = new System.Drawing.Size(252, 77);
            this.promo_txt.TabIndex = 5;
            this.promo_txt.TextChanged += new System.EventHandler(this.promo_txt_TextChanged);
            // 
            // guardarConfig_btn
            // 
            this.guardarConfig_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guardarConfig_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.guardarConfig_btn.FlatAppearance.BorderSize = 2;
            this.guardarConfig_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarConfig_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarConfig_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.guardarConfig_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.save1;
            this.guardarConfig_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarConfig_btn.Location = new System.Drawing.Point(196, 231);
            this.guardarConfig_btn.Name = "guardarConfig_btn";
            this.guardarConfig_btn.Size = new System.Drawing.Size(112, 51);
            this.guardarConfig_btn.TabIndex = 180;
            this.guardarConfig_btn.Text = "GUARDAR";
            this.guardarConfig_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarConfig_btn.UseVisualStyleBackColor = false;
            this.guardarConfig_btn.Click += new System.EventHandler(this.guardarConfig_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOBRE EMPRESA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label5.Location = new System.Drawing.Point(8, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MONTO ($RD):";
            // 
            // precioTicket_txt
            // 
            this.precioTicket_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTicket_txt.Location = new System.Drawing.Point(209, 45);
            this.precioTicket_txt.Name = "precioTicket_txt";
            this.precioTicket_txt.Size = new System.Drawing.Size(124, 23);
            this.precioTicket_txt.TabIndex = 6;
            this.precioTicket_txt.Valor = SistemaParqueoAdministracion.Controles.textboxN.Tipo.Números;
            // 
            // txt_MontoVal
            // 
            this.txt_MontoVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MontoVal.Location = new System.Drawing.Point(115, 43);
            this.txt_MontoVal.MaxLength = 5;
            this.txt_MontoVal.Name = "txt_MontoVal";
            this.txt_MontoVal.Size = new System.Drawing.Size(265, 23);
            this.txt_MontoVal.TabIndex = 1;
            this.txt_MontoVal.Valor = SistemaParqueoAdministracion.Controles.textboxN.Tipo.Números;
            // 
            // txt_NombreEmpresa
            // 
            this.txt_NombreEmpresa.Location = new System.Drawing.Point(115, 15);
            this.txt_NombreEmpresa.MaxLength = 100;
            this.txt_NombreEmpresa.Name = "txt_NombreEmpresa";
            this.txt_NombreEmpresa.Size = new System.Drawing.Size(265, 22);
            this.txt_NombreEmpresa.TabIndex = 0;
            this.txt_NombreEmpresa.Validar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ESTADO:";
            // 
            // chb_Estado
            // 
            this.chb_Estado.AutoSize = true;
            this.chb_Estado.Checked = true;
            this.chb_Estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Estado.Location = new System.Drawing.Point(115, 75);
            this.chb_Estado.Name = "chb_Estado";
            this.chb_Estado.Size = new System.Drawing.Size(15, 14);
            this.chb_Estado.TabIndex = 2;
            this.chb_Estado.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarValidacion
            // 
            this.btn_GuardarValidacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GuardarValidacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_GuardarValidacion.FlatAppearance.BorderSize = 2;
            this.btn_GuardarValidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarValidacion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarValidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.btn_GuardarValidacion.Image = global::SistemaParqueoAdministracion.Properties.Resources.save1;
            this.btn_GuardarValidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarValidacion.Location = new System.Drawing.Point(399, 15);
            this.btn_GuardarValidacion.Name = "btn_GuardarValidacion";
            this.btn_GuardarValidacion.Size = new System.Drawing.Size(112, 51);
            this.btn_GuardarValidacion.TabIndex = 3;
            this.btn_GuardarValidacion.Text = "GUARDAR";
            this.btn_GuardarValidacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarValidacion.UseVisualStyleBackColor = false;
            this.btn_GuardarValidacion.Click += new System.EventHandler(this.btn_GuardarValidacion_Click);
            // 
            // dtg_Validaciones
            // 
            this.dtg_Validaciones.AllowUserToAddRows = false;
            this.dtg_Validaciones.AllowUserToDeleteRows = false;
            this.dtg_Validaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Validaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Validaciones.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtg_Validaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Validaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Validaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Validaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Validaciones.EnableHeadersVisualStyles = false;
            this.dtg_Validaciones.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dtg_Validaciones.Location = new System.Drawing.Point(3, 115);
            this.dtg_Validaciones.MultiSelect = false;
            this.dtg_Validaciones.Name = "dtg_Validaciones";
            this.dtg_Validaciones.ReadOnly = true;
            this.dtg_Validaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Validaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Validaciones.RowHeadersWidth = 10;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.dtg_Validaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Validaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Validaciones.Size = new System.Drawing.Size(513, 223);
            this.dtg_Validaciones.TabIndex = 163;
            this.dtg_Validaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Validaciones_CellDoubleClick);
            // 
            // OtrasConfiguracionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(527, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OtrasConfiguracionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OTRAS CONFIGURACIONES";
            this.Load += new System.EventHandler(this.OtrasConfiguracionesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Validaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox promo_txt;
        private System.Windows.Forms.Button guardarConfig_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controles.textboxN precioTicket_txt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GuardarValidacion;
        private System.Windows.Forms.CheckBox chb_Estado;
        private System.Windows.Forms.Label label6;
        private Controles.textbox txt_NombreEmpresa;
        private Controles.textboxN txt_MontoVal;
        private System.Windows.Forms.DataGridView dtg_Validaciones;
    }
}