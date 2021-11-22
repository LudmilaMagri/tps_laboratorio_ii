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
                if(idPlantaConFruto< value)
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
                if(Validar.SoloLetras(aux))
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
        public static float PorcentajeDeFrutos(List<PlantaConFruto> listaFiltradaDeFrutos, List<PlantaConFruto> listaTotal , string frutoSeleccionado)
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
