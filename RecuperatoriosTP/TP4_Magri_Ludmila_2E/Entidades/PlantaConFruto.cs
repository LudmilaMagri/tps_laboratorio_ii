using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public delegate void MiDelegadoConFruto(List<PlantaConFruto> lista);
    [Serializable]
    public class PlantaConFruto : Planta, IAltura
    {
        public event MiDelegadoConFruto MostrarPlantaConFruto;

        public enum EColorFlor
        {
            roja, amarilla, rosa
        };

        private EColorFlor colorFlor;
        private string fruto;
        private int idPlantaConFruto;
        private float altura;

        public PlantaConFruto()
        {

        }

        public PlantaConFruto(string nombre, string familia, string origen, int aniosVida, float cantidadAgua, EColorFlor colorFlor, string fruto, float altura)
            : base(nombre, familia, origen, aniosVida, cantidadAgua)
        {
            this.ColorFlor = colorFlor;
            this.Fruto = fruto;
            this.Id = UltimoId() + 1;
            this.Altura = altura;
        }
        public PlantaConFruto(string nombre, string familia, string origen, int aniosVida, float cantidadAgua, string fruto, float altura)
           : base(nombre, familia, origen, aniosVida, cantidadAgua)
        {
            this.Fruto = fruto;
            // this.Id = UltimoId() + 1;
            this.Altura = altura;
        }

        #region Propiedades
        public int Id
        {
            set
            {
                if (idPlantaConFruto < value)
                    this.idPlantaConFruto = value++;
            }
            get { return this.idPlantaConFruto; }
        }
        public EColorFlor ColorFlor
        {
            set { this.colorFlor = value; }
            get { return colorFlor; }
        }
        public string Fruto
        {
            set
            {
                string aux = value;
                if (Validar.SoloLetras(aux))
                    this.fruto = value;
                else
                {
                    throw new FrutoException();
                }
            }
            get { return this.fruto; }
        }

        public float Altura
        {
            set
            {
                float aux = value;
                if (Validar.NumeroMayorACeroFloat(aux))
                {
                    this.altura = value;
                }
                else
                {
                    AlturaException alturaExc = new AlturaException();
                    alturaExc.Altura = aux;
                    throw alturaExc;
                }
            }
            get
            {
                return this.altura;
            }
        }
        #endregion

        /// <summary>
        /// Agrega una planta Con fruto a la lista de planta Con fruto
        /// </summary>
        /// <param name="planta">planta a ser agregada</param>
        public static void AltaConFruto(PlantaConFruto planta)
        {
            CargaDeDatos.listaPlantaConFruto.Add(planta);
        }

        /// <summary>
        /// Elimina una planta de la lista de planta con fruto
        /// </summary>
        /// <param name="id">id de la planta a borrar</param>
        public override void EliminarPlanta(int id)
        {
            foreach (PlantaConFruto item in CargaDeDatos.listaPlantaConFruto)
            {
                if (item.idPlantaConFruto == id)
                {
                    CargaDeDatos.listaPlantaConFruto.Remove(item);
                    break;
                }
            }
        }

        /// <summary>
        /// Filtra la planta con la altura maxima. Metodo implentando la interfaz.
        /// </summary>
        /// <returns>retorna el nombre de la planta que encontro</returns>
        public string AlturaMaxima()
        {
            float altura = 0;
            string nombre = null;
            int flag = 0;
            PlantaConFruto plantita = new PlantaConFruto();
            foreach (PlantaConFruto item in CargaDeDatos.listaPlantaConFruto)
            {
                if (altura <= item.altura || flag == 0)
                {
                    altura = item.altura;
                    nombre = item.Nombre;
                    flag = 1;
                }
            }
            return nombre;
        }
        /// <summary>
        /// Busca el nombre pasado por parametro
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>retorna la lista de nombres coincidentes</returns>
        public List<PlantaConFruto> BuscarPlantaPorNombre(string nombre)
        {
            List<PlantaConFruto> listaNombres = new List<PlantaConFruto>();
            listaNombres = CargaDeDatos.listaPlantaConFruto.FindAll((p) => p.Nombre.Contains(nombre));
            return listaNombres;
        }

        /// <summary>
        /// Busca la planta por color de flor pasado por parametro
        /// </summary>
        /// <param name="lista">lista en la que busca</param>
        /// <param name="color">color seleccionado a buscar</param>
        /// <returns>lista de plantas filtradas por el color a buscar</returns>
        public static List<PlantaConFruto> FiltrarColorFlor(List<PlantaConFruto> lista, string color)
        {
            List<PlantaConFruto> listaFiltrada = new List<PlantaConFruto>();
            listaFiltrada = lista.Where(p => p.ColorFlor.ToString() == color).ToList();
            return listaFiltrada;
        }

        /// <summary>
        /// Calcula el porcentaje del color seleccionado de flor
        /// </summary>
        /// <param name="listaFiltradaDeFrutos"></param>
        /// <param name="listaTotal"></param>
        /// <param name="florSeleccionada"></param>
        /// <returns></returns>
        public static float PorcentajeDeFLor(List<PlantaConFruto> listaFiltradaDeFrutos, List<PlantaConFruto> listaTotal, string florSeleccionada)
        {
            List<PlantaConFruto> listaFiltrada = FiltrarColorFlor(listaFiltradaDeFrutos, florSeleccionada);
            float cantidadTotal = listaTotal.Count;
            float porcentaje = 100;
            float porcentajeTotal = 0;
            porcentajeTotal = (listaFiltrada.Count * porcentaje) / cantidadTotal;
            return porcentajeTotal;
        }


        /// <summary>
        /// Busca la planta por el fruto seleccionado
        /// </summary>
        /// <param name="lista">lista en la que busca</param>
        /// <param name="fruto">fruto seleccionado a buscar</param>
        /// <returns></returns>
        public static List<PlantaConFruto> FiltrarFruto(List<PlantaConFruto> lista, string fruto)
        {
            List<PlantaConFruto> listaFiltrada = new List<PlantaConFruto>();
            listaFiltrada = lista.Where(p => p.Fruto == fruto).ToList();
            return listaFiltrada;
        }
        /// <summary>
        /// Calcula el porcentaje del fruto seleccionado
        /// </summary>
        /// <param name="listaFiltradaDeFrutos"></param>
        /// <param name="listaTotal"></param>
        /// <param name="frutoSeleccionado"></param>
        /// <returns>retorna el porcentaje</returns>
        public static float PorcentajeDeFrutos(List<PlantaConFruto> listaFiltradaDeFrutos, List<PlantaConFruto> listaTotal, string frutoSeleccionado)
        {
            List<PlantaConFruto> listaFiltrada = FiltrarFruto(listaFiltradaDeFrutos, frutoSeleccionado);
            float cantidadTotal = listaTotal.Count;
            float porcentaje = 100;
            float porcentajeTotal = 0;

            switch (frutoSeleccionado)
            {
                case "Seco":
                    porcentajeTotal = (listaFiltrada.Count * porcentaje) / cantidadTotal;
                    break;

                case "Carnoso":
                    porcentajeTotal = (listaFiltrada.Count * porcentaje) / cantidadTotal;
                    break;
            }
            return porcentajeTotal;
        }

        /// <summary>
        /// Filtra la lista de plantas por fruto y retorna una lista con la altura que le pase el usuario por parametro
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="fruto"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static List<PlantaConFruto> ReporteFrutoConAltura(List<PlantaConFruto> lista, string fruto, float altura)
        {
            List<PlantaConFruto> listaFiltrada = FiltrarFruto(lista, fruto);
            List<PlantaConFruto> listaRetorno = new List<PlantaConFruto>();
            foreach (PlantaConFruto item in listaFiltrada)
            {
                if (item.Altura >= altura)
                {
                    listaRetorno.Add(item);
                }
            }
            return listaRetorno;
        }

        /// <summary>
        /// Realiza el porcentaje de las plantas con fruto y altura que desea el usuario
        /// </summary>
        /// <param name="listaTotal"></param>
        /// <param name="fruto"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static float PorcentajeReporteFrutoConAltura(List<PlantaConFruto> listaTotal, string fruto, float altura)
        {
            List<PlantaConFruto> listaFiltradaConFrutoSeleccionado = FiltrarFruto(listaTotal, fruto);
            List<PlantaConFruto> listaPorcentaje = ReporteFrutoConAltura(listaFiltradaConFrutoSeleccionado, fruto, altura);


            float cantidadTotal = listaFiltradaConFrutoSeleccionado.Count;
            float porcentaje = 100;
            float porcentajeTotal = 0;

            return porcentajeTotal = (listaPorcentaje.Count * porcentaje) / cantidadTotal;
        }

        /// <summary>
        /// Filtra la lista de plantas por color de flor y retorna una lista con la cantidad de agua que le pase el usuario por parametro
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="fruto"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static List<PlantaConFruto> ReporteColorConAgua(List<PlantaConFruto> lista, string color, float agua)
        {
            List<PlantaConFruto> listaFiltrada = FiltrarColorFlor(lista, color);
            List<PlantaConFruto> listaRetorno = new List<PlantaConFruto>();
            foreach (PlantaConFruto item in listaFiltrada)
            {
                if (item.CantidadAgua >= agua)
                {
                    listaRetorno.Add(item);
                }
            }
            return listaRetorno;
        }


        /// <summary>
        /// Realiza el porcentaje de las plantas con flor y cantidad de agua que desea el usuario
        /// </summary>
        /// <param name="listaTotal"></param>
        /// <param name="fruto"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static float PorcentajeReporteColorAgua(List<PlantaConFruto> listaTotal, string color, float agua)
        {
            List<PlantaConFruto> listaFiltradaConColorSeleccionado = FiltrarColorFlor(listaTotal, color);
            List<PlantaConFruto> listaPorcentaje = ReporteColorConAgua(listaFiltradaConColorSeleccionado, color, agua);

            float cantidadTotal = listaFiltradaConColorSeleccionado.Count;
            float porcentaje = 100;
            float porcentajeTotal = 0;

            return porcentajeTotal = (listaPorcentaje.Count * porcentaje) / cantidadTotal;
        }



        /// <summary>
        /// Escribe en un archivo .txt el reporte
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreArchivo"></param>
        /// <param name="porcentajeTotal"></param>
        /// <param name="porcentajeResultado"></param>
        /// <param name="america"></param>
        /// <param name="asia"></param>
        /// <param name="nativa"></param>
        /// <param name="europa"></param>
        /// <param name="variable1"></param>
        /// <param name="variable2"></param>
        /// <returns></returns>
        public static bool EscribirTxtReporte(List<PlantaConFruto> datos, string nombreArchivo, float porcentajeTotal, float porcentajeResultado,
                                               float america, float asia, float nativa, float europa, string variable1, float variable2)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string archivo = ruta + $"{nombreArchivo}" + ".txt";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (StreamWriter escribir = new StreamWriter(archivo))
            {
                if (datos != null)
                {
                    if (nombreArchivo == "Reporte_Color_Flor")
                    {
                        escribir.WriteLine("El " + porcentajeTotal + "% de las plantas poseen flores con color " + variable1 + "\n y el " + porcentajeResultado +
                        "% de esas plantas necesita una cantidad de agua mayor o igual a " + variable2 + "lt. \n");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("El " + america + "% son de America.\n");
                        escribir.WriteLine("El " + asia + "% son de Asia.\n");
                        escribir.WriteLine("El " + europa + "% son de Europa.\n");
                        escribir.WriteLine("El " + nativa + "% son de Nativa.\n");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("\n LISTA: ");
                    }
                    else
                    {
                        escribir.WriteLine("El " + porcentajeTotal + "% de las plantas poseen un tipo de fruto " + variable1 + "\n y el " + porcentajeResultado +
                       "% de esas plantas tiene una altura mayor o igual a  " + variable2 + "m. \n");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("El " + america + "% son de America.\n");
                        escribir.WriteLine("El " + asia + "% son de Asia.\n");
                        escribir.WriteLine("El " + europa + "% son de Europa.\n");
                        escribir.WriteLine("El " + nativa + "% son de Nativa.\n");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("\n\n--------------------------------------------------");
                        escribir.WriteLine("\n LISTA: ");
                    }
                    foreach (PlantaConFruto item in datos)
                    {
                        escribir.WriteLine(item.ToString());
                        escribir.WriteLine("\n*******************************************");
                    }
                }
                else
                {
                    throw new EscribirTxtExceptionSinFruto();
                }

            }
            return true;
        }



        /// <summary>
        /// Busca el ultimo id de la lista planta con fruto
        /// </summary>
        /// <returns>retorna el ultimo id de la lista</returns>
        public static int UltimoId()
        {
            int numeroRetorno = 0;
            foreach (PlantaConFruto item in CargaDeDatos.listaPlantaConFruto)
            {
                numeroRetorno = item.Id;
            }
            return numeroRetorno;
        }
        /// <summary>
        /// Escribe en .txt los datos pasados por parametro
        /// </summary>
        /// <param name="datos">datos a escribir en el archivo</param>
        /// <param name="nombreArchivo">nombre que tendra el archivo</param>
        /// <returns>retorna true si salio bien la ejecucion</returns>
        public static bool EscribirTxt(List<PlantaConFruto> datos, string nombreArchivo)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string archivo = ruta + $"{nombreArchivo}" + ".txt";
            
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (StreamWriter escribir = new StreamWriter(archivo))
            {
                if(datos != null)
                {
                    foreach (PlantaConFruto item in datos)
                    {
                        escribir.WriteLine(item.ToString());
                        escribir.WriteLine("\n*******************************************");
                    }
                }
                else
                {
                    throw new EscribirTxtExceptionConFruto();
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreArchivo"></param>
        /// <param name="porcentaje"></param>
        /// <returns></returns>
        public static bool EscribirTxtPorcentaje(List<PlantaConFruto> datos, string nombreArchivo, float porcentaje)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
            string archivo = ruta + $"{nombreArchivo}" + ".txt";

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            using (StreamWriter escribir = new StreamWriter(archivo))
            {
                if (datos != null)
                {
                    escribir.WriteLine("EL PORCENTAJE CALCULADO ES : " + porcentaje+ "%");
                    escribir.WriteLine("\n\n--------------------------------------------------");
                    escribir.WriteLine("\n RESULTADO: ");

                    foreach (PlantaConFruto item in datos)
                    {
                        escribir.WriteLine(item.ToString());
                        escribir.WriteLine("\n*******************************************");
                    }
                }
                else
                {
                    throw new EscribirTxtExceptionConFruto();
                }
            }
            return true;

        }

        /// <summary>
        /// Metodo para invocar al delegado si hay mas de 2 plantas en la lista
        /// </summary>
        /// <param name="lista"></param>
        public void ControlarLista(List<PlantaConFruto> lista)
        {
            if (CargaDeDatos.listaPlantaConFruto.Count >= 2)
            {
                MostrarPlantaConFruto.Invoke(lista);
            }

        }

        public override string ToString()
        { 
            return "\nID:  "+ this.Id + "\nNOMBRE: " + this.Nombre + "\nORIGEN: "+ this.Origen + "\nFAMILIA: " + this.Familia + "\nCANTIDAD DE AGUA: " + this.CantidadAgua + "\nALTURA: "+ this.Altura +
               "\nAÑOS DE VIDA: " + this.AniosVida + "\nCOLOR DE FLOR: "+ this.ColorFlor + "\nTIPO DE FRUTO: " +this.Fruto;

        }
    }
}
