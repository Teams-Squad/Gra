using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Gra
{
	class Drzwi // zaj��em si� bo jest za ma�o czasu
	{
		private static void koniec()
        {
			Program.loading();
			Console.Clear();
			Console.WriteLine("  _______________\n |  ___________  |\n | |  _ _ _ _  | |\n | | | | | | | | |\n | | |-+-+-+-| | |\n | | |-+-+-+-| | |\n | | |_|_|_|_| | |\n | |    ___    | |\n | |   [___] ()| |\n | |         ||| |\n | |         ()| |\n | |           | |\n | |           | |\n | |           | |\n |_|___________|_| ");
			Thread.Sleep(1500);
			Console.Clear();
			Console.WriteLine("  ______________\n |  ___________  |\n | |  /|,| |   | |\n | | |,x,| |   | |\n | | |,x,' |   | |\n | | |,x   ,   | |\n | | |/    |   | |\n | |    /] ,   | |\n | |   [/ ()   | |\n | |       |   | |\n | |       |   | |\n | |       |   | |\n | |      ,'   | |\n | |   ,'      | |\n |_|,'_________|_|");
			Thread.Sleep(3000);
			Console.Clear();
			Console.WriteLine("######################################");
			Console.WriteLine("#             GRATULACJE!            #");
			Console.WriteLine("######################################");
			Console.WriteLine("#                                    #");
			Console.WriteLine("#      UKO�CZY�E� GR� KEYSEARCH      #");
			Console.WriteLine("#                                    #");
			Console.WriteLine("######################################");
			Console.WriteLine("\nWci�nij dowolny przycisk, aby wyj��...");
			Console.ReadKey();
			System.Environment.Exit(0);
		}
		public static void glowny() // lepiej zrobi� 'glowny' bo potem b�dzie �atwiej pisa�
		{
			ConsoleKeyInfo cki;
			if (Program.czyKlucz() == 0)
               {
				do
				{
					Console.Clear();
					Console.WriteLine("######################################");
					Console.WriteLine("#               DRZWI                #");
					Console.WriteLine("######################################");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#     NIE MASZ PRZY SOBIE KLUCZA     #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#   [R] WR��                         #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("######################################");
					cki = Console.ReadKey();
				} while (cki.Key != ConsoleKey.R);
			} 
			else
            {
				do
				{
					Console.Clear();
					Console.WriteLine("######################################");
					Console.WriteLine("#               DRZWI                #");
					Console.WriteLine("######################################");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#        MASZ PRZY SOBIE KLUCZ       #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#          CZY CHCESZ WYJ��          #");
					Console.WriteLine("#           I UKO�CZY� GR�?          #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("#      [1] TAK          [2] NIE      #");
					Console.WriteLine("#                                    #");
					Console.WriteLine("######################################");
					cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.D1) koniec();
				} while (cki.Key != ConsoleKey.D2);
			}
			Korytarz.glowny();
		}
	}
}

