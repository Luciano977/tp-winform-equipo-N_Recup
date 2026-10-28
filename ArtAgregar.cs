using System;
using System.Windows.Forms;
using negocio;
using dominio;


namespace TPWinForm_EquipoN
{
    public partial class ArtAgregar : Form
    {
        private Articulos articulo = null;
        public ArtAgregar()
        {
            InitializeComponent();
        }

        public ArtAgregar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            Articulos articuloaux = new Articulos();
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                articuloaux.Codigo = txtCodigo.Text;
                articuloaux.Nombre = txtNombre.Text;
                articuloaux.Descripcion = txtDescripcion.Text;
                articuloaux.DescMarca = (Marcas)cboMarca.SelectedItem;
                articuloaux.DescCategoria = (Categoria)cboCategoria.SelectedItem;
                articuloaux.Precio = decimal.Parse(txtPrecio.Text);

                negocio.AgregarArt(articuloaux);
                MessageBox.Show("Se guardo el Articulo");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
             
            }
        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ArtAgregar_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();

            try
            {
                cboMarca.DataSource = articulosNegocio.listarMarcas();
                cboCategoria.DataSource = articulosNegocio.listarCategorias();

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }
    }
}
