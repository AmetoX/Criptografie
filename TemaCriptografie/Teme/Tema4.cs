using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCriptografie.Teme
{
    internal class Tema4 : TemeBP // Permutare Aleatorie
    {
        int[] key;
        internal override void Cripatare()
        {
            Random random = new Random();
            Console.Write("Text: ");
            string text = Console.ReadLine();
            int index = text.Length;
            key= new int[index];
            string t = "";
            int count = 0, n;           
            if (text != null)
            {
                while (count != index)
                {
                    char a = text[count];
                    char b = ' ';
                    n = random.Next(1, 26);
                    key[count] = n;
                    count++;                    
                    if (a == b)
                    {
                        a = b;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (a == 'z')
                            {
                                a = 'a';
                            }
                            else
                                a++;
                        }
                    }
                    t += a;
                }
            }
            Console.WriteLine("Textul codificat: " + t);
        }

        internal override void DeCripatare()
        {
            Console.Write("Introduceti textul codificat: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t2 = "";
            int count = 0, contor = 0;
            if (text != null)
            {
                while (count != index)
                {
                    char a = text[count];
                    char b = ' ';
                    count++;
                    if (a == b)
                    {
                        a = b;
                    }
                    else
                    {
                        
                        for (int i = 0; i < key[contor]; i++)
                        {
                            if (a == 'a')
                            {
                                a = 'z';
                            }
                            else
                                a--;
                        }
                        contor++;
                    }
                    t2 += a;
                }
            }
            Console.WriteLine("Textul decodificat: " + t2);
        }

        internal override void CriptoAnaliza()
        {
            //
        }
    }
}
