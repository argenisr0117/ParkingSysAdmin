using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class MainScreenForm : Form
    {
        SETTINGS S = new SETTINGS();
        public MainScreenForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparam, int lparam);
        private void tipoUsuario_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<RegistroTipoUsuario>().FirstOrDefault();
            RegistroTipoUsuario hijo = form ?? new RegistroTipoUsuario();
            ABrirFormulario(hijo);
        }
      
        private void agregarUsuario_btn_Click(object sender, EventArgs e)
        {
            //OcultarHora();
            var form = Application.OpenForms.OfType<RegistroUsuario>().FirstOrDefault();
            RegistroUsuario hijo = form ?? new RegistroUsuario();
            ABrirFormulario(hijo);
            //MostrarHora();
        }

        public void AbrirIntroForm()
        {
            var form = Application.OpenForms.OfType<IntroForm>().FirstOrDefault();
            IntroForm hijo = form ?? new IntroForm();
            ABrirFormulario(hijo);
        }
        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            AbrirIntroForm();
            Usuario_lbl.Text = Program.UserName + " - " + Program.UserId;
             
            tipoUsuario_lbl.Text = Program.TipoUsuario ;
            bool mensaje = S.CheckIfSoftwareActivated();
            if (mensaje)
            {
                notActivated_lbl.Visible = false;
            }
            else
            {
                toolTip1.SetToolTip(notActivated_lbl, "ESTACION DE ENTRADA Y ESTACION DE SALIDA ESTARAN DESABILITADAS");
            }
        }

        private void cerrarSesion_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm form = new LoginForm();
            form.ShowDialog();           
            
        }

        private void aCTIVARSOFTWAREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivarSoftwareForm form = new ActivarSoftwareForm();
            form.ShowDialog();
            notActivated_lbl.Visible = Program.Activate;
        }

        private void cierre_diario_btn_Click(object sender, EventArgs e)
        {
            CierreDiario obj = new CierreDiario();
            obj.ShowDialog();
        }

        private void empresa_btn_Click(object sender, EventArgs e)
        {
            Empresa form = new Empresa();
            form.Show();
        }

        private void detalle_cierre_btn_Click(object sender, EventArgs e)
        {
            Reportes obj = new Reportes();
            obj.Valor = 2;
            obj.Show();
        }

        private void btn_MenuVertical_Click(object sender, EventArgs e)
        {
            if(pn_ReporteSubmenu.Visible==false)
            {
                if (pn_MenuVertical.Width == 234)
                {
                    pn_MenuVertical.Width = 54;
                    pb_CuentaUsuario.Size=new Size(42,40);
                }
                else
                {
                    pn_MenuVertical.Width = 234;
                    pb_CuentaUsuario.Size = new Size(96, 73);

                }
            }
            //MostrarHora();       
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximize.Visible = true;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Restaurar.Visible = true;
            btn_Maximize.Visible = false;
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.Gainsboro;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.WhiteSmoke;
        }

        private void btn_Close_MouseHover(object sender, EventArgs e)
        {
            btn_Close.BackColor = Color.Gainsboro;
        }

        private void btn_Restaurar_MouseHover(object sender, EventArgs e)
        {
            btn_Restaurar.BackColor = Color.Gainsboro;
        }

        private void btn_Restaurar_MouseLeave(object sender, EventArgs e)
        {
            btn_Restaurar.BackColor = Color.WhiteSmoke;
        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.BackColor = Color.WhiteSmoke;
        }

        private void btn_Maximize_MouseHover(object sender, EventArgs e)
        {
            btn_Maximize.BackColor = Color.Gainsboro;
        }

        private void btn_Maximize_MouseLeave(object sender, EventArgs e)
        {
            btn_Maximize.BackColor = Color.WhiteSmoke;
        }

        private void pn_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Reporte_btn_Click(object sender, EventArgs e)
        {
            if (pn_ReporteSubmenu.Visible == false)
            {
                pn_ReporteSubmenu.Visible = true;
            }
            else
            {
                pn_ReporteSubmenu.Visible = false;

            }
        }

        private void tiempo_precio_btn_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<configuracionTiempoPrecioForm>().FirstOrDefault();
            configuracionTiempoPrecioForm hijo = form ?? new configuracionTiempoPrecioForm();
            ABrirFormulario(hijo);
        }

        private void configuraciones_btn_Click(object sender, EventArgs e)
        {
            OtrasConfiguracionesForm form = new OtrasConfiguracionesForm();
            form.ShowDialog();
        }

        private void historial_cierre_btn_Click(object sender, EventArgs e)
        {
            Reportes obj = new Reportes();
            obj.Valor = 1;
            obj.Show();
        }

        private void ABrirFormulario (Form fh)
        {
            //OcultarHora();
            //abrirform_timer.Start();
            if (pn_Central.Controls.Count > 0)
            {
                pn_Central.Controls.RemoveAt(0);
            }
            //Form fh = objForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pn_Central.Controls.Add(fh);
            this.pn_Central.Tag = fh;
            fh.Show();
            //MostrarHora();
        }

        private void avtivar_btn_Click(object sender, EventArgs e)
        {
            ActivarSoftwareForm form = new ActivarSoftwareForm();
            form.ShowDialog();
            notActivated_lbl.Visible = Program.Activate;
        }

        private void pn_Central_MouseEnter(object sender, EventArgs e)
        {
            if (Program.form == 1)
            {
                AbrirIntroForm();
                Program.form = 0;
            }
        }
    }
}
