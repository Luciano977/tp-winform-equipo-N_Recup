using dominio;
using negocio;
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
    public partial class FrmArticulos : Form
    {
        private ArticulosNegocio ArticuloNegocios = new ArticulosNegocio();
        private int seleccionado;
        private List<Articulos> listaArticulo;
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            
        }
        /*
        private void btListar_Click(object sender, EventArgs e)
        {
        }*/
        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            ///pxbArticulos.Load(listaArticulo[0].);
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo ventana = new FrmAltaArticulo();
            ventana.ShowDialog();
            CargarGrilla();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ArtBusDet ventana = new ArtBusDet();
            ventana.ShowDialog();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un artículo
            if (dgvArticulos.CurrentRow == null || dgvArticulos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Obtengo los datos del artículo seleccionado
            DataGridViewRow filaSeleccionada = dgvArticulos.CurrentRow;
            // Obtengo el ID del artículo seleccionado
            string codigoArticulo = filaSeleccionada.Cells["Codigo"].Value.ToString();
            //alternativamente por nombre
            //string nombreArticulo = filaSeleccionada.Cells["Nombre"].Value.ToString();

            // Muestro un cuadro de diálogo de confirmación
            DialogResult resultado = MessageBox.Show($"¿Está seguro de eliminar el artículo con código {codigoArticulo}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si el usuario confirma la eliminación, procedo a eliminar el artículo

            if (resultado == DialogResult.Yes)
            {
                ArticulosNegocio negocio = new ArticulosNegocio();
                Articulos seleccionado;
                try
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.ElimArt(seleccionado.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            CargarGrilla();
        }
      
        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            }
        private void CargarGrilla()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgvArticulos.DataSource = negocio.listar();
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
        }
    }
}

               

   