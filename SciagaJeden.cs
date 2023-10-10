namespace ConsoleApp // Przestrzeń nazw
{
    internal class SciagaJeden //Nazwa klasy naszego programu
    {
        static void Main(string[] args) // Główna statyczna funkcja programu, o typie zwrotnym void
        {
            // #region służy do oznaczania sekcji kodu, służy on tylko do uporządkowania, zrobiłem to by można było chować sobie dane sekcje

            #region Wypisywanie danych do konsoli
            // Wypisywanie tekstu w konsoli z przejściem do nowej linii na końcu
            Console.WriteLine("Hello, World!");

            // Wypisywanie tekstu w konsoli bez przejścia do nowej linii na końcu
            Console.Write("Kolejny napis nie będzie w nowej linii");
            Console.WriteLine("Ten tekst pojawił się w tej samej linii, ale kolejny będzie niżej");

            #endregion

            #region Typy zmiennych
            // Liczba całkowita 32 bitowa
            int liczbaInt = 10;

            // Liczba całkowita 64 bitowa
            long liczbaLong = 10L; // DO LONG'A TRZEBA DODAĆ 'L' NA KONIEC LICZBY

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            // Jeżeli do int lub long dodamy sprzodu u -> uint, ulong -> możemy przechowywać liczby tylko >= 0 //
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // Liczba zmiennoprzecinkowa 32 bitowa wartość
            float liczbaFloat = 20.0F; // DO FLOAT'A TRZEBA DODAĆ 'F' NA KONIEC LICZBY

            // Liczba zmiennoprzecinkowa 64 bitowa wartość
            double liczbaDouble = 20.0D; // DO DOUBLE'A TRZEBA DODAĆ 'D' NA KONIEC LICZBY

            // Tekst
            string jakisTekst = "Tutaj dajemy tekst"; 

            // Boolean - prawda/fałsz
            bool prawdaFalsz = true;

            #endregion

            #region Wprowadzanie danych z konsoli

            ///////////////////////////////////
            // Wprowadzanie tekstu z consoli //
            ///////////////////////////////////

            Console.Write("Wprowadź tekst: ");
            string zmiennaZTekstem = Console.ReadLine(); // Sytuacja analogincza do WriteLine, samo Console.Read
                                                         // nie przeniesie nas do nastepnej linii
            Console.WriteLine("Wprowadzony tekst: " + zmiennaZTekstem);


            ///////////////////////////////////////////////////
            // Wprowadzanie liczby z konsoli z użyciem Parse //
            ///////////////////////////////////////////////////

            Console.Write("Wprowadź liczbę całkowitą: ");
            int zmiennaZLiczba = Int32.Parse(Console.ReadLine()); // przez dopisanie 'Int32.Parse(...)' powodujemy że nasz
                                                                  // tekst zostanie zmieniony w int, jednak jeżeli podamy
                                                                  // znaki inne niż liczba całkowita program się wysypie.
                                                                  // W tym przypadku trzeba użyć TryParse()
            Console.WriteLine("Liczba z Parse: " + zmiennaZLiczba);


            //////////////////////////////////////////////////////
            // Wprowadzanie liczby z konsoli z użyciem TryParse //
            //////////////////////////////////////////////////////

            Console.Write("Wprowadź liczbę całkowitą: ");
            int zmiennaZLiczbaTry = 0;
            Int32.TryParse(Console.ReadLine(), out zmiennaZLiczbaTry); // Jeżeli się uda to zamieni na liczbe,
            Console.WriteLine("Liczba z try: " + zmiennaZLiczbaTry);   // jeżeli nie, to zignoruje błąd i pójdzie dalej

            // TryParse potrzebuje w () dwóch wartości:
            // pierwsza to dane które chcemy zamienić
            // druga po przecinku wraz z 'out' to nazwa zmiennej do której zapiszemy dane po zamianie


            #endregion

            #region Instrukcje warunkowe
            ////////////////////////////////////////////
            // Instrukcja warunkowa if, else if, else //
            ////////////////////////////////////////////

            // Przykład 1
            int jakisInt = 10;

            if (jakisInt > 5)
            {
                Console.WriteLine("Wykonał się if dla inta");
            }


            // Przykład 2
            bool jakisBool = true;

            if (jakisBool)
            {
                Console.WriteLine("Wykonał się if dla booleana");
            }


            // Przykład 3
            string smutnyString = "smutek";

            if (smutnyString != "smutek") // UWAGA! W przypadku instrukcji warunkowych, wielkość liter ma znaczenie!
            {
                Console.WriteLine("Nasza zmienna nie jest smutna");
            }
            else
            {
                Console.WriteLine("Nasza zmienna jest smutna");
            }


            // Przykład 4
            int fajnyInt = 20;
            bool fajnyBool = false;

            if (fajnyBool)
            {
                Console.WriteLine("To by się wykonało gdyby fajnyBool był równy True");
            }
            else if (fajnyInt < 40)
            {
                Console.WriteLine("To się wykonało bo jakisInt jest mniejszy od 40");
            }
            else
            {
                Console.WriteLine("To się nie wykonało ponieważ wcześniejszy 'else if' był prawdą");
            }


            // Przykład 5
            bool falszywyBool = false;

            if (!falszywyBool)
            {
                Console.WriteLine("Wykonał się if dla booleana");
            }

            //////////////////////////////////////
            // Instrukcja warunkowa switch case //
            //////////////////////////////////////

            // Przykład 1
            string tekstSwitcha = "Kot";

            switch (tekstSwitcha)
            {
                case "Kot": // <-- Dwukropek, nie średnik
                    Console.WriteLine("Miau");
                    break; // Polecenie przerwania -> wytłumaczone w dziale pętle
                case "Pies": // <-- Dwukropek, nie średnik
                    Console.WriteLine("Hau");
                    break; // Polecenie przerwania -> wytłumaczone w dziale pętle
                default:
                    Console.WriteLine("Nie wiem jaki oddgłos wydaje to zwierze");
                    break; // Polecenie przerwania -> wytłumaczone w dziale pętle
            }
            // W tym przypadku w konsoli pojawi się napis "Miau"


            // Przykład 2
            string drugiTekstSwitcha = "Ryba"; // UWAGA! W przypadku instrukcji warunkowych, wielkość liter ma znaczenie!

            switch (drugiTekstSwitcha)
            {
                case "Kot": // <-- Dwukropek, nie średnik
                    Console.WriteLine("Miau");
                    break;
                case "Pies": // <-- Dwukropek, nie średnik
                    Console.WriteLine("Hau");
                    break;
                default:
                    Console.WriteLine("Nie wiem jaki oddgłos wydaje to zwierze");
                    break;
            }
            // W tym przypadku wykona się opcja default ponieważ nie mamy zdefiniowanej wartości "Ryba"

            #endregion

            #region Pętle

            /////////////////
            // Pętla while //
            /////////////////

            int zmiennaWhile = 0;

            while (zmiennaWhile < 10) // dopóki zmiennaWhile < 0 to wykonuj pętle
            {
                Console.WriteLine("Liczba w while: " + zmiennaWhile);
                zmiennaWhile++; // ++ oznacza inkrementacje, czyli zwiększenie się liczby o 1
            }


            //////////////////////
            // Pętla do...while //
            //////////////////////

            int drugaZmiennaWhile = 5;

            do // zrób...
            {
                Console.WriteLine("Liczba w do...while: " + drugaZmiennaWhile);
                drugaZmiennaWhile--; // -- oznacza dekrementacje, czyli zmniejszenie się liczby o 1
            }
            while (drugaZmiennaWhile > 10); // dopóki drugaZmiennaWhile > 10

            // Pętla wykonała się pomimo niespełnionego warunku, ponieważ pętla do...while
            // najpierw wykonuje powtórzenie, a potem sprawdza czy warunek jest spełniony
            // reszta działania jest taka sama.


            ///////////////
            // Pętla for //
            ///////////////

            for (int i = 0; i < 10; i++) // dla i = 0; dopóki i < 10; z każdym powtórzeniem wykonaj i++, czyli zwiększ o 1
            {
                Console.WriteLine("Liczba w for: " + i);
            }

            /////////////////////////
            // Zagnieżdzanie pętli //
            /////////////////////////

            // Przykład: Tabliczka mnożenia 10x10

            Console.WriteLine("Tabliczka mnożenia 10x10");
            for (int j = 1; j <= 10; j++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write(k * j + " \t"); // \t to znak "taba", wykonuje on tą samą akcje co klawisz TAB w edytorach tekstowych
                }
                Console.WriteLine(); // Pusty WriteLine by przejść no nowej linii
            }

            /////////////////////
            // Polecenie break //
            /////////////////////
            
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine("Liczba w pętli for z break: " + l);
                if (l == 5) // Jeżeli l będzie równe 5...
                {
                    break; // Przerwij/zakończ pętle
                }
            }

            ////////////////////////
            // Polecenie continue //
            ////////////////////////

            for (int m = 0; m < 20; m++)
            {
                if (m == 10) // Jeżeli m będzie równe 10...
                {
                    continue; // Zignoruj dalszy kod w pętli i przejdź do kolejnego powtórzenia pętli
                }
                Console.WriteLine("Liczba w pętli for z continue: " + m);
            }

            #endregion
        }
    }
}