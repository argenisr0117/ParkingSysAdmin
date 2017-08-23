using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion.Forms
{
    public partial class OtrasConfiguracionesForm : Form
    {
        SETTINGS S = new SETTINGS();
        public OtrasConfiguracionesForm()
        {
            InitializeComponent();
        }

        

        private void OtrasConfiguracionesForm_Load(object sender, EventArgs e)
        {
            
            LoadSettings();
            precioTicket_txt.Focus();

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
    }
}
