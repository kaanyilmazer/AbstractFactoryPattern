using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class RealMadrid : ITakim
    {
        public string GetTakimRengi()
        {
           return  "Black-White";
        }
    }
}