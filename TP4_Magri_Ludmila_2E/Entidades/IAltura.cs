using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAltura
    {
       
        /// <summary>
        /// Metodo para filtrar la altura maxima de las clases PlantaConFruto y PlantaSinFruto
        /// </summary>
        /// <returns>retorna el nombre de la planta con mas altura</returns>
        string AlturaMaxima();
       
    }
}
