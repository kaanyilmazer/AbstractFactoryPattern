using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class PttLigFactory : ITakimFactory
    {
        public IOyuncular CreateOyuncular()
        {
            return new PttLigOyuncu();
        }

        public ITakim CreateTakim()
        {
            return new Sakaryaspor();
        }
    }
}
