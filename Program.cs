using System;


namespace KassaSystem
{

    class Program
    {

        static void Main(string[] args)
        {

            // Skriv in köpbelopp
            Console.Write("Ange pris: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            // Skriv in betalningssumma 
            Console.Write("Betalt: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            // Om köpbeloppet är större än betalningssumman är betalningen otillräcklig
            if (tal1 > tal2)
            {
                Console.WriteLine("Betalningssumman är otillräcklig!");
            }
            else
            {
                // Betalningssumman - Köpbeloppet
                int rest = tal2 - tal1;
                Console.WriteLine("Växel tillbaka:");
                // Räkna ut och visa rest i sedlar och mynt
                calculateRest(ref rest, 500, "femhundralapp", "femhundralappar");
                calculateRest(ref rest, 200, "tvåhundralapp", "tvåhundralappar");
                calculateRest(ref rest, 100, "hundralapp", "hundralappar");
                calculateRest(ref rest, 50, "femtiolapp", "femtiolappar");
                calculateRest(ref rest, 20, "tjugolapp", "tjugolappar");
                calculateRest(ref rest, 10, "tio", "tior");
                calculateRest(ref rest, 5, "fem", "femmor");
                calculateRest(ref rest, 1, "ett", "ettor");


                if (rest > 0)
                {
                    Console.WriteLine("Rest: " + rest);
                }
            }

            Console.ReadLine();
        }

        static void calculateRest(ref int restchange, int denomination, string singular, string plural)
        {
            int numDenomination = restchange / denomination;
            if (numDenomination > 0)
            {
                restchange %= denomination;
                if (numDenomination > 1)
                {
                    Console.WriteLine(numDenomination + " " + plural);
                }
                if (numDenomination == 1)
                {
                    Console.WriteLine(numDenomination + " " + singular);
                }


            }
        }
    }
}