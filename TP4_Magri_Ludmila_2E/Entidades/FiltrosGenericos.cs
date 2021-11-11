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

        public static float PorcentajeOrigen(List<PlantaConFruto> listPlantaConFrutos, List<PlantaSinFruto> listPlantaSinFrutos, List<PlantaMusgo> listPlantaMusgos, string seleccion)
        {
            float porcentaje = 100;
            float porcentajeTotal = 0;
            List<PlantaConFruto> listFiltradaFruto = FiltrarPorOrigen(listPlantaConFrutos, seleccion);
            List<PlantaSinFruto> listFiltradaSinFruto = FiltrarPorOrigen(listPlantaSinFrutos, seleccion);
            List<PlantaMusgo> listFiltradaMusgo = FiltrarPorOrigen(listPlantaMusgos, seleccion);
            int cantidadTotal = listPlantaConFrutos.Count + listPlantaSinFrutos.Count + listPlantaMusgos.Count;
            int cantidadTotalOrigen = listFiltradaFruto.Count + listFiltradaSinFruto.Count + listFiltradaMusgo.Count;

            if (seleccion is not null)
            {
                porcentajeTotal = (cantidadTotalOrigen * porcentaje) / cantidadTotal;
            }

            return porcentajeTotal;
        }

        public static float PorcentajeDeTipoPlanta(List<PlantaConFruto> listPlantaConFrutos, List<PlantaSinFruto> listPlantaSinFrutos, List<PlantaMusgo>  listPlantaMusgos, string seleccion)
        {
            float porcentaje = 100;
            float porcentajeTotal= 0;
            int cantidadTotal = listPlantaConFrutos.Count + listPlantaSinFrutos.Count + listPlantaMusgos.Count;

            if(seleccion is not null)
            switch (seleccion)
            {
                case "Con Fruto":
                    porcentajeTotal = (listPlantaConFrutos.Count * porcentaje) / cantidadTotal;
                    break;
                case "Sin Fruto":
                    porcentajeTotal = (listPlantaSinFrutos.Count * porcentaje) / cantidadTotal;
                    break;
                case "Musgo":
                    porcentajeTotal = (listPlantaMusgos.Count * porcentaje) / cantidadTotal;
                    break;
            }
            return porcentajeTotal;
        }
    }
}
