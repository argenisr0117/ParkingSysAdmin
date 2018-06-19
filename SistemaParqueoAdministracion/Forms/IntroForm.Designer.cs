namespace SistemaParqueoAdministracion.Forms
{
    partial class IntroForm
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
            this.hora_lb = new System.Windows.Forms.Label();
            this.fecha_lb = new System.Windows.Forms.Label();
            this.hora_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fecha_lb);
            this.panel1.Controls.Add(this.hora_lb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 580);
            this.panel1.TabIndex = 0;
            // 
            // hora_lb
            // 
            this.hora_lb.AutoSize = true;
            this.hora_lb.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.hora_lb.Location = new System.Drawing.Point(169, 221);
            this.hora_lb.Name = "hora_lb";
            this.hora_lb.Size = new System.Drawing.Size(54, 86);
            this.hora_lb.TabIndex = 1;
            this.hora_lb.Text = ".";
            // 
            // fecha_lb
            // 
            this.fecha_lb.AutoSize = true;
            this.fecha_lb.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(154)))), ((int)(((byte)(10)))));
            this.fecha_lb.Location = new System.Drawing.Point(175, 307);
            this.fecha_lb.Name = "fecha_lb";
            this.fecha_lb.Size = new System.Drawing.Size(32, 50);
            this.fecha_lb.TabIndex = 2;
            this.fecha_lb.Text = ".";
            // 
            // hora_timer
            // 
            this.hora_timer.Interval = 1000;
            this.hora_timer.Tick += new System.EventHandler(this.hora_timer_Tick);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IntroForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fecha_lb;
        private System.Windows.Forms.Label hora_lb;
        private System.Windows.Forms.Timer hora_timer;
    }
}