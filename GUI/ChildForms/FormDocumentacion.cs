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
using GUI.Properties;

namespace GUI
{
    public partial class FormDocumentacion : Form
    {
        Dominio dominio = new Dominio();

        public FormDocumentacion()
        {
            InitializeComponent();
        }

        private void FormDocumentacion_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Resources.Recursos.Documentación;
        }
    }
    
}
