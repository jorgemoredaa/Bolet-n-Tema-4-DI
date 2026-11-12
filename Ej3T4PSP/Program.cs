namespace Ej3T4PSP
{
    public delegate double OperacionDouble(double numero);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número: ");
            if (!double.TryParse(Console.ReadLine(), out double num))
            {
                Console.WriteLine("Número no válido.");
                return;
            }

            Console.WriteLine("¿Que deseas calcular?");
            Console.WriteLine("1. Cuadrado de un número.");
            Console.WriteLine("2. Cubo de un número.");
            Console.WriteLine("Escoge una opción (1 o 2)");
            string opcion = Console.ReadLine();

            OperacionDouble op = null;

            if (opcion.Equals("1"))
            {
                op = x => x * x;
            }
            else if (opcion.Equals("2"))
            {
                op = x => x * x * x;
            }
            else
            {
                Console.WriteLine("Opción no válida, debes escoger la 1 o la 2.");
                return;
            }

            double resultado = op(num);

            Console.WriteLine($"El resultado de la operación es: {resultado}");
        }
    }
}
