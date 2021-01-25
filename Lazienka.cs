using System;

namespace Gra
{
    class Lazienka
    {
        public static void zlew()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#           ŁAZIENKA: ZLEW           #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void szafka2()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#      ŁAZIENKA: SZAFKI: SZAFKA2     #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); szafka();
        }

        public static void szafka1()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#      ŁAZIENKA: SZAFKI: SZAFKA1     #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); szafka();
        }

        public static void szafka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         ŁAZIENKA: SZAFKI           #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] PIERWSZA SZAFKA              #");
                Console.WriteLine("#   [2] DRUGA SZAFKA                 #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) szafka1();
                if (cki.Key == ConsoleKey.D2) szafka2();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void toaleta()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         ŁAZIENKA: TOALETA          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void prysznic()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         ŁAZIENKA: PRYSZNIC         #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void glowny()
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              ŁAZIENKA              #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] PRYSZNIC                     #");
                Console.WriteLine("#   [2] TOALETA                      #");
                Console.WriteLine("#   [3] SZAFKI                       #");
                Console.WriteLine("#   [4] ZLEW                         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [5] KORYTARZ                     #");
                Console.WriteLine("#   [6] SALON                        #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) prysznic();
                if (cki.Key == ConsoleKey.D2) toaleta();
                if (cki.Key == ConsoleKey.D3) szafka();
                if (cki.Key == ConsoleKey.D4) zlew();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D4) Korytarz.glowny();
                if (cki.Key == ConsoleKey.D5) Salon.glowny();


            } while (cki.Key != ConsoleKey.D5 || cki.Key != ConsoleKey.D6);


        }
    }
}
