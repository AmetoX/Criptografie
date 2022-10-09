using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCriptografie.Teme
{
    internal class Tema2 : TemeBP
    {
        internal override void Problema()
        {
            Criptare();
            DeCriptare();
            DeCriptarev2();
        }

        static int n;
        private void Criptare()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            int index = text.Length;
            string t = "";
            int count = 0;
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
                        for (int i = 0; i < n; i++)
                        {
                            a++;
                        }
                    }
                    t += a;
                }
            }
            Console.WriteLine("Textul codificat: " + t);
        }
        private void DeCriptare()
        {
            Console.Write("Introduceti textul codificat: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t2 = "";
            int count = 0;
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
                        for (int i = 0; i < n; i++)
                        {
                            a--;
                        }
                    }
                    t2 += a;
                }
            }
            Console.WriteLine("Textul decodificat: " + t2);
        }
        private void DeCriptarev2()
        {
            Console.Write("Introduceti textul codificat: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t3 = "";
            int count = 0;
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
                        for (int i = 0; i < n; i++)
                        {
                            a--;
                        }
                    }
                    t3 += a;
                }
            }
            Console.WriteLine("Textul decodificat: " + t3);
        }
    }
}
