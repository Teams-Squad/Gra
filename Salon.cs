﻿using System;

namespace Gra
{
    public class Salon
    {
        public static void barek()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("######################################");
                Console.WriteLine("#               BAREK                #");
                Console.WriteLine("######################################");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#     ZNAJDUJESZ SIĘ PRZY            #");
                Console.WriteLine("#     OBIEKCIE BAREK, ZNAJDUJE SIĘ   #");
                Console.WriteLine("#     TUTAJ KILKA PÓŁEK , SZAFKA     #");
                Console.WriteLine("#     ORAZ MAŁE ZAMKNIĘTE PUDEŁKO    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #"); 
                Console.WriteLine("#          CO CHCESZ ZROBIĆ ?        #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [1] PRZESZUKAJ                   #"); 
                Console.WriteLine("#                                    #");
                Console.WriteLine("#   [2] POWRÓT                       #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("#                                    #");
                Console.WriteLine("######################################");
                
                cki = Console.ReadKey();
            
            } while (cki.Key != ConsoleKey.D2);
			if (cki.Key == ConsoleKey.D1) ;
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("######################################");
                    Console.WriteLine("#               BAREK                #");
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
                } while (cki.Key != ConsoleKey.D4);
	{
                    cki = Console.ReadKey();
					if (cki.Key == ConsoleKey.D1) PÓŁKI();
					if (cki.Key == ConsoleKey.D2) SZAFKA();
                    if (cki.Key == ConsoleKey.D3) PUDEŁKO();



                }

        }
        public static void glowny()
        {
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
            Console.WriteLine("######################################");
           
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1) barek();
            /*  if (cki.Key == ConsoleKey.D2) stojak.glowny();
             if (cki.Key == ConsoleKey.D3) kanapa.glowny();


             if (cki.Key == ConsoleKey.D4) korytarz.glowny();
             if (cki.Key == ConsoleKey.D5) kuchnia.glowny();
           */
            Console.Clear();
            
        }
          
            
        
    }
}
