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
                Console.WriteLine("############################################");
                Console.WriteLine("#              ŁAZIENKA: ZLEW              #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     W KRANIE NIE MA ANI CIEPŁEJ          #");
                Console.WriteLine("#     ANI ZIMNEJ WODY                      #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void szafka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#            ŁAZIENKA: SZAFKA              #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     W SZAFCE ZNAJDUJĄ SIĘ ŚRODKI         #");
                Console.WriteLine("#     PIERWSZEJ POMOCY: NOŻYCZKI,          #");
                Console.WriteLine("#     TERMOMETR, BANDAŻE RÓŻNYCH           #");
                Console.WriteLine("#     ROZMIARÓW, PLASTRY ORAZ              #");
                Console.WriteLine("#     OPAKOWANIE LEKÓW PRZECIWBÓLOWYCH     #");
                Console.WriteLine("#     I MAŚĆ NA OPARZENIA                  #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void toaleta()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#             ŁAZIENKA: TOALETA            #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     WYGLĄDA NA ZADBANĄ                   #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void polka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#         ŁAZIENKA: PRYSZNIC: PÓŁKA        #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     NA PÓŁCE ZNAJDUJE SIĘ JEDYNIE        #");
                Console.WriteLine("#     DO POŁOWY PEŁNA BUTELKA SZAMONU      #");
                Console.WriteLine("#     ORAZ OLIWKOWE MYDŁO W PŁYNIE         #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); prysznic();
        }

        public static void woda()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#         ŁAZIENKA: PRYSZNIC: WODA         #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     COŚ ZABULGOTAŁO W KRANIE,            #");
                Console.WriteLine("#     ALE NIE POLECIAŁA Z NIEGO WODA       #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); prysznic();
        }

        public static void prysznic()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#            ŁAZIENKA: PRYSZNIC            #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     ZA LIMONKOWĄ ZASŁONĄ ZNAJDUJE SIĘ    #");
                Console.WriteLine("#     PRYSZNIC Z WYSOKIM BRODZIKIEM        #");
                Console.WriteLine("#     ORAZ MAŁA PÓŁKA NA PRZEDMIOTY        #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#             CO CHCESZ ZROBIĆ ?           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [1] WŁĄCZ WODĘ                        #");
                Console.WriteLine("#    [2] SPRAWDŹ PÓŁKĘ                     #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) woda();
                if (cki.Key == ConsoleKey.D2) polka();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void glowny()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#                 ŁAZIENKA                 #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [1] PRYSZNIC                          #");
                Console.WriteLine("#    [2] TOALETA                           #");
                Console.WriteLine("#    [3] SZAFKI                            #");
                Console.WriteLine("#    [4] ZLEW                              #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [5] KORYTARZ                          #");
                Console.WriteLine("#    [6] SALON                             #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
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
