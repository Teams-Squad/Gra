using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    class Sypialnia
    {
        public static void glowny()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#              SYPIALNIA             #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] ŁÓŻKO                        #");
                Console.WriteLine("#   [2] DYWAN                        #");
                Console.WriteLine("#   [3] SZAFA                        #");
                Console.WriteLine("#   [4] KOMODA                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [5] KORYTARZ                     #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lozko();
                if (cki.Key == ConsoleKey.D2) dywan();
                if (cki.Key == ConsoleKey.D3) szafa();
                if (cki.Key == ConsoleKey.D4) komoda();
                if (cki.Key == ConsoleKey.D5)  Korytarz.glowny();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.D6);
            Korytarz.glowny();
        }
        private static void lozko()
        {
            int exit = 0;
            ConsoleKeyInfo cki;
            do
            {
                exit = 0;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          SYPIALNIA: ŁÓŻKO          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#      KLASYCZNE DREWNIANE ŁÓŻKO     #");
                Console.WriteLine("#  Z MATERACEM, POŚCIELĄ I PODUSZKĄ  #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ POD PODUSZKĄ         #");
                Console.WriteLine("#   [2] SPRAWDŹ POD MATERACEM        #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] WRÓĆ                         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D1)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#     SYPIALNIA: ŁÓŻKO: PODUSZKA     #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#     NIESTETY NIC NIE ZNALAZŁEŚ     #");
                        Console.WriteLine("#            POD PODUSZKĄ            #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
                if (cki.Key == ConsoleKey.D2)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#     SYPIALNIA: ŁÓŻKO: MATERAC      #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#     PO ZNALEZIONYM PRZEZ CIEBIE    #");
                        Console.WriteLine("#      PRZEDMIOCIE MASZ PEWNOŚĆ,     #");
                        Console.WriteLine("#   ŻE TO ŁÓŻKO NALEŻĄCE DO KOBIETY  #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
            } while (cki.Key != ConsoleKey.R || exit == 1); // nie umieszczamy powrotu, bo wróci nam do funkcji głównej, jak nie damy exita to powrót z np PODUSZKA da nas do sypialni
        }
        private static void dywan()
        {
            int exit = 0;
            ConsoleKeyInfo cki;
            do
            {
                exit = 0;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          SYPIALNIA: DYWAN          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#       SZARY, WŁOCHATY DYWAN,       #");
                Console.WriteLine("#       WYGLĄDA TROCHĘ JAK MOP       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ POD DYWANEM          #");
                Console.WriteLine("#   [2] SPRAWDŹ WE WŁOSIU            #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] WRÓĆ                         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D1)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#    SYPIALNIA: DYWAN: SPÓD DYWANU   #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#       KILKA RYS NA PANELACH,       #");
                        Console.WriteLine("#       GODNE ZAKRYCIA DYWANEM       #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
                if (cki.Key == ConsoleKey.D2)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#      SYPIALNIA: DYWAN: WŁOSIE      #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#          ZNALAZŁEŚ KLUCZ!:         #");
                        Console.WriteLine("#         MOŻLIWE, ŻE PASUJE         #");
                        Console.WriteLine("#        DO DRZWI WYJŚCIOWYCH        #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        Program.znalezienieKlucza();
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
            } while (cki.Key != ConsoleKey.R || exit == 1);
        }
        private static void szafa()
        {
            int exit = 0;
            ConsoleKeyInfo cki;
            do
            {
                exit = 0;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          SYPIALNIA: SZAFA          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#       BIAŁA PROSTOKĄTNA SZAFA,     #");
                Console.WriteLine("#         NIC NADZWYCZAJNEGO         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ WIERZCH SZAFY        #");
                Console.WriteLine("#   [2] SPRAWDŹ ŚRODEK SZAFY         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] WRÓĆ                         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D1)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#     SYPIALNIA: SZAFA: WIERZCH      #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#     OPRÓCZ KURZU NIC TU NIE MA     #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
                if (cki.Key == ConsoleKey.D2)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#      SYPIALNIA: SZAFA: ŚRODEK      #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#     SĄ TU SUKIENKI, PŁASZCZE,      #");
                        Console.WriteLine("#     CO NAJMNIEJ KILKADZIESIĄT      #");
                        Console.WriteLine("#     RODZAJÓW KROJÓW I KOLORÓW,     #");
                        Console.WriteLine("#     NA DOLE UPORZĄDKOWANE BUTY     #");
                        Console.WriteLine("#          NA KAŻDĄ OKAZJĘ           #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [1] SPRAWDŹ ŚCIANKĘ              #");
                        Console.WriteLine("#       ZA UBRANIAMI                 #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                        if (cki.Key == ConsoleKey.D1)
                        {
                            do
                            {
                                exit = 2;
                                Console.Clear();
                                Console.WriteLine("######################################");
                                Console.WriteLine("# SYPIALNIA: SZAFA: ŚRODEK: ŚCIANKA  #");
                                Console.WriteLine("######################################");
                                Console.WriteLine("#                                    #");
                                Console.WriteLine("#     KILKA ARAFATEK, NIC WIĘCEJ     #");
                                Console.WriteLine("#                                    #");
                                Console.WriteLine("#   [R] WRÓĆ                         #");
                                Console.WriteLine("#                                    #");
                                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                                Console.WriteLine("#                                    #");
                                Console.WriteLine("######################################");
                                cki = Console.ReadKey();
                                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                            } while (cki.Key != ConsoleKey.R);
                        }
                    } while (cki.Key != ConsoleKey.R || exit == 2);
                }
            } while (cki.Key != ConsoleKey.R || exit == 1);
        }
        private static void komoda()
        {
            int exit = 0;
            ConsoleKeyInfo cki;
            do
            {
                exit = 0;
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#         SYPIALNIA: KOMODA          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#      STYLOWA KOMODA, VINTAGE,      #");
                Console.WriteLine("#       WYGLĄDA JAK Z JAKIEGOŚ       #");
                Console.WriteLine("#            FILMU NOIRE             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ SZUFLADĘ             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [R] WRÓĆ                         #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1)
                {
                    do
                    {
                        exit = 1;
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#     SYPIALNIA: KOMODA: SZUFLADA    #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#      JAKIEŚ LEKI I SUPLEMENTY,     #");
                        Console.WriteLine("#           NIC ISTOTNEGO            #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [R] WRÓĆ                         #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("######################################");
                        cki = Console.ReadKey();
                        if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                    } while (cki.Key != ConsoleKey.R);
                }
            } while (cki.Key != ConsoleKey.R || exit == 1);
        }
    }
}
