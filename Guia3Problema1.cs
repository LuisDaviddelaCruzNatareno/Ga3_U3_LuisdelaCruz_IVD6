internal class Program
{
    static string[,] productos = new string[10, 3];
    private static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Registrar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Actualizar");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=== REGISTRAR PRODUCTOS ===");
                    Registrar();
                    Pausa();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("=== MOSTRAR PRODUCTOS ===");
                    MostrarP();
                    Pausa();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("=== ACTUALIZAR PRODUCTOS ===");
                    Actualizar();
                    Pausa();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("=== ELIMINAR PRODUCTOS ===");
                    Eliminar();
                    Pausa();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    Pausa();
                    break;
            }
        } while (opcion != 5);
    }

    static void Registrar()
    {
        bool registrado = false;
        for (int i = 0; i < 10; i++)
        {
            if (string.IsNullOrEmpty(productos[i, 0]))
            {
                Console.Write("Código: ");
                productos[i, 0] = Console.ReadLine();
                Console.Write("Nombre: ");
                productos[i, 1] = Console.ReadLine();
                Console.Write("Cantidad: ");
                productos[i, 2] = Console.ReadLine();
                Console.WriteLine("\nProducto registrado.");
                registrado = true;
                break;
            }
        }
        if (!registrado)
        {
            Console.WriteLine("\nLa matriz está llena.");
        }
    }

    static void MostrarP()
    {
        Console.WriteLine("\nCODIGO\tNOMBRE\t\tCANTIDAD");
        Console.WriteLine("---------------------------------");
        for (int i = 0; i < 10; i++)
        {
            if (!string.IsNullOrEmpty(productos[i, 0]))
            {
                Console.WriteLine(
                    productos[i, 0] + "\t" +
                    productos[i, 1] + "\t\t" +
                    productos[i, 2]);
            }
        }
    }

    static void Actualizar()
    {
        string codigo;
        bool encontrado = false;
        Console.Write("Código a buscar: ");
        codigo = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            if (productos[i, 0] == codigo)
            {
                Console.Write("Nuevo nombre: ");
                productos[i, 1] = Console.ReadLine();
                Console.Write("Nueva cantidad: ");
                productos[i, 2] = Console.ReadLine();
                Console.WriteLine("\nRegistro actualizado.");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("\nCódigo no encontrado.");
        }
    }

    static void Eliminar()
    {
        string codigo;
        bool encontrado = false;
        Console.Write("Código a eliminar: ");
        codigo = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            if (productos[i, 0] == codigo)
            {
                productos[i, 0] = "";
                productos[i, 1] = "";
                productos[i, 2] = "";
                Console.WriteLine("\nRegistro eliminado.");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("\nCódigo no encontrado.");
        }
    }

    static void Pausa()
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}