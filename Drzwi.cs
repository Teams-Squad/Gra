using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
	class Drzwi
	{
		private static void Wieszak()
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;
				do
				{


					Console.WriteLine("#########################################");
					Console.WriteLine("#             DRZWI: WIESZAK            #");
					Console.WriteLine("#########################################");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#  TO BY BY�O ZA PROSTE ...             #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#   [R] POWR�T                          #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#   [Q] WYJ�CIE                         #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#########################################");

					cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.R) Pod_wycieraczk�();
				} while (cki.Key == ConsoleKey.Q); Program.wyjscie();


			}

		}

		private static void Pod_wycieraczk�()
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;
				do
				{


					Console.WriteLine("#########################################");
					Console.WriteLine("#  DRZWI: WYCIERACZKA: POD WYCIERACZK�  #");
					Console.WriteLine("#########################################");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#  POD WYCIERACZK� WIDNIEJE STERTA ,    #");
					Console.WriteLine("#  PIACHU .                             #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#   [R] POWR�T                          #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#   [Q] WYJ�CIE                         #");
					Console.WriteLine("#                                       #");
					Console.WriteLine("#########################################");

					cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.R) Pod_wycieraczk�();
				} while (cki.Key == ConsoleKey.Q); Program.wyjscie();


			}

		}





		private static void Wycieraczka()
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;
				do
				{


					Console.WriteLine("######################################");
					Console.WriteLine("#         DRZWI: WYCIERACZKA         #");
					Console.WriteLine("######################################");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#  STARA WYCIERACZKA FILCOWA,        #");
					Console.WriteLine("#  TEGO WYNALAZKU NIESPOTYKA SI�,    #");
					Console.WriteLine("#  CODZIENNIE.                       #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#        CO CHCESZ ZROBI� ?          #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [1] SPRAWD� POD WYCIERACZK�      #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [R] POWR�T                       #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [Q] WYJ�CIE                      #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("######################################");

					cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.D1) Pod_wycieraczk�();
				} while (cki.Key == ConsoleKey.R); Drzwi.glowny();


			}

		}




		public static void glowny() // lepiej zrobi� 'glowny' bo potem b�dzie �atwiej pisa�
		{
			{
				Console.Clear();
				ConsoleKeyInfo cki;
				do
				{


					Console.WriteLine("######################################");
					Console.WriteLine("#              DRZWI                 #");
					Console.WriteLine("######################################");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [1] WYCIERACZKA                  #");
					Console.WriteLine("#   [2] WIESZAK NA KLUCZE            #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [3] KORYTARZ                     #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [Q] WYJ�CIE                      #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("######################################");

					cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.D1) Wycieraczka();
					if (cki.Key == ConsoleKey.D2) Wieszak();
				} while (cki.Key == ConsoleKey.D3); Korytarz.glowny();


			}
		}
		
		
	}
}

