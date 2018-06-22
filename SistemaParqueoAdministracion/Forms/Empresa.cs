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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }
        Empresas E = new Empresas();
        private void Empresa_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = E.GetEmpresa();
            try
            {
                Empresa_dtg.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    Empresa_dtg.Rows.Add(dt.Rows[x][0]);
                    Empresa_dtg.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    Empresa_dtg.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    Empresa_dtg.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    Empresa_dtg.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    Empresa_dtg.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    BloquearTxts();
                  
                }
                Empresa_dtg.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BloquearTxts()
        {
            Nombre_txt.Enabled = false;
            direccion_txt.Enabled = false;
            telefono_txt.Enabled = false;
            correo_txt.Enabled = false;
        }
        private void DesbloquearTxts()
        {
            Nombre_txt.Enabled = true;
            direccion_txt.Enabled = true;
            telefono_txt.Enabled = true;
            correo_txt.Enabled = true;
        }
        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(DatosEmpresa_pn, errorProvider1) == false)
                {
                    return;
                }
                if (Program.Evento == 0)
                {
                    E.Idempresa = 0;
                    
                }
                else if (Program.Evento == 1)
                {
                    E.Idempresa = Program.Idempresa;
                }
                E.Nombre = Nombre_txt.Text;
                E.Direccion = direccion_txt.Text;
                E.Telefono = telefono_txt.Text;
                E.Correo = correo_txt.Text;
                mensaje = E.Registrar();
                if (mensaje == "1")
                {
                    MessageBox.Show("Guardado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenarGrid();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Limpiar()
        {
            if (Empresa_dtg.Rows.Count > 0)
            {
                BloquearTxts();
            }
            correo_txt.Clear();
            direccion_txt.Clear();
            Nombre_txt.Clear();
            telefono_txt.Clear();
            Nombre_txt.Focus();
            Program.Idempresa = 0;
            Program.Evento = 0;

        }

        private void Empresa_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Empresa_dtg.SelectedRows.Count > 0)
            {
                Program.Idempresa = Convert.ToInt16(Empresa_dtg.CurrentRow.Cells[0].Value);
                Nombre_txt.Text = Empresa_dtg.CurrentRow.Cells[1].Value.ToString();
                direccion_txt.Text= Empresa_dtg.CurrentRow.Cells[2].Value.ToString();
                telefono_txt.Text= Empresa_dtg.CurrentRow.Cells[3].Value.ToString();
                correo_txt.Text= Empresa_dtg.CurrentRow.Cells[4].Value.ToString();
                Program.Evento = 1;
                DesbloquearTxts();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Program.form = 1;
            this.Dispose();
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
