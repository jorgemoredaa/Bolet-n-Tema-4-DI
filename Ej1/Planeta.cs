using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ej7
{
    internal class Planeta : Astro, ITerraformable
    {
        private int numSatelites;
        public bool Gaseoso { get; set; }
        public int NumSatelites
        {
            get
            {
                return numSatelites;
            }

            set
            {
                if (value < 0)
                { 
                    numSatelites = 0;
                }
                numSatelites = value;
            }
        }

        public Planeta(string nombre, double radio, bool gaseoso, int numSatelites): base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.NumSatelites = numSatelites;
        }

        public Planeta(): this("", 1, false, 0)
        {
            
        }

        public bool esHabitable()
        {
            return (!Gaseoso && Radio > 2000 && Radio < 8000);
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre,10} | Satélites: {NumSatelites,4} | Radio: {Radio:F2} km";
        }

        public static Planeta operator ++(Planeta p)
        {
            p.NumSatelites++;
            return p;
        }

        public static Planeta operator --(Planeta p)
        {
            if (p.numSatelites > 0)
            {
                p.NumSatelites--;
            } 
            else
            {
                p.numSatelites = 0;
            }

            return p;
        }
    }
}
