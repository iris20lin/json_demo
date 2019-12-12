using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_DEMO
{
    public class CoinRate
    {
        public string UTC { get; set; }
        public float Exrate { get; set; }

        public CoinRate()
        {

        }

        public CoinRate(string date, float exrate)
        {
            this.UTC = date;
            this.Exrate = exrate;
        }
    }
}
