using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarouselView.FormsPlugin.Abstractions;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.Entry;
using Microcharts.Forms;


namespace charts
{
    public partial class MainPage : CarouselPage
    {

       

        public MainPage()
        {
            InitializeComponent();

            
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<Entry> entries = new List<Entry>
            {
                new Entry(500)
                {
                    Color = SKColor.Parse("#FF1943"),
                    Label = "January",
                    ValueLabel = "500",
                },
                new Entry(400)
                {
                    Color = SKColor.Parse("00BFFF"),
                    Label = "March",
                    ValueLabel = "400"
                },
                new Entry(-100)
                {
                    Color = SKColor.Parse("#00CED1"),
                    Label = "October",
                    ValueLabel = "-100"
                }
            };



            var Chart1 = new RadialGaugeChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5)};
            var Chart2 = new LineChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5) };
            var Chart3 = new DonutChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5) };
            var Chart4 = new BarChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5) };
            var Chart5 = new PointChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5) };
            var Chart6 = new RadarChart() { Entries = entries, BackgroundColor = SKColors.Transparent, IsAnimated = true, AnimationDuration = TimeSpan.FromSeconds(5) };



            ObservableCollection<ChartView> MyItemSource = new ObservableCollection<ChartView>
            {

                new ChartView(){Chart = Chart1},
                new ChartView(){Chart = Chart2},
                new ChartView(){Chart = Chart3},
                new ChartView(){Chart = Chart4},
                new ChartView(){Chart = Chart5},
                new ChartView(){Chart = Chart6}




            };

            chartcarousel.ItemsSource = MyItemSource; 





        }
    }
}
