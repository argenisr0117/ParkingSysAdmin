using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class MainScreenForm : Form
    {
        SETTINGS S = new SETTINGS();
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void tipoUsuario_btn_Click(object sender, EventArgs e)
        {
            RegistroTipoUsuario form = new RegistroTipoUsuario();
            form.ShowDialog();
        }

        private void agregarUsuario_btn_Click(object sender, EventArgs e)
        {
            RegistroUsuario form = new RegistroUsuario();
            form.ShowDialog();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
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

        private void MainScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Sistema de Control de Parqueo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
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
       
    }
}
