using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlturaException: Exception
    {
        private float altura;

        public float Altura
        {
            get { return altura; }
            set { this.altura = value; }
        }
        public override string Message
        {
            get { return "Error, ingrese solo numeros"; }
        }

    }
}
