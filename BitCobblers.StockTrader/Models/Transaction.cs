using System;
using System.Collections.Generic;
using System.Text;

namespace BitCobblers.StockTrader.Models
{
    public class Transaction
    {
        public virtual long Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Symbol { get; set; }
        public virtual string Action { get; set; }
        public virtual float Quantity { get; set; }
        public virtual float PricePerShare { get; set; }
    }
}
