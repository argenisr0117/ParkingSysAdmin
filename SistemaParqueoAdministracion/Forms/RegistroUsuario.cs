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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        TipoUsuario T = new TipoUsuario();
        Usuario U = new Usuario();
        MainScreenForm obj = new MainScreenForm();
        private void FillCombouserType()
        {
            try
            {
                tipoUsuario_cb.DataSource = T.GetTipoUsuario();
                tipoUsuario_cb.DisplayMember = "DESCRIPCION";
                tipoUsuario_cb.ValueMember = "ID_tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            if (rbActivo.Checked)
            {
                U.Estado = true;
            }
            else if (rbInactivo.Checked)
            {
                U.Estado = false;
            }
            dt = U.GetUsuario();
            try
            {
                Users_dtg.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    Users_dtg.Rows.Add(dt.Rows[x][0]);
                    Users_dtg.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    Users_dtg.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    Users_dtg.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    Users_dtg.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    Users_dtg.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    Users_dtg.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                }
                Users_dtg.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Program.Evento = 0;
            Program.id = 0;
            LlenarGrid();
            FillCombouserType();
            rbActivo.Checked = true;
            panel3.Location = new Point(this.ClientSize.Width / 2 - panel3.Size.Width / 2,
                this.ClientSize.Height / 2 - panel3.Size.Height / 2);
            panel3.Anchor = AnchorStyles.None;
        }

        private void Limpiar()
        {
            Nombre_txt.Clear();
            Usuario_txt.Clear();
            Clave_txt.Clear();
            clave_anterior.Clear();
            confirmarClaveUpd_txt.Clear();
            claveNuevaUpd_txt.Clear();
            confirmarClave_txt.Clear();
            registrar_panel.Visible = true;
            update_panel.Visible = false;
            //clave_anterior.Validar = true;
            //Clave_txt.Validar = true;
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //obj.BringToFront();
            Program.form = 1;
            //obj.abrirform_timer_Tick(e, e);
            this.Dispose();
            this.Close();
            //obj.introform_btn_Click(e, e);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Limpiar();
            Program.Evento = 0;
            Program.id = 0;
            update_panel.Visible = false;
            registrar_panel.Visible = true;
        }

        private void saveSettings_btn_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(DatosUser_pn, errorProvider1) == false)
            {
                return;
            }

            if (update_panel.Visible == true && changePass_chbox.Checked)
            {
                if (Utilidades.ValidarForm2(update_panel, errorProvider1) == false)
                {
                    return;
                }
            }
            if (update_panel.Visible == false)
            {
                if (Utilidades.ValidarForm2(registrar_panel, errorProvider1) == false)
                {
                    return;
                }

            }


            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    if (Clave_txt.Text == confirmarClave_txt.Text)
                    {
                        U.Nombre = Nombre_txt.Text;
                        U.User = Usuario_txt.Text;
                        U.Clave = Utilidades.EncodePassword(Usuario_txt.Text + Clave_txt.Text);
                        U.Idtipo = Convert.ToInt32(tipoUsuario_cb.SelectedValue);
                        mensaje = U.Registrar();
                        if (mensaje == "1")
                        {

                            update_panel.Visible = false;
                            registrar_panel.Visible = true;
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
                    else
                    {
                        MessageBox.Show("Claves no coinciden", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Program.Evento == 1)
                {
                    int error = 0;
                    U.Idusuario = Program.id;
                    U.Nombre = Nombre_txt.Text;
                    U.User = Usuario_txt.Text;
                    U.Idtipo = Convert.ToInt32(tipoUsuario_cb.SelectedValue);
                    if (changePass_chbox.Checked)
                    {
                        U.Valor = 1;
                        if (Users_dtg.CurrentRow.Cells[3].Value.ToString() != Utilidades.EncodePassword(Users_dtg.CurrentRow.Cells[2].Value.ToString() + clave_anterior.Text))
                        {
                            error = 1;
                            MessageBox.Show("Contraseña anterior no coincide", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (claveNuevaUpd_txt.Text != confirmarClaveUpd_txt.Text)
                        {
                            error = 1;
                            MessageBox.Show("Claves nuevas no coinciden", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            U.Clave = Utilidades.EncodePassword(Usuario_txt.Text + claveNuevaUpd_txt.Text);
                            mensaje = U.Actualizar();
                        }


                    }
                    else
                    {
                        U.Valor = 2;
                        U.Clave = Utilidades.EncodePassword(Usuario_txt.Text + claveNuevaUpd_txt);
                        mensaje = U.Actualizar();
                    }




                    if (mensaje == "1" && error == 0)
                    {
                        MessageBox.Show("Actualizado", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                        Program.Evento = 0;

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Limpiar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid();
            inactivate_btn.Text = "INACTIVAR";
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGrid();
            inactivate_btn.Text = "ACTIVAR";
        }

        private void Users_dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            registrar_panel.Visible = false;
            update_panel.Visible = true;

            Program.id = Convert.ToInt32(Users_dtg.CurrentRow.Cells[0].Value);
            Nombre_txt.Text = Users_dtg.CurrentRow.Cells[1].Value.ToString();
            Usuario_txt.Text = Users_dtg.CurrentRow.Cells[2].Value.ToString();
            //Clave_txt.Text = Users_dtg.CurrentRow.Cells[3].Value.ToString();
            //confirmarClave_txt.Text = Users_dtg.CurrentRow.Cells[3].Value.ToString();
            tipoUsuario_cb.Text = Users_dtg.CurrentRow.Cells[4].Value.ToString();
            Program.Evento = 1;
            //clave_anterior.Validar = false;
            //Clave_txt.Validar = false;
        }

        private void inactivate_btn_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (Users_dtg.SelectedRows.Count > 0)
                {
                    U.Idusuario = Convert.ToInt32(Users_dtg.CurrentRow.Cells[0].Value);
                    U.Estado = Convert.ToBoolean(Users_dtg.CurrentRow.Cells[5].Value);
                    mensaje = U.Activar();
                    if (mensaje == "Activado")
                    {
                        MessageBox.Show(mensaje, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Sistema de Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void changePass_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (changePass_chbox.Checked)
            {
                clave_anterior.Enabled = true;
                confirmarClaveUpd_txt.Enabled = true;
                claveNuevaUpd_txt.Enabled = true;
                //clave_anterior.Validar = true;
                //confirmarClaveUpd_txt.Validar = true;
                //claveNuevaUpd_txt.Validar = true;
            }
            else
            {
                clave_anterior.Enabled = false;
                confirmarClaveUpd_txt.Enabled = false;
                claveNuevaUpd_txt.Enabled = false;
                //clave_anterior.Validar = false;
                //confirmarClaveUpd_txt.Validar = false;
                //claveNuevaUpd_txt.Validar = false;
            }
        }
    }
}
