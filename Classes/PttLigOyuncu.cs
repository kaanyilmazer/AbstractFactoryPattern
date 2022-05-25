using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class PttLigOyuncu : IOyuncular
    {
        public string GetEniyiler()
        {
            return "Umut Bulut";
        }
    }
}