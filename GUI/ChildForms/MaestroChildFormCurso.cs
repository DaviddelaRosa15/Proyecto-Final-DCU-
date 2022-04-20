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
    public partial class MaestroChildFormCurso : Form
    {
        Dominio dominio = new Dominio();

        public MaestroChildFormCurso()
        {
            InitializeComponent();
        }

        private void MaestroChildFormCurso_Load(object sender, EventArgs e)
        {
            mostrarCursos();
        }

        private void mostrarCursos()
        {
            dataGridView1.DataSource = dominio.mostrarCursosMaestros(UserCache.id); ;
        }

    }
    
}
