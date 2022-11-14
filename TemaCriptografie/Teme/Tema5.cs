using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCriptografie.Teme
{
    internal class Tema5 : TemeBP // Cilindrul Jefferson
    {
        int n;
        char[,] cilindru;
        internal override void Cripatare()
        {
            Console.Write("Numarul de discuri: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Text: ");
            string text = Console.ReadLine();
            int index = text.Length;
            cilindru= new char[26,n];
            char a = 'a';
            for (int i = 0; i < 26; i++)
            {
                 
                for (int j = 0; j < n; j++)
                {
                    cilindru[i, j] = a;                   
                }
                a++;
            }


            show(cilindru, 5);
        }

        internal override void DeCripatare()
        {
            
        }

        internal override void CriptoAnaliza()
        {
            //
        }

        private static void show(char[,] chars, int m)
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(chars[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
