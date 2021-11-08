using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class Validar
    {

        /// <summary>
        /// Verifica si la cadena tiene letras
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool SoloLetras(string cadena)
        {
            foreach (Char item in cadena.ToCharArray())
            {
                if(/*Char.IsDigit(item) &&*/ Char.IsLetter(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena sean numeros float
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool EsNumericaFloat(string cadena)
        {
            if (float.TryParse(cadena, out float cadenaParse))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que la cadena sean numeros int
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool EsNumericaInt(string cadena)
        {
            if (int.TryParse(cadena, out int cadenaParse))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica que el numero sea mayor a 0
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool NumeroMayorACeroInt(int numero)
        {
            if(numero >0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica si el numero es mayor a 0,1
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool NumeroMayorACeroFloat(float numero)
        {
            if(numero >= 0.1)
            {
                return true;
            }
            return false;
        }
    }
}
