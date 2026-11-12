namespace Ej1_T5PSP
{
    internal class Program
    {
        static int contador = 0;
        static bool running = true;
        static readonly object cerrojo = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Incrementar);
            Thread thread2 = new Thread(Decrementar);
            
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.ForegroundColor = ConsoleColor.White;
            if (contador >= 500)
            {
                Console.WriteLine("Ha ganado el hilo incrementador +500");
            } else if (contador <= -500)
            {
                Console.WriteLine("Ha ganado el hilo decrementador -500");
            }
        }

        static void Incrementar()
        {
            while (running)
            {
                lock (cerrojo)
                {
                    if (running)
                    {
                        contador++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Hilo 1 (incrementador): {contador}");

                        if (contador >= 500)
                        {
                            running = false;
                        }
                    }
                }
            }
        }

        static void Decrementar()
        {
            while (running)
            {
                lock (cerrojo)
                {
                    if (running)
                    {
                        contador--;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Hilo 2 (decrementador): {contador}");
                    
                        if (contador <= -500)
                        {
                            running = false;
                        }
                    }
                }
            }
        }
    }
}
