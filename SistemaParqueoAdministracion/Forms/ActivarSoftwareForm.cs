using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class ActivarSoftwareForm : Form
    {
        SN sn = new SN();
        SETTINGS S = new SETTINGS();
        public ActivarSoftwareForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void activar_btn_Click(object sender, EventArgs e)
        {
            if(sn_txt.Text == sn.serial())
            {
                bool mensaje = S.ActivarSoftware();
                if (mensaje)
                {
                    Program.Activate = false;                   
                    MessageBox.Show("Activación Correcta", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("No se pudo activar el Software", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se pudo activar el Software", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActivarSoftwareForm_Load(object sender, EventArgs e)
        {
            bool mensaje = S.CheckIfSoftwareActivated();
            if (mensaje)
            {
                label1.Visible = false;
                activar_btn.Visible = false;
                sn_txt.Visible = false;
                activado_lbl.Visible = true;
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
