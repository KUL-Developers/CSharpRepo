using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TypyWlasne
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiek1 = new Czlowiek("Jan", "Kowalski", new DateTime(1994, 3, 27), Plec.Mezczyzna);

            czlowiek1.WyswietlDane1();
            double dodanePrzezCzlowieka = czlowiek1.DodajDwieLiczby(123, 321.123);

            Console.ReadLine();
        }
    }
}
