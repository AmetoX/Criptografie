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
        public string toLower(string text)
        {
            
            string lower = "";
            for (int i = 0; i < text.Length; i++)
            {
                string aux = text[i].ToString().ToLower();
                lower += aux;               
            }         
           
            return lower;
        }
    }
}
