using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaParqueoAdministracion
{
    public partial class LoginForm : Form
    {
        Login L = new Login();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Usuario_txt.Text = Properties.Settings.Default.userName;
            string mensaje = L.TipoLogin();
            if (mensaje == "1")
            {
                //normal_login_panel.Visible = false;
                first_login_panel.Visible = true;
                
            }
            else
            {
                first_login_panel.Visible = false;
                normal_login_panel.Visible = true;
                
                
            }

            //SN sn = new SN();
            //MessageBox.Show(sn.serial());
        }

        private void registrarLogin_txt_Click(object sender, EventArgs e)
        {
            firstLogin();
        }

        private void salirLogin_txt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrarLogin_txt_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void salirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void firstLogin()
        {
            if (nombreUsuario_txt.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos en blanco", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (userRegistrarLogin_txt.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos en blanco", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clave_txt.Text.Trim() == "")
            {
                MessageBox.Show("Existen campos en blanco", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (clave_txt.Text != confirmarClave_txt.Text)
            {
                MessageBox.Show("Contraseñas no coinciden", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                L.Nombre = nombreUsuario_txt.Text;
                L.Usuario = userRegistrarLogin_txt.Text;
                L.Clave = Utilidades.EncodePassword(userRegistrarLogin_txt.Text + clave_txt.Text);
                string[] mensaje = L.PrimerLogin();
                if (mensaje[0] == "1")
                {
                    Program.UserName = userRegistrarLogin_txt.Text;
                    Program.UserId = mensaje[1].ToString();
                    Properties.Settings.Default.userName = Program.UserName;
                    Properties.Settings.Default.Save();
                    PermisoUsuario P = new PermisoUsuario();
                    P.UserId = Convert.ToInt16(Program.UserId);
                    DataTable dt = new DataTable();
                    dt = P.GetPersmissions();
                    Program.TipoUsuario = dt.Rows[0]["descripcion"].ToString();
                    this.Hide();
                    Forms.MainScreenForm form = new Forms.MainScreenForm();
                    form.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se pudo Registrar Usuario", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public void Login()
        {
            L.Usuario = Usuario_txt.Text;
            L.Clave = Utilidades.EncodePassword(Usuario_txt.Text + Password_txt.Text);
            string[] mensaje = L.UserLogin();
            if (mensaje[0] == "1")
            {
                Program.UserId = mensaje[1].ToString();
                Program.UserName = Usuario_txt.Text;
                Properties.Settings.Default.userName = Program.UserName;
                Properties.Settings.Default.Save();
                PermisoUsuario P = new PermisoUsuario();
                P.UserId = Convert.ToInt16(Program.UserId);
                DataTable dt = new DataTable();
                dt = P.GetPersmissions();
                Program.TipoUsuario = dt.Rows[0]["descripcion"].ToString();
                this.Hide();
                Forms.MainScreenForm form = new Forms.MainScreenForm();
                form.ShowDialog();
                this.Close();

                //this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no coinciden", "Sistema Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (first_login_panel.Visible == true)
                {
                    firstLogin();
                }
                else
                {
                    
                    Login();
                }
            }
        }
    }
}
