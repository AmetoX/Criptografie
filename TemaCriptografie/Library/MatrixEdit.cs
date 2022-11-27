using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TemaCriptografie.Library
{
    public class MatrixEdit
    {
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
                m--;
            }
            
            return matrice;
        }
    }
}
