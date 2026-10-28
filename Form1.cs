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


namespace TPWinForm_EquipoN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btArticulos_Click(object sender, EventArgs e)
        {
            MenuArticulos ventana = new MenuArticulos();
            ventana.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas ventana = new FrmMarcas();
            ventana.ShowDialog();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias ventana = new FrmCategorias();
            ventana.ShowDialog();
        }
    }
}
