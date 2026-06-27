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
    public partial class frmListarProductos : Form
    {
        public frmListarProductos()
        {
            InitializeComponent();
        }

        clsArchivoProductos x = new clsArchivoProductos();
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListarProductos_Load(object sender, EventArgs e)
        {
            x.Listar(dgvProductos);
            lblCantidadProductos.Text = x.CantidadProductos().ToString();
            lblTotalInventario.Text = x.TotalInventario().ToString();
            lblPromedioPrecio.Text = x.PromedioPrecio().ToString();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            MessageBox.Show("Archivo ordenado");
            x.Listar(dgvProductos);
        }
    }
}
