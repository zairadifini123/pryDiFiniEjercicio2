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
    public partial class frmGestionComercio : Form
    {
        public frmGestionComercio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProductos x = new frmListarProductos();
            x.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoStockMenor x = new frmListadoStockMenor();
            x.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProducto x = new frmAgregarProducto();
            x.ShowDialog();
        }

        private void ordenarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenarProductos x = new frmOrdenarProductos();
            x.ShowDialog();
        }
    }
}
