using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("#   [5] SZAFKA NOCNA                 #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [6] KORYTARZ                     #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [Q] WYJŚCIE Z GRY                #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) lozko();
                if (cki.Key == ConsoleKey.D2) dywan();
                if (cki.Key == ConsoleKey.D3) szafa();
                if (cki.Key == ConsoleKey.D4) komoda();
				if (cki.Key == ConsoleKey.D5) szafkanocna();
                if (cki.Key == ConsoleKey.D6)  Korytarz.korytarz(); //też moje przejście - kamil
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.D6);
            Korytarz.glowny();
        }
        private static void lozko()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#          SYPIALNIA: ŁÓŻKO          #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#      KLASYCZNE DREWNIANE ŁÓŻKO     #");
                Console.WriteLine("#  Z MATERACEM, POŚCIELĄ I PODUSZKĄ  #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] SPRAWDŹ POD PODUSZKĄ         #");
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
                        Console.Clear();
                        Console.WriteLine("######################################");
                        Console.WriteLine("#     SYPIALNIA: ŁÓŻKO: PODUSZKA     #");
                        Console.WriteLine("######################################");
                        Console.WriteLine("#                                    #");
                        Console.WriteLine("#     NIESTETY NIC NIE ZNALAZŁEŚ     #");
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
            } while (cki.Key != ConsoleKey.R);
            // nie umieszczamy powrotu, bo wróci nam do funkcji głównej
        }
        private static void dywan()
        {
            
        }
        private static void szafa()
        {

        }
        private static void komoda()
        {

        }
        private static void szafkanocna()
        {

        }
    }
}
