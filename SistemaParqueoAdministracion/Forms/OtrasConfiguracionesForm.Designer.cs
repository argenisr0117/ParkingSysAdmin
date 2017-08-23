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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promo_txt = new System.Windows.Forms.TextBox();
            this.guardarConfig_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.precioTicket_txt = new SistemaParqueoAdministracion.Controles.textboxN(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRECIO TICKET PERDIDO($RD):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PROMOCIÓN TICKET:";
            this.toolTip1.SetToolTip(this.label2, "ESTE MENSAJE SERA VISIBLE EN LA PARTE INFERIOR DE LOS TICKETS ");
            // 
            // promo_txt
            // 
            this.promo_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promo_txt.Location = new System.Drawing.Point(5, 118);
            this.promo_txt.Multiline = true;
            this.promo_txt.Name = "promo_txt";
            this.promo_txt.Size = new System.Drawing.Size(361, 77);
            this.promo_txt.TabIndex = 5;
            this.promo_txt.TextChanged += new System.EventHandler(this.promo_txt_TextChanged);
            // 
            // guardarConfig_btn
            // 
            this.guardarConfig_btn.BackColor = System.Drawing.SystemColors.Info;
            this.guardarConfig_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.guardarConfig_btn.FlatAppearance.BorderSize = 2;
            this.guardarConfig_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.guardarConfig_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarConfig_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarConfig_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guardarConfig_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.save;
            this.guardarConfig_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarConfig_btn.Location = new System.Drawing.Point(120, 210);
            this.guardarConfig_btn.Name = "guardarConfig_btn";
            this.guardarConfig_btn.Size = new System.Drawing.Size(129, 63);
            this.guardarConfig_btn.TabIndex = 38;
            this.guardarConfig_btn.Text = "GUARDAR";
            this.guardarConfig_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarConfig_btn.UseVisualStyleBackColor = false;
            this.guardarConfig_btn.Click += new System.EventHandler(this.guardarConfig_btn_Click);
            // 
            // precioTicket_txt
            // 
            this.precioTicket_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTicket_txt.Location = new System.Drawing.Point(216, 33);
            this.precioTicket_txt.Name = "precioTicket_txt";
            this.precioTicket_txt.Size = new System.Drawing.Size(67, 26);
            this.precioTicket_txt.TabIndex = 6;
            this.precioTicket_txt.Valor = SistemaParqueoAdministracion.Controles.textboxN.Tipo.Números;
            // 
            // OtrasConfiguracionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 276);
            this.Controls.Add(this.guardarConfig_btn);
            this.Controls.Add(this.precioTicket_txt);
            this.Controls.Add(this.promo_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OtrasConfiguracionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OTRAS CONFIGURACIONES";
            this.Load += new System.EventHandler(this.OtrasConfiguracionesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox promo_txt;
        private Controles.textboxN precioTicket_txt;
        private System.Windows.Forms.Button guardarConfig_btn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}