using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class OtrasConfiguracionesForm : Form
    {
        SETTINGS S = new SETTINGS();
        Configuraciones C = new Configuraciones();
        public OtrasConfiguracionesForm()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void OtrasConfiguracionesForm_Load(object sender, EventArgs e)
        {
            
            LoadSettings();
            precioTicket_txt.Focus();
            Program.Evento = 0;
            C.Id = 0;
        }

        public void LoadSettings()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = S.GetSettings();
                precioTicket_txt.Text = dt.Rows[0]["precioTicketPerdido"].ToString();
                promo_txt.Text = dt.Rows[0]["promocion"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guardarConfig_btn_Click(object sender, EventArgs e)
        {
            try
            {
                S.MensajePromo = promo_txt.Text;
                S.PrecioTicketPerdido = float.Parse(precioTicket_txt.Text);
                bool mensaje = S.updateSettigs();
                if (mensaje)
                {
                    MessageBox.Show("Configuración guardada", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Configuración no pudo ser guardada", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void promo_txt_TextChanged(object sender, EventArgs e)
        {
            if(promo_txt.Text.Length == 81)
            {
                MessageBox.Show("Se ha sobrepasado cantidad máxima de caracteres", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                promo_txt.Text = promo_txt.Text.Remove(promo_txt.Text.Length - 1);
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

        private void btn_GuardarValidacion_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = "";
                if(txt_NombreEmpresa.Text!="" && txt_MontoVal.Text != "")
                {
                    if (Program.Evento == 0)
                    {
                        C.Id = 0;
                        C.Empresa = txt_NombreEmpresa.Text;
                        C.Monto = float.Parse(txt_MontoVal.Text);
                        C.Estado = chb_Estado.Checked;
                        msj = C.RegistrarValidaciones();
                        if (msj == "1")
                        {
                            MessageBox.Show("Validación guardada", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error!", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (Program.Evento == 1)
                    {
                        C.Id = Program.id;
                        C.Empresa = txt_NombreEmpresa.Text;
                        C.Monto = float.Parse(txt_MontoVal.Text);
                        C.Estado = chb_Estado.Checked;
                        msj = C.RegistrarValidaciones();
                        if (msj == "1")
                        {
                            MessageBox.Show("Validación actualizada", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error!", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void dtg_Validaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Validaciones.SelectedRows.Count > 0)
            {
                Program.id = Convert.ToInt16(dtg_Validaciones.CurrentRow.Cells[0].Value);
                txt_NombreEmpresa.Text = dtg_Validaciones.CurrentRow.Cells[1].Value.ToString();
                txt_MontoVal.Text= dtg_Validaciones.CurrentRow.Cells[2].Value.ToString();
                chb_Estado.Checked = Convert.ToBoolean(dtg_Validaciones.CurrentRow.Cells[2].Value);
                Program.Evento = 1;
            }
        }
        private void Limpiar()
        {
            txt_MontoVal.Clear();
            txt_NombreEmpresa.Clear();
            Program.Evento = 0;
            Program.id = 0;
            C.Id = 0;
            chb_Estado.Checked = true;
        }
    }
}
