using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
	class Drzwi
	{







		public static void glowny() // lepiej zrobiæ 'glowny' bo potem bêdzie ³atwiej pisaæ
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;

				Console.WriteLine("######################################");
				Console.WriteLine("#              Drzwi                 #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [1] WYCIERACZKA                  #");
				Console.WriteLine("#   [2] WIESZAK NA KLUCZE            #");
				Console.WriteLine("#                                    #"); 
				Console.WriteLine("#   [3] KORYTARZ                     #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [Q] WYJŒCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();
				if (cki.Key == ConsoleKey.D3)  Korytarz.glowny(); 
				

			}

		}
	}
}

