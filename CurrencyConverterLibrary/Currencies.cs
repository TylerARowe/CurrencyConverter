using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterLibrary
{
    public class Currencies
    {
        public double CashValue { get; set; }
        public double BtcValue { get; set; }
        public double EthValue { get; set; }
        public double LteValue { get; set; }

        public Currencies(double cashValue, double btcValue, double ethValue, double lteValue)
        {
            CashValue = cashValue;
            BtcValue = btcValue;
            EthValue = ethValue;
            LteValue = lteValue;
        }

    }
}
