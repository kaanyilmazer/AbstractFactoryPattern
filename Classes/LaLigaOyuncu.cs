using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class LaLigaOyuncu : IOyuncular
    {
        public string GetEniyiler()
        {
            return "Karim Benzema";
        }
    }
}