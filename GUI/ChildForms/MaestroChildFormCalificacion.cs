using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capas;

namespace GUI
{
    public partial class MaestroChildFormCalificacion : Form
    {
        Dominio dominio = new Dominio();

        public MaestroChildFormCalificacion()
        {
            InitializeComponent();
            txtCalificacion.Size = new System.Drawing.Size(100,30);
        }

        private void MaestroChildFormCalificacion_Load(object sender, EventArgs e)
        {
            mostrarCalificaciones();
        }

        private void mostrarCalificaciones()
        {
            dataGridView1.DataSource = dominio.mostrarCalificaciones(UserCache.id); ;
        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                //btnlogin_Click(sender, e);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
    
}
