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
    public partial class ChildFormEstudiante : Form
    {
        Dominio dominio = new Dominio();
        private string idEstudiante = null;
        private bool modificar = false;
        private DataGridView dataGrid;
        private int textCBB;

        public ChildFormEstudiante()
        {
            InitializeComponent();
        }

        private void ChildFormEstudiante_Load(object sender, EventArgs e)
        {
            mostrarEventos();
            cargarCursos();
        }

        private void descargarDataGrid()
        {
            dataGridView1 = new DataGridView();
        }

        private void mostrarEventos()
        {
            dataGridView1.DataSource = dominio.mostrarEstudiantes(); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarEstudiantes(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), txtMatricula.Text, 
                        txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text, int.Parse(cbbCurso.SelectedIndex.ToString()));
                    MessageBox.Show("¡Se insertó correctamente!");
                    descargarDataGrid();
                    mostrarEventos();
                    clearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (modificar == true)
            {
                try
                {
                    dominio.actualizarEstudiantes(int.Parse(idEstudiante), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), txtMatricula.Text,
                        txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text, int.Parse(cbbCurso.SelectedValue.ToString()));
                    MessageBox.Show("¡Se modificó correctamente!");
                    descargarDataGrid();
                    mostrarEventos();
                    clearForm();
                    modificar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }
            }
        }



        private void clearForm()
        {
            txtNombre.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                modificar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                cbbCurso.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["Curso"].Value.ToString());
                idEstudiante = dataGridView1.CurrentRow.Cells["idEstudiante"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila. Por favor");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idEstudiante = dataGridView1.CurrentRow.Cells["idEstudiante"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dominio.eliminarEstudiantes(int.Parse(idEstudiante));
                    MessageBox.Show("Eliminado correctamente");
                    descargarDataGrid();
                    mostrarEventos();
                }
                //mostrarEventos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void cargarCursos()
        {
            cbbCurso.DisplayMember = "Nombre";
            cbbCurso.ValueMember = "idCurso";
            cbbCurso.DataSource = dominio.llenarCBBCursos();
        }

        private void cargarCursos(int idCurso)
        {
            cbbCurso.DisplayMember = "Nombre";
            cbbCurso.ValueMember = "idCurso";
            cbbCurso.DataSource = dominio.llenarCBBCursos(idCurso);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
