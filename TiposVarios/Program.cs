using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo1 = "Esta é a primeira string";
            string tipo2 = @"C:\Users\Rui\Documents\Visual Studio 2017";
            string tipo3 = "\"Esta string esta' entre aspas\"";
            string tipo4 = @"""Esta string esta' entre aspas""";

            Console.WriteLine("\n" + tipo1 + "\n" + tipo2 + "\n" + tipo3 + "\n" + tipo4);
        }
    }
}
