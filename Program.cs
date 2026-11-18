namespace ControlInventarioTecnoPuntoo
{
    internal class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine("=================================================================");
            Console.WriteLine("                           TECNOPUNTO                            ");
            Console.WriteLine("                       CONTROL DE INVENTARIO                     ");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("Bienvenido al sistema de control de inventario.");
            Console.WriteLine();

            Console.WriteLine("\nREGISTRO DEL PRODUCTO 1 \n");

        Console.WriteLine("Ingrese el código del producto:");
            string _codigo1 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del producto:");
            string _nombre1 = Console.ReadLine();
            while (_nombre1 == "")
            {
                Console.Write("\n¡Error! El nombre no puede estar vacío.\n Ingrese el nombre: ");
                _nombre1 = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el precio del producto:");
            decimal _precio1;
            while (!decimal.TryParse(Console.ReadLine(), out _precio1) || _precio1 <= 0)
            {
                Console.Write("\n¡Error! Precio inválido.\n Ingrese un precio mayor que cero: ");
            }

            Console.WriteLine("Ingrese la cantidad del producto:");
            int _cantidad1;
            while (!int.TryParse(Console.ReadLine(), out _cantidad1) || _cantidad1 < 0)
            {
                Console.Write("\n¡Error! Cantidad inválida.\n Ingrese una cantidad mayor o igual a cero: ");
            }

            Producto producto1 = new Producto(_codigo1, _nombre1, _precio1, _cantidad1  );
            Console.WriteLine();
            Console.WriteLine("    INFORMACIÓN DEL PRODUCTO REGISTRADO");
            Console.WriteLine("-------------------------------------------");
            producto1.MostrarInfo();
            Console.WriteLine();
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("\nREGISTRO DEL PRODUCTO 2\n");

            Console.WriteLine("Ingrese el código del producto:");
            string _codigo2 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del producto:");
            string _nombre2 = Console.ReadLine();
            while (_nombre2 == "")
            {
                Console.Write("\n¡Error! El nombre no puede estar vacío.\n Ingrese el nombre: ");
                _nombre2 = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el precio del producto:");
            decimal _precio2;
            while (!decimal.TryParse(Console.ReadLine(), out _precio2) || _precio2 <= 0)
            {
                Console.Write("\n¡Error! Precio inválido.\n Ingrese un precio mayor que cero: ");
            }

            Console.WriteLine("Ingrese la cantidad del producto:");
            int _cantidad2;
            while (!int.TryParse(Console.ReadLine(), out _cantidad2) || _cantidad2 < 0)
            {
                Console.Write("\n¡Error! Cantidad inválida.\n Ingrese una cantidad mayor o igual a cero: ");
            }

            Producto producto2 = new Producto(_codigo2, _nombre2, _precio2, _cantidad2);
            Console.WriteLine();
            Console.WriteLine("    INFORMACIÓN DEL PRODUCTO REGISTRADO");
            Console.WriteLine("-------------------------------------------");
            producto2.MostrarInfo();
            Console.WriteLine();
            Console.WriteLine("================================================================================================");
            Console.WriteLine("\nREGISTRO DEL PRODUCTO 3\n");
            Console.WriteLine("Ingrese el código del producto:");
            string _codigo3 = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del producto:");
            string _nombre3 = Console.ReadLine();
            while (_nombre3 == "")
            {
                Console.Write("\n¡Error! El nombre no puede estar vacío.\n Ingrese el nombre: ");
                _nombre3 = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el precio del producto:");
            decimal _precio3;
            while (!decimal.TryParse(Console.ReadLine(), out _precio3) || _precio3 <= 0)
            {
                Console.Write("\n¡Error! Precio inválido.\n Ingrese un precio mayor que cero: ");
            }

            Console.WriteLine("Ingrese la cantidad del producto:");
            int _cantidad3;
            while (!int.TryParse(Console.ReadLine(), out _cantidad3) || _cantidad3 < 0)
            {
                Console.Write("\n¡Error! Cantidad inválida.\n Ingrese una cantidad mayor o igual a cero: ");
            }

            Producto producto3 = new Producto(_codigo3, _nombre3, _precio3, _cantidad3);
            Console.WriteLine();
            Console.WriteLine("    INFORMACIÓN DEL PRODUCTO REGISTRADO");
            Console.WriteLine("-------------------------------------------");
            producto3.MostrarInfo();
            Console.WriteLine();
        }
    }
}
