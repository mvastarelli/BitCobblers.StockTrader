using System;
using System.Collections.Generic;
using System.Text;

namespace BitCobblers.StockTrader.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            this.Title = "Select Account";
        }

        //public string Title { get; set; } = "Select Account";

        public Account[] Accounts { get; } = new[]
        {
            new Account { Name="Account1", Balance=15.0f},
            new Account { Name="Account2", Balance=-10.0f},
            new Account { Name="Account3", Balance=-25.0f}
        };
    }

    public class Account
    {
        public string Name { get; set; }
        public float Balance { get; set; }
    }

    public class AccountSummaryViewModel : BaseViewModel
    {
        public Position[] Positions { get; } = new[]
        {
            new Position { Symbol="ABC", Price=123f, Shares=1f, Profit=0f },
            new Position { Symbol="DEF", Price=15.5f, Shares=25f, Profit=-10f },
            new Position { Symbol="GHI", Price=16.06f, Shares=300f, Profit=25f },
            new Position { Symbol="JLK", Price=25f, Shares=80f, Profit=5000f }
        };
    }

    public class Position
    {
        public string Symbol { get; set; }
        public float Price { get; set; }
        public float Shares { get; set; }
        public float Profit { get; set; }
    }

    public class HistoryViewModel : BaseViewModel
    {
        public Transaction[] Transactions { get; } = new[]
        {
            new Transaction { Date = DateTime.UtcNow, Action="BUY", Symbol="ABC", Shares=5, Cost=25.0f},
            new Transaction { Date = DateTime.UtcNow, Action="SELL", Symbol="DEF", Shares=5, Cost=100.0f},
            new Transaction { Date = DateTime.UtcNow, Action="BUY", Symbol="GHI", Shares=5, Cost=1000.0f}
        };
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public string Symbol { get; set; }
        public int Shares { get; set; }
        public float Cost { get; set; }
    }

    public class TradeViewModel : BaseViewModel
    {
        public TradeAction[] Actions { get; } = new[]
        {
            TradeAction.Buy,
            TradeAction.Sell
        };

        public TradeAction SelectedAction { get; set; }
    }

    public enum TradeAction
    {
        Buy,
        Sell
    }
}