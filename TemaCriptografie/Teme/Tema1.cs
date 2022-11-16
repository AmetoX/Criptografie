using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TemaCriptografie // Cifrul Lui Cezar
{
    internal class Tema1 : TemeBP
    {     
        static int n = 3;
        internal override void Cripatare()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            int index = text.Length;
            string t = "";
            int count = 0;
            if (text != null)
            {
                while (count < index)
                {
                    char a = text[count];
                    char b = ' ';
                    count++;
                    if (a == b && count != index)
                    {
                        a = b;
                        a = text[count];
                        for (int i = 0; i < n; i++)
                        {
                            if (a == 'z')
                            {
                                a = 'a';
                            }
                            else
                                a++;
                        }
                        count++;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if(a == 'z')
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
            int count = 0;
            if (text != null)
            {
                while (count != index)
                {
                    char a = text[count];
                    char b = ' ';
                    count++;
                    if (a == b && count != index)
                    {
                        //a = b;
                        //a = text[count];
                        //for (int i = 0; i < n; i++)
                        //{
                        //    if (a == 'z')
                        //    {
                        //        a = 'a';
                        //    }
                        //    else
                        //        a--;
                        //}
                        //count++;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (a == 'a')
                            {
                                a = 'z';
                            }
                            else
                                a--;
                        }
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
