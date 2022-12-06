using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TemaCriptografie.Library;

namespace TemaCriptografie.Teme
{
    internal class Tema5 : TemeBP // Cilindrul Jefferson - putin diferit
    {
        int n;
        char[,] cilindru;
        int[] key;
        internal override void Cripatare()
        {           
            //Console.Write("Numarul de discuri: ");
            //n = int.Parse(Console.ReadLine());
            Console.Write("Text: ");
            string text = Console.ReadLine();
            int index = text.Length;
            Console.WriteLine("Cilindru va avea: {0} discuri" ,index);
            Console.WriteLine();
            n = index;
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

            Resources resource = new Resources();
            resource.MatrixRandomize(cilindru);
            show(cilindru, n);

            Resources lower = new Resources();
            text = lower.toLower(text);

            //caut literele pe discuri
            int litera = 0;//literele
            int coloana = 0;//coloanele
            while(coloana != n) 
            { 
                for(int i = 0; i < 26; i++)
                {
                    if (litera != index)
                    {
                        int auxRand = i;
                        char b = text[litera];
                        
                        char c = ' ';
                        if (coloana != n && cilindru[i, coloana] == b)
                        {
                            Console.WriteLine("i = " + i + " j= " + coloana);
                            key[coloana] = i;//pozitia pe care se afla litera in coloana
                            
                            for (int j = 0; j < 3; j++)
                            {
                                auxRand +=  1;
                                if(auxRand > 25)
                                {
                                    auxRand = 0;
                                    c = cilindru[auxRand, coloana];
                                }
                                else
                                {
                                    c = cilindru[auxRand, coloana];
                                }

                            }
                            t += c;
                            coloana++;
                            litera++;                           
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
            Console.WriteLine($"Textul criptat este: {t} .");
            //for(int i = 0; i < t.Length; i++)
            //{
            //    Console.Write(t[i]+ " ");
            //}
        }

        internal override void DeCriptare()
        {
            Console.Write("Introduceti textul criptat: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t = "";
            int litera = 0;//literele
            int coloana = 0;//coloanele
            while (coloana != n)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (litera != index)
                    {
                        int auxRand = i;
                        char b = text[litera];
                        char c = ' ';
                        if (coloana != n && cilindru[i, coloana] == b)
                        {
                            Console.WriteLine("i = " + i + " j= " + coloana);
                            key[coloana] = i;//pozitia pe care se afla litera in coloana

                            for (int j = 0; j < 3; j++)
                            {
                                auxRand -= 1;
                                if (auxRand < 0)
                                {
                                    auxRand = 25;
                                    c = cilindru[auxRand, coloana];
                                }
                                else
                                {
                                    c = cilindru[auxRand, coloana];
                                }

                            }
                            t += c;
                            coloana++;
                            litera++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Textul decriptat este: {t}");
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
