using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AniosVidaException: Exception
    {
        private int aniosVida;

        public int AniosVida
        {
            get { return aniosVida; }
            set { aniosVida = value; }
        }
        public override string Message
        {
            get { return "Error, ingrese numeros enteros"; }
        }

    }
}
