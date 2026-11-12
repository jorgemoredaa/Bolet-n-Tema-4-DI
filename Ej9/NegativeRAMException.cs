using System;
using System.Collections.Generic;
using System.Text;

namespace Ej9
{
    internal class NegativeRAMException : Exception
    {
        public NegativeRAMException(String mensaje) : base(mensaje)
        {
        }
    }
}
