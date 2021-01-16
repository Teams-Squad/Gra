using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Kuchnia
    {
        


            public static void piec_palenisko()
            {
                ConsoleKeyInfo cki;
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
                Console.WriteLine("#   [3] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                //if (cki.Key == ConsoleKey.D1) piec_palenisko_popiol();
                //if (cki.Key == ConsoleKey.D2) piec_palenisko_komin();
                if (cki.Key == ConsoleKey.D3) piec();
                if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
            }

        public static void piec()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("######################################");
            Console.WriteLine("#                PIEC                #");
            Console.WriteLine("######################################");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [1] SPRAWDŹ PALENISKO            #");
            Console.WriteLine("#   [2] OBEJRZYJ PÓŁKĘ               #");
            Console.WriteLine("#   [3] SPRAWDŹ STOJAK NA DREWNO     #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [4] POWRÓT                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1) piec_palenisko();
            //if (cki.Key == ConsoleKey.D2) piec_polka();
            //if (cki.Key == ConsoleKey.D3) piec_stojak();
            if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
        }







            public static void lodowka_otworzam()
            {
                ConsoleKeyInfo cki;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#        LODÓWKA: ZAMRAŻARKA         #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lodowka();
                if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
            }

            public static void lodowka_otworz()
            {
                ConsoleKeyInfo cki;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          LODÓWKA: OTWÓRZ           #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     tu będzie poetycki tekst       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] POWROT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lodowka();
                if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
            }

        public static void lodowka()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("######################################");
            Console.WriteLine("#              LODÓWKA               #");
            Console.WriteLine("######################################");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [1] OTWÓRZ                       #");
            Console.WriteLine("#   [2] OTWÓRZ ZAMRAŻARKĘ            #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [3] POWROT                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1) lodowka_otworz();
            if (cki.Key == ConsoleKey.D2) lodowka_otworzam();
            if (cki.Key == ConsoleKey.D3) glowny();
            if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
        }

                    public static void zmywarka_otworz_sztucce()
                    {
                        ConsoleKeyInfo cki;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("# KUCHNIA: ZMYWARKA: OTWÓRZ: SZTUĆCE #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [1] POWRÓT                       #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.D1) zmywarka_otworz();
                        if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
                    }

                    public static void zmywarka_otworz_zastawa()
                    {
                        ConsoleKeyInfo cki;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("# KUCHNIA: ZMYWARKA: OTWÓRZ: ZASTAWA #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [1] POWRÓT                       #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.D1) zmywarka_otworz();
                        if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
                    }

                public static void zmywarka_otworz()
                {
                    ConsoleKeyInfo cki;
                    Console.Clear();
                    Console.WriteLine("######################################");
                    Console.WriteLine("#      KUCHNIA: ZMYWARKA: OTWÓZ      #");
                    Console.WriteLine("######################################");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   [1] PRZEJRZYJ ZASTAWĘ            #");
                    Console.WriteLine("#   [2] SPRAWDŹ SZTUĆCE              #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   [3] POWRÓT                       #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("######################################");
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.D1) zmywarka_otworz_zastawa();
                    if (cki.Key == ConsoleKey.D2) zmywarka_otworz_sztucce();
                    if (cki.Key == ConsoleKey.D3) zmywarka();
                    if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
                }

                public static void zmywarka_przyjrzyj()
                {
                    ConsoleKeyInfo cki;
                    Console.Clear();
                    Console.WriteLine("######################################");
                    Console.WriteLine("#    KUCHNIA: ZMYWARKA: PRZYJRZYJ    #");
                    Console.WriteLine("######################################");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   [1] POWRÓT                       #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                    Console.WriteLine("#                                    #");
                    Console.WriteLine("######################################");
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.D1) zmywarka();
                    if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
                }


            public static void zmywarka()
            {
                ConsoleKeyInfo cki;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         KUCHNIA: ZMYWARKA          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   tu będzie jakiś poetycki tekst   #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] OTWÓRZ                       #");
                Console.WriteLine("#   [2] PRZYJRZYJ SIĘ                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [2] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Esc] WYJŚCIE                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");

                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) zmywarka_otworz();
                if (cki.Key == ConsoleKey.D2) zmywarka_przyjrzyj();
                if (cki.Key == ConsoleKey.D3) glowny();
                if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
            }

        public static void glowny()
        {
            Console.Clear();
            ConsoleKeyInfo cki;
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
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");

            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1) zmywarka();
            if (cki.Key == ConsoleKey.D2) lodowka();
			if (cki.Key == ConsoleKey.D3) piec();
            if (cki.Key == ConsoleKey.D4) Korytarz.korytarz();
            if (cki.Key == ConsoleKey.D5) Salon.glowny();
            if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
        }  
    }
}
