using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class OrigenException: Exception
    {
        public OrigenException() : base()
        {

        }
        public override string Message
        {
            get { return "Error, ingrese solo letras" ; }
        }
    }
}
