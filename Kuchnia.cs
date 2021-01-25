using System;

namespace Gra
{
    class Kuchnia
    {
        public static void piekarnik()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              PIEKARNIK             #");
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
            } while (cki.Key != ConsoleKey.R); kuchenka();
        }


        public static void czajnik()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         KUCHENKA: CZAJNIK          #");
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
            } while (cki.Key != ConsoleKey.R); kuchenka();
        }


        public static void kuchenka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          KUCHENKA                  #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ CZAJNIK              #");
                Console.WriteLine("#   [2] OTWÓRZ PIEKARNIK             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) czajnik();
                if (cki.Key == ConsoleKey.D2) piekarnik();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }
















        public static void lodowka_otworz()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          LODÓWKA: OTWÓRZ           #");
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
            } while (cki.Key != ConsoleKey.R); lodowka();
        }

        public static void lodowka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              LODÓWKA               #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie tekst                  #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lodowka_otworz();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void zmywarka_otworz_sztucce()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#      ZMYWARKA: OTWÓRZ: SZTUĆCE     #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); zmywarka_otworz();
        }

        public static void zmywarka_otworz_zastawa()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#      ZMYWARKA: OTWÓRZ: ZASTAWA     #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); zmywarka_otworz();
        }

        public static void zmywarka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#           ZMYWARKA: OTWÓZ          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] PRZEJRZYJ ZASTAWĘ            #");
                Console.WriteLine("#   [2] SPRAWDŹ SZTUĆCE              #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) zmywarka_otworz_zastawa();
                if (cki.Key == ConsoleKey.D2) zmywarka_otworz_sztucce();

                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); zmywarka();
        }

      

        

        
        public static void glowny()
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              KUCHNIA               #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] ZMYWARKA                     #");
                Console.WriteLine("#   [2] LODÓWKA                      #");
                Console.WriteLine("#   [3] KUCHENKA                     #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [4] KORYTARZ                     #");
                Console.WriteLine("#   [5] SALON                        #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) zmywarka();
                if (cki.Key == ConsoleKey.D2) lodowka();
                if (cki.Key == ConsoleKey.D3) kuchenka();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D4) Korytarz.glowny();
                if (cki.Key == ConsoleKey.D5) Salon.glowny();


            } while (cki.Key != ConsoleKey.D5 || cki.Key != ConsoleKey.D4);
            
            
        }
    }
}
