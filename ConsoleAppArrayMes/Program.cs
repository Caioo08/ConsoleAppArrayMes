using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite o número de um mês de 1 a 12");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês escolhido foi " + meses[i-1]);
            Console.ReadKey();
        }
    }
}
