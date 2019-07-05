using Foundation;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.iOS;
using System;
using System.Collections.Generic;
using UIKit;

namespace ChartDemo
{
    public partial class GroupedBarChartController : UIViewController
    {
        public GroupedBarChartController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Grouped Bar Chart";

            this.View = new PlotView
            {
                Model = GetGroupedBarChart()
            };
        }

        private PlotModel GetGroupedBarChart()
        {
            PlotModel plotModel = new PlotModel
            {
                Title = "Grouped Bar Chart",
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomCenter,
                LegendOrientation = LegendOrientation.Vertical,
                LegendBorderThickness = 0
            };

            BarSeries barSeriesOne = new BarSeries
            {
                Title = "Price",
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            barSeriesOne.Items.Add(new BarItem { Value = 25000 });
            barSeriesOne.Items.Add(new BarItem { Value = 7000 });
            barSeriesOne.Items.Add(new BarItem { Value = 12000 });

            plotModel.Series.Add(barSeriesOne);

            BarSeries barSeriesTwo = new BarSeries
            {
                Title = "Sale",
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            barSeriesTwo.Items.Add(new BarItem { Value = 1500 });
            barSeriesTwo.Items.Add(new BarItem { Value = 3200 });
            barSeriesTwo.Items.Add(new BarItem { Value = 800 });

            plotModel.Series.Add(barSeriesTwo);

            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = new[] { "Android ", "iOS", "Windows" }
            };

            plotModel.Axes.Add(categoryAxis);

            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                MinimumPadding = 0,
                MaximumPadding = 0.5,
                AbsoluteMinimum = 0
            };

            plotModel.Axes.Add(linearAxis);

            return plotModel;
        }
    }
}