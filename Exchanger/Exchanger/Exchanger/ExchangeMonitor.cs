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

        public decimal ConvertCurrency(decimal currencyInput, int exchangeChoice)
        {
            return 0M;//Insert Exchanger.[method name here](currencyInput); Also, how will the ExchangeMonitor know which rate to call?
        }

        private void IncrementProperties(decimal currencyInput, int exchangeChoice)
        { 
            ExchangeOccurences++; //The comment below should inserted in place of 0 once Exchanger is finished.
            TotalExchanged += 0; //exchangeChoice >= 1 && <= 3 ? Exchanger.[method name here](currencyInput) :exchangeChoice >= 4 && <= 6 ? Exchanger.[method name here](currencyInput):exchangeChoice >= 7 && <= 9 ? Exchanger.[method name here](currencyInput): Exchanger.[method name here](currencyInput);
        }


    }
}
