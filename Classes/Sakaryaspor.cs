using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class Sakaryaspor : ITakim
    {
        public string GetTakimRengi()
        {
            return "Yeşil-Siyah";
        }
    }
}