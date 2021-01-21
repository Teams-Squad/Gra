using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Korytarz
    {
		public static void glowny() // poprawa nazwy - adam
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;

				Console.WriteLine("######################################");
				Console.WriteLine("#              KORYTARZ              #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [1] OBRAZY                       #");
				Console.WriteLine("#   [2] KOMODA                       #");
				Console.WriteLine("#   [3] ZWISAJĄCA LAMPA              #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [4] SALON                        #");
				Console.WriteLine("#   [5] KUCHNIA                      #");
				Console.WriteLine("#   [6] ŁAZIENKA                     #");
				Console.WriteLine("#   [7] SYPIALNIA                    #");
				Console.WriteLine("#   [8] DRZWI                        #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();
				if (cki.Key == ConsoleKey.D4)  Salon.glowny();
				if (cki.Key == ConsoleKey.D5)  Kuchnia.glowny();
				if (cki.Key == ConsoleKey.D6)  Lazienka.glowny();
				if (cki.Key == ConsoleKey.D7)  Sypialnia.glowny(); // poprawa nazwy - adam
				if (cki.Key == ConsoleKey.D8)  Drzwi.drzwi();

			}

		}
	}
}
