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
            teme = new Tema1();
            teme.Run();
            teme = new Tema2();
            teme.Run();
            teme = new Tema3();
            teme.Run();
        }
    }
}
