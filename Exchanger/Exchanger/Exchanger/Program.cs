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
                int inputTypeChoice;
                int outputTypeChoice;
                decimal exchangeInput;
                decimal exchangeOutput;
                string inputCurrencyType;
                string outputCurrencyType;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the Currency Exchanger! Please choose the starting currency to begin:");
                    Console.WriteLine("1-United States Dollar (USD)\n2-Canadian Dollar (CAN)" +
                        "\n3-Euro (EUR)\n4-British Pound Sterling (GBP)");
                    if (!int.TryParse(Console.ReadLine(), out inputTypeChoice))
                        inputTypeChoice = 0;
                } while (!(inputTypeChoice >= 1 && inputTypeChoice <= 4));
                inputCurrencyType = inputTypeChoice == 1 ? "USD" : inputTypeChoice == 2 ? "CAN" :
                    inputTypeChoice == 3 ? "EUR" : "GBP";
                do
                {
                    Console.Clear();
                    Console.WriteLine("Next, please choose the output currency:");
                    Console.WriteLine("1-United States Dollar (USD)\n2-Canadian Dollar (CAN)" +
                        "\n3-Euro (EUR)\n4-British Pound Sterling (GBP)");
                    if (!int.TryParse(Console.ReadLine(), out outputTypeChoice))
                        outputTypeChoice = 0;
                } while (!(outputTypeChoice >= 1 && outputTypeChoice <= 4));
                outputCurrencyType = outputTypeChoice == 1 ? "USD" : outputTypeChoice == 2 ? "CAN" :
                    outputTypeChoice == 3 ? "EUR" : "GBP";
                do
                {
                    Console.Clear();
                    Console.WriteLine("Selected Exchange: " + inputCurrencyType + " to " + outputCurrencyType);
                    Console.WriteLine("Insert input currency in " + inputCurrencyType);
                } while (!decimal.TryParse(Console.ReadLine(), out exchangeInput));
                exchangeOutput = monitor.ConvertCurrency(exchangeInput, inputTypeChoice, outputTypeChoice);
                Console.WriteLine("New total is " + 
                    (outputTypeChoice == 3 ? "\u20AC" + Math.Round(exchangeOutput, 2, MidpointRounding.AwayFromZero) : 
                    outputTypeChoice == 4 ? "\u00A3" + Math.Round(exchangeOutput, 2, MidpointRounding.AwayFromZero) :
                    exchangeOutput.ToString("C")) + 
                    (outputTypeChoice == 1 ? " USD" : outputTypeChoice == 2 ? "CAN" : string.Empty));
                Console.WriteLine("Perform another exchange? (Y/N)"); //Consider how to account for bad input
            } while (Console.ReadKey().Key == ConsoleKey.Y);
            Console.Clear();
            Console.WriteLine("Total exchanges performed: " + monitor.ExchangeOccurences);
            Console.WriteLine("Total currency exchanged: " + monitor.TotalExchanged.ToString("C") + " USD");
            Console.ReadLine();
        }
    }
}
