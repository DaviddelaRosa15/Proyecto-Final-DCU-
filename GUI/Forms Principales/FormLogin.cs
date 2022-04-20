using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capas;

namespace GUI
{
    public partial class FormLogin : Form
    {
        Dominio dominio = new Dominio();
        public FormLogin()
        {
            InitializeComponent();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "Usuario" && txtuser.TextLength > 2)
            {
                if (txtpass.Text != "Contraseña")
                {
                    var validacionUsuario = dominio.validarUsuario(txtuser.Text, txtpass.Text);
                    if (validacionUsuario == true)
                    {
                        this.Hide();
                        FormDirector director = new FormDirector();
                        FormEstudiante estudiante = new FormEstudiante();
                        FormMaestro maestro = new FormMaestro();
                        FormSplashForm splashForm = new FormSplashForm();
                        splashForm.ShowDialog();
                        switch (UserCache.tipo)
                        {
                            case "Director":
                                director.Show();
                                director.FormClosed += cerrarSesion;
                                break;
                            case "Estudiante":
                                estudiante.Show();
                                estudiante.FormClosed += cerrarSesion;
                                break;
                            case "Maestro":
                                maestro.Show();
                                maestro.FormClosed += cerrarSesion;
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o Contraseña incorrecto. \n   Por favor, intente de nuevo.");
                        txtpass.Text = "Contraseña";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else msgError("Por favor, ingrese la contraseña");
            }
            else msgError("Por favor, ingrese el usuario.");
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "Contraseña";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }

        private void shapeContainer1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
