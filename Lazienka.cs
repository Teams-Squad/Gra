using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
    class Lazienka
    {
		public static void glowny()                                      //kolejne przejście
		{
			Console.Clear();
			ConsoleKeyInfo cki;

			Console.WriteLine("######################################");
			Console.WriteLine("#               ŁAZIENKA             #");
			Console.WriteLine("######################################");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#   [4] KORYTARZ                     #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#   [Q] WYJŚCIE                      #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("######################################");

			cki = Console.ReadKey();
			


			if (cki.Key == ConsoleKey.D4)  Korytarz.korytarz(); 
			

			if (cki.Key == ConsoleKey.Q) Program.wyjscie();

		}                                                                 //
	}
}
