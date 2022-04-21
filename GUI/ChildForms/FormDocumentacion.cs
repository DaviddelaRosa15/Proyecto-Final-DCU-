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

        private void FormAyuda_Load(object sender, EventArgs e)
        {
            //string resultado = "";
            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "GUI.sample.txt";
            //Stream stream = assembly.GetManifestResourceStream(resourceName);
            //StreamReader reader = new StreamReader(stream);
            //resultado = reader.ReadToEnd();

            richTextBox1.Text = Resources.Recursos.Documentación;
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("GUI.sample.txt"));
            //richTextBox1.Text = reader.ReadToEnd();
        }
    }
    
}
