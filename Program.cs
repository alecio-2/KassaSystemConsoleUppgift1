using System;

namespace KassaSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga efter köpbelopp
            Console.Write("Ange pris: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            // Fråga efter betalningssumma
            Console.Write("Betalt: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            // Kontrollera om köpbeloppet är större än betalningssumma
            if (tal1 > tal2)
            {
                // Medella om pengarna räcker inte
                Console.WriteLine("Betalningssumman är otillräcklig!");
            }
            else
            {
                // Beräkna växel
                int rest = tal2 - tal1;
                Console.WriteLine("Växel tillbaka:" + rest);

                // Beräkna och visa växel i sedlar och mynt
                calculateRest(ref rest, 500, "femhundralapp", "femhundralappar");
                calculateRest(ref rest, 200, "tvåhundralapp", "tvåhundralappar");
                calculateRest(ref rest, 100, "hundralapp", "hundralappar");
                calculateRest(ref rest, 50, "femtiolapp", "femtiolappar");
                calculateRest(ref rest, 20, "tjugolapp", "tjugolappar");
                calculateRest(ref rest, 10, "tio", "tior");
                calculateRest(ref rest, 5, "fem", "femmor");
                calculateRest(ref rest, 1, "ett", "ettor");                              
            }
            // Vänta på användarens input innan programmet avslutas
            Console.ReadLine();
        }
        // En metod för att beräkna och visa växel i olika valörer
        static void calculateRest(ref int restchange, int denomination, string singular, string plural)
        {
            // Beräkna hur många av valören (denomination) som ryms i restväxeln
            int numDenomination = restchange / denomination;
            // Om det finns minst en av valören i restväxeln
            if (numDenomination > 0)
            {
                // Uppdatera restväxeln genom att ta bort det belopp som täcks av valören
                restchange %= denomination;
                // Om det finns fler än ett av valören, använd pluralformen av valören
                if (numDenomination > 1)
                {
                    Console.WriteLine(numDenomination + " " + plural);
                }
                // Om det bara finns ett av valören, använd singularformen av valören
                if (numDenomination == 1)
                {
                    Console.WriteLine(numDenomination + " " + singular);
                }
            }
        }
    }
}