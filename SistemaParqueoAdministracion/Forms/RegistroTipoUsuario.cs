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
    public partial class RegistroTipoUsuario : Form
    {
        TipoUsuario T = new TipoUsuario();
        public RegistroTipoUsuario()
        {
            InitializeComponent();
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (!string.IsNullOrEmpty(txtTipoUsuario.Text))
                {
                    if (Program.Evento == 0)
                    {
                        T.Descripcion = txtTipoUsuario.Text;
                    
                        T.entradaStatus = verStatusEntrada_chbox.Checked;
                        T.cerrarEntrada = cerrarEntrada_chbox.Checked;
                        T.generarReportes = generarReportes_chbox.Checked;
                        T.salirSalida = cerrarSalida_chbox.Checked;
                        T.ticketManual = ticketManual_chbox.Checked;
                        T.ticketPerdido = ticketPerdido_chbox.Checked;
                        T.tiempoPrecio = tiempoPrecio_chbox.Checked;
                        T.agregarUsuario = agregarUsuario_chbox.Checked;
                        
                        mensaje = T.Registrar();
                        if (mensaje == "1")
                        {
                            MessageBox.Show("Registrado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenarGrid();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                        }
                    }
                    else if (Program.Evento == 1)
                    {
                        T.idTipo = Program.id;
                        T.Descripcion = txtTipoUsuario.Text;
                        T.entradaStatus = verStatusEntrada_chbox.Checked;
                        T.cerrarEntrada = cerrarEntrada_chbox.Checked;
                        T.generarReportes = generarReportes_chbox.Checked;
                        T.salirSalida = cerrarSalida_chbox.Checked;
                        T.ticketManual = ticketManual_chbox.Checked;
                        T.ticketPerdido = ticketPerdido_chbox.Checked;
                        T.tiempoPrecio = tiempoPrecio_chbox.Checked;
                        T.agregarUsuario = agregarUsuario_chbox.Checked;

                        mensaje = T.Actualizar();
                        if (mensaje == "1")
                        {
                            MessageBox.Show("Actualizado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenarGrid();
                            Limpiar();
                            Program.Evento = 0;
                            Program.id = 0;
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Existen campos vacios", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTipoUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            txtTipoUsuario.Clear();
            agregarUsuario_chbox.Checked = false;
            cerrarEntrada_chbox.Checked = false;
            cerrarSalida_chbox.Checked = false;
            generarReportes_chbox.Checked = false;
            ticketManual_chbox.Checked = false;
            ticketPerdido_chbox.Checked = false;
            tiempoPrecio_chbox.Checked = false;
            verStatusEntrada_chbox.Checked = false;
            txtTipoUsuario.Focus();
        }

        private void RegistroTipoUsuario_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Limpiar();
            Program.Evento = 0;
            LlenarGrid();
            panel2.Location = new Point(this.ClientSize.Width / 2 - panel2.Size.Width / 2,
                this.ClientSize.Height / 2 - panel2.Size.Height / 2);
            panel2.Anchor = AnchorStyles.None;
        }

        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = T.GetTipoUsuario();
            try
            {
                dtgTipoUsuario.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgTipoUsuario.Rows.Add(dt.Rows[x][0]);
                    dtgTipoUsuario.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgTipoUsuario.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgTipoUsuario.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgTipoUsuario.Rows[x].Cells[3].Value = dt.Rows[x][4].ToString();
                    dtgTipoUsuario.Rows[x].Cells[4].Value = dt.Rows[x][5].ToString();
                    dtgTipoUsuario.Rows[x].Cells[5].Value = dt.Rows[x][6].ToString();
                    dtgTipoUsuario.Rows[x].Cells[6].Value = dt.Rows[x][8].ToString();
                    dtgTipoUsuario.Rows[x].Cells[7].Value = dt.Rows[x][9].ToString();
                    dtgTipoUsuario.Rows[x].Cells[8].Value = dt.Rows[x][10].ToString();
                    dtgTipoUsuario.Rows[x].Cells[9].Value = dt.Rows[x][11].ToString();

                }
                dtgTipoUsuario.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgTipoUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Evento = 1;
            Program.id = Convert.ToInt32(dtgTipoUsuario.CurrentRow.Cells[0].Value);
            txtTipoUsuario.Text = dtgTipoUsuario.CurrentRow.Cells[1].Value.ToString();
            
            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[2].Value.ToString()))
            {
                verStatusEntrada_chbox.Checked = true;
            }
            else
            {
                verStatusEntrada_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[3].Value.ToString()))
            {
                cerrarEntrada_chbox.Checked = true;
            }
            else
            {
                cerrarEntrada_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[4].Value.ToString()))
            {
               tiempoPrecio_chbox.Checked = true;
            }
            else
            {
                tiempoPrecio_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[5].Value.ToString()))
            {
                cerrarSalida_chbox.Checked = true;
            }
            else
            {
                cerrarSalida_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[6].Value.ToString()))
            {
                ticketPerdido_chbox.Checked = true;
            }
            else
            {
                ticketPerdido_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[7].Value.ToString()))
            {
                ticketManual_chbox.Checked = true;
            }
            else
            {
                ticketManual_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[8].Value.ToString()))
            {
                generarReportes_chbox.Checked = true;
            }
            else
            {
               generarReportes_chbox.Checked = false;
            }

            if (Convert.ToBoolean(dtgTipoUsuario.CurrentRow.Cells[9].Value.ToString()))
            {
                agregarUsuario_chbox.Checked = true;
            }
            else
            {
                agregarUsuario_chbox.Checked = false;
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Limpiar();
            Program.Evento = 0;
            Program.id = 0;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Program.form = 1;
            this.Dispose();
            this.Close();
        }
    }
}
