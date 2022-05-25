using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class SuperLigFactory : ITakimFactory
    {
        public IOyuncular CreateOyuncular()
        {
            return new SuperLigOyuncular();
        }

        public ITakim CreateTakim()
        {
            return new Fenerbahce();
        }
    }
}
