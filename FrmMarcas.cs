using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_EquipoN
{
    public partial class FrmMarcas : Form
    {
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        private int idMarcaSeleccionada;

        public FrmMarcas()
        {
            InitializeComponent();

            txtDescripcion.MaxLength = 50;
        }

        private void LimpiarFormulario()
        {
            txtDescripcion.Clear();

            idMarcaSeleccionada = 0;
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgvMarcas.Rows.Clear();

            List<Marcas> lista = marcaNegocio.Listar();

            foreach (Marcas marca in lista)
            {
                dgvMarcas.Rows.Add(marca.Id, marca.Descripcion);
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
              Close();

        }

        private void dgvMarcas_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idMarcaSeleccionada = Convert.ToInt32(

                    dgvMarcas.Rows[e.RowIndex].Cells["columId"].Value
                );

                txtDescripcion.Text = dgvMarcas.Rows[e.RowIndex]

                    .Cells["colDescripcion"].Value?.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción.");
                return;
            }

            string descripcion = txtDescripcion.Text.Trim();

            if (marcaNegocio.Existe(descripcion))
            {
                MessageBox.Show("La marca ya existe!");

                return;
            }

            marcaNegocio.Agregar(descripcion);

            MessageBox.Show("marca agregada correctamente!");

            LimpiarFormulario();
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idMarcaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una marca!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción.");
                return;
            }

            marcaNegocio.Modificar(
                idMarcaSeleccionada,
                txtDescripcion.Text.Trim()
            );

            MessageBox.Show("Marca modificada correctamente.");

            LimpiarFormulario();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMarcaSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una marca.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(

                "Está seguro de eliminar la marca seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                marcaNegocio.Eliminar(idMarcaSeleccionada);

                MessageBox.Show("Marca eliminada correctamente.");

                LimpiarFormulario();
                CargarGrilla();
            }
        }
        

        private void lblMarcas_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void lblDescripcion_Click(object sender, EventArgs e) { }
    }
}