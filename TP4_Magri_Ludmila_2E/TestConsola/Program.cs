using System;
using System.Collections.Generic;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlantaConFruto> listaConFrutos = new List<PlantaConFruto>();
            
            listaConFrutos = CargaDeDatos.RetornarListaConFruto();
            foreach (PlantaConFruto item in listaConFrutos)
            {
                if(item != null)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("\n*******************************************");
                }
                else
                {
                    Console.WriteLine("Datos cargados incorrectamente");
                }
            }
            string fruto = "Seco";
            List<PlantaConFruto> listaFiltrada = new List<PlantaConFruto>();

            listaFiltrada = PlantaConFruto.FiltrarFruto(listaConFrutos, fruto);
            float resultado = PlantaConFruto.PorcentajeDeFrutos(listaFiltrada, listaConFrutos, fruto);



            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("--------------PLANTAS FILTRADAS-----------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            foreach (PlantaConFruto item in listaFiltrada)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine("\n*******************************************");
            }

            if(PlantaConFruto.EscribirTxtPorcentaje(listaFiltrada, "Lista_Filtrada_Test_Consola", resultado))
            {
                Console.WriteLine("Archivos guardados correctamente");
            }

            else
            {
                Console.WriteLine("Error al guardar archivos");
            }

        }
    }
}
