using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
   public class FutbolDunyasi
    {
        private readonly ITakim _takim;
        private readonly IOyuncular _oyuncular;

        public FutbolDunyasi(ITakimFactory factory)
        {
            _takim = factory.CreateTakim();
            _oyuncular = factory.CreateOyuncular();

        }

        public string GetFutbolTakımRengi()
        {
            return _takim.GetTakimRengi();
        }

        public string GetFutbolEnİyiler()
        {
            return _oyuncular.GetEniyiler();
        }


    }
}
