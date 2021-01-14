using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Kuchnia
    {
        public static void glowny()
        {
            ConsoleKeyInfo cki;
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
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Escape) Program.wyjscie();
            if (cki.Key == ConsoleKey.D1) zmywarka();
            if (cki.Key == ConsoleKey.D2) lodowka();
            if (cki.Key == ConsoleKey.D2) piec();
            Console.Clear();
        }  

        public static void zmywarka()
        {
            Console.WriteLine("######################################");
            Console.WriteLine("#              ZMYWARKA              #");
            Console.WriteLine("######################################");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [1] OTWÓRZ                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [2] POWRÓT                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
        }

        public static void lodowka()
        {
            Console.WriteLine("######################################");
            Console.WriteLine("#              LODÓWKA               #");
            Console.WriteLine("######################################");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [1] OTWÓRZ                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [2] POWROT                       #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
        }

        public static void piec()
        {
            Console.WriteLine("######################################");
            Console.WriteLine("#                PIEC                #");
            Console.WriteLine("######################################");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [1] SPRAWDŹ PALENISKO            #");
            Console.WriteLine("#   [2]                              #");
            Console.WriteLine("#   [3]                              #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [4]                              #");
            Console.WriteLine("#   [5]                              #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("#   [Esc] WYJŚCIE                    #");
            Console.WriteLine("#                                    #");
            Console.WriteLine("######################################");
        }
    }
}
