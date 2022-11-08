using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaCriptografie.Teme;

namespace TemaCriptografie
{
    internal class TemaStart
    {
        internal TemaStart() { }
        internal void Start()
        {
            TemeBP teme;
            List<string> temeList = new List<string>();
            temeList.Add("CezarCypher");temeList.Add("ShiftByN"); temeList.Add("Rot13");
            Console.WriteLine();
            int i = 1;
            foreach(string tema in temeList)
            {
                Console.WriteLine(i + "." + tema);
                i++;
            }
            Console.Write("Alegeti tema dorita: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    teme = new Tema1();
                    teme.Run();
                    break;
                case 2:
                    teme = new Tema2();
                    teme.Run();
                    break;
                case 3:
                    teme = new Tema3();
                    teme.Run();
                    break;
            }
        }
    }
}
