using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCriptografie
{
    internal abstract class TemeBP
    {
        internal TemeBP() { }
        internal void Run()
        {
            Cripatare();
            DeCriptare();
            CriptoAnaliza();
        }
        internal abstract void Cripatare();
        internal abstract void DeCriptare();
        internal abstract void CriptoAnaliza();
    }
}
