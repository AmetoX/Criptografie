using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TemaCriptografie.Library
{
    public class Resources  // amestec literele din matrice pe coloane pt ca fiecare coloana are litere de la a - z
    {
        public Resources() { }
        private static int Next(RNGCryptoServiceProvider random)
        {
            byte[] randomInt = new byte[4];
            random.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
            //arr = arr.OrderBy(x => Next(random)).ToArray();
        }
        public char[,] MatrixRandomize(char[,] matrice)
        {
            int n = matrice.GetLength(0);//linii
            int m = matrice.GetLength(1);//coloane
            char[] arr = new char[n];
            RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j] = matrice[j, i];
                }
                arr = arr.OrderBy(x => Next(random)).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrice[j, i] = arr[j];
                }
                
            }
            
            return matrice;
        }
        char[] up;
        int[] frecv;
        private void upper()
        {
            up = new char[26];
            char a = 'A';
            for(int i = 0; i < 26; i++)
            {
                up[i] = a;
                a++;
            }
        }
        public string toLower(string text) // tin minte care litera era upper ca la decriptare sa fie inapoi
        {
            upper();
            frecv = new int[text.Length];
            string lower = "";
            char a = ' ';
            for (int i = 0; i < text.Length; i++)
            {
                a = text[i];
                for(int j = 0;j < up.Length; j++)
                {
                    if(a == up[j])
                    {
                        frecv[i]++;
                        break;
                    }
                }
                string aux = text[i].ToString().ToLower();
                lower += aux;               
            }         
           
            return lower;
        }
        public string toUpper(string text)
        {
            string lower = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (frecv[i] == 1)
                {
                    lower += text[i].ToString().ToUpper();
                }
                else
                {
                    lower+= text[i].ToString();
                }
            }
            return lower;
        }
    }
}
