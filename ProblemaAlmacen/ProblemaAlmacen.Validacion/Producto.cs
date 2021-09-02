using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaAlmacen.Validacion
{
    public class Producto
    {
        //atributos de la clase producto
        private int _codProducto;
        private string _nombreProducto;
        private decimal _precioProducto;
        private string _categoriaProducto;

        //Escondo los "detalles" mediante encapsulamiento
        public int CodProducto
        {
            get
            { 
                return _codProducto; 
            }
            set
            { 
                _codProducto =  value;
            }        
        }

        public string NombreProducto
        {
            get
            { 
                return _nombreProducto; 
            }
            set
            { 
                _nombreProducto = value; 
            }
        }
        public decimal PrecioProducto
        {
            get
            { 
                return _precioProducto; 
            }
            set
            { 
                _precioProducto = value; 
            }
        }

        public string CategoriaProducto
        {
            get
            { 
                return _categoriaProducto; 
            }
            set
            { 
                _categoriaProducto = value; 
            }
        }



    }
}
