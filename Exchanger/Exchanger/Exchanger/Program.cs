using System;

namespace Exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            ExchangeMonitor monitor = new ExchangeMonitor();
            do
            {
                int exchangeChoice;
                decimal exchangeInput;
                decimal exchangeOutput;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Currency Exchanger! Please input one of the exchanges to begin:");
                    Console.WriteLine("1-\n2-\n3-\n4-\n5-\n6-\n7-\n8-\n9-\n10-\n11-\n12-"); //fill in with exchanges from Exchanger classes in order
                    int.TryParse(Console.ReadLine(), out exchangeChoice);
                } while (!(exchangeChoice >= 1 && exchangeChoice <= 12));
                do
                {
                    Console.Clear();
                    Console.WriteLine("Selected Exchange: "/*How would this be communicated?*/);
                    Console.WriteLine("Insert input currency in " +
                        (exchangeChoice <= 3 ? "USD" : exchangeChoice <= 6 ? "GBP" :
                        exchangeChoice <= 9 ? "CAN" : "EUR"));
                } while (decimal.TryParse(Console.ReadLine(), out exchangeInput));
                exchangeOutput = monitor.ConvertCurrency(exchangeInput, exchangeChoice);
                Console.WriteLine("New total is " + exchangeOutput.ToString("C"));
                Console.WriteLine("Perform another exchange? (Y/N)"); //Consider how to account for bad input
            } while (Console.ReadKey().Key == ConsoleKey.Y);
            Console.WriteLine("Total exchanges performed: " + monitor.TotalExchanged);
            Console.WriteLine("Total currency exchanged: " + monitor.ExchangeOccurences.ToString("C") + "USD");
            Console.ReadLine();
        }
    }
}
