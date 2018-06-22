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
    public partial class CierreDiario : Form
    {
        Usuario U = new Usuario();
        public CierreDiario()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = U.FindCloseSessions();
            try
            {
                Usuarios_dtg.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    Usuarios_dtg.Rows.Add(dt.Rows[x][0]);
                    Usuarios_dtg.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    Usuarios_dtg.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    Usuarios_dtg.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    Usuarios_dtg.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();

                }
                Usuarios_dtg.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CierreDiario_Load(object sender, EventArgs e)
        {
            FechaInicial_dtp.Value = FechaInicial_dtp.Value.AddDays(-1);
            Buscar_btn_Click(e, e);
        }

        private void Buscar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FechaInicial_dtp.Value.Date <= FechaFinal_dtp.Value.Date)
                {
                    U.Fechai = FechaInicial_dtp.Value;
                    U.Fechaf = FechaFinal_dtp.Value;
                    LlenarGrid();
                }
                else
                {
                    MessageBox.Show("Fecha inicial no puede ser mayor que la final", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Resumen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Usuarios_dtg.SelectedRows.Count > 0)
                {
                    Reportes obj = new Reportes();
                    obj.Valor = 0;
                    obj.Reporte = "cierre_diario.rdlc";
                    obj.Idturno = Convert.ToInt32(Usuarios_dtg.CurrentRow.Cells[3].Value);
                    obj.Idusuario = Convert.ToInt32(Usuarios_dtg.CurrentRow.Cells[1].Value);
                    obj.panel = false;
                    obj.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
