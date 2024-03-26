using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLaço
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de multiplicações: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do:" + numero);
            for (int i = 1; i <= quantidade; i++) ;
            {
                int resultado numero * i;
                Console.WriteLine($"{numero} X {i} = {resultado}");
            }
            Console.ReadKey();
        }
    }
}
