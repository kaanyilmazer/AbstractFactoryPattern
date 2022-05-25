using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.İnterfaces
{
    public interface ITakimFactory
    {
        ITakim CreateTakim();
        IOyuncular CreateOyuncular();
    }
}
