using System;

namespace Gra
{
    class Kuchnia
    {




        public static void palenisko()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          PIEC: PALENISKO           #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] PRZESZUKAJ POPIÓŁ            #");
                Console.WriteLine("#   [2] OBEJRZYJ KOMIN               #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                //if (cki.Key == ConsoleKey.D1) popiol();
                //if (cki.Key == ConsoleKey.D2) komin();
                if (cki.Key == ConsoleKey.D3) piec();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); piec();
        }

        public static void obraz()
        {
            ConsoleKeyInfo cki;
        }

        public static void figurka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         PIEC: PÓŁKA: FIGURKA       #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) figurka();
                if (cki.Key == ConsoleKey.D2) obraz();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key == ConsoleKey.R); piec();
        }

        public static void polka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#             PIEC: PÓŁKA            #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ FIGURKĘ              #");
                Console.WriteLine("#   [2] OBEJRZYJ OBRAZ               #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) figurka();
                if (cki.Key == ConsoleKey.D2) obraz();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key == ConsoleKey.R); piec();
        }

        public static void stojak()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#             PIEC: STOJAK           #");
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
            } while (cki.Key == ConsoleKey.R); piec();
        }

        public static void piec()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#                PIEC                #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ PALENISKO            #");
                Console.WriteLine("#   [2] OBEJRZYJ PÓŁKĘ               #");
                Console.WriteLine("#   [3] SPRAWDŹ STOJAK NA DREWNO     #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) palenisko();
                if (cki.Key == ConsoleKey.D2) polka();
                if (cki.Key == ConsoleKey.D3) stojak();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }









        public static void lodowka_otworzam()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#        LODÓWKA: ZAMRAŻARKA         #");
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
                Console.WriteLine("#   [1] OTWÓRZ                       #");
                Console.WriteLine("#   [2] OTWÓRZ ZAMRAŻARKĘ            #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lodowka_otworz();
                if (cki.Key == ConsoleKey.D2) lodowka_otworzam();
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

        public static void zmywarka_otworz()
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

        public static void zmywarka_przyjrzyj()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#        ZMYWARKA: PRZYJRZYJ         #");
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
            } while (cki.Key != ConsoleKey.R); zmywarka();
        }


        public static void zmywarka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              ZMYWARKA              #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] OTWÓRZ                       #");
                Console.WriteLine("#   [2] PRZYJRZYJ SIĘ                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] POWRÓT                       #"); 
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE                      #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) zmywarka_otworz();
                if (cki.Key == ConsoleKey.D2) zmywarka_przyjrzyj();
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
                Console.WriteLine("#              KUCHNIA               #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] ZMYWARKA                     #");
                Console.WriteLine("#   [2] LODÓWKA                      #");
                Console.WriteLine("#   [3] PIEC                         #");
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
                if (cki.Key == ConsoleKey.D3) piec();
                if (cki.Key == ConsoleKey.D4) Korytarz.glowny();
                if (cki.Key == ConsoleKey.D5) Salon.glowny();

            } while (cki.Key != ConsoleKaey.Q); Program.wyjscie();
        }
    }
}
