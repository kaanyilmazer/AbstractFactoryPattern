using System;
using AbstractFactoryPattern.Classes;
    using AbstractFactoryPattern.İnterfaces;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITakimFactory turkiye = new SuperLigFactory();

            FutbolDunyasi fdunya = new FutbolDunyasi(turkiye);

            Console.WriteLine("Fenerbahçe Takım Rengi:" + " \n" + fdunya.GetFutbolTakımRengi());
            Console.WriteLine("SüperLig Gol Kralı :" + " \n" + fdunya.GetFutbolEnİyiler());

            ITakimFactory laliga = new LaLigaFactory();
            FutbolDunyasi fdunya1 = new FutbolDunyasi(laliga);

            Console.WriteLine("Real Madrid Takım Rengi :"  + "\n"+ fdunya1.GetFutbolTakımRengi());
            Console.WriteLine("LaLiga Gol Kralı :" +" \n" + fdunya1.GetFutbolEnİyiler());

            Console.ReadKey();        }
    }
}
