using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {

        static void OutputHelloWorld()
        {
            Console.WriteLine("Hello, World\n");
        }



        static void Main(string[] args)
        {
            OutputHelloWorld();
            string stroca = "Dima is very loves Olga";
            Console.WriteLine("Old: {0}", stroca);
            stroca = stroca.Replace('a', 'A');
            Console.WriteLine("New: {0}\n", stroca);

            int[] chislo = new int[] { 1, 3, 7, 45, 7, 9 };

            int tmp;
            for (int i = 0; i < chislo.Length - 1; i++)
            {
                for (int j = i + 1; j < chislo.Length; j++)
                {
                    if (chislo[i]>chislo[j])
                    {
                        tmp = chislo[i];
                        chislo[i] = chislo[j];
                        chislo[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < chislo.Length; i++)
            {
                Console.Write(" " + chislo[i]);
            }
            Console.WriteLine();

            // Console.WriteLine(string.Join(",", chislo));

        }

    }
}

