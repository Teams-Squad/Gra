using System;
using System.Threading;

namespace Gra
{
    class Program
    {
        public static int skrytka;
        public static int[] klucz = new int[3];

        public static void nowagra()
        {
            Random rnd = new Random();
            skrytka = rnd.Next(1, 4);
            for (int i = 0; i <= 2; i++) klucz[i] = rnd.Next(1, 10);
            //test
        }
        public static void zasady()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#            ZASADY GRY:             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#       MUSISZ PRZESZUKAĆ DOM,       #");
                Console.WriteLine("#    ABY ZNALEŹĆ KLUCZ DO WYJŚCIA    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#            [1] WYJŚCIE             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.D1);
        }
        public static void wyjscie()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Thread.Sleep(200);
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     CZY NA PEWNO CHCESZ WYJŚĆ?     #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#        [1] TAK      [2] NIE        #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) System.Environment.Exit(0);
            } while (cki.Key != ConsoleKey.D2);
        }
        
        public static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#              KEYSEARCH             #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#           [1] START                #");
                Console.WriteLine("#           [2] ZASADY               #");
                Console.WriteLine("#           [3] WYJŚCIE              #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D3) wyjscie();
                if (cki.Key == ConsoleKey.D2) zasady();
            } while (cki.Key != ConsoleKey.D1);
            Console.Clear();
            Salon.glowny();
        }
    }
}
