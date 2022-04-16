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
    public partial class ChildFormMaestro : Form
    {
        Dominio dominio = new Dominio();
        private string idMaestro = null;
        private bool modificar = false;
        private DataGridView dataGrid;

        public ChildFormMaestro()
        {
            InitializeComponent();
        }

        private void ChildFormMaestro_Load(object sender, EventArgs e)
        {
            mostrarEventos();
        }

        private void descargarDataGrid()
        {
            dataGridView1 = new DataGridView();
        }

        private void mostrarEventos()
        {
            dataGridView1.DataSource = dominio.mostrarMaestros(); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarMaestros(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), 
                        txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text);
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
                    dominio.actualizarMaestros(int.Parse(idMaestro), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text),
                        txtTelefono.Text, txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text);
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
                idMaestro = dataGridView1.CurrentRow.Cells["idMaestro"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione un evento. Por favor");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idMaestro = dataGridView1.CurrentRow.Cells["idMaestro"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar al usuario?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dominio.eliminarMaestros(int.Parse(idMaestro));
                    MessageBox.Show("Eliminado correctamente");
                    descargarDataGrid();
                    mostrarEventos();
                }
                //mostrarEventos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
    
}
