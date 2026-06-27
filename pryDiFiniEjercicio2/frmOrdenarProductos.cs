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
    public partial class frmOrdenarProductos : Form
    {
        public frmOrdenarProductos()
        {
            InitializeComponent();
        }

        clsArchivoProductos x = new clsArchivoProductos();
        private void frmOrdenarProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorCodigoAscendente();
                    }
                    else
                    {
                        x.OrdenarPorCodigoDescendente();
                    }
                    break;

                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorProductoAscendente();
                    }
                    else
                    {
                        x.OrdenarPorProductoDescendente();
                    }
                    break;

                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorStockAscendente();
                    }
                    else
                    {
                        x.OrdenarPorStockDescendente();
                    }
                    break;

                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        x.OrdenarPorPrecioAscendente();
                    }
                    else
                    {
                        x.OrdenarPorPrecioDescendente();
                    }
                    break;
            }

            dgvProductos.Rows.Clear();
            x.Listar(dgvProductos);
        }
    }
}
