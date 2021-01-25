using System;
using System.Collections.Generic;
using System.Text;

namespace Gra
{
	class Korytarz
	{


		private static void Lampa()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#     KORYTARZ :ZWISAJĄCA LAMPA      #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("# KLOSZ LAMPY WYPEŁNIONY JEST ,      #");
				Console.WriteLine("#  ROBACZYMI TRUCHŁAMI.              #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

			
				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}

		private static void Półki()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#      KORYTARZ :KOMODA :PÓŁKI       #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  NIE POWINIEN ZDZIWIĆ CIĘ FAKT ŻE, #");
				Console.WriteLine("#  NIC TU NIE MA ...                 #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

				
				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}
		private static void Szuflady()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#     KORYTARZ :KOMODA :SZUFLADY     #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  SZUFLADY KOMODY OKAZAŁY SIĘ BYĆ , #");
				Console.WriteLine("#  DOMOWĄ BIBLIOTECZKĄ PEŁNĄ ,       #");
				Console.WriteLine("#  AUTORSKICH OPOWIADAŃ              #");
				Console.WriteLine("#  NKILKA PÓŁEK.                     #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}
		private static void Pod_komodą()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#    KORYTARZ :KOMODA :POD KOMODĄ    #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  ZNOWU PUDŁO .                     #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

				
				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}

		private static void Komoda()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#          KORYTARZ :KOMODA          #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  POD NAJWIĘKSZYM Z OBRAZÓW MIEŚCI, #");
				Console.WriteLine("#  SIĘ STARA DĘBOWA KOMODA ,POSIADA  #");
				Console.WriteLine("#  NIE MAŁĄ LICZBĘ SZUFLAD A NAWET,  #");
				Console.WriteLine("#  NKILKA PÓŁEK.                     #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#        CO CHCESZ ZROBIĆ ?          #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [1] SPRAWDŹ POD KOMODĄ           #");
				Console.WriteLine("#   [2] SPRAWDŹ SZUFLADY             #");
				Console.WriteLine("#   [3] SPRAWDŹ PÓŁKI                #"); 
				Console.WriteLine("#                                    #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.D1) Pod_komodą();
				if (cki.Key == ConsoleKey.D2) Szuflady();
				if (cki.Key == ConsoleKey.D3) Półki();
				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}


		private static void Sprawdź_obrazy()
		{
			ConsoleKeyInfo cki;
			do
			{




				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#      KORYTARZ :OBRAZY -SPRAWDŹ     #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  KURZ I PAJĘCZYNY , NIC WIĘCEJ.    #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();

			} while (cki.Key == ConsoleKey.R); Obrazy();
		}



		private static void Obrazy()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();


				Console.WriteLine("######################################");
				Console.WriteLine("#          KORYTARZ :OBRAZY          #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#  NA KORYTARZU WIDAĆ CZTERY OBRAZY  #");
				Console.WriteLine("#  KAŻDY Z NICH JEST PORTRETEM,      #");
				Console.WriteLine("#  INNEJ OSOBY,                      #");
				Console.WriteLine("#  NIKOGO NIE ROZPOZNAJESZ.          #"); 
				Console.WriteLine("#                                    #"); 
				Console.WriteLine("#        CO CHCESZ ZROBIĆ ?          #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [1] SPRAWDŹ ZA OBRAZAMI          #"); 
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [R] POWRÓT                       #");
				Console.WriteLine("#   [Q] WYJŚCIE                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();
				
				if (cki.Key == ConsoleKey.D1) Sprawdź_obrazy(); 
				if (cki.Key == ConsoleKey.R) glowny();
			} while (cki.Key == ConsoleKey.Q); Program.wyjscie();



		}


		public static void glowny() // poprawa nazwy - adam
		{
			ConsoleKeyInfo cki;
			do
				{
					Console.Clear();
					

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
				if (cki.Key == ConsoleKey.D1) Obrazy(); 
				if (cki.Key == ConsoleKey.D2) Komoda();
				if (cki.Key == ConsoleKey.D3) Zwisająca_lampa();
				    if (cki.Key == ConsoleKey.D4) Salon.glowny();
					if (cki.Key == ConsoleKey.D5) Kuchnia.glowny();
					if (cki.Key == ConsoleKey.D6) Lazienka.glowny();
					if (cki.Key == ConsoleKey.D7) Sypialnia.glowny(); // poprawa nazwy - adam
					if (cki.Key == ConsoleKey.D8) Drzwi.glowny();
				} while (cki.Key == ConsoleKey.Q); Program.wyjscie();
			
		}
	}
}
