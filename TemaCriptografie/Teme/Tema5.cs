using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TemaCriptografie.Library;

namespace TemaCriptografie.Teme
{
    internal class Tema5 : TemeBP // Cilindrul Jefferson - in lucru
    {
        int n;
        char[,] cilindru;
        int[] key;
        internal override void Cripatare()
        {           
            Console.Write("Numarul de discuri: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Text: ");
            string text = Console.ReadLine();
            int index = text.Length;
            key = new int[index];
            string t = "";            

            //generare cilindru
            cilindru= new char[26,n];
            char a = 'a';
            for (int i = 0; i < n; i++)
            {                 
                for (int j = 0; j < 26; j++)
                {
                    cilindru[j, i] = a;
                    a++;
                }
                a = 'a';
            }

            MatrixEdit Matrix = new MatrixEdit();
            Matrix.MatrixRandomize(cilindru);
            show(cilindru, n);
            
            //caut literele pe discuri
            int count = 0;//literele
            int contor = 0;//coloanele
            while(contor != n) 
            { 
                for(int i = 0; i < 26; i++)
                {
                    if (count != index)
                    {
                        char b = text[count];
                        if (contor != n && cilindru[i, contor] == b)
                        {
                            Console.WriteLine("i = " + i + " j= " + contor);
                            key[contor] = i;
                            if(cilindru[i, contor] == 'z')
                            {
                                t += 'a';
                                key[contor] = 0;
                            }
                            else
                            {
                                t += cilindru[i+1, contor];
                            }
                            contor++;
                            count++;                           
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i< key.Length; i++)
            {
                Console.Write(key[i]+ " ");
            }
            Console.WriteLine();
            for(int i = 0; i < t.Length; i++)
            {
                Console.Write(t[i]+ " ");
            }
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
