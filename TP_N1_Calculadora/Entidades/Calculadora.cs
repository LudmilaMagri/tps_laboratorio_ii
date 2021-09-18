using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
       
        /// <summary>
        /// Validar que el operador recibido sea +, - , / o *. Caso contrario retorna + 
        /// </summary>
        /// <param name="operador">Operador ingresado a ser validado </param>
        /// <returns></returns>

        private static char ValidarOperador(char operador)
        {
            switch(operador)
            {
                case '+':
                    return '+';
                case '-':
                    return '-';
                case '/':
                    return '/';
                case '*':
                    return '*';
            }
            return '+';
        }

        /// <summary>
        /// Valida y realiza la operacion requerida entre ambos numeros ingresados.
        /// </summary>
        /// <param name="num1">Primer numero de tipo Operando utilizado para la operacion</param>
        /// <param name="num2">Segundo numero de tipo Operando utilizado para la operacion</param>
        /// <param name="operador"> Operador a ser utilizado en el calculo </param>
        /// <returns></returns>

        public double Operar (Operando num1, Operando num2, char operador)
        {
            char operadorValidado = ValidarOperador(operador);
            
            double resultado = 0;
            
            switch(operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
    }
}
