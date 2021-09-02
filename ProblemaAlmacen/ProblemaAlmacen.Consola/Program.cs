using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemaAlmacen.Validacion;

namespace ProblemaAlmacen.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaro la variable producto1 de la clase Producto
            Producto producto1;
            //Instancio la clase Producto => genero un objeto
            producto1 = new Producto();

            producto1.CodProducto = 001;

            Console.WriteLine(producto1.CodProducto);

        }
    }
}
