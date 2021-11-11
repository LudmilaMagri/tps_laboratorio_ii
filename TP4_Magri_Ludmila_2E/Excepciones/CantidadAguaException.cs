using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantidadAguaException: Exception
    {
        private float cantidadAgua;

        public float CantidadAgua
        {
            get { return cantidadAgua; }
            set { cantidadAgua = value; }
        }
        public override string Message
        {
            get { return "Error, ingrese solo numeros"; }
        }

    }
}
