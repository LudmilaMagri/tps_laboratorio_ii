using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public class PlantaMusgo : Planta
    {
        private int cantidadEsporas;
        private int idPlantaMusgo;
        public PlantaMusgo()
        {

        }
        public PlantaMusgo(string nombre, string familia, string origen, int añosVida, float cantidadAgua, int cantidadEsporas)
          : base(nombre, familia, origen, añosVida, cantidadAgua)
        {
            this.Id = UltimoId() + 1;
            this.CantidadEsporas = cantidadEsporas;
        }



        public int Id
        {
            set { this.idPlantaMusgo = value; }
            get { return this.idPlantaMusgo; }
        }
        public int CantidadEsporas
        {
            set
            {
                int aux = value;
                if (Validar.NumeroMayorACeroInt(aux))
                    this.cantidadEsporas = value;

                else
                {
                    CantidadEsporasException esporas = new CantidadEsporasException();
                    esporas.CantidadEsporas = aux;
                    throw esporas;
                }
                    
            }
            get { return this.cantidadEsporas; }
        }

        /// <summary>
        /// Agrega una planta Musgo a la lista de planta Musgo
        /// </summary>
        /// <param name="planta">planta a ser agregada</param>
        public void AltaMusgo(PlantaMusgo planta)
        {
            CargaDeDatos.listaPlantaMusgo.Add(planta);
        }

        /// <summary>
        /// Elimina una planta de la lista de planta musgo
        /// </summary>
        /// <param name="id">id de la planta a borrar</param>
        public override void EliminarPlanta(int id)
        {
            foreach (PlantaMusgo item in CargaDeDatos.listaPlantaMusgo)
            {
                if(item.idPlantaMusgo == id)
                {
                    CargaDeDatos.listaPlantaMusgo.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// Filtra la planta con mas cantidad de esporas
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>retorna el nombre de la planta encontrada</returns>
        public static string FiltrarCantidadEsporas(List<PlantaMusgo> lista)
        {
            int esporas = 0;
            int flag = 0;
            string nombre = null;
            foreach (PlantaMusgo item in lista)
            {
                if(esporas<= item.CantidadEsporas || flag == 0)
                {
                    esporas = item.CantidadEsporas;
                    nombre = item.Nombre;
                    flag = 1;
                }
            }
            return nombre;
        }
        /// <summary>
        /// Busca el nombre pasado por parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>retorna la lista con ese nombre coincidente</returns>
        public List<PlantaMusgo> BuscarPlantaPorNombre(string nombre)
        {
            List<PlantaMusgo> listaNombres = new List<PlantaMusgo>();
            listaNombres = CargaDeDatos.listaPlantaMusgo.FindAll((p) => p.Nombre.Contains(nombre));
            return listaNombres;
        }

        /// <summary>
        /// Escribe en .txt los datos pasados por parametro
        /// </summary>
        /// <param name="datos">datos a escribir en el archivo</param>
        /// <param name="nombreArchivo">nombre que tendra el archivo</param>
        /// <returns>retorna true si salio bien la ejecucion</returns>
        public static bool EscribirTxt(List<PlantaMusgo> datos, string nombreArchivo)
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
                    foreach (PlantaMusgo item in datos)
                    {
                        escribir.WriteLine("ID: " + item.Id.ToString());
                        escribir.WriteLine("NOMBRE: " + item.Nombre.ToString());
                        escribir.WriteLine("ORIGEN: " + item.Origen.ToString());
                        escribir.WriteLine("FAMILIA: " + item.Familia.ToString());
                        escribir.WriteLine("CANTIDAD DE AGUA: " + item.CantidadAgua.ToString());
                        escribir.WriteLine("AÑOS DE VIDA: " + item.AniosVida.ToString());
                        escribir.WriteLine("CANTIDAD DE ESPORAS: " + item.CantidadEsporas.ToString());
                        escribir.WriteLine("\n*******************************************");
                    }
                }
                else
                {
                    throw new EscribirTxtExceptionMusgo();
                }
            }
            return true;
        }
        public static bool EscribirTxTPorcentaje(List<PlantaMusgo> datos, string nombreArchivo, float porcentaje)
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
                    escribir.WriteLine("EL PORCENTAJE CALCULADO ES : " + porcentaje + "%");
                    escribir.WriteLine("\n\n--------------------------------------------------");
                    escribir.WriteLine("\n RESULTADO: ");

                    foreach (PlantaMusgo item in datos)
                    {
                        escribir.WriteLine(item.ToString());
                        escribir.WriteLine("\n*******************************************");
                    }
                }
                else
                {
                    throw new EscribirTxtExceptionMusgo();
                }
            }
            return true;
        }

        /// <summary>
        /// Busca el ultimo id de la lista planta musgo
        /// </summary>
        /// <returns>retorna el ultimo id de la lista</returns>
        public int UltimoId()
        {
            int numeroRetorno = 0;
            foreach (PlantaMusgo item in CargaDeDatos.listaPlantaMusgo)
            {
                numeroRetorno = item.Id;
            }
            return numeroRetorno;
        }

        public override string ToString()
        {
            return "\nID:  " + this.Id + "\nNOMBRE: " + this.Nombre + "\nORIGEN: " + this.Origen + "\nFAMILIA: " + this.Familia + "\nCANTIDAD DE AGUA: " + this.CantidadAgua +
               "\nAÑOS DE VIDA: " + this.AniosVida + "\nCANTIDAD DE ESPORAS: " +this.CantidadEsporas;
        }
    }
}
