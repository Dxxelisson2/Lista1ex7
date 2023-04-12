using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhasn;
            double km;
            Console.WriteLine("conversor de milhas nauticas para km");

            Console.WriteLine("Digite as milhas nauticas");
            milhasn = double.Parse(Console.ReadLine());
            km = milhasn * 1.852;
            Console.WriteLine("valor em km = "+ km);
        }
    }
}
