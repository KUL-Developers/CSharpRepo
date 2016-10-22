using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Zmienne_i_operatory
{
    class Program
    {
        static void Main(string[] args)
        {// Punkt startowy programu

            // Wypisanie ciągu na konsoli i przejście do nowej linii
            Console.WriteLine("Hello World!\n");

            #region Zmienne i deklaracje

            int zmiennaInt;// Deklaracja zmiennej
            zmiennaInt = 123;// Inicjalizacja zmiennej
            double zmiennaDouble = 321.123;// Deklaracja z inicjalizacją
            Console.WriteLine("Zapoznanie ze zmiennymi:\n {0}", zmiennaInt);
            Console.WriteLine(zmiennaDouble);

            bool typBool = false;
            string typString = "Jakiś ciąg znaków";
            char typChar = 'z'; // Typ char zapisaujemy w apostrofach
            int typChar2 = typChar; // Wspomniałem, że litera jest liczbą, to jest najprostrzy dowód na to - hasło znaki ASCII

            #endregion

            #region Operacje na danych
            // Arytmetyczne
            double a = 2;
            double b = 4;
            double wynikDod = a + b;
            Console.WriteLine("\nOperatory arytmetyczne:\na + b = {0}, {1}", wynikDod, "qwe");
            Console.WriteLine("a + b = " + wynikDod + " qwe"); // To samo formatowanie co linijka wyżej, lecz zapisana w inny sposób
            Console.WriteLine("a / b = {0}", a / b);

            // Post i Pre inkrementacja (zwiększenie wartości o 1)
            Console.WriteLine("\nPostinkremenacja:\na = {0}\na++ = {1}", a, a++);
            Console.WriteLine("teraz a = {0}", a);

            Console.WriteLine("\nPreinkrementacja:\na = {0}\n++a = {1}", a, ++a);
            Console.WriteLine("teraz a = {0}", a);
            // Inaczej mówiąc ++x i x++oznacza to samo co: x = x + 1.
            // Jedyna różnica polega na tym kiedy następuje to przypisanie

            // Relacyjne
            int x = 1;
            int y = 2;
            bool wynikRelacjiMniejsze = x < y;
            Console.WriteLine("\nOperatory relacyjne:\nx = {0}, y = {1}, x < y = {2}", x, y, wynikRelacjiMniejsze);
            Console.WriteLine("x = {0}, y = {1}, x > y = {2}", x, y, x > y);

            // Logiczne
            bool prawda = true;
            bool falsz = false;
            bool wynikNegacji = !prawda;
            Console.WriteLine("\nOperatory logiczne:\nprawda = {0}, falsz = {1}, wynikNegacji = {2}", prawda, falsz, wynikNegacji);
            Console.WriteLine("prawda = {0}, falsz = {1}, prawda || falsz = {2}", prawda, falsz, prawda || falsz);
            Console.WriteLine("prawda = {0}, falsz = {1}, prawda && falsz = {2}", prawda, falsz, prawda && falsz);
            // || (LUB) zwraca True jeśli CO NAJMNIEJ 1 operand ma wartość True.
            // && (I) zwraca True jeśli WSZYSTKIE operandy mają wartość True.

            #endregion

            #region Zakres zmiennych
            // Przykład na domyślne działanie zakresu zmiennych

            byte byteExample = 255;
            Console.WriteLine("\nZakres zmiennych:\n" + byteExample);
            Console.WriteLine(byteExample + 1);
            //byteExample = 255 + 1;
            Console.WriteLine(++byteExample);// Przykład działania zakresu przyjmowanych wartości danego typu.
                                             // Domyślnym zachowanie przekroczenia zakresu zmiennych jest "przekręcenie licznika"
                                             //(choć można zmienić to zachowanie o czym kiedyś sobie powiemy).

            #endregion

            #region Znaki specjalne w stringu
            // Przykłdziałania znaków specjalnych

            Console.WriteLine("\nZnaki specjalne:\nC\t#\nK\nU\nL\nN\nE\nT");

            #endregion

            #region Rzutowanie

            // Rzutowanie polega na przedstawienia typu 'x' jako typ 'y'
            int rzutowanyInt = 2;
            double rzutowanyDouble = 3.9999999999;
            int doubleNaInt = (int)rzutowanyDouble;
            Console.WriteLine("\nRzutowanie:\nrzutowanyInt = {0}, rzutowanyDouble = {1}, (int)rzutowanyDouble = {2}", rzutowanyInt, rzutowanyDouble, doubleNaInt);

            #endregion

            /*Komentarz
             Wielolinijkowy
              - ten kod nie będzie interpretowany przez kompilator*/

            // Zastopowanie aplikacji w celu zobaczenia wyniku na konsoli.
            // Konsola czeka na wciśnięcie dowolnego przycisku
            Console.ReadKey();
        }
    }
}
