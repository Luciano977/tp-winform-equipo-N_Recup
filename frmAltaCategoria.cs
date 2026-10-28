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
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;

        public frmAltaCategoria()
        {
            InitializeComponent();
        }
        public frmAltaCategoria(Categoria categoria)
        { 
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría"; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categoria == null)
                categoria = new Categoria();

            categoria.Descripcion = txtDescripcion.Text;

            CategoriaNegocio negocio = new CategoriaNegocio();

            if (categoria.Id != 0)
                negocio.modificar(categoria);
            else
                negocio.agregar(categoria);

            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
