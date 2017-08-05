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
    public partial class ActivarSoftwareForm : Form
    {
        SN sn = new SN();
        SETTINGS S = new SETTINGS();
        public ActivarSoftwareForm()
        {
            InitializeComponent();
        }

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
    }
}
