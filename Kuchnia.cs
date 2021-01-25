using System;

namespace Gra
{
    class Kuchnia
    {
        public static void szafka_trzecia()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#         KUCHNIA: SZAFKI: TRZECIA         #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     W TEJ SZAFCE ZNAJDUJE SIĘ ZASTAWA    #");
                Console.WriteLine("#     ZDOBIONA NIEBIESKIMI KWIATAMI:       #");
                Console.WriteLine("#     DUŻE I MAŁE TALERZE, CUKIERNICA,     #");
                Console.WriteLine("#     DZBANEK DO MLEKA I INNE ELEMENTY     #");
                Console.WriteLine("#     ZASTAWY WRAZ Z ZDOBIONYMI            #");
                Console.WriteLine("#     ZŁOTYMI OZDOBAMI SZTUĆCAMI           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); szafki();
        }

        public static void szafka_druga()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#          KUCHNIA: SZAFKI: DRUGA          #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     TA SZAFKA WYPEŁNIONA JEST            #");
                Console.WriteLine("#     SZKLANKAMI RÓŻNYCH WIELKOŚCI         #");
                Console.WriteLine("#     ORAZ DWOMA BIAŁYMI KUBKAMI           #");
                Console.WriteLine("#     W CZARNE KROPKI                      #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); szafki();
        }

        public static void szafka_pierwsza()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#        KUCHNIA: SZAFKI: PIERWSZA         #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     TA SZAFKA MA W SOBIE KOLEKCJĘ        #");
                Console.WriteLine("#     NISKICH, NIEDUŻYCH SŁOIKÓW           #");
                Console.WriteLine("#     WYPEŁNIONYCH PRZYPRAWAMI,            #");
                Console.WriteLine("#     MIĘDZY INNYMI MIELONYM PIEPRZEM,     #");
                Console.WriteLine("#     CYNAMONEM I GOŹDZIKAMI               #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#             CO CHCESZ ZROBIĆ ?           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); szafki();
        }

        public static void szafki()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#             KUCHNIA: SZAFKI              #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     SZAFKI WYKONANE SĄ Z CIEMNEGO        #");
                Console.WriteLine("#     DREWNA, W PODWÓJNYCH DRZWIACH        #");
                Console.WriteLine("#     ZNAJDUJĄ SIĘ SZYBY POZWALAJĄCE       #");
                Console.WriteLine("#     ZAJRZEĆ DO ŚRODKA                    #");
                Console.WriteLine("#     BEZ OTWIERANIA DANEJ SZAFKI          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#             CO CHCESZ ZROBIĆ ?           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [1] ZAJRZYJ DO PIERWSZEJ SZAFKI       #");
                Console.WriteLine("#    [2] ZAJRZYJ DO DRUGIEJ SZAFKI         #");
                Console.WriteLine("#    [3] ZAJRZYJ DO TRZECIEJ SZAFKI        #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) szafka_pierwsza();
                if (cki.Key == ConsoleKey.D2) szafka_druga();
                if (cki.Key == ConsoleKey.D3) szafka_trzecia();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
}


public static void piekarnik()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#       KUCHNIA: KUCHENKA: PIEKARNIK       #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     W PIEKARNIKU ZNAJDUJE SIĘ DUŻA       #");
                Console.WriteLine("#     FORMA DO PIECZENIA CIASTA,           #");
                Console.WriteLine("#     NIEDUŻA PATELNIA ORAZ                #");
                Console.WriteLine("#     SZKLANE NACZYNIE ŻAROODPORNE         #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); kuchenka();
        }


        public static void czajnik()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#        KUCHNIA: KUCHENKA: CZAJNIK        #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     CZAJNIK WYDAJE SIĘ BYĆ DOŚĆ NOWY,    #");
                Console.WriteLine("#     W ŚRODKU ZNAJDUJE SIĘ                #");
                Console.WriteLine("#     TROCHĘ WYSTUDZONEJ JUŻ WODY          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); kuchenka();
        }


        public static void kuchenka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#            KUCHNIA: KUCHENKA             #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     KUCHENKA Z PIEKARNIKIEM,             #");
                Console.WriteLine("#     NAJWYRAŹNIEJ GAZOWA, POSIADA         #");
                Console.WriteLine("#     CZTERY MIEJSCA DO GOTOWANIA,         #");
                Console.WriteLine("#     A NA JEDNYM Z NICH                   #");
                Console.WriteLine("#     STOI METALOWY CZAJNIK                #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#             CO CHCESZ ZROBIĆ ?           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [1] SPRAWDŹ CZAJNIK                   #");
                Console.WriteLine("#    [2] OTWÓRZ PIEKARNIK                  #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) czajnik();
                if (cki.Key == ConsoleKey.D2) piekarnik();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void lodowka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#            KUCHNIA: LODÓWKA              #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#     JEDYNE CO TU JEST TO ŚWIATŁO         #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWROT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

       

        public static void zmywarka()
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#             KUCHNIA: ZMYWARKA            #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#      W ZMYWARCE ZNAJDUJĄ SIĘ             #");
                Console.WriteLine("#      UMYTE TALERZE Z ZDOBIONEJ           #");
                Console.WriteLine("#      KWIATAMI ZASTAWY ORAZ ŚTUĆCE        #");
                Console.WriteLine("#      POKRYTE ZŁOTYMI ELEMENTAMI          #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [R] POWRÓT                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
            } while (cki.Key != ConsoleKey.R); glowny();
        }

        public static void glowny()
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.Clear();
                Console.WriteLine("############################################");
                Console.WriteLine("#                 KUCHNIA                  #");
                Console.WriteLine("############################################");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [1] ZMYWARKA                          #");
                Console.WriteLine("#    [2] LODÓWKA                           #");
                Console.WriteLine("#    [3] KUCHENKA                          #");
                Console.WriteLine("#    [4] SZAFKI                            #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [5] KORYTARZ                          #");
                Console.WriteLine("#    [6] SALON                             #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("#    [Q] WYJŚCIE                           #");
                Console.WriteLine("#                                          #");
                Console.WriteLine("############################################");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1) zmywarka();
                if (cki.Key == ConsoleKey.D2) lodowka();
                if (cki.Key == ConsoleKey.D3) kuchenka();
                if (cki.Key == ConsoleKey.D4) szafki();
                if (cki.Key == ConsoleKey.Q) Program.wyjscie();
                if (cki.Key == ConsoleKey.D5) Korytarz.glowny();
                if (cki.Key == ConsoleKey.D6) Salon.glowny();
            } while (cki.Key != ConsoleKey.D5 || cki.Key != ConsoleKey.D4);
            
            
        }
    }
}
