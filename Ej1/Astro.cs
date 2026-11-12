using System;
using System.Collections.Generic;
using System.Text;

namespace ej7
{
    internal abstract class Astro
    {
        private string nombre;
        private double radio;

        public string Nombre
        {
            get
            {
                return $"\"{nombre}\"";//Devolver entre "
            }

            set
            {
                nombre = value.ToUpper();
            }
        }
        public double Radio
        {
            get
            {
                return radio;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El radio debe ser positivo");
                }

                radio = value;
            }
        }

        public Astro() : this("Tierra", 6378) { } //llamar al otro
        

        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Astro otroAstro)
            {
                return this.nombre == otroAstro.nombre;
            }

            if (obj is string texto)
            {
                return this.nombre == texto.ToUpper();
            }

            return false;
        }
    }
}
