using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_de_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, numero3;


            Console.WriteLine("Digite o primeiro número:");
             numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
             numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
             numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                int temp = numero1;
                numero1 = numero2;
                numero2 = temp;
            }

            if (numero2 > numero3)
            {
                int temp = numero2;
                numero2 = numero3;
                numero3 = temp;
            }

            //if (numero1 > numero2)
            // {
            // int temp = numero1;
            // numero1 = numero2;
            // numero2 = temp;
            // }

            Console.WriteLine("Números em ordem crescente: {0}, {1}, {2}", numero1, numero2, numero3);


            Console.ReadKey();
        }
    }
}
