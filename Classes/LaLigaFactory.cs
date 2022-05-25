using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    class LaLigaFactory : ITakimFactory
    {
        public IOyuncular CreateOyuncular()
        {
           return new LaLigaOyuncu();
        }

        public ITakim CreateTakim()
        {
            return new RealMadrid();
        }
    }
}
