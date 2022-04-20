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
    public partial class ChildFormCurso : Form
    {
        Dominio dominio = new Dominio();
        private string idCurso = null;
        private bool modificar = false;
        private DataGridView dataGrid;
        private int textCBB;

        public ChildFormCurso()
        {
            InitializeComponent();
        }

        private void ChildFormCurso_Load(object sender, EventArgs e)
        {
            mostrarEventos();
            cargarMaestros();
        }

        private void descargarDataGrid()
        {
            dataGridView1 = new DataGridView();
        }

        private void mostrarEventos()
        {
            dataGridView1.DataSource = dominio.mostrarCursos(); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarCursos(txtNombre.Text, int.Parse(cbbMaestro.SelectedValue.ToString()));
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
                    dominio.actualizarCursos(int.Parse(idCurso), txtNombre.Text, int.Parse(cbbMaestro.SelectedValue.ToString()));
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
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                modificar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cbbMaestro.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["idMaestro"].Value.ToString());
            }
            else
                MessageBox.Show("Seleccione una fila. Por favor");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCurso = dataGridView1.CurrentRow.Cells["idCurso"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar el curso?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dominio.eliminarCursos(int.Parse(idCurso));
                    MessageBox.Show("Eliminado correctamente");
                    descargarDataGrid();
                    mostrarEventos();
                }
                //mostrarEventos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void cargarMaestros()
        {
            cbbMaestro.DisplayMember = "Nombre";
            cbbMaestro.ValueMember = "idMaestro";
            cbbMaestro.DataSource = dominio.llenarCBBMaestros();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
