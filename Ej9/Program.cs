using System;
using System.Collections.Generic;

namespace Ej9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Ordenador> redOrdenadores = new Dictionary<string, Ordenador>();

            int opcion = 0;

            do
            {
                Console.WriteLine("\nMENÚ");
                Console.WriteLine("1. Añadir nuevo equipo.");
                Console.WriteLine("2. Añadir varios equipos.");
                Console.WriteLine("3. Elimina un dato por clave.");
                Console.WriteLine("4. Mostrar lista de nombres.");
                Console.WriteLine("5. Mostrar un elemento de la colección.");
                Console.WriteLine("6. Salir");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error: debes introducir un número válido.");
                    continue;
                }
                //TODO revision intro datos
                switch (opcion)
                {
                    case 1:
                        string ip = "";
                        bool ipValidaNueva = false;
                        while (!ipValidaNueva)
                        {
                            Console.WriteLine("Introduce una dirección IP: ");
                            ip = Console.ReadLine();

                            if (!Ordenador.IPvalida(ip))
                            {
                                Console.WriteLine("Error: la ip no tiene un formato válido.");
                            }
                            else if (redOrdenadores.ContainsKey(ip))
                            {
                                Console.WriteLine("Error: ya existe un equipo registrado con esta dirección IP. Introduce otra.");
                            }
                            else
                            {
                                ipValidaNueva = true;
                            }
                        }

                        string nombre = "";
                        while (string.IsNullOrEmpty(nombre))
                        {
                            Console.WriteLine("Indica el nombre del equipo: ");
                            nombre = Console.ReadLine();

                            if (string.IsNullOrEmpty(nombre))
                            {
                                Console.WriteLine("Error: no has introducido ningún nombre.");
                            }
                        }

                        int ram = 0;
                        bool ramValida = false;
                        while (!ramValida)
                        {
                            Console.WriteLine("Introduce la cantidad de RAM que tiene el equipo:");
                            if (int.TryParse(Console.ReadLine(), out ram))
                            {
                                try
                                {
                                    Ordenador ordenadorNuevo = new Ordenador(nombre, ram);
                                    redOrdenadores.Add(ip, ordenadorNuevo);
                                    Console.WriteLine("Ordenador añadido con éxito.");
                                    ramValida = true;
                                }
                                catch (NegativeRAMException e)
                                {
                                    Console.WriteLine("Error de RAM: " + e.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: debes introducir un número entero válido para la RAM.");
                            }
                        }
                        break;


                    case 2:
                        Console.WriteLine("Introduce los equipos que quieras (ej: 192.0.0.1:16, 192.0.0.2:8)");
                        string equipos = Console.ReadLine();
                        if (string.IsNullOrEmpty(equipos))
                        {
                            Console.WriteLine("Error: debes introducir algún equipo.");
                            break;
                        }

                        string[] equiposSpliteados = equipos.Split(",");
                        int aniadidos = 0;
                        foreach (string i in equiposSpliteados)
                        {
                            string[] partes = i.Split(":");
                            if (partes.Length == 2)
                            {
                                string ipSola = partes[0].Trim();
                                string ramSola = partes[1].Trim();

                                if (Ordenador.IPvalida(ipSola) && int.TryParse(ramSola, out int ramOut) && ramOut >= 0)
                                {
                                    string nombreGenerico = "NONAME_" + ipSola;

                                    try
                                    {
                                        Ordenador nuevoPC = new Ordenador(nombreGenerico, ramOut);
                                        if (!redOrdenadores.ContainsKey(ipSola))
                                        {
                                            redOrdenadores.Add(ipSola, nuevoPC);
                                            aniadidos++;
                                        }
                                    }
                                    catch (NegativeRAMException)
                                    {

                                    }
                                }
                            }
                        }
                        Console.WriteLine($"Se han añadido {aniadidos} ordenadores nuevos con éxito");
                        break;


                    case 3:
                        Console.WriteLine("Indica la IP que quieres eliminar: ");
                        string ipAEliminar = Console.ReadLine();

                        if (redOrdenadores.ContainsKey(ipAEliminar))
                        {
                            redOrdenadores.Remove(ipAEliminar);
                            Console.WriteLine("Equipo eliminado con éxito de la red de ordenadores.");
                        }
                        else
                        {
                            Console.WriteLine("Error, no existe ningún equipo con esta dirección IP");
                        }

                        break;


                    case 4:
                        Console.WriteLine("\n--LISTA DE NOMBRES--");
                        if (redOrdenadores.Count == 0)
                        {
                            Console.WriteLine("No hay ningún equipo registrado en la red.");
                        }
                        else
                        {
                            foreach (KeyValuePair<string, Ordenador> par in redOrdenadores)
                            {
                                Console.WriteLine($"- {par.Value.Nombre}");
                            }
                        }
                        break;


                    case 5:
                        Console.WriteLine("Indica la IP que quieres consultar.");
                        string ipAConsultar = Console.ReadLine();

                        if (redOrdenadores.ContainsKey(ipAConsultar))
                        {
                            Ordenador ordenadorConsultado = redOrdenadores[ipAConsultar];
                            Console.WriteLine($"Nombre: {ordenadorConsultado.Nombre}");
                            Console.WriteLine($"Memoria RAM: {ordenadorConsultado.MemoriaRAM}");
                        }
                        else
                        {
                            Console.WriteLine("El ordenador seleccionado no existe.");
                        }
                        break;


                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;


                    default:
                        Console.WriteLine("Opción no válida, escoge otra");
                        break;
                }
            }
            while (opcion != 6);
        }
    }
}
