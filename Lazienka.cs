using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Lazienka
    {
		public static void glowny()                                      //kolejne przejście
		{
			Console.Clear(); // nie ma pętli, przez co wpisanie czegokolwiek będzie kończyć funkcję
			ConsoleKeyInfo cki;

			Console.WriteLine("######################################");
			Console.WriteLine("#               ŁAZIENKA             #");
			Console.WriteLine("######################################");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#   [R] KORYTARZ                     #"); // zmieniłem z '4' na 'R' - adam
			Console.WriteLine("#			                        #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#   [Q] WYJŚCIE                      #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("######################################");

			cki = Console.ReadKey();
			


			if (cki.Key == ConsoleKey.R) Korytarz.glowny();
			

			if (cki.Key == ConsoleKey.Q) Program.wyjscie();

		}                                                                 //
	}
}
