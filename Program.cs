using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4_cs_ex3
{

    /*Escreva um programa em C#, seguindo as orientações do início deste documento. O
    seu programa deve receber 3 valores a, b e c, lados de um triângulo, e verificar
    qual é o tipo de triângulo formado retornando:
    • 0 - se o triângulo é retângulo (A^2=B^2+C^2);
    • 1 - se o triângulo é acutângulo (A^2 > B^2 + C^2);
    • 2 - obtusângulo (A^2 < B^2 + C^2).
    Considere que, para aplicar as relações mostradas, o programa deve garantir que
    o maior dos 3 lados estará em A.
    Testar o valor recebido e escrever o tipo do triângulo*/

    public  class Program
    {
        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program()
        {
            Convert Converter = new Convert();
            List<string> listaS = new List<string>();
            List<double> listaD = new List<double>();
            int retorno;

            Console.WriteLine("Digite os 3 valores: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite o valor {0}/3: ", i + 1);
                listaS.Add(Console.ReadLine());
            }
            listaD = listaS.ConvertAll(double.Parse);
            Converter.Logica1(listaD);
            retorno = Converter.Logica2(listaD);
            if (retorno == 0)
            {
                Console.WriteLine("0 - Triângulo Retângulo");
            }
            else if (retorno == 1)
            {
                Console.WriteLine("1 - Triângulo Acutângulo");
            }
            else if (retorno == 2) 
            {
                Console.WriteLine("2 - Triângulo Obtusângulo");
            }
            else
            { 
                Console.WriteLine("Erro");
            }
            Console.ReadKey();
        }
    }
}
