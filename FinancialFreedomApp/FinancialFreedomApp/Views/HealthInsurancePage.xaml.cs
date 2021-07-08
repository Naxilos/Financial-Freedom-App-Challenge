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
    public partial class HealthInsurancePage : ContentPage
    {

        public HealthInsurancePage()
        {
            InitializeComponent();

            IEnumerable<ChartEntry> entries = new List<ChartEntry>()
            {
                new ChartEntry(10)
                {
                    Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(10)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(0)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(10)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(0)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(10)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(30)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(30)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(100)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(40)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(20)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(30)
                {
                     Color = SKColor.Parse("#FFFFFF")
                },
                new ChartEntry(30)
                {
                     Color = SKColor.Parse("#FFFFFF")
                }
            };

            Chart.Chart = new Microcharts.LineChart() { Entries = entries, EnableYFadeOutGradient = false, BackgroundColor = SKColor.Parse("#5CD4E7"), LineMode = LineMode.Straight, LineSize=8, PointSize=22, PointMode = PointMode.Circle };
        }
    }
}