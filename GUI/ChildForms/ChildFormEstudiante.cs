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
            mostrarEstudiantes();
            cargarCursos();
            lblEstado.Visible = false;
        }

        private void mostrarEstudiantes()
        {
            dataGridView1.DataSource = dominio.mostrarEstudiantes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarEstudiantes(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), Presentación.sinFormatoMatricula(txtMatricula.Text), 
                        Presentación.sinFormatoTelefono(txtTelefono.Text), txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text, int.Parse(cbbCurso.SelectedValue.ToString()));
                    lblEstado.Text = "¡Se insertó correctamente!....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;
                    mostrarEstudiantes();
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
                    dominio.actualizarEstudiantes(int.Parse(idEstudiante), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), Presentación.sinFormatoMatricula(txtMatricula.Text),
                        Presentación.sinFormatoTelefono(txtTelefono.Text), txtDireccion.Text, txtEmail.Text, txtUsuario.Text, txtContraseña.Text, int.Parse(cbbCurso.SelectedValue.ToString()));
                    lblEstado.Text = "¡Se modificó correctamente!....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;
                    mostrarEstudiantes();
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
            txtMatricula.Text = "0000-00000";
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
                string matricula = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                txtMatricula.Text = Presentación.formatoMatricula(matricula);
                string telefono = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtTelefono.Text = Presentación.formatoTelefono(telefono);
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
                cbbCurso.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["Curso"].Value.ToString());
                idEstudiante = dataGridView1.CurrentRow.Cells["idEstudiante"].Value.ToString();
            }
            else
            {
                lblEstado.Text = "Seleccione una fila. Por favor....";
                lblEstado.ForeColor = Color.Red;
                lblEstado.Visible = true;
            }   
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
                    lblEstado.Text = "Eliminado correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;
                    mostrarEstudiantes();
                }
                //mostrarEstudiantes();
            }
            else
            {
                lblEstado.Text = "Seleccione una fila, por favor....";
                lblEstado.ForeColor = Color.Red;
                lblEstado.Visible = true;
            }                
        }

        private void cargarCursos()
        {
            cbbCurso.DisplayMember = "Nombre";
            cbbCurso.ValueMember = "idCurso";
            cbbCurso.DataSource = dominio.llenarCBBCursos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
