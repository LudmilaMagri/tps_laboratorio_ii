using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Asigna el valor 0 al atributo numero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Asigna un valor double pasado por parametro al atributo numero
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Asigna un valor string pasado por parametro a la propiedad Numero
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Propiedad que asigna un valor al atributo numero previamente validado
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
            

        }

        /// <summary>
        /// Comprueba que el valor recibido es numerico y lo retorna en un double. 
        /// Contrariamente, retorna 0.
        /// </summary>
        /// <param name="strNumero"> Valor a ser comprobado</param>
        /// <returns></returns>

        private double ValidarOperando(string strNumero)
        {
            double numRetornado;

            if (!double.TryParse(strNumero, out numRetornado))
            {
                numRetornado = 0;
            }
           
            return numRetornado;
        }

        /// <summary>
        /// Valida que el string este compuesto solo por 0 o 1. 
        /// </summary>
        /// <param name="binario">Numero binario a ser validado </param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i].ToString() != "0" && binario[i].ToString() != "1")
                {
                    return false;
                }
            }
            return true;
            
        }
        /// <summary>
        /// Convierte el numero binario a un numero decimal
        /// </summary>
        /// <param name="binario">Numero binario a ser convertido a decimal</param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            double numDecimal = 0;
            double numBinario;
            if (EsBinario(binario))
            {
                for (int i = 0; i <= binario.Length-1; i++)
                {
                    double.TryParse(binario[i].ToString(), out numBinario);
                    numDecimal += numBinario * Math.Pow(2, binario.Length - i - 1);
                }
            }
            else
            {
                return "Valor Inválido";
            }
            return numDecimal.ToString();
        }
       
        /// <summary>
        /// Convierte un decimal en binario. Caso contrario retorna un "valor invalido"
        /// </summary>
        /// <param name="numero"> valor a ser convertido en binario</param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string numBinario="";
            long resto;
            long numCociente = (long)numero;

            while(numCociente>0)
            {
                resto = numCociente % 2;
                numCociente = numCociente / 2;

                if(resto!=0)
                {
                    numBinario = "1" + numBinario;
                }
                else
                {
                    numBinario = "0" + numBinario;
                }
            }
            return numBinario;
        }
        /// <summary>
        /// Convierte un decimal en binario. Caso contrario retorna un "valor invalido"
        /// </summary>
        /// <param name="numero">valor a ser convertido en binario </param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double numCociente;
            string retorno = "Valor Inválido";
            if(double.TryParse(numero, out numCociente))
            {
                retorno = this.DecimalBinario(numCociente);
            }
            return retorno;
        }




        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga del operador suma
        /// </summary>
        /// <param name="num1">Primer numero de tipo Operando utilizado para la operacion</param>
        /// <param name="num2">Segundo numero de tipo Operando utilizado para la operacion</param>
        /// <returns></returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador resta
        /// </summary>
        /// <param name="num1">Primer numero de tipo Operando utilizado para la operacion</param>
        /// <param name="num2">Segundo numero de tipo Operando utilizado para la operacion</param>
        /// <returns></returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador multiplicacion
        /// </summary>
        /// <param name="num1">Primer numero de tipo Operando utilizado para la operacion</param>
        /// <param name="num2">Segundo numero de tipo Operando utilizado para la operacion</param>
        /// <returns></returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador division
        /// </summary>
        /// <param name="num1">Primer numero de tipo Operando utilizado para la operacion</param>
        /// <param name="num2">Segundo numero de tipo Operando utilizado para la operacion<</param>
        /// <returns></returns>
        public static double operator /(Operando num1, Operando num2)
        {
            if(num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }

       
        #endregion
    }
}
