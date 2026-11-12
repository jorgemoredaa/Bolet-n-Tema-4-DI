namespace Ej9
{
    internal class Ordenador
    {
        private int memoriaRAM;

        public string Nombre { get; set; }  //TODO autoimplementado

        public int MemoriaRAM
        {
            get
            {
                return memoriaRAM;
            }
            set
            {
                if (value >= 0)
                {
                    memoriaRAM = value;
                }
                else
                {
                    throw new NegativeRAMException("La cantidad de RAM debe ser 0 o superior.");
                }
            }
        }

        public Ordenador(string nombre, int memoriaRAM)
        {
            Nombre = nombre;
            MemoriaRAM = memoriaRAM;
        }

        public static bool IPvalida(string IP)
        {
            if (string.IsNullOrEmpty(IP))
            {
                return false;
            }

            string[] partes = IP.Split('.');
            if (partes.Length != 4)
            {
                return false;
            }

            foreach (string parte in partes)
            {
                if (!int.TryParse(parte, out int num) || num < 0 || num > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
