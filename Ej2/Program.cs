namespace Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error: debes indicar el subcomando (ls, cat, newfile).");
                return;
            }

            string subcomando = args[0].ToLower();

            switch (subcomando)
            {
                case "ls":
                    EjecutarLs(args);
                    break;

                case "cat":
                    EjecutarCat(args);
                    break;

                case "newfile":
                    EjecutarNewFile(args);
                    break;

                default:
                    Console.WriteLine($"Error: subcomando {subcomando}");
                    break;
            }
        }


        public static void EjecutarLs(string[] args)
        {
            string ruta;

            if (args.Length > 1)
            {
                ruta = args[1];
            }
            else
            {
                ruta = ".";
            }

            if (!Directory.Exists(ruta))
            {
                Console.WriteLine($"Error: la ruta '{ruta}' no existe o no es un directorio.");
                return;
            }

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(ruta);

                Console.WriteLine($"\nContenido de {dirInfo.FullName}:\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                foreach (DirectoryInfo subcarpeta in dirInfo.GetDirectories())
                {
                    Console.WriteLine($"[DIR] {subcarpeta.Name}");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                foreach (FileInfo archivo in dirInfo.GetFiles())
                {
                    Console.WriteLine($"[FILE] {archivo.Name, -30} | {archivo.Length, 10} bytes");
                }

                Console.ResetColor();

            } catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: faltan permisos.");
            }
        }


        public static void EjecutarCat(string[] args)
        { 
            if (args.Length < 2)
            {
                Console.WriteLine($"Error: debes indicar el archivo a leer.");
                return;
            }

            string rutaArchivo = "";
            int limiteLineas = -1;

            if (args[1].StartsWith("-n"))
            {
                string numStr = args[1].Substring(2);

                if (int.TryParse(numStr, out int lineas))
                {
                    limiteLineas = lineas;
                }
                else
                {
                    Console.WriteLine("Error: el formato del número de líneas para -n no es válido.");
                    return;
                }

                if (args.Length > 2) 
                {
                    rutaArchivo = args[2];
                } 
                else
                {
                    Console.WriteLine("Error: falta indicar la ruta del archivo después de -n.");
                    return;
                }
            }
            else
            {
                rutaArchivo = args[1];
            }

            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine($"Error: el archivo '{rutaArchivo}' no existe.");
                return;
            }

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    int contadorLineas = 0;

                    while ((linea = sr.ReadLine()) != null && (limiteLineas == -1 || contadorLineas < limiteLineas))
                    {
                        Console.WriteLine(linea);
                        contadorLineas++;
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: no tienes permisos para leer este archivo.");
            }
}


        public static void EjecutarNewFile(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Error: uso incorrecto (Ejemplo: tool newfile archivo.txt \"Texto a escribir\").");
                return;
            }

            bool adjuntar = false;
            string rutaArchivo = "";
            string textoAEscribir = "";

            if (args.Length > 1 && args[1].ToLower() == "-a")
            {
                if (args.Length < 4)
                {
                    Console.WriteLine("Error: falta la ruta de texto, necesitamos 4 elementos.");
                    return;
                }
                adjuntar = true;
                rutaArchivo = args[2];
                textoAEscribir = args[3];
            } 
            else
            {
                if (args.Length < 3)
                {
                    Console.WriteLine("Error: uso incorrecto, necesitamos 3 argumentos.");
                    return;
                }
                rutaArchivo = args[1];
                textoAEscribir = args[2];
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, adjuntar)) 
                {
                    sw.WriteLine(textoAEscribir);
                    Console.WriteLine("Texto guardado correctamente en el archivo.");
                }
            } 
            catch (IOException ex)
            {
                Console.WriteLine("Error al escribir en el archivo: " + ex.Message);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: faltan permisos.");
            }
        }
    }
}