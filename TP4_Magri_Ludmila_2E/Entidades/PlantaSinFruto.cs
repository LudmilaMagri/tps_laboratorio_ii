using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public delegate void MiDelegadoSinFruto(List<PlantaSinFruto> lista);

    [Serializable]
    public class PlantaSinFruto : Planta, IAltura
    {
        public event MiDelegadoSinFruto MostrarPlantaSinFruto;

        public enum ETipoPlanta
        {
            Arbol, Arbusto
        };

        private ETipoPlanta tipoPlanta;
        private int idPlantaSinFruto;
        private float altura;

        public PlantaSinFruto()
        {

        }
        
        public PlantaSinFruto(string nombre, string familia, string origen, int aniosVida, float cantidadAgua, ETipoPlanta tipoPlanta, float altura)
           : base(nombre, familia, origen, aniosVida, cantidadAgua)
        {
            this.Id = UltimoId() + 1;
            this.TipoPlanta = tipoPlanta;
            this.Altura = altura; 
        }
        public PlantaSinFruto(string nombre, string familia, string origen, int aniosVida, float cantidadAgua, float altura)
            : base(nombre, familia, origen, aniosVida, cantidadAgua)
        {
            this.Altura = altura;
        }

        #region Propiedades

        
        public ETipoPlanta TipoPlanta
        {
            set
            {
                this.tipoPlanta = value;
            }
            get { return tipoPlanta; }
        }
        public int Id
        {
            set { this.idPlantaSinFruto = value; }
            get { return this.idPlantaSinFruto; }
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
        /// Agrega una planta Sin fruto a la lista de planta Sin fruto
        /// </summary>
        /// <param name="planta">planta a ser agregada</param>
        public static void AltaSinFruto(PlantaSinFruto planta)
        {
            CargaDeDatos.listaPlantaSinFruto.Add(planta);
        }

        /// <summary>
        /// Elimina una planta de la lista de planta sin fruto
        /// </summary>
        /// <param name="id">id de la planta a borrar</param>
        public override void EliminarPlanta(int id)
        {
            foreach (PlantaSinFruto item in CargaDeDatos.listaPlantaSinFruto)
            {
                if (item.idPlantaSinFruto == id)
                {
                    CargaDeDatos.listaPlantaSinFruto.Remove(item);
                    break;
                }
            }
        }


        /// <summary>
        /// Filtra la planta con la altura maxima
        /// </summary>
        /// <returns>retorna el nombre de la planta que encontro</returns>
        public string AlturaMaxima()
        {
            float altura = 0;
            string nombre = null;
            int flag = 0;
            PlantaSinFruto plantita = new PlantaSinFruto();
            foreach (PlantaSinFruto item in CargaDeDatos.listaPlantaSinFruto)
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
        public List<PlantaSinFruto> BuscarPlantaPorNombre(string nombre)
        {
            List<PlantaSinFruto> listaNombres = new List<PlantaSinFruto>();
            listaNombres = CargaDeDatos.listaPlantaSinFruto.FindAll((p) => p.Nombre.Contains(nombre));
            return listaNombres;
        }

        /// <summary>
        /// Escribe en .txt los datos pasados por parametro
        /// </summary>
        /// <param name="datos">datos a escribir en el archivo</param>
        /// <param name="nombreArchivo">nombre que tendra el archivo</param>
        /// <returns>retorna true si salio bien la ejecucion</returns>
        public static bool EscribirTxt(List<PlantaSinFruto> datos, string nombreArchivo)
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
                    foreach (PlantaSinFruto item in datos)
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
        /// Escribe en .txt los datos pasados por parametro y le agrega el porcentaje calculado
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombreArchivo"></param>
        /// <param name="porcentaje"></param>
        /// <returns></returns>
        public static bool EscribirTxtPorcentaje(List<PlantaSinFruto> datos, string nombreArchivo, float porcentaje)
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

                    foreach (PlantaSinFruto item in datos)
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
        /// Busca el ultimo id de la lista planta sin fruto
        /// </summary>
        /// <returns>retorna el ultimo id de la lista</returns>
        public int UltimoId()
        {
            int numeroRetorno = 0;
            foreach (PlantaSinFruto item in CargaDeDatos.listaPlantaSinFruto)
            {
                numeroRetorno = item.Id;
            }
            return numeroRetorno;
        }

        /// <summary>
        /// Metodo para invocar al delegado si hay mas de 2 plantas en la lista
        /// </summary>
        /// <param name="lista"></param>
        public void ControlarLista(List<PlantaSinFruto> lista)
        {
            if (CargaDeDatos.listaPlantaSinFruto.Count >= 2)
            {
                MostrarPlantaSinFruto.Invoke(lista);
            }
            
        }


       

        public override string ToString()
        {
            return "\nID:  " + this.Id + "\nNOMBRE: " + this.Nombre + "\nORIGEN: " + this.Origen + "\nFAMILIA: " + this.Familia + "\nCANTIDAD DE AGUA: " + this.CantidadAgua + "\nALTURA: " + this.Altura +
               "\nAÑOS DE VIDA: " + this.AniosVida;
        }

    }
}
