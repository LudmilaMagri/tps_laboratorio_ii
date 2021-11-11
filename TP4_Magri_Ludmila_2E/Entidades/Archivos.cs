using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public static class Archivos<T>
    {
        static string ruta;
       
        static Archivos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos\";
        }

        /// <summary>
        /// Escribe datos genericos en un archivo .xml
        /// </summary>
        /// <param name="listaDatos">lista de datos a escribir</param>
        /// <param name="nombreArchivo">nombre del archivo a guardar</param>
        /// <returns>bool</returns>
        public static bool EscribirXml(T listaDatos, string nombreArchivo)
        {
            string archivo = ruta + $"{nombreArchivo}" + ".xml";
           
            if(listaDatos != null)
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (XmlTextWriter sw = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
                {
                    XmlSerializer xlmSer = new XmlSerializer(typeof(T));
                    xlmSer.Serialize(sw, listaDatos);
                }
                return true;
            }
            else
            {
                throw new EscribirXmlException();
            }    
        }

        /// <summary>
        /// Escribe datos genericos en un archivo .json
        /// </summary>
        /// <param name="listaDatos">lista de datos a escribir</param>
        /// <param name="nombreArchivo">nombre del archivo a guardar</param>
        /// <returns></returns>
        public static bool EscribirJson(T listaDatos, string nombreArchivo) 
        {
            string archivo = ruta + nombreArchivo + ".json";

            if (listaDatos != null)
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string listaSerializada = JsonSerializer.Serialize(listaDatos);
                File.WriteAllText(archivo, listaSerializada);
                return true;
            }
            else
            {
                throw new EscribirJsonException();
            }
        }

       
        /// <summary>
        /// Lee un archivo en .xml
        /// </summary>
        /// <param name="nombreArchivo">nombre del archivo a leer</param>
        /// <returns>Lista generica</returns>
        public static List<T> LeerXml(string nombreArchivo)
        {
            try
            {
                string archivo;
                List<T> newList = new List<T>();
                archivo = ruta +$"{nombreArchivo}" + ".xml";
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (XmlTextReader leer = new XmlTextReader(archivo))
                {
                    XmlSerializer xmlSer = new XmlSerializer(typeof(List<T>));
                    newList = (List<T>)xmlSer.Deserialize(leer);
                }
                return newList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
