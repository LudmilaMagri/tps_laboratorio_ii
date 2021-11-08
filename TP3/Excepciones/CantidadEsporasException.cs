using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantidadEsporasException: Exception
    {
        private int cantidadEsporas;

        public int CantidadEsporas
        {
            get { return cantidadEsporas; }
            set { cantidadEsporas = value; }
        }
        public override string Message
        {
            get { return "Error, ingrese numeros enteros"; }
        }
    }
}
