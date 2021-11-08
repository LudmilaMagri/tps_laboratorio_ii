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
            //List<PlantaConFruto> listaConFruto = CargaDeDatos.RetornarListaConFruto();

            listaFiltrada = PlantaConFruto.FiltrarFruto(listaConFrutos, fruto);


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

            if (Archivos<List<PlantaConFruto>>.EscribirXml(listaFiltrada, "Lista_Filtrada_Test_Consola"))
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
