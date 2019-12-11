using System;
using System.Collections.Generic;
using System.Text;

namespace BitCobblers.StockTrader.Models
{
    public class StockHolding
    {
        public virtual long Id { get; set; }
        public virtual string Symbol { get; set; }
        public virtual float Quantity { get; set; }
        public virtual float CostBasis { get; set; }
    }
}