using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BitCobblers.StockTrader.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StockDetails : ContentView
    {
        public StockDetails()
        {
            InitializeComponent();
        }
    }
}