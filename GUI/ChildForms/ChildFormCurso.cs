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
            mostrarCursos();
            cargarMaestros();
            lblEstado.Visible = false;
        }

        private void mostrarCursos()
        {
            dataGridView1.DataSource = dominio.mostrarCursos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (modificar == false)
            {
                try
                {
                    dominio.insertarCursos(txtNombre.Text, int.Parse(cbbMaestro.SelectedValue.ToString()));
                    lblEstado.Text = "Se insertó correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;                    
                    mostrarCursos();
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
                    dominio.actualizarCursos(int.Parse(idCurso), txtNombre.Text, int.Parse(cbbMaestro.SelectedValue.ToString()));
                    lblEstado.Text = "Se modificó correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;                    
                    mostrarCursos();
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
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                modificar = true;
                idCurso = dataGridView1.CurrentRow.Cells["idCurso"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cbbMaestro.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["idMaestro"].Value.ToString());
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
                idCurso = dataGridView1.CurrentRow.Cells["idCurso"].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que quiere eliminar el curso?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dominio.eliminarCursos(int.Parse(idCurso));
                    lblEstado.Text = "Eliminado correctamente....";
                    lblEstado.ForeColor = Color.White;
                    lblEstado.Visible = true;                    
                    mostrarCursos();
                }
                //mostrarCursos();
            }
            else
            {
                lblEstado.Text = "Seleccione una fila, por favor....";
                lblEstado.ForeColor = Color.Red;
                lblEstado.Visible = true;
            }                
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
