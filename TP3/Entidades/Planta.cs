using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public abstract class Planta
    {
        string nombre;
        string familia;
        string origen;
        int aniosVida;
        float cantidadAgua;
        public static int id;

        protected Planta()
        {

        }

        static Planta()
        {
           
        }
       
        protected Planta(string nombre, string familia, string origen, int aniosVida, float cantidadAgua)
        {
            this.Nombre = nombre;
            this.Familia = familia;
            this.Origen = origen;
            this.AniosVida = aniosVida;
            this.CantidadAgua = cantidadAgua;
        }

        #region Propiedades

        public string Nombre
        {
            set 
            {
                string aux = value;
                if (Validar.SoloLetras(aux))
                    this.nombre = aux;
                else
                    throw new NombreException();
            }
            get { return this.nombre; }
        }
        public string Familia
        {
            set 
            {
                string aux = value;
                if(Validar.SoloLetras(aux))
                {
                    this.familia = aux;
                }
                else
                {
                    throw new FamiliaException();
                }
            }
            get { return this.familia; }
        }
        public string Origen
        {
            set
            {
                string aux = value;
                if (Validar.SoloLetras(aux))
                {
                    this.origen = aux;
                }
                else
                {
                    throw new OrigenException();
                }
            }
          
            get { return this.origen; }
        }

        public int AniosVida
        {
            set 
            {
                int aux = value;
                if (Validar.NumeroMayorACeroInt(value))
                {
                    this.aniosVida = aux;
                }
                else
                {
                    AniosVidaException aniosVidaExc = new AniosVidaException();
                    aniosVidaExc.AniosVida = aux;
                    throw aniosVidaExc;
                }
            }
            get { return this.aniosVida; }
        }

        public float CantidadAgua
        {
            set 
            {
                float aux = value;
                if(Validar.NumeroMayorACeroFloat(value))
                {
                    this.cantidadAgua = aux;
                }
                else
                {
                    CantidadAguaException cantAguaExc = new CantidadAguaException();
                    cantAguaExc.CantidadAgua = aux;
                    throw cantAguaExc;
                }
            }
            get { return this.cantidadAgua; }
        }
        #endregion

        public abstract void EliminarPlanta(int id);

    }
}
