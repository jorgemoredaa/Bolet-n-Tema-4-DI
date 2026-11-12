namespace Ej5T4PSP
{
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            string exito = MenuGenerator(
                new string[] { "op1", "op2", "op3" },
                new MyDelegate[] {
                    () =>Console.WriteLine("A"),
                    () =>Console.WriteLine("B"),
                    () =>Console.WriteLine("C")
                }
            ) ? "Si" : "No";

            Console.WriteLine($"¿Menú creado con éxito? {exito}"); 
        }

        public static bool MenuGenerator(string[] opciones, MyDelegate[] funciones)
        {
            if (opciones == null || funciones == null || opciones.Length != funciones.Length || opciones.Length == 0)
            {
                return false;
            }

            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("--MENÚ PRINCIPAL--");

                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }

                int opcionSalir = opciones.Length + 1;
                Console.WriteLine($"{opcionSalir}. Exit");

                Console.WriteLine("Elige una opción: ");

                if (int.TryParse(Console.ReadLine(), out int seleccion)) 
                {
                    if (seleccion == opcionSalir)
                    {
                        Console.WriteLine("Saliendo del programa...");
                        salir = true;
                    }
                    else if (seleccion >= 1 && seleccion <= opciones.Length)
                    {
                        funciones[seleccion - 1]();

                        Console.WriteLine("\nPulsa cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Error: selección fuera de rango. Pulsa una tecla para reintentar.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Error: debes introducir un número válido. Pulsa una tecla para reintentar.");
                    Console.ReadKey();
                }
            }
            return true;
        }
    }
}
