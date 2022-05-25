using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern.Classes
{
    public class Fenerbahce : ITakim
    {
        public string GetTakimRengi()
        {
            return "Lacivert - Sari";
        }
    }
}