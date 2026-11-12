namespace Ej4T4PSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userprofile = Environment.GetEnvironmentVariable("userprofile");
            string rutaArchivo = Path.Combine(userprofile, "datos.txt");

            if (!File.Exists(rutaArchivo))
            {
                string[] contenido =
                {
                    "5,2,-8,1,20,-4",
                    "Sol,Luna,Estrella,Cielo,La,Si,Do"
                };

                File.WriteAllLines(rutaArchivo, contenido);
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);

            if (lineas.Length < 2)
            {
                Console.WriteLine("El archivo no tiene el formato esperado.");
                return;
            }

            int[] numbers = Array.ConvertAll(lineas[0].Split(","), x => int.Parse(x));
            string[] words = lineas[1].Split(",");


            Console.WriteLine("\n--TAREAS CON NUMBERS--");
            string hayNegativos = Array.Exists(numbers, x => x < 0) ? "Si" : "No";
            Console.WriteLine($"¿Hay números negativos? {hayNegativos}");

            int[] impares = Array.FindAll(numbers, x => x % 2 != 0);
            Console.WriteLine("\nNúmeros impares:");
            foreach (var impar in impares)
            {
                Console.Write(impar + ", ");
            }
            Console.WriteLine();

            int indice = Array.FindIndex(numbers, x => x > 10);
            Console.WriteLine($"\nPosición del último número mayor que 10: {indice}");

            int ultimo = Array.FindLast(numbers, x => x > 0);
            Console.WriteLine($"\nValor del último número positivo: {ultimo}");

            int numsPositivosDivisibles5 = Array.FindAll(numbers, x => x > 0 && x % 5 == 0).Length;
            Console.WriteLine($"\nCantidad de números positivos y divisibles entre 5: {numsPositivosDivisibles5}\n");


            Console.WriteLine("\n--TAREAS CON WORDS--");
            string primera4Carac = Array.Find(words, w => w.Length > 4);
            Console.WriteLine($"La primera palabra encontrada con más de 4 caracteres es: {primera4Carac}");

            string[] todasAMayus = Array.ConvertAll(words, w => w.ToUpper());
            Console.WriteLine("\nPalabras en mayúsculas:");
            foreach (var word in todasAMayus)
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();

            string palabra2CaracA = Array.Exists(words, w => w.Length == 2 && w[1] == 'A') ? "Si" : "No";
            Console.WriteLine($"\n¿Existe alguna palabra de 2 caracteres con el segundo siendo una 'A'? {palabra2CaracA}");

            int posicionPrimeraE = Array.FindIndex(words, w => w[0] == 'E');
            Console.WriteLine($"\nPosición de la primera palabra que empieza por 'E': {posicionPrimeraE}");
        }
    }
}
