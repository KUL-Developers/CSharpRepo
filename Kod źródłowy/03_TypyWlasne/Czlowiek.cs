using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TypyWlasne
{
    class Czlowiek
    {
        public Czlowiek()
        {// To jest domyślny konstruktor.
            
        }

        public Czlowiek(string imie, string nazwisko, DateTime dataUrodzenia, Plec plec)
        {// To jest konstruktor. Wywoływany jest w momencie tworzenia obiektu.
            Imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = dataUrodzenia;
            Plec = plec;
        }

        #region Pola

        public string Imie;
        private string _nazwisko;

        #endregion

        #region Właściwości

        public string Nazwisko// Full property.
        {
            get
            {
                return _nazwisko;
            }
            set
            {
                _nazwisko = value;
            }
        }

        public Plec Plec { get; set; }
        public DateTime DataUrodzenia { get; set; }// Auto property.
        public int WiekWDniach
        {
            get
            {
                return (DateTime.Now.Date - DataUrodzenia.Date).Days;
            }
        }

        #endregion

        #region Metody

        public void WyswietlDane1()
        {
            Console.WriteLine(Imie + " " + Nazwisko + " " + DataUrodzenia + " " + WiekWDniach + " " + Plec);
        }

        public void WyswietlDane2()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", Imie, Nazwisko, DataUrodzenia, WiekWDniach, Plec);
        }

        public void WyswietlDane3()
        {
            Console.WriteLine($"{Imie} {Nazwisko} {DataUrodzenia} {WiekWDniach} {Plec}");
        }

        public string ZwrocDane1()
        {
            return Imie + " " + Nazwisko + " " + DataUrodzenia + " " + WiekWDniach + " " + Plec;
        }
        public string ZwrocDane2()
        {
           return String.Format("{0} {1} {2} {3} {4}", Imie, Nazwisko, DataUrodzenia, WiekWDniach, Plec);
        }
        public string ZwrocDane3()
        {
            return $"{Imie} {Nazwisko} {DataUrodzenia} {WiekWDniach} {Plec}";
        }

        public double DodajDwieLiczby(double liczba1, double liczba2)
        {
            return liczba1 + liczba2;
        }

        #endregion
    }

    #region Typ wyliczeniowy

    public enum Plec
    {
        Kobieta = 1, // Domyślną wartością 1. elementu jest 0.
        Mezczyzna // Każdy kolejny element wynosi {poprzedniElement} + 1 
    }

    #endregion
}
