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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            this.pn_MenuVertical = new System.Windows.Forms.Panel();
            this.avtivar_btn = new System.Windows.Forms.Button();
            this.cerrarSesion_btn = new System.Windows.Forms.Button();
            this.Usuario_lbl = new System.Windows.Forms.Label();
            this.tipoUsuario_lbl = new System.Windows.Forms.Label();
            this.pb_CuentaUsuario = new System.Windows.Forms.PictureBox();
            this.pn_ReporteSubmenu = new System.Windows.Forms.Panel();
            this.historial_cierre_btn = new System.Windows.Forms.Button();
            this.detalle_cierre_btn = new System.Windows.Forms.Button();
            this.cierre_diario_btn = new System.Windows.Forms.Button();
            this.Reporte_btn = new System.Windows.Forms.Button();
            this.configuraciones_btn = new System.Windows.Forms.Button();
            this.tiempo_precio_btn = new System.Windows.Forms.Button();
            this.empresa_btn = new System.Windows.Forms.Button();
            this.agregarUsuario_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tipoUsuario_btn = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_Maximize = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pn_Superior = new System.Windows.Forms.Panel();
            this.notActivated_lbl = new System.Windows.Forms.Label();
            this.btn_MenuVertical = new System.Windows.Forms.PictureBox();
            this.pn_Central = new System.Windows.Forms.Panel();
            this.pn_MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CuentaUsuario)).BeginInit();
            this.pn_ReporteSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.pn_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MenuVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_MenuVertical
            // 
            this.pn_MenuVertical.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_MenuVertical.Controls.Add(this.avtivar_btn);
            this.pn_MenuVertical.Controls.Add(this.cerrarSesion_btn);
            this.pn_MenuVertical.Controls.Add(this.Usuario_lbl);
            this.pn_MenuVertical.Controls.Add(this.tipoUsuario_lbl);
            this.pn_MenuVertical.Controls.Add(this.pb_CuentaUsuario);
            this.pn_MenuVertical.Controls.Add(this.pn_ReporteSubmenu);
            this.pn_MenuVertical.Controls.Add(this.Reporte_btn);
            this.pn_MenuVertical.Controls.Add(this.configuraciones_btn);
            this.pn_MenuVertical.Controls.Add(this.tiempo_precio_btn);
            this.pn_MenuVertical.Controls.Add(this.empresa_btn);
            this.pn_MenuVertical.Controls.Add(this.agregarUsuario_btn);
            this.pn_MenuVertical.Controls.Add(this.pictureBox2);
            this.pn_MenuVertical.Controls.Add(this.tipoUsuario_btn);
            this.pn_MenuVertical.Controls.Add(this.shapeContainer1);
            this.pn_MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pn_MenuVertical.Name = "pn_MenuVertical";
            this.pn_MenuVertical.Size = new System.Drawing.Size(234, 622);
            this.pn_MenuVertical.TabIndex = 36;
            // 
            // avtivar_btn
            // 
            this.avtivar_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.avtivar_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtivar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.avtivar_btn.FlatAppearance.BorderSize = 0;
            this.avtivar_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.avtivar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avtivar_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtivar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.avtivar_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.open_lock;
            this.avtivar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.avtivar_btn.Location = new System.Drawing.Point(0, 64);
            this.avtivar_btn.Name = "avtivar_btn";
            this.avtivar_btn.Size = new System.Drawing.Size(234, 24);
            this.avtivar_btn.TabIndex = 51;
            this.avtivar_btn.Text = "Activar Software";
            this.avtivar_btn.UseVisualStyleBackColor = false;
            this.avtivar_btn.Click += new System.EventHandler(this.avtivar_btn_Click);
            // 
            // cerrarSesion_btn
            // 
            this.cerrarSesion_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cerrarSesion_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarSesion_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cerrarSesion_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cerrarSesion_btn.FlatAppearance.BorderSize = 0;
            this.cerrarSesion_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.cerrarSesion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cerrarSesion_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.logout__1_;
            this.cerrarSesion_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesion_btn.Location = new System.Drawing.Point(0, 582);
            this.cerrarSesion_btn.Name = "cerrarSesion_btn";
            this.cerrarSesion_btn.Size = new System.Drawing.Size(234, 40);
            this.cerrarSesion_btn.TabIndex = 50;
            this.cerrarSesion_btn.Text = "Cerrar Sesión";
            this.cerrarSesion_btn.UseVisualStyleBackColor = false;
            this.cerrarSesion_btn.Click += new System.EventHandler(this.cerrarSesion_btn_Click);
            // 
            // Usuario_lbl
            // 
            this.Usuario_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Usuario_lbl.AutoSize = true;
            this.Usuario_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.Usuario_lbl.Location = new System.Drawing.Point(75, 527);
            this.Usuario_lbl.Name = "Usuario_lbl";
            this.Usuario_lbl.Size = new System.Drawing.Size(18, 20);
            this.Usuario_lbl.TabIndex = 1;
            this.Usuario_lbl.Text = "u";
            // 
            // tipoUsuario_lbl
            // 
            this.tipoUsuario_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tipoUsuario_lbl.AutoSize = true;
            this.tipoUsuario_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.tipoUsuario_lbl.Location = new System.Drawing.Point(75, 499);
            this.tipoUsuario_lbl.Name = "tipoUsuario_lbl";
            this.tipoUsuario_lbl.Size = new System.Drawing.Size(15, 20);
            this.tipoUsuario_lbl.TabIndex = 5;
            this.tipoUsuario_lbl.Text = "t";
            // 
            // pb_CuentaUsuario
            // 
            this.pb_CuentaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_CuentaUsuario.Image = global::SistemaParqueoAdministracion.Properties.Resources.verification;
            this.pb_CuentaUsuario.Location = new System.Drawing.Point(3, 491);
            this.pb_CuentaUsuario.Name = "pb_CuentaUsuario";
            this.pb_CuentaUsuario.Size = new System.Drawing.Size(64, 64);
            this.pb_CuentaUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_CuentaUsuario.TabIndex = 49;
            this.pb_CuentaUsuario.TabStop = false;
            // 
            // pn_ReporteSubmenu
            // 
            this.pn_ReporteSubmenu.Controls.Add(this.historial_cierre_btn);
            this.pn_ReporteSubmenu.Controls.Add(this.detalle_cierre_btn);
            this.pn_ReporteSubmenu.Controls.Add(this.cierre_diario_btn);
            this.pn_ReporteSubmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_ReporteSubmenu.Location = new System.Drawing.Point(36, 353);
            this.pn_ReporteSubmenu.Name = "pn_ReporteSubmenu";
            this.pn_ReporteSubmenu.Size = new System.Drawing.Size(198, 121);
            this.pn_ReporteSubmenu.TabIndex = 47;
            this.pn_ReporteSubmenu.Visible = false;
            // 
            // historial_cierre_btn
            // 
            this.historial_cierre_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historial_cierre_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.historial_cierre_btn.FlatAppearance.BorderSize = 0;
            this.historial_cierre_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.historial_cierre_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historial_cierre_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historial_cierre_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.historial_cierre_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.search_in_folder;
            this.historial_cierre_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historial_cierre_btn.Location = new System.Drawing.Point(0, 78);
            this.historial_cierre_btn.Name = "historial_cierre_btn";
            this.historial_cierre_btn.Size = new System.Drawing.Size(198, 40);
            this.historial_cierre_btn.TabIndex = 50;
            this.historial_cierre_btn.Text = "Historial Tickets";
            this.historial_cierre_btn.UseVisualStyleBackColor = false;
            this.historial_cierre_btn.Click += new System.EventHandler(this.historial_cierre_btn_Click);
            // 
            // detalle_cierre_btn
            // 
            this.detalle_cierre_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detalle_cierre_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.detalle_cierre_btn.FlatAppearance.BorderSize = 0;
            this.detalle_cierre_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.detalle_cierre_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalle_cierre_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle_cierre_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.detalle_cierre_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.chart;
            this.detalle_cierre_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detalle_cierre_btn.Location = new System.Drawing.Point(0, 40);
            this.detalle_cierre_btn.Name = "detalle_cierre_btn";
            this.detalle_cierre_btn.Size = new System.Drawing.Size(198, 40);
            this.detalle_cierre_btn.TabIndex = 49;
            this.detalle_cierre_btn.Text = "Detalle Cierre";
            this.detalle_cierre_btn.UseVisualStyleBackColor = false;
            this.detalle_cierre_btn.Click += new System.EventHandler(this.detalle_cierre_btn_Click);
            // 
            // cierre_diario_btn
            // 
            this.cierre_diario_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cierre_diario_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cierre_diario_btn.FlatAppearance.BorderSize = 0;
            this.cierre_diario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.cierre_diario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cierre_diario_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cierre_diario_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.cierre_diario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.sale_report;
            this.cierre_diario_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cierre_diario_btn.Location = new System.Drawing.Point(0, 0);
            this.cierre_diario_btn.Name = "cierre_diario_btn";
            this.cierre_diario_btn.Size = new System.Drawing.Size(198, 40);
            this.cierre_diario_btn.TabIndex = 48;
            this.cierre_diario_btn.Text = "Cierre Diario";
            this.cierre_diario_btn.UseVisualStyleBackColor = false;
            this.cierre_diario_btn.Click += new System.EventHandler(this.cierre_diario_btn_Click);
            // 
            // Reporte_btn
            // 
            this.Reporte_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Reporte_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reporte_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.Reporte_btn.FlatAppearance.BorderSize = 0;
            this.Reporte_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Reporte_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reporte_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.Reporte_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.schedule;
            this.Reporte_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reporte_btn.Location = new System.Drawing.Point(0, 311);
            this.Reporte_btn.Name = "Reporte_btn";
            this.Reporte_btn.Size = new System.Drawing.Size(234, 40);
            this.Reporte_btn.TabIndex = 46;
            this.Reporte_btn.Text = "Reportes";
            this.Reporte_btn.UseVisualStyleBackColor = false;
            this.Reporte_btn.Click += new System.EventHandler(this.Reporte_btn_Click);
            // 
            // configuraciones_btn
            // 
            this.configuraciones_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.configuraciones_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.configuraciones_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.configuraciones_btn.FlatAppearance.BorderSize = 0;
            this.configuraciones_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.configuraciones_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuraciones_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraciones_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.configuraciones_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.icon;
            this.configuraciones_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configuraciones_btn.Location = new System.Drawing.Point(0, 271);
            this.configuraciones_btn.Name = "configuraciones_btn";
            this.configuraciones_btn.Size = new System.Drawing.Size(234, 40);
            this.configuraciones_btn.TabIndex = 45;
            this.configuraciones_btn.Text = "Configuraciones";
            this.configuraciones_btn.UseVisualStyleBackColor = false;
            this.configuraciones_btn.Click += new System.EventHandler(this.configuraciones_btn_Click);
            // 
            // tiempo_precio_btn
            // 
            this.tiempo_precio_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tiempo_precio_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tiempo_precio_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.tiempo_precio_btn.FlatAppearance.BorderSize = 0;
            this.tiempo_precio_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tiempo_precio_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiempo_precio_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_precio_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.tiempo_precio_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.settings;
            this.tiempo_precio_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tiempo_precio_btn.Location = new System.Drawing.Point(0, 231);
            this.tiempo_precio_btn.Name = "tiempo_precio_btn";
            this.tiempo_precio_btn.Size = new System.Drawing.Size(234, 40);
            this.tiempo_precio_btn.TabIndex = 44;
            this.tiempo_precio_btn.Text = "Tiempo/Precio";
            this.tiempo_precio_btn.UseVisualStyleBackColor = false;
            this.tiempo_precio_btn.Click += new System.EventHandler(this.tiempo_precio_btn_Click);
            // 
            // empresa_btn
            // 
            this.empresa_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empresa_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empresa_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.empresa_btn.FlatAppearance.BorderSize = 0;
            this.empresa_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.empresa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empresa_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.empresa_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.store;
            this.empresa_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empresa_btn.Location = new System.Drawing.Point(0, 191);
            this.empresa_btn.Name = "empresa_btn";
            this.empresa_btn.Size = new System.Drawing.Size(234, 40);
            this.empresa_btn.TabIndex = 43;
            this.empresa_btn.Text = "Empresas";
            this.empresa_btn.UseVisualStyleBackColor = false;
            this.empresa_btn.Click += new System.EventHandler(this.empresa_btn_Click);
            // 
            // agregarUsuario_btn
            // 
            this.agregarUsuario_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.agregarUsuario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.agregarUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.agregarUsuario_btn.FlatAppearance.BorderSize = 0;
            this.agregarUsuario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.agregarUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarUsuario_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuario_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.agregarUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.man_user;
            this.agregarUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarUsuario_btn.Location = new System.Drawing.Point(0, 111);
            this.agregarUsuario_btn.Name = "agregarUsuario_btn";
            this.agregarUsuario_btn.Size = new System.Drawing.Size(234, 40);
            this.agregarUsuario_btn.TabIndex = 42;
            this.agregarUsuario_btn.Text = "Usuarios";
            this.agregarUsuario_btn.UseVisualStyleBackColor = false;
            this.agregarUsuario_btn.Click += new System.EventHandler(this.agregarUsuario_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaParqueoAdministracion.Properties.Resources.Logo5;
            this.pictureBox2.Location = new System.Drawing.Point(3, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // tipoUsuario_btn
            // 
            this.tipoUsuario_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tipoUsuario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoUsuario_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.tipoUsuario_btn.FlatAppearance.BorderSize = 0;
            this.tipoUsuario_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tipoUsuario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoUsuario_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.tipoUsuario_btn.Image = global::SistemaParqueoAdministracion.Properties.Resources.multiple_users_silhouette;
            this.tipoUsuario_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoUsuario_btn.Location = new System.Drawing.Point(0, 151);
            this.tipoUsuario_btn.Name = "tipoUsuario_btn";
            this.tipoUsuario_btn.Size = new System.Drawing.Size(234, 40);
            this.tipoUsuario_btn.TabIndex = 34;
            this.tipoUsuario_btn.Text = "Tipos Usuarios";
            this.tipoUsuario_btn.UseVisualStyleBackColor = false;
            this.tipoUsuario_btn.Click += new System.EventHandler(this.tipoUsuario_btn_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(234, 622);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            this.lineShape1.X1 = 2;
            this.lineShape1.X2 = 233;
            this.lineShape1.Y1 = 484;
            this.lineShape1.Y2 = 484;
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restaurar.Enabled = false;
            this.btn_Restaurar.Image = global::SistemaParqueoAdministracion.Properties.Resources.multi_tab;
            this.btn_Restaurar.Location = new System.Drawing.Point(801, 7);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(15, 15);
            this.btn_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Restaurar.TabIndex = 44;
            this.btn_Restaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Restaurar, "Restaurar");
            this.btn_Restaurar.Visible = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            this.btn_Restaurar.MouseLeave += new System.EventHandler(this.btn_Restaurar_MouseLeave);
            this.btn_Restaurar.MouseHover += new System.EventHandler(this.btn_Restaurar_MouseHover);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = global::SistemaParqueoAdministracion.Properties.Resources.minimize;
            this.btn_minimize.Location = new System.Drawing.Point(780, 7);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(15, 15);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 45;
            this.btn_minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_minimize, "Minimizar");
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            this.btn_minimize.MouseHover += new System.EventHandler(this.btn_minimize_MouseHover);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximize.Enabled = false;
            this.btn_Maximize.Image = global::SistemaParqueoAdministracion.Properties.Resources.blank_check_box;
            this.btn_Maximize.Location = new System.Drawing.Point(801, 7);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(15, 15);
            this.btn_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Maximize.TabIndex = 46;
            this.btn_Maximize.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Maximize, "Maximizar");
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            this.btn_Maximize.MouseLeave += new System.EventHandler(this.btn_Maximize_MouseLeave);
            this.btn_Maximize.MouseHover += new System.EventHandler(this.btn_Maximize_MouseHover);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Image = global::SistemaParqueoAdministracion.Properties.Resources.cancel1;
            this.btn_Close.Location = new System.Drawing.Point(822, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(15, 15);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_Close, "Cerrar");
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            this.btn_Close.MouseHover += new System.EventHandler(this.btn_Close_MouseHover);
            // 
            // pn_Superior
            // 
            this.pn_Superior.BackColor = System.Drawing.Color.White;
            this.pn_Superior.Controls.Add(this.notActivated_lbl);
            this.pn_Superior.Controls.Add(this.btn_Restaurar);
            this.pn_Superior.Controls.Add(this.btn_minimize);
            this.pn_Superior.Controls.Add(this.btn_Maximize);
            this.pn_Superior.Controls.Add(this.btn_MenuVertical);
            this.pn_Superior.Controls.Add(this.btn_Close);
            this.pn_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Superior.Location = new System.Drawing.Point(234, 0);
            this.pn_Superior.Name = "pn_Superior";
            this.pn_Superior.Size = new System.Drawing.Size(843, 42);
            this.pn_Superior.TabIndex = 41;
            this.pn_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_Superior_MouseDown);
            // 
            // notActivated_lbl
            // 
            this.notActivated_lbl.AutoSize = true;
            this.notActivated_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notActivated_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.notActivated_lbl.Location = new System.Drawing.Point(276, 11);
            this.notActivated_lbl.Name = "notActivated_lbl";
            this.notActivated_lbl.Size = new System.Drawing.Size(291, 21);
            this.notActivated_lbl.TabIndex = 43;
            this.notActivated_lbl.Text = "SOFTWARE NO HA SIDO ACTIVADO...!";
            // 
            // btn_MenuVertical
            // 
            this.btn_MenuVertical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MenuVertical.Image = global::SistemaParqueoAdministracion.Properties.Resources.menu1;
            this.btn_MenuVertical.Location = new System.Drawing.Point(3, 4);
            this.btn_MenuVertical.Name = "btn_MenuVertical";
            this.btn_MenuVertical.Size = new System.Drawing.Size(37, 35);
            this.btn_MenuVertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_MenuVertical.TabIndex = 0;
            this.btn_MenuVertical.TabStop = false;
            this.btn_MenuVertical.Visible = false;
            this.btn_MenuVertical.Click += new System.EventHandler(this.btn_MenuVertical_Click);
            // 
            // pn_Central
            // 
            this.pn_Central.BackColor = System.Drawing.Color.White;
            this.pn_Central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Central.Location = new System.Drawing.Point(234, 42);
            this.pn_Central.Name = "pn_Central";
            this.pn_Central.Size = new System.Drawing.Size(843, 580);
            this.pn_Central.TabIndex = 42;
            this.pn_Central.MouseEnter += new System.EventHandler(this.pn_Central_MouseEnter);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 622);
            this.Controls.Add(this.pn_Central);
            this.Controls.Add(this.pn_Superior);
            this.Controls.Add(this.pn_MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA ADMINISTRATIVO PARQUEO";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            this.pn_MenuVertical.ResumeLayout(false);
            this.pn_MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CuentaUsuario)).EndInit();
            this.pn_ReporteSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.pn_Superior.ResumeLayout(false);
            this.pn_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MenuVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_MenuVertical;
        private System.Windows.Forms.Label Usuario_lbl;
        private System.Windows.Forms.Label tipoUsuario_lbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pn_Superior;
        private System.Windows.Forms.Panel pn_Central;
        private System.Windows.Forms.Label notActivated_lbl;
        private System.Windows.Forms.Button tipoUsuario_btn;
        private System.Windows.Forms.PictureBox btn_MenuVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox btn_Maximize;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.PictureBox btn_Restaurar;
        private System.Windows.Forms.Button agregarUsuario_btn;
        private System.Windows.Forms.Button empresa_btn;
        private System.Windows.Forms.Button configuraciones_btn;
        private System.Windows.Forms.Button tiempo_precio_btn;
        private System.Windows.Forms.Button Reporte_btn;
        private System.Windows.Forms.Panel pn_ReporteSubmenu;
        private System.Windows.Forms.Button detalle_cierre_btn;
        private System.Windows.Forms.Button cierre_diario_btn;
        private System.Windows.Forms.Button historial_cierre_btn;
        private System.Windows.Forms.PictureBox pb_CuentaUsuario;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button cerrarSesion_btn;
        private System.Windows.Forms.Button avtivar_btn;
    }
}