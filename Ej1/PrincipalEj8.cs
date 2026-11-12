using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ej7
{
    internal class PrincipalEj8
    {
        static void Main(string[] args)
        {
            string rutaCarpeta = Environment.ExpandEnvironmentVariables("%APPDATA%");
            string rutaArchivo = rutaCarpeta + "\\astros_datos.txt";

            List<Astro> astros = new List<Astro>();

            if (File.Exists(rutaArchivo))
            {
                try
                {
                    StreamReader sr = new StreamReader(rutaArchivo);
                    string linea = sr.ReadLine();

                    while (linea != null)
                    {
                        string[] partesPrincipales = linea.Split(":");
                        if (partesPrincipales.Length == 2)
                        {
                            string tipo = partesPrincipales[0].Trim();
                            string restoDatos = partesPrincipales[1].Trim();
                            string[] datos = restoDatos.Split(";");

                            if (tipo == "Planeta")
                            {
                                if (datos.Length == 4)
                                {
                                    bool nombreValido = !string.IsNullOrWhiteSpace(datos[0]);
                                    bool radioValido = double.TryParse(datos[1].Trim(), out double radioParse);
                                    bool gaseosoValido = bool.TryParse(datos[2].Trim(), out bool gaseosoParse);
                                    bool numSatelitesValido = int.TryParse(datos[3].Trim(), out int numSatelitesParse);

                                    if (nombreValido && radioValido && gaseosoValido && numSatelitesValido)
                                    {
                                        Planeta planetaLeido = new Planeta();
                                        planetaLeido.Nombre = datos[0].Trim();
                                        planetaLeido.Radio = radioParse;
                                        planetaLeido.Gaseoso = gaseosoParse;
                                        planetaLeido.NumSatelites = numSatelitesParse;
                                        astros.Add(planetaLeido);
                                    }
                                    else
                                    {
                                        Console.WriteLine("ATENCIÓN: Se ha ignorado una línea de planeta con formato incorrecto.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("ATENCIÓN: Al planeta le faltan campos.");
                                }
                            }
                            
                            else if (tipo == "Cometa" && datos.Length == 2)
                            {
                                Cometa cometaLeido = new Cometa();
                                cometaLeido.Nombre = datos[0].Trim();
                                cometaLeido.Radio = Convert.ToDouble(datos[1].Trim());

                                astros.Add(cometaLeido);
                            }
                        }

                        linea = sr.ReadLine();
                    }

                    sr.Close();
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Error: no tienes permisos de acceder o modificar estos archivos.");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error al cargar los datos: " + e.Message);
                }
            }

            int opcion = 0;

            do
            {
                Console.WriteLine("\nMENÚ DE OPCIONES");
                Console.WriteLine("1. Añade planeta");
                Console.WriteLine("2. Añade Cometa");
                Console.WriteLine("3. Mostrar datos");
                Console.WriteLine("4. Incrementar/Decrementar Nº de satélites");
                Console.WriteLine("5. Eliminar no terraformables");
                Console.WriteLine("6. Salir del programa");
                Console.WriteLine("\nIntroduce una opción...");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        Planeta planetaNuevo = new Planeta();
                        Console.WriteLine("¿El planeta es gaseoso? (s/n)");
                        planetaNuevo.Gaseoso = (Console.ReadLine().ToLower() == "s") ? true : false;
                     
                        Console.WriteLine("Dime su nombre.");
                        planetaNuevo.Nombre = Console.ReadLine();

                        Console.WriteLine("Dime su radio.");
                        double radioPlaneta;
                        while (!double.TryParse(Console.ReadLine(), out radioPlaneta))
                        {
                            Console.WriteLine("Error: introduce un número válido.");
                        }
                        planetaNuevo.Radio = radioPlaneta;

                        Console.WriteLine("¿Cuantas lunas tiene?");
                        int lunas;
                        while (!int.TryParse(Console.ReadLine(), out lunas))
                        {
                            Console.WriteLine("Error: introduce un número válido.");
                        }
                        planetaNuevo.NumSatelites = lunas;

                        astros.Add(planetaNuevo);
                        break;

                    case 2:
                        Cometa cometaNuevo = new Cometa();
                        Console.WriteLine("Dime el nombre del cometa");
                        string nombre = Console.ReadLine();
                        cometaNuevo.Nombre = nombre;

                        Console.WriteLine("Dime ahora su radio");
                        double radioCometa;
                        while (!double.TryParse(Console.ReadLine(), out radioCometa))
                        {
                            Console.WriteLine("Error: introduce un número");
                        }
                        cometaNuevo.Radio = radioCometa;

                        astros.Add(cometaNuevo);
                        break;

                    case 3:
                        foreach (var i in astros)
                        {
                            if (i is Cometa)
                            {
                                Console.WriteLine("El nombre del cometa es " + i.Nombre);
                            }
                            else if (i is Planeta)
                            {
                                Console.WriteLine("El nombre del planeta es " + i.ToString());
                            }

                            if (i is ITerraformable)
                            {
                                Console.WriteLine("El astro es habitable");
                            }
                            else
                            {
                                Console.WriteLine("El astro NO es habitable");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Indica el astro al que le quieres manipular el número de satélites");
                        string respuesta = Console.ReadLine();

                        int indice = astros.FindIndex(a => a.Nombre.Equals(respuesta, StringComparison.OrdinalIgnoreCase));

                        if (indice != -1 && astros[indice] is Planeta planetaSeleccionado)
                        {
                            Console.WriteLine("¿Desea aumentar (+) o decrementar (-) su número de satélites?");
                            string operador = Console.ReadLine();

                            if (operador == "+")
                            {
                                Console.WriteLine("Nº de satélites antes: " + planetaSeleccionado.NumSatelites);
                                planetaSeleccionado++;
                                Console.WriteLine("Satélites incrementados:");
                                Console.WriteLine(planetaSeleccionado.NumSatelites);
                            }
                            else if (operador == "-")
                            {
                                Console.WriteLine("Nº de satélites antes: " + planetaSeleccionado.NumSatelites);
                                planetaSeleccionado--;
                                Console.WriteLine("Satélites decrementados");
                                Console.WriteLine(planetaSeleccionado.NumSatelites);
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida, debes seleccionar + o -");
                            }
                        }
                        else
                        {
                            Console.WriteLine("El astro no existe en la lista o no es un planeta");
                        }
                        break;

                    case 5:
                        for (int i = astros.Count - 1; i >= 0; i--)
                        {
                            if (astros[i] is not ITerraformable)
                            {
                                astros.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("Se han eliminado todos los astros no terraformables\n");

                        break;

                    case 6:
                        try
                        {
                            StreamWriter sw = new StreamWriter(rutaArchivo);

                            foreach (var astro in astros)
                            {
                                if (astro is Planeta planetaAEscribir)
                                {
                                    sw.WriteLine($"Planeta: {planetaAEscribir.Nombre}; {planetaAEscribir.Radio}; {planetaAEscribir.Gaseoso}; {planetaAEscribir.NumSatelites}");
                                }
                                else if (astro is Cometa cometaAEscribir)
                                {
                                    sw.WriteLine($"Cometa: {cometaAEscribir.Nombre}; {cometaAEscribir.Radio}");
                                }
                            }

                            sw.Close();
                            Console.WriteLine("Datos guardados correctamente en el disco.");
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            Console.WriteLine("Error: no tienes permisos de acceder o modificar estos archivos.");
                        }
                        catch (IOException e)//Unautorized 
                        {
                            Console.WriteLine("Error al guardar los datos: " + e.Message);
                        }
                        
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, escoge otra.");
                        break;
                }
            }

            while (opcion != 6);
        }
    }
}
