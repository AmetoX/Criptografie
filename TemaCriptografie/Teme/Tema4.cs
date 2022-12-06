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
            int textcount = 0;int n; int count = 0;          
            if (text != null)
            {
                while (textcount < index)
                {
                    char a = text[textcount];
                    char b = ' ';
                    n = random.Next(1, 26);                                        
                    if (a == b && textcount != index)
                    {
                        textcount++;
                        a = text[textcount];
                        for (int i = 0; i < n; i++)
                        {
                            if (a == 'z')
                            {
                                a = 'a';
                            }
                            else
                                a++;
                        }
                        
                        textcount++;
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
                        
                        textcount++;
                    }
                    key[count] = n;
                    count++;
                    t += a;
                }
            }
            Console.WriteLine("Textul codificat: " + t);
        }

        internal override void DeCriptare()
        {
            Console.Write("Introduceti textul codificat: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t2 = "";
            int textcount = 0, contor = 0;
            if (text != null)
            {
                while (textcount != index)
                {
                    char a = text[textcount];
                    char b = ' ';
                    if (a == b && textcount != index)
                    {
                        textcount++;
                        a = text[textcount];
                        for (int i = 0; i < key[contor]; i++)
                        {
                            if (a == 'z')
                            {
                                a = 'a';
                            }
                            else
                                a--;
                        }
                        contor++;
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
                    textcount++;
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
