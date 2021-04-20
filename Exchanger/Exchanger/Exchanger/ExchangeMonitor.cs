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
        {   //This probably isn't the best way to do this because it runs all the conversions and then reports it to the array
            IncrementProperties(currencyInput, inputTypeChoice);
            if (inputTypeChoice != outputTypeChoice)
            {
                decimal[,] conversions = new decimal[,]{ { Exchanger.USDtoCAN(currencyInput), Exchanger.USDtoGBP(currencyInput) , Exchanger.USDtoEUR(currencyInput) },
                {Exchanger.CANtoUSD(currencyInput), Exchanger.CANtoEUR(currencyInput) , Exchanger.CANtoGBP(currencyInput)  },
                {Exchanger.EURtoUSD(currencyInput), Exchanger.EURtoCAN(currencyInput) , Exchanger.EURtoGBP(currencyInput)  },
                {Exchanger.GBPtoUSD(currencyInput), Exchanger.GBPtoCAN(currencyInput) , Exchanger.GBPtoEUR(currencyInput)  } };
                return conversions[inputTypeChoice - 1, (outputTypeChoice == 4 ? outputTypeChoice - 2: outputTypeChoice  -1)]; //Also, how will the ExchangeMonitor know which rate to call?
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
