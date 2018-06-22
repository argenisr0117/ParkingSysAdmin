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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }
        SETTINGS S = new SETTINGS();
        DataTable dt = new DataTable();
        private void IntroForm_Load(object sender, EventArgs e)
        {
            hora_timer_Tick(e, e);
            hora_timer.Start();
            ActualizarTotalesDiarios();
            datos_timer.Start();
        }
        private void ActualizarTotalesDiarios()
        {
            try
            {
                dt = S.GetTotalesDiarios();
                lb_vehparqueo.Text = dt.Rows[0][0].ToString();
                lb_ticketscob.Text= dt.Rows[0][1].ToString();
                lb_totalcaja.Text=string.Format("{0:C}", dt.Rows[0][2]);
                lb_ticketsper.Text= dt.Rows[0][3].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void hora_timer_Tick(object sender, EventArgs e)
        {
            hora_lb.Text = DateTime.Now.ToString("hh:mm:ss tt");
            fecha_lb.Text = DateTime.Now.Date.ToString("dddd,dd MMMM yyyy", CultureInfo.CreateSpecificCulture("es-DO"));
        }

        private void datos_timer_Tick(object sender, EventArgs e)
        {
            ActualizarTotalesDiarios();
        }
    }
}
