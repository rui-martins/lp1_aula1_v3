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
            int x = 2;
            int y = 5;

            string tipo1 = "Esta é a primeira string";
            string tipo2 = @"C:\Users\Rui\Documents\Visual Studio 2017";
            string tipo3 = "\"Esta string esta' entre aspas\"";
            string tipo4 = @"""Esta string esta' entre aspas""";

            string tipo5 = "Uma" + "String" + "Concatenada";
            string tipo6 = "Outros tipos autom. convertidos " + x + "" + y;
            tipo6 += " Adicionar texto no final da string.";
            string tipo7 = $"String interpolada {x} + {y} e' igual a {x + y}";
            string tipo8 = $@"String verbatim e interpolada {x}";

            Console.WriteLine("\n" + tipo1 + "\n" + tipo2 + "\n" + tipo3 + "\n" + tipo4 + "\n" + tipo5 + "\n" + tipo6 + "\n" + tipo7);
        }
    }
}
