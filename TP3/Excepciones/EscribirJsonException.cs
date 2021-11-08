using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EscribirJsonException : Exception
    {

        public override string Message
        {
            get { return "Error al guardar en json"; }
        }
    }
}
