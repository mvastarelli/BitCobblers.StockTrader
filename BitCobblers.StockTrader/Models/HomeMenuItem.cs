namespace BitCobblers.StockTrader.Models
{
    public enum MenuItemType
    {
        Browse,
        //About,

        Home,
        AccountSummary,
        Trade,
        History,

        //NewTrade,
        Deposit
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}