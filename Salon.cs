using System;

namespace Gra
{
	public class Salon
	{
		private static void barek()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("############################################");
				Console.WriteLine("#             SALON: BAREK                 #");
				Console.WriteLine("############################################");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#    ZNAJDUJESZ SIĘ PRZY OBIEKCIE BAREK,   #");
				Console.WriteLine("#    ZNAJDUJE SIĘ TUTAJ KILKA PÓŁEK,       #");
				Console.WriteLine("#    SZAFKA ORAZ MAŁE ZAMKNIĘTE PUDEŁKO    #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#          CO CHCESZ ZROBIĆ ?              #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [1] PRZESZUKAJ                         #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [2] POWRÓT                             #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [Q] WYJŚCIE                            #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("############################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.D2)
					glowny();
				if (cki.Key == ConsoleKey.Q) Program.wyjscie();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_barek() ;
		}




		private static void przeszukaj_barek()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("######################################");
				Console.WriteLine("#             SALON: BAREK           #");
				Console.WriteLine("######################################");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#     CO CHCESZ PRZESZUKAĆ ?         #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [1] PÓŁKI                        #");
				Console.WriteLine("#   [2] SZAFKA                       #");
				Console.WriteLine("#   [3] PUDEŁKO                      #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("#   [4] POWRÓT                       #");
				Console.WriteLine("#                                    #");
				Console.WriteLine("######################################");

				cki = Console.ReadKey();
				  if (cki.Key == ConsoleKey.D1) półki();
					if (cki.Key == ConsoleKey.D2) szafka();
					  if (cki.Key == ConsoleKey.D3) pudełko();

				if (cki.Key == ConsoleKey.D4) barek();

			} while (cki.Key != ConsoleKey.D4);
		}
		private static void półki()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#           SALON: BAREK: PÓŁKI               #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#     NA PÓŁKACH JEDYNE CO UDAŁO CI SIĘ       #");
				Console.WriteLine("#      ZNALEŹĆ TO JEDYNIE STERTA KURZU        #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_barek();
		}
		private static void szafka()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#           SALON: BAREK: SZAFKA              #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#     SZAFKI ZAIWERAŁY KILKA BUTELEK          #");
				Console.WriteLine("#         Z PODEJRZANYMI PŁYNAMI,             #");
				Console.WriteLine("#         LEPIEJ TEGO NIE RUSZAĆ              #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_barek();
		}
		private static void pudełko()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#           SALON: BAREK: PUDEŁKO             #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#     OTWIERASZ PUDEŁKO, TWOIM OCZOM          #");
				Console.WriteLine("#     UKAZAŁ SIĘ STARY PISTOLET SKAŁKOWY      #");
				Console.WriteLine("#     BROŃ NIE WYGLĄDAŁA NA DOBRZE            #");
				Console.WriteLine("#     POMIMO KONSERWACJI KURZEM I RDZĄ        #");
				Console.WriteLine("#     PISTOLE WCIĄŻ WYGLĄDA JAKBY BYŁ         #");
				Console.WriteLine("#     GOTOWY DO WYSTRZAŁU,                    #");
				Console.WriteLine("#     LEPIEJ TEGO NIE RUSZAĆ                  #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #"); 
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_barek();
		}

		private static void stojak()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("############################################");
				Console.WriteLine("#             SALON: STOJAK                #");
				Console.WriteLine("############################################");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#    PRZED TOBĄ ROZPOŚCIERA SIĘ STARY,     #");
				Console.WriteLine("#    OKURZONY STOJAK NA PŁYTY,             #");
				Console.WriteLine("#    SKŁADA SIĘ Z NAPRAWDĘ WIELU SLOTÓW,   #");
				Console.WriteLine("#    MIESZCZĄCYCH W SOBIE,                 #");
				Console.WriteLine("#    KILKA ZABYTKOWYCH WINYLI              #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#          CO CHCESZ ZROBIĆ ?              #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [1] PRZESZUKAJ                         #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [2] POWRÓT                             #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [Q] WYJŚCIE                            #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("############################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.D2)
					glowny();
				if (cki.Key == ConsoleKey.Q) Program.wyjscie();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_stojak();
		}

		private static void przeszukaj_stojak()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("############################################");
				Console.WriteLine("#       SALON: STOJA: STOS WINYLI          #");
				Console.WriteLine("############################################");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#    POŚRÓD STOSU WINYLI JEDYNĄ WARTĄ,     #");
				Console.WriteLine("#    UWAGI RZECZĄ OKAZUJE SIĘ BYĆ,         #");
				Console.WriteLine("#    ''SŁUCHOWISKO - DZIEŁA ZEBRANE'',     #");
				Console.WriteLine("#    NIESTETY NA WYTARTYM JUŻ WINYLU,      #");
				Console.WriteLine("#    PRÓŻNO SZUKAĆ AUTORA...               #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [1] POWRÓT                             #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [Q] WYJŚCIE                            #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("############################################");

				cki = Console.ReadKey();

				
					
				if (cki.Key == ConsoleKey.Q) Program.wyjscie();
			} while (cki.Key != ConsoleKey.D1);stojak();
		}

		private static void kanapa()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("############################################");
				Console.WriteLine("#             SALON: KANAPA                #");
				Console.WriteLine("############################################");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#    NA ŚRODKU SALONU STAŁA SKÓRZANA,      #");
				Console.WriteLine("#    MOCNO ZANIEDBANA KANAPA ,             #");
				Console.WriteLine("#    STAŁA NISKO OSADZONA NA DREWNIANEJ,   #");
				Console.WriteLine("#    LEDWO WIDOCZNEJ PODBITCE,             #");
				Console.WriteLine("#    JEJ PODUSZKI NIE BYŁY PRZYBITE,       #");
				Console.WriteLine("#    DO DREWNIANEGO STELARZA,              #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#          CO CHCESZ ZROBIĆ ?              #");
				Console.WriteLine("#                                          #"); 
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [1] PRZESZUKAJ                         #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [2] POWRÓT                             #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [Q] WYJŚCIE                            #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("############################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.D2)
					glowny();
				if (cki.Key == ConsoleKey.Q) Program.wyjscie();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_kanapa();
		}

		private static void przeszukaj_kanapa()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("############################################");
				Console.WriteLine("#             SALON: KANAPA                #");
				Console.WriteLine("############################################");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#          CO CHCESZ PRZESZUKAĆ ?          #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [1] SPRAWDŹ POD KANAPĄ                 #");
				Console.WriteLine("#   [2] ZDEJMIJ PODUSZKI I SPRAWDŹ KANAPĘ  #");
				Console.WriteLine("#   [3] SPRWADŹ WNĘTRZA PODUSZEK           #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [4] POWRÓT                             #"); 
				Console.WriteLine("#                                          #");
				Console.WriteLine("#   [Q] WYJŚCIE                            #");
				Console.WriteLine("#                                          #");
				Console.WriteLine("############################################");

				cki = Console.ReadKey();

				if (cki.Key == ConsoleKey.D2)  zdejmij_poduszki_sprawdź();
				if (cki.Key == ConsoleKey.D3) sprawdź_poduszki();
				if (cki.Key == ConsoleKey.D4) glowny();



				if (cki.Key == ConsoleKey.Q) Program.wyjscie();
			} while (cki.Key != ConsoleKey.D1); sprawdź_pod_kanapą();
		}
		private static void sprawdź_pod_kanapą()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#         SALON: KANAPA: POD KANAPĄ           #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#     POD KANAPĄ WIDAĆ JEDYNIE KILKA MONET,   #");
				Console.WriteLine("#     UCZCIWIE POKRYTYCH KURZEM,              #");
				Console.WriteLine("#     NIKT NIE ZAGLĄDAŁ TUTAJ OD LAT          #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_kanapa();
		}
		private static void sprawdź_poduszki()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#         SALON: KANAPA: PODUSZKI             #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#     POD SKÓRZANĄ TAPICERKĄ WIDAĆ GĄBKĘ,     #");
				Console.WriteLine("#     BYŁ TO NIEZWYKLE GROŹNY MATERIAŁ,       #");
				Console.WriteLine("#     PODCZAS SPALANIA WYTWARZAŁ TRUJĄCY GAZ, #");
				Console.WriteLine("#     LEPIEJ TEGO NIE RUSZAĆ                  #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_kanapa();
		}

		private static void zdejmij_poduszki_sprawdź()
		{
			ConsoleKeyInfo cki;
			do
			{
				Console.Clear();
				Console.WriteLine("###############################################");
				Console.WriteLine("#         SALON: KANAPA: POD PODUSZKAMI       #");
				Console.WriteLine("###############################################");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#    NIC TU NIE MA, JEDYNIE PUSTY STELARZ,    #");
				Console.WriteLine("#     EKSKLUZYWNEJ KANAPY W STYLU VINTAGE     #");		
				Console.WriteLine("#                                             #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("#   [1] POWRÓT                                #");
				Console.WriteLine("#                                             #");
				Console.WriteLine("###############################################");
				cki = Console.ReadKey();
			} while (cki.Key != ConsoleKey.D1); przeszukaj_kanapa();
		}
		public static void glowny()
					{
						Console.Clear();
						ConsoleKeyInfo cki;

						Console.WriteLine("######################################");
						Console.WriteLine("#                SALON               #");
						Console.WriteLine("######################################");
						Console.WriteLine("#                                    #");
						Console.WriteLine("#   [1] BAREK                        #");
						Console.WriteLine("#   [2] STOJAK NA PŁYTY              #");
						Console.WriteLine("#   [3] KANAPA                       #");
						Console.WriteLine("#                                    #");
						Console.WriteLine("#   [4] KORYTARZ                     #");
						Console.WriteLine("#   [5] KUCHNIA                      #");
						Console.WriteLine("#                                    #");
						Console.WriteLine("#   [Q] WYJŚCIE                      #");
						Console.WriteLine("#                                    #");
						Console.WriteLine("######################################");

			cki = Console.ReadKey();
						if (cki.Key == ConsoleKey.D1) barek();
						  if (cki.Key == ConsoleKey.D2) stojak();
						   if (cki.Key == ConsoleKey.D3) kanapa();


			 if (cki.Key == ConsoleKey.D4)  Korytarz.korytarz();
			 if (cki.Key == ConsoleKey.D5)  Kuchnia.glowny();
		   
			if (cki.Key == ConsoleKey.Q) Program.loading(); Program.wyjscie();

		}






	}
}
