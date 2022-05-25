using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class SuperLigOyuncular : IOyuncular
    {
        public string GetEniyiler()
        {
            return "Enner GOAT Valencia";
        }
    }
}