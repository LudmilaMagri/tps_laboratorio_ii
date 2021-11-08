using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EscribirTxtExceptionSinFruto: Exception
    {
        public override string Message
        {
            get { return "Error, no se pudo exportar a txt"; }
        }
    }
}
