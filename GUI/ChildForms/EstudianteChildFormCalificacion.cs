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
    public partial class EstudianteChildFormCalificacion : Form
    {
        Dominio dominio = new Dominio();

        public EstudianteChildFormCalificacion()
        {
            InitializeComponent();
        }

        private void EstudianteChildFormCalificacion_Load(object sender, EventArgs e)
        {
            mostrarCalificaciones();
        }

        private void mostrarCalificaciones()
        {
            dataGridView1.DataSource = dominio.mostrarCalificacionEstudiante(UserCache.id);
        }

    }
    
}
