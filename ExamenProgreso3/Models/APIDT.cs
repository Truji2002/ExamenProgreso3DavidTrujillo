using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ExamenProgreso3.Models
{
    [SQLite.Table("apiDT")]
    

    public class APIDT
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string symbol { get; set; }
        public double price_24h { get; set; }
        public double volume_24h { get; set; }
        public double last_trade_price { get; set; }
    }
}
