using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger
{
    class ExchangeMonitor
    {
        private int exhangeOccurences;

        public int ExchangeOccurences
        {
            get { return exhangeOccurences; }
            set { exhangeOccurences = value; }
        }
        
        private decimal totalExchanged;

        public decimal  TotalExchanged
        {
            get { return totalExchanged; }
            set { totalExchanged = value; }
        }
        
        public ExchangeMonitor()
        { 
            ExchangeOccurences = 0;
            TotalExchanged = 0M;
        }

        public decimal ConvertCurrency(decimal currencyInput, int inputTypeChoice, int outputTypeChoice)
        {
            IncrementProperties(currencyInput, inputTypeChoice);
            if (inputTypeChoice != outputTypeChoice)
            {
                if (inputTypeChoice == 1)
                {
                    return outputTypeChoice == 2 ? Exchanger.USDtoCAN(currencyInput) :
                        outputTypeChoice == 3 ? Exchanger.USDtoEUR(currencyInput) :
                        Exchanger.USDtoGBP(currencyInput);
                }
                else if (inputTypeChoice == 2)
                {
                    return outputTypeChoice == 1 ? Exchanger.CANtoUSD(currencyInput) :
                        outputTypeChoice == 3 ? Exchanger.CANtoEUR(currencyInput) :
                        Exchanger.CANtoGBP(currencyInput);
                }
                else if (inputTypeChoice == 3)
                {
                    return outputTypeChoice == 1 ? Exchanger.EURtoUSD(currencyInput) :
                        outputTypeChoice == 2 ? Exchanger.EURtoCAN(currencyInput) :
                        Exchanger.EURtoGBP(currencyInput);
                }
                else
                {
                    return outputTypeChoice == 1 ? Exchanger.GBPtoUSD(currencyInput) :
                        outputTypeChoice == 2 ? Exchanger.GBPtoCAN(currencyInput) :
                        Exchanger.GBPtoEUR(currencyInput);
                }
            }
            else
            { return currencyInput; }

        }
        private void IncrementProperties(decimal currencyInput, int exchangeChoice)
        { 
            ExchangeOccurences++;
            TotalExchanged += exchangeChoice == 2 ? Exchanger.CANtoUSD(currencyInput) :
                exchangeChoice == 3 ? Exchanger.EURtoUSD(currencyInput) : 
                exchangeChoice == 4 ? Exchanger.GBPtoUSD(currencyInput) : currencyInput;
        }
    }
}
