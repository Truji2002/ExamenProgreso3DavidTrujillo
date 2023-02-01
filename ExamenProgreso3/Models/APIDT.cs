using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgreso3.Models
{
    public class API
    {
        public string symbol { get; set; }
        public double price_24h { get; set; }
        public double volume_24h { get; set; }
        public double last_trade_price { get; set; }
    }
}
