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
    public partial class MaestroChildFormCalificacion : Form
    {
        Dominio dominio = new Dominio();
        private string idCalificacion;

        public MaestroChildFormCalificacion()
        {
            InitializeComponent();
            txtCalificacion.Size = new System.Drawing.Size(100,30);
        }

        private void MaestroChildFormCalificacion_Load(object sender, EventArgs e)
        {
            mostrarCalificaciones();
        }

        private void mostrarCalificaciones()
        {
            dataGridView1.DataSource = dominio.mostrarCalificaciones(UserCache.id); ;
        }

        private void txtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnSave_Click(sender, e);
            }
        }

        private void clearForm()
        {
            lblNombre.Text = "";
            lblMatricula.Text = "";
            lblCurso.Text = "";
            txtCalificacion.Clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblNombre.Visible = true;
                lblMatricula.Visible = true;
                lblCurso.Visible = true;
                idCalificacion = dataGridView1.CurrentRow.Cells["idCalificacion"].Value.ToString();
                lblNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                lblMatricula.Text = dataGridView1.CurrentRow.Cells["Matricula"].Value.ToString();
                lblCurso.Text = dataGridView1.CurrentRow.Cells["Curso"].Value.ToString();
                txtCalificacion.Text = dataGridView1.CurrentRow.Cells["notaFinal"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila. Por favor");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
                {
                    dominio.actualizarCalificaciones(int.Parse(idCalificacion), int.Parse(txtCalificacion.Text));
                    MessageBox.Show("¡Se modificó correctamente!");
                    mostrarCalificaciones();
                    clearForm();
                    lblNombre.Visible = false;
                    lblMatricula.Visible = false;
                    lblCurso.Visible = false;
            }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }
        }
    }
    
}
