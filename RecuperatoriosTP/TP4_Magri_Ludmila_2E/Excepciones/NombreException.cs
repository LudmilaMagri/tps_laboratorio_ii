using System;

namespace Excepciones
{
    public class NombreException : Exception
    {
        public NombreException() : base()
        {

        }

        public override string Message
        {
            get { return "Error, ingrese solo letras"; }
        }
    }
}
