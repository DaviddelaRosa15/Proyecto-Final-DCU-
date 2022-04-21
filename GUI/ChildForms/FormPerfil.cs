using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas;

namespace GUI
{
    public partial class FormPerfil : Form
    {
        Dominio dominio = new Dominio();

        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            lblNombre.Text = UserCache.nombre + "" + UserCache.apellido;
            lblMatricula.Text = UserCache.matricula;
            lblEdad.Text = Convert.ToString(UserCache.id);
            lblDireccion.Text = UserCache.direccion;
            lblTelefono.Text = UserCache.telefono;
            lblEmail.Text = UserCache.email;

            if (UserCache.matricula == "")
            {
                label2.Visible = false;
                lblMatricula.Visible = true;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagen|*.jpg|Imagen|*.png|Imagen|*.jpeg|Todos los archivos|*.*";
            //abrir.Filter = "Imagen|*.png";
            //abrir.Filter = "Imagen|*.jpeg";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                fotoPerfil.ImageLocation = abrir.FileName;
                fotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
    
}
