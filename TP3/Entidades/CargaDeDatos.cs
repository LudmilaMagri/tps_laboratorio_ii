using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class CargaDeDatos
    {
        internal static List<PlantaSinFruto> listaPlantaSinFruto;
        internal static List<PlantaConFruto> listaPlantaConFruto;
        internal static List<PlantaMusgo> listaPlantaMusgo;

      
        static CargaDeDatos()
        {
            listaPlantaConFruto = new List<PlantaConFruto>();
            listaPlantaSinFruto = new List<PlantaSinFruto>();
            listaPlantaMusgo = new List<PlantaMusgo>();
            ArchivoACheckearConFruto("Planta_Con_Fruto");
            ArchivoACheckearMusgo("Planta_Musgo");
            ArchivoACheckearSinFruto("Planta_Sin_Fruto");
        }

        /// <summary>
        /// Retorna la lista de Plantas sin Fruto
        /// </summary>
        /// <returns></returns>
        public static List<PlantaSinFruto> RetornarListaSinFruto()
        {
            return listaPlantaSinFruto;
        }
        /// <summary>
        /// Retorna la lista de Plantas con Fruto
        /// </summary>
        /// <returns></returns>
        public static List<PlantaConFruto> RetornarListaConFruto()
        {
            return listaPlantaConFruto;
        }
        /// <summary>
        /// Retorna la lista de Plantas Musgo
        /// </summary>
        /// <returns></returns>
        public static List<PlantaMusgo> RetornarListaMusgo()
        {
            return listaPlantaMusgo;
        }

        /// <summary>
        /// Hardcodeo de plantas con frutos y la agrega a la lista
        /// </summary>
        public static void CargarPlantaConFruto()
        {
            listaPlantaConFruto.Add(new PlantaConFruto("Lantana camara", "Verbenaceae", "Nativa", 1, 10000, PlantaConFruto.EColorFlor.roja, "Carnoso", 1000));
            listaPlantaConFruto.Add(new PlantaConFruto("Hibiscus striatus", "Malvaceae", "Nativa", 1, 50000, PlantaConFruto.EColorFlor.rosa, "Seco", 2000));
            listaPlantaConFruto.Add(new PlantaConFruto("Sphaeralcea bonariensis", "Malvaceae", "Nativa", 1, 8000, PlantaConFruto.EColorFlor.rosa, "Carnoso", 1500));
            listaPlantaConFruto.Add(new PlantaConFruto("Cucurbita maxima", "Cucurbitaceae", "America", 2, 20000, PlantaConFruto.EColorFlor.amarilla, "Carnoso", 1500));
            listaPlantaConFruto.Add(new PlantaConFruto("Helianthus annuus", "Asteraceae", "America", 1, 15000, PlantaConFruto.EColorFlor.amarilla, "Seco", 1000));
            listaPlantaConFruto.Add(new PlantaConFruto("Brugmansia arborea", "Solanaceae", "America", 2, 1000, PlantaConFruto.EColorFlor.amarilla, "Seco", 1000));
            listaPlantaConFruto.Add(new PlantaConFruto("Cestrum elegans", "Solanaceae", "America", 2, 2000, PlantaConFruto.EColorFlor.roja, "Carnoso", 1500));
            listaPlantaConFruto.Add(new PlantaConFruto("Solanum nigrum", "Solanaceae", "America", 2, 5500, PlantaConFruto.EColorFlor.amarilla, "Carnoso", 100));

        }
        /// <summary>
        /// Hardcodeo de plantas sin frutos y la agrega a la lista
        /// </summary>
        public static void CargarPlantaSinFruto()
        {
            listaPlantaSinFruto.Add(new PlantaSinFruto("Araucaria araucana", "Araucariaceae", "Nativa", 1000, 50000, PlantaSinFruto.ETipoPlanta.Arbol, 3000));
            listaPlantaSinFruto.Add(new PlantaSinFruto("Juniperus deppeana", "Cupressaceae", "America", 500, 25000, PlantaSinFruto.ETipoPlanta.Arbol, 2000));
            listaPlantaSinFruto.Add(new PlantaSinFruto("Taxus globosa", "Taxaceae", "America", 10, 10000, PlantaSinFruto.ETipoPlanta.Arbusto, 800));
            listaPlantaSinFruto.Add(new PlantaSinFruto("Ginkgo biloba", "Ginkgoaceae", "Asia", 1200, 10000, PlantaSinFruto.ETipoPlanta.Arbol, 3000));
            listaPlantaSinFruto.Add(new PlantaSinFruto("Pinus uncinata", "Pinaceas", "Europa", 1000, 6000, PlantaSinFruto.ETipoPlanta.Arbol, 4000));
            listaPlantaSinFruto.Add(new PlantaSinFruto("Pinus cembra", "Pinaceas", "Europa", 1600, 5000, PlantaSinFruto.ETipoPlanta.Arbol, 2500));
           
        }
        /// <summary>
        /// Hardcodeo de plantas musgo y la agrega a la lista
        /// </summary>
        public static void CargarPlantaMusgo()
        {
            listaPlantaMusgo.Add(new PlantaMusgo("Weymouthia mollis", "Lembophyllaceae", "America", 100, 6000, 1000));
            listaPlantaMusgo.Add(new PlantaMusgo("Dendroligotrichum dendroides", "Polytrichaceae", "America", 500, 4000, 3000));
            listaPlantaMusgo.Add(new PlantaMusgo("Sphagnum magellanicum", "Sphagnaceae", "Nativa", 200, 1000, 200000));
            listaPlantaMusgo.Add(new PlantaMusgo("Archidium alternifolium", "Archidiaceae", "Nativa", 300, 1000, 2060));
            listaPlantaMusgo.Add(new PlantaMusgo("Andreaea rupestris", "Andreaeaceae", "Europa", 600, 4000, 15000));
        }

        /// <summary>
        /// Comprueba si el archivo pasado por parametro existe. Si no existe, crea uno nuevo con los datos hardcodeados de plantas con frutos.
        /// Si existe, lee los datos
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        public static void ArchivoACheckearConFruto(string nombre)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string nombreArchivo = ruta + $"{nombre}" + ".xml";
            if (!File.Exists(nombreArchivo))
            {
                CargarPlantaConFruto();
                Archivos<List<PlantaConFruto>>.EscribirXml(listaPlantaConFruto, "Planta_Con_Fruto");
            }
            else
            {
                listaPlantaConFruto = Archivos<PlantaConFruto>.LeerXml("Planta_Con_Fruto");
            }
        }

        /// <summary>
        /// Comprueba si el archivo pasado por parametro existe. Si no existe, crea uno nuevo con los datos hardcodeados de plantas sin frutos.
        /// Si existe, lee los datos
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        public static void ArchivoACheckearSinFruto(string nombre)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string nombreArchivo = ruta + $"{nombre}" + ".xml";
            if (!File.Exists(nombreArchivo))
            {
                CargarPlantaSinFruto();
                Archivos<List<PlantaSinFruto>>.EscribirXml(listaPlantaSinFruto, "Planta_Sin_Fruto");
                Archivos<List<PlantaSinFruto>>.EscribirJson(listaPlantaSinFruto, "Planta_Sin_Fruto_Json");
            }
            else
            {
                listaPlantaSinFruto = Archivos<PlantaSinFruto>.LeerXml("Planta_Sin_Fruto");
            }
        }
        /// <summary>
        /// Comprueba si el archivo pasado por parametro existe. Si no existe, crea uno nuevo con los datos hardcodeados de plantas musgos.
        /// Si existe, lee los datos
        /// </summary>
        /// <param name="nombre">nombre del archivo</param>
        public static void ArchivoACheckearMusgo(string nombre)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string nombreArchivo = ruta + $"{nombre}" + ".xml";
            if (!File.Exists(nombreArchivo))
            {
                CargarPlantaMusgo();
                Archivos<List<PlantaMusgo>>.EscribirXml(listaPlantaMusgo, "Planta_Musgo");
                Archivos<List<PlantaMusgo>>.EscribirJson(listaPlantaMusgo, "Planta_Musgo_Json");
            }
            else
            {
                listaPlantaMusgo = Archivos<PlantaMusgo>.LeerXml("Planta_Musgo");
            }
        }
    }
}
