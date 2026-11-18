using System;
using System.Collections.Generic;
using System.Text;

namespace ControlInventarioTecnoPuntoo
{
    internal class Producto
    {

        public string Codigo { get; set; }  
        private string _nombre;
        public string Nombre
        { 
        get { return _nombre; }
        set
            {
                if (value.Length > 0)
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("¡Error! El nombre no puede estar vacío.");
                }
            }

        }

        public decimal _precio;
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value > 0)
                {
                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("¡Error! El precio debe ser mayor a cero.");
                }
            }
        }

        public int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value >= 0)
                {
                    _cantidad = value;
                }
                else
                {
                    throw new ArgumentException("¡Error! La cantidad no puede ser negativa.");
                }
            }
        }

        public Producto (string _codigo, string _nombre, decimal _precio, int _cantidad)
        {

            Codigo = _codigo;
            Nombre = _nombre;
            Precio = _precio;
            Cantidad = _cantidad;


        }

        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public void MostrarInfo()
        { 
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: $ {Precio} DOP");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Valor Total: $ {ValorTotal} DOP");




        }









    }
}
