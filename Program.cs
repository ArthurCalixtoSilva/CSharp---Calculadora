using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1- + (Adição)");
            Console.WriteLine("2- - (Subtração)");
            Console.WriteLine("3- / (Divisão)");
            Console.WriteLine("4- * (Multiplicação) ");

            Console.WriteLine();

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;


            switch (operacao)
            {
                case 1:
                    {
                        /*result = num1 + num2;
                        break;
                        */
                        result = adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {

                        result = divisao(num1, num2);
                        break;
                    }
                case 4:
                    {

                        result = mult(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("Número invalido, digite outro numero");

                    break;

            }

            Console.WriteLine($"O resultado da operação com os número {num1} e {num2} é : {result}");















        }
        public static int adicao(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        public static int subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        public static int divisao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        public static int mult(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
    }
}
