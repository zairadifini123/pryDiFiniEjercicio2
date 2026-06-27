using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniEjercicio2
{
    public partial class frmListadoStockMenor : Form
    {
        public frmListadoStockMenor()
        {
            InitializeComponent();
        }

        clsArchivoProductos x = new clsArchivoProductos();
        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmListadoStockMenor_Load(object sender, EventArgs e)
        {
            x.ListarStockBajo(dgvProductos);
            lblCantidadProductos.Text = x.CantidadStockBajo().ToString();
            lblTotalInventario.Text = x.TotalInventario().ToString();
            lblPromedioPrecio.Text = x.PromedioPrecio().ToString();
        }
    }
}
