using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace TPWinForm_EquipoN
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulos articulo = null;

        
        
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        public FrmAltaArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";

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
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                decimal precio;
                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el precio.");
                    return;
                }
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.DescMarca = (Marcas)cboMarca.SelectedItem;
                articulo.DescCategoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = precio;


                if (articulo.Id != 0)
                {
                    negocio.ModifArt(articulo);
                    MessageBox.Show("Se modifico el Articulo");
                    
                }
                else
                {
                    negocio.AgregarArt(articulo);
                    MessageBox.Show("Se guardo el Articulo");
                }
                
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
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = articulosNegocio.listarCategorias();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                
                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.SelectedValue = articulo.DescMarca.Id;
                    cboCategoria.SelectedValue = articulo.DescCategoria.Id;
                    
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.DescMarca = (Marcas)cboMarca.SelectedItem;
                articulo.DescCategoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);


                if (articulo.Id != 0)
                {
                    negocio.ModifArt(articulo);
                    MessageBox.Show("Se modifico el Articulo");
                }
                else
                {
                    negocio.AgregarArt(articulo);
                    MessageBox.Show("Se guardo el Articulo");
                }
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
