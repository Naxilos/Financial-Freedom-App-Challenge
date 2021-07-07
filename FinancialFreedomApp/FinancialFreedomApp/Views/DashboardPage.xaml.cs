using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinancialFreedomApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();

            List<ChartEntry> entries = new List<ChartEntry>
            {
                 new ChartEntry(50)
                {
                    Color =  SKColor.Parse("#ADCC82"),
                },
                  new ChartEntry(60)
                {
                    Color = SKColor.Parse("#74D2E1"),
                },
                new ChartEntry(75)
                {
                    Color=SKColor.Parse("#E9789E"),
                },
               
               
            };

            Chart.Chart = new RadialGaugeChart() { Entries = entries, MaxValue = 100, IsAnimated =false , LineSize =24 };
        }
    }
}