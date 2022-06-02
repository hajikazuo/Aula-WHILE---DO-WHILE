using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos__FOR___WHILE___DOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de estrutura WHILE
            int a = 0;

            Console.WriteLine("Antes\n");

            while (a < 0)
            {
                a++;
                Console.WriteLine("Durante\n");
            }
            Console.WriteLine("Depois\n");

            Console.WriteLine("---------------------------");

          
            //Exemplo de estrutura DO WHILE
            int b = 0;

            Console.WriteLine("Antes\n");

            do
            {
                b++;
                Console.WriteLine("Durante\n");
            }while (b < 0);

            Console.WriteLine("Depois\n");
            Console.ReadKey();
        }
    }
}
