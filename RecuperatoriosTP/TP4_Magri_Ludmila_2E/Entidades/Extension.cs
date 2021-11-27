using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        /// <summary>
        /// Metodo de extension donde filtra la planta con mas cantidad de esporas
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>retorna el nombre de la planta encontrada</returns>
        public static string FiltrarCantidadEsporas(this List<PlantaMusgo> lista)
        {
            int esporas = 0;
            int flag = 0;
            string nombre = null;
            foreach (PlantaMusgo item in lista)
            {
                if (esporas <= item.CantidadEsporas || flag == 0)
                {
                    esporas = item.CantidadEsporas;
                    nombre = item.Nombre;
                    flag = 1;
                }
            }
            return nombre;
        }
    }
}
