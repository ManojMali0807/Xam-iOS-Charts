using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.iOS;
using System;
using UIKit;

namespace ChartDemo
{
    public partial class BarChartController : UIViewController
    {
        public BarChartController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Bar Chart";

            this.View = new PlotView
            {
                Model = GetBarChart()
            };
        }

        private PlotModel GetBarChart()
        {
            PlotModel plotModel = new PlotModel
            {
                Title = "Bar Chart"
            };

            var barSeries = new ColumnSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(33),
                Color = OxyColor.Parse("#3498db")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(196),
                Color = OxyColor.Parse("#2ecc71")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(152),
                Color = OxyColor.Parse("#9b59b6")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(62),
                Color = OxyColor.Parse("#34495e")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(68),
                Color = OxyColor.Parse("#e74c3c")
            });

            barSeries.Items.Add(new ColumnItem
            {
                Value = Convert.ToDouble(101),
                Color = OxyColor.Parse("#f1c40f")
            });

            plotModel.Series.Add(barSeries);
            string[] strNames = { "Rabbit", "Dog", "Cat", "Goldfish", "Hamster", "Birds" };
            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "Sample Data",
                ItemsSource = strNames,
                IsPanEnabled = false,
                IsZoomEnabled = false,
                Selectable = false,
            });
            return plotModel;
        }
    }
}