using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedido
    {
        public string CodigoProducto { get; set; }
        public string Nombre_Producto { get; set;}
        public int Cantidad { get; set; }
        public string Nombre { get; set; }

        public Pedido()
        {
        }

        public Pedido(string codigoProducto, string nombre_Producto, int cantidad, string nombre)
        {
            CodigoProducto = codigoProducto;
            Nombre_Producto = nombre_Producto;
            Cantidad = cantidad;
            Nombre = nombre;
        }
    }
}
