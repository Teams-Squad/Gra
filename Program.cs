﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
    class Program
    {
        public static int klucz = 0;
        public static void znalezienieKlucza()
        {
            klucz++;
        }
        public static int czyKlucz()
        {
            if (klucz==0) return 0;
            else return 1;
        }
        public static void loading()
        {
            Console.Clear();
            Random rnd = new Random();
            Console.WriteLine("\n   TRWA ŁADOWANIE");
            Console.Write("   ");
            for (int i = 1; i <= 14; i++)
            {
                int ladowanko = rnd.Next(1, 501);
                Thread.Sleep(ladowanko);
                Console.Write("#");
            }
            Thread.Sleep(1000);
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
                Console.WriteLine("#            [Q] POWRÓT              #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Q); 
        }
        public static void wyjscie()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
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
                Console.WriteLine("#           [Q] WYJŚCIE              #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) wyjscie();
                if (cki.Key == ConsoleKey.D2) zasady();
            } while (cki.Key != ConsoleKey.D1);
            loading();
            Salon.glowny();
        }
    }
}
