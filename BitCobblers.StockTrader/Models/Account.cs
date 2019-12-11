using System;
using System.Collections.Generic;
using System.Text;

namespace BitCobblers.StockTrader.Models
{
    public class Account
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual List<Transaction> Transactions { get; set; }
        public virtual List<StockHolding> StockHoldings { get; set; }
    }
}