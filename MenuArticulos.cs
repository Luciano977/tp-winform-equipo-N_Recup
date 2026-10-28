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
    public partial class MenuArticulos : Form
    {
        public MenuArticulos()
        {
            InitializeComponent();
        }

        private void btModElimArt_Click(object sender, EventArgs e)
        {

        }

        private void listarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ArtListar))
                    return;
            }
            ArtListar ventana= new ArtListar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ArtAgregar))
                    return;
            }
            ArtAgregar ventana= new ArtAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void busquedaYDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ArtBusDet))
                    return;
            }
            ArtBusDet ventana = new ArtBusDet();
            ventana.MdiParent= this;
            ventana.Show();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ArtModElim))
                    return;
            }
            ArtModElim ventana = new ArtModElim();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
