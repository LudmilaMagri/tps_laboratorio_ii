using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class FiltrosGenericos
    {

        /// <summary>
        /// Filtra el atributo "Origen" que tiene en comun con las 3 clases.
        /// Se aplica Tipos Genericos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista">lista generica a filtrar</param>
        /// <param name="origen">origen seleccionado</param>
        /// <returns>lista generica</returns>
        public static List<T> FiltrarPorOrigen<T>(List<T> lista, string origen) where T : Planta
        {
            List<T> listaFiltrada = new List<T>();
            foreach (T item in lista)
            {
                if (item.Origen == origen)
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
    }
}
