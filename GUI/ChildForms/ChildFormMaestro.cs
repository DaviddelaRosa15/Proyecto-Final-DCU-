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
            mostrarMaestros();
            lblEstado.Visible = false;
        }

        private void mostrarMaestros()
        {
            dataGridView1.DataSource = dominio.mostrarMaestros();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarMaestros(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), 
                        Presentación.sinFormatoTelefono(txtTelefono.Text), txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text);
                    lblEstado.Text = "Se insertó correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;
                    mostrarMaestros();
                    clearForm();
                }
                catch (Exception ex)
                {
                    lblEstado.Text = "Revise sus datos....";
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Visible = true;
                }
            }
            //EDITAR
            if (modificar == true)
            {
                try
                {
                    dominio.actualizarMaestros(int.Parse(idMaestro), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text),
                        Presentación.sinFormatoTelefono(txtTelefono.Text), txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text);
                    lblEstado.Text = "Se modificó correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;
                    mostrarMaestros();
                    clearForm();
                    modificar = false;
                }
                catch (Exception ex)
                {
                    lblEstado.Text = "Revise sus datos....";
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Visible = true;
                }
            }
        }



        private void clearForm()
        {
            txtNombre.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtTelefono.Text = "(000)-000-0000";
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
                string telefono = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtTelefono.Text = Presentación.formatoTelefono(telefono);
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                idMaestro = dataGridView1.CurrentRow.Cells["idMaestro"].Value.ToString();
            }
            else
            {
                lblEstado.Text = "Seleccione una fila, por favor....";
                lblEstado.ForeColor = Color.Red;
                lblEstado.Visible = true;
            }     
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
                    lblEstado.Text = "Eliminado correctamente....";
                    lblEstado.ForeColor = Color.White;
                    mostrarMaestros();
                }
                //mostrarMaestros();
            }
            else
            {
                lblEstado.Text = "Seleccione una fila, por favor....";
                lblEstado.ForeColor = Color.Red;
                lblEstado.Visible = true;
            }                
        }
    }
    
}
