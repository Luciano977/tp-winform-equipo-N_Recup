using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_EquipoN
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.listar();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAltaCategoria ventana = new frmAltaCategoria();
            ventana.ShowDialog();

            CargarGrilla();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la lista primero.");
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;
            frmAltaCategoria ventana = new frmAltaCategoria(categoriaSeleccionada);
            ventana.ShowDialog();

            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la lista primero.");
                return;
            }

            Categoria categoriaSeleccionada = (Categoria)dgvCategorias.SelectedRows[0].DataBoundItem;

            DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.eliminar(categoriaSeleccionada.Id);
                CargarGrilla();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
