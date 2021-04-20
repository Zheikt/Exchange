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
            return 0M;//Insert Exchanger.[method name here](currencyInput); Also, how will the ExchangeMonitor know which rate to call?

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
