using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniEjercicio2
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }

        clsArchivoProductos x = new clsArchivoProductos();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtCodigo.Text, txtProducto.Text, txtStock.Text, txtPrecio.Text);
            MessageBox.Show("Datos cargados correctamente");
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtProducto.Text != "" && txtStock.Text != "" && txtPrecio.Text != "")
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar(); 
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
    }
}
