using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //frmAltaCategoria ventana = new frmAltaCategoria(); 
            //ventana.ShowDialog();
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

            /* TODO Etapa 2: sacar la categoría real de la fila seleccionada en dgvCategorias
            Categoria categoriaSeleccionada = new Categoria();
            frmAltaCategoria ventana = new frmAltaCategoria(categoriaSeleccionada);
            ventana.ShowDialog();*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná una categoría de la lista primero.");
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Seguro que querés eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                // TODO Etapa 2: llamar a CategoriaNegocio.eliminar() con el Id real de la fila seleccionada
                MessageBox.Show("Categoría eliminada (simulado).");
            }
        }
    }
}
