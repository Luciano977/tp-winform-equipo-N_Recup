
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_EquipoN
{
    public partial class ArtBusDet : Form
    {
        private ArticulosNegocio articulosNegocio = new ArticulosNegocio();

        public ArtBusDet()
        {
            InitializeComponent();

            this.Load += MenuMarcas_Load;

            btBuscar.Click += btBuscar_Click;
            btLimpiar.Click += btLimpiar_Click;
        }

        private void MenuMarcas_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Código");
            comboBox1.Items.Add("Nombre");
            comboBox1.Items.Add("Descripción");

            comboBox1.SelectedIndex = 0;

            ConfigurarGrilla();

            try
            {
                CargarArticulos(articulosNegocio.listar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void ConfigurarGrilla()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Descripcion", "Descripción");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Categoria", "Categoría");
            dataGridView1.Columns.Add("Precio", "Precio");

            dataGridView1.Columns["Codigo"].Width = 90;
            dataGridView1.Columns["Nombre"].Width = 130;
            dataGridView1.Columns["Descripcion"].Width = 150;
            dataGridView1.Columns["Marca"].Width = 100;
            dataGridView1.Columns["Categoria"].Width = 100;
            dataGridView1.Columns["Precio"].Width = 90;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void CargarArticulos(List<Articulos> lista)
        {
            dataGridView1.Rows.Clear();

            foreach (Articulos articulo in lista)
            {
                dataGridView1.Rows.Add(
                    articulo.Codigo,
                    articulo.Nombre,
                    articulo.Descripcion,
                    articulo.DescMarca.Descripcion,
                    articulo.DescCategoria.Descripcion,
                    articulo.Precio
                );
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBuscar.Text))
            {
                MessageBox.Show("Ingrese un texto para buscar.");
                textBuscar.Focus();
                return;
            }

            try
            {
                string criterio = comboBox1.SelectedItem.ToString();

                List<Articulos> lista = articulosNegocio.Buscar(
                    criterio,
                    textBuscar.Text.Trim()
                );

                CargarArticulos(lista);

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron artículos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();
            comboBox1.SelectedIndex = 0;

            try
            {
                CargarArticulos(articulosNegocio.listar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }

            textBuscar.Focus();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
