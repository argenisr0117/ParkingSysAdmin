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

        private void IntroForm_Load(object sender, EventArgs e)
        {
            hora_timer_Tick(e, e);
            hora_timer.Start();
        }

        private void hora_timer_Tick(object sender, EventArgs e)
        {
            hora_lb.Text = DateTime.Now.ToString("hh:mm:ss tt");
            fecha_lb.Text = DateTime.Now.Date.ToString("dddd,dd MMMM yyyy", CultureInfo.CreateSpecificCulture("es-DO"));
        }
    }
}
