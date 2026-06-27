using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiFiniEjercicio2
{
    internal class clsArchivoProductos
    {
        public string NombreArchivo = "Productos.csv";
        Decimal Total = 0;
        Int32 C = 0;

        private struct Productos
        {
            public Int32 Codigo;
            public String Producto;
            public Int32 Stock;
            public Decimal Precio;
        }

        private Productos[] VecProductos = new Productos[1500];
        private Int32 IND = 0;

        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecProductos[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecProductos[IND].Producto = VecDatos[1];
                VecProductos[IND].Stock = Convert.ToInt32(VecDatos[2]);
                VecProductos[IND].Precio = Convert.ToDecimal(VecDatos[3]);
                IND++;
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        private void OrdenarVector()
        {
            Productos aux;

            for (Int32 c = 0; c < IND - 1; c++)
            {
                for (Int32 i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Codigo > VecProductos[i + 1].Codigo)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

        }

        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND; i++)
            {
                AD.Write(VecProductos[i].Codigo);
                AD.Write(";");
                AD.Write(VecProductos[i].Producto);
                AD.Write(";");
                AD.Write(VecProductos[i].Stock);
                AD.Write(";");
                AD.WriteLine(VecProductos[i].Precio);
            }

            AD.Close();
            AD.Dispose();

        }

        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }

        public void Grabar(string Cod, string Prod, string Sto, string Pre)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(Cod);
            AD.Write(";");
            AD.Write(Prod);
            AD.Write(";");
            AD.Write(Sto);
            AD.Write(";");
            AD.WriteLine(Pre);
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadProductos()
        {
            string DatosLeidos;
            Int32 c = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return c;
        }

        public Decimal TotalInventario()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total = Total + (Convert.ToInt32(VecDatos[2]) * Convert.ToDecimal(VecDatos[3]));
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return Total;
        }

        public Decimal PromedioPrecio()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Decimal Total = 0;
            Int32 c = 0;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                c++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return Total / c;
        }

        public void ListarStockBajo(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToInt32(VecDatos[2]) < 10)
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                }
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadStockBajo()
        {
            string[] VecDatos = new string[4];
            string DatosLeidos;
            Int32 c = 0;
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) < 10)
                {
                    c++;
                }
                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();

            return c;
        }

        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            Int32 Cantidad = 0;
            Decimal TotalInventario = 0;
            Decimal TotalPrecio = 0;    

            StreamWriter Reporte = new StreamWriter("ReporteProductos.csv", false, Encoding.UTF8);

            Reporte.WriteLine("Listado de productos");
            Reporte.WriteLine("");
            Reporte.WriteLine("Código;Producto;Stock;Precio");

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Reporte.Write(VecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[2]);
                Reporte.Write(";");
                Reporte.WriteLine(VecDatos[3]);

                DatosLeidos = AD.ReadLine();
                Cantidad++;
                TotalInventario = TotalInventario + (Convert.ToInt32(VecDatos[2]) * Convert.ToDecimal(VecDatos[3]));
                TotalPrecio = TotalPrecio + Convert.ToDecimal(VecDatos[3]);
            }

            AD.Close();
            AD.Dispose();
            Reporte.WriteLine(" ");
            Reporte.Write("Total inventario:;;");
            Reporte.WriteLine(TotalInventario);

            Reporte.Write("Total Clientes:;;");
            Reporte.WriteLine(Cantidad);

            Reporte.Write("Promedio precio;;");
            Reporte.WriteLine(TotalPrecio/ Cantidad);



            Reporte.Close();
            Reporte.Dispose();
        }

        public void OrdenarPorCodigoAscendente()
        {
            CargarVector(); //Para cargar los datos de los clientes

            Productos aux; //Crea una variable nueva para guardar temporalmente un cliente mientras se intercambian las posiciones del vector

            for (int c = 0; c < IND - 1; c++) //Recorre el vector mientras haya clientes y asi asegurarse que queden ordenados   
            {
                for (int i = 0; i < IND - c - 1; i++) //Para comparar cada elemento con el que le sigue
                {
                    if (VecProductos[i].Codigo > VecProductos[i + 1].Codigo) //Compara codigos de dos clientes, si el actual es mayor que el siguiente, se intercambian 
                    {
                        aux = VecProductos[i]; //Guarda el cliente actual en la variable temporal
                        VecProductos[i] = VecProductos[i + 1]; //El cliente que sigue pasa a ocupar la posición actual
                        VecProductos[i + 1] = aux; // Lo que habia en aux pasa a la siguiente posición 
                    }
                }
            }

            ReescribirArchivo(); //Una vez ordenado el vector, se reescribe el archivo con los datos en el nuevo orden
        }

        public void OrdenarPorCodigoDescendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - c - 1; i++)
                {
                    if (VecProductos[i].Codigo < VecProductos[i + 1].Codigo) //Si el código actual es menor que el siguiente, significa que están al revés
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorProductoAscendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Producto.CompareTo(VecProductos[i + 1].Producto) > 0)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorProductoDescendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Producto.CompareTo(VecProductos[i + 1].Producto) < 0)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorStockAscendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Stock > VecProductos[i + 1].Stock)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorStockDescendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Stock < VecProductos[i + 1].Stock)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorPrecioAscendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Precio > VecProductos[i + 1].Precio)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

        public void OrdenarPorPrecioDescendente()
        {
            CargarVector();

            Productos aux;

            for (int c = 0; c < IND - 1; c++)
            {
                for (int i = 0; i < IND - 1; i++)
                {
                    if (VecProductos[i].Precio < VecProductos[i + 1].Precio)
                    {
                        aux = VecProductos[i];
                        VecProductos[i] = VecProductos[i + 1];
                        VecProductos[i + 1] = aux;
                    }
                }
            }

            ReescribirArchivo();
        }

    }
}
