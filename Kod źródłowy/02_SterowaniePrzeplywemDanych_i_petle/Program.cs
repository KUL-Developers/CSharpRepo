using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SterowaniePrzeplywemDanych_i_petle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stałe

            // Stałą oznaczamy słowem kluczowym const
            const int stalaInt = 123;

            // Wartości stałej nie można zmienić
            //stalaInt = 2;

            #endregion

            #region Interakcja z użytkownikiem
            Console.Write("Interakcja z użytkownikiem:\nNapisz cokolwiek: ");

            // Pobieranie danych z klawiatury przy pomocy metody ReadLine() i przypisanie ich do zmiennej
            string danaOdUsera = Console.ReadLine();
            Console.WriteLine("Wpisałeś: {0}", danaOdUsera);

            #endregion

            #region Instrukcja if

            int ifIntA = 1;
            int ifIntB = 2;
            bool warunek = ifIntA < ifIntB;

            Console.WriteLine("\nInstrukcja warunkowa:");
            if (warunek)
            {// Wartość warunku wynosi true, kod pomiędzy tymi nawiasami zostanie wykonany
                Console.WriteLine("Warunek {0} < {1} jest {2}", ifIntA, ifIntB, warunek);
            }
            else
            {// Wartość warunku wynosi false, kod pomiędzy tymi nawiasami nie zostanie wykonany
                Console.WriteLine("Warunek {0} < {1} jest {2}", ifIntA, ifIntB, warunek);
            }

            if (ifIntA > ifIntB)
            {
                Console.WriteLine("Warunek jest prawdziwy, jego wartość to na pewno True");
            }
            else
            {
                Console.WriteLine("Warunek jest fałszywy, jego wartość to na pewno False");
            }

            if (!warunek)
            {
                Console.WriteLine("!warunek");
            }
            else if ("ciag" != "ciag")
            {
                Console.WriteLine("\"ciag\" != \"ciag\"");
            }
            else
            {
                Console.WriteLine("Żaden z warunków nie został spełniony");
            }

            #endregion

            #region Konwertowanie string na inny typ

            Console.WriteLine("\nKonwertowanie danych");
            Console.WriteLine("Typ zmiennej danaOdUsera to {0}, a jej wartość = {1}", danaOdUsera.GetType(), danaOdUsera);

            int przekonwertowanaLiczba;
            // Konwersja danej pobranej z klawiatury do zmiennej przekonwertowanaLiczba i 
            // przypisanie wyniku konwersji do zmiennej czyPowiodloSieKonwertowanie
            bool czyPowiodloSieKonwertowanie = Int32.TryParse(danaOdUsera, out przekonwertowanaLiczba);

            if (czyPowiodloSieKonwertowanie)
            {// Konwersja się powiodła - użytkownik podał liczbę całkowitą
                Console.WriteLine("Typ zmiennej przekonwertowanaLiczba to {0}, a jej wartość = {1}", przekonwertowanaLiczba.GetType(), przekonwertowanaLiczba);
            }
            else
            {// Konwersja się nie powiodła - dana wpisana przez użytkownika nie była liczbą całkowitą
                Console.WriteLine("Nie udało się przekonwertować {0} na liczbę całkowitą {1}", danaOdUsera, przekonwertowanaLiczba);
            }

            #endregion

            #region Switch

            Console.WriteLine("\nInstrukcja wyboru switch:");
            int wartoscSelekcyjna = 2;

            switch (wartoscSelekcyjna)
            {
                case 1:
                    Console.WriteLine("zmienna wartoscSelekcyjna wynosi 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("zmienna wartoscSelekcyjna wynosi 2 albo 3");
                    break;
                default:
                    Console.WriteLine("Wartość selekcyjna nie odpowiada żadnemu ze spodziewanych case'ów.");
                    break;
            }

            #endregion

            #region Typ tablicowy

            // Tablica jest zbiorem/kolekcją zmiennych tego samego typu
            int[] tablicaInt1 = new int[100];// Deklaracja tablicy o rozmiarze 100 elementów
            int[] tablicaInt2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };// Lista inicjalizacyjna
            tablicaInt1[0] = 123;// Przypisanie wartości 123 do pierwszego elementu tablicy
            int zmiennaZTablicy = tablicaInt1[0];// Odczytanie pierwszego elementu tablicy i przypisanie jego wartości do zmienej

            Console.WriteLine("\nTablice:\nWielkość tablicy tablicaInt1 to {0}", tablicaInt1.Length);
            Console.WriteLine("Wielkość tablicy tablicaInt2 to {0}", tablicaInt2.Length);

            Console.WriteLine("Pierwszy element tablicy tablicaInt2 to {0}", tablicaInt2[0]);

            #endregion

            #region Pętle

            #region Pętla while
            // Pętla while będzie powtarzała kod dopóki jej warunek jest prawdziwy
            Console.WriteLine("\nPętla while:");
            int whileVar1 = 2;

            while (whileVar1 > 0)
            {
                Console.WriteLine("whileVar1 = {0}", whileVar1);
                whileVar1--;
            }

            while (whileVar1 > 2)
            {// Przy wartości warunku wynoszącym False, pętla while ani razu nie wykona swojego kodu
                Console.WriteLine("Nie wyświetlę się.");
            }

            #endregion

            #region Pętla do...while
            Console.WriteLine("\nPętla do...while:");
            int doWhileVar1 = 3;

            do
            {// Przy warunku False, kod pętli do..while zostanie wykonany co najmniej 1 raz!
                Console.WriteLine("Wartość warunku pętli wynosi False");
            } while (doWhileVar1 > 3);

            #endregion

            #region Pętla for
            // Pętla działa podobnie jak pętla while
            Console.WriteLine("\nPętla for");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Wartośc zmiennej i = {0}", i);
            }


            #endregion

            #region Pętla foreach
            // Pętla stworzona do iterowania się po wszystkich elementach kolekcji
            Console.WriteLine("\nPętla foreach:");
            int[] tablica2 = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };

            foreach (int element in tablica2)
            {
                Console.WriteLine("1. log: Wchodzimy do pętli. Iterowany element tablicy to {0}", element);

                if (element == 33)
                {
                    Console.WriteLine("iterowany element to 33");
                }
                else if (element == 44)
                {
                    // Słowo continue powoduje przejście do kolejnej iteracji pętli
                    continue;
                }

                Console.WriteLine("2. log: Wychodzimy z pętli. Iterowany element tablicy to {0}", element);
            }


            #endregion

            #endregion

            #region "Praktyczny" przykład

            // Pobierane będą dane od użytkownika z klawiatury, dopóki nie poda on jakiejkolwiek liczby całkowitej
            Console.WriteLine("\n\"Praktyczny przykład\"");
            int podanaLiczba;
            do
            {
                Console.Write("Podaj liczbę całkowitą: ");
            } while (!Int32.TryParse(Console.ReadLine(), out podanaLiczba));

            Console.WriteLine("Podana przez Ciebie liczba całkowita to {0} ", podanaLiczba);

            #endregion

            Console.ReadKey();
        }
    }
}
