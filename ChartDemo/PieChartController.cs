using Foundation;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Xamarin.iOS;
using System;
using UIKit;

namespace ChartDemo
{
    public partial class PieChartController : UIViewController
    {
        public PieChartController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.Title = "Pie Chart";
            vwPieChart.Frame = new CoreGraphics.CGRect(57, 93, 300, 300);
            var plotView = new PlotView
            {
                Model = GetPieChart()
            };

            this.vwPieChart.Model=GetPieChart();
            this.vwPieChart2.Model = GetPieChart();
            //this.View.AddSubview(plotView);
        }

        private PlotModel GetPieChart()
        {
            PlotModel plotModel = new PlotModel
            {
                Title = "Pie Chart"
            };

            PieSeries pieSeries = new PieSeries { StrokeThickness = 2.0, AngleSpan = 360, StartAngle = 0 };

            pieSeries.Slices.Add(new PieSlice("Android", 35) { Fill = OxyColors.Green });
            pieSeries.Slices.Add(new PieSlice("iOS", 50) { Fill = OxyColors.Silver });
            pieSeries.Slices.Add(new PieSlice("Windows", 15) { Fill = OxyColors.Brown, IsExploded = true });

            plotModel.Series.Add(pieSeries);

            return plotModel;
        }

        //public override void ViewWillDisappear(bool animated)
        //{
        //    base.ViewWillDisappear(animated);
        //    ((AppDelegate)UIApplication.SharedApplication.Delegate).IsLandscape = false;
        //    UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)(UIInterfaceOrientation.Portrait)), new NSString("orientation")); 
        //}

        //public override void ViewWillAppear(bool animated)
        //{
        //    base.ViewWillAppear(animated);
        //    ((AppDelegate)UIApplication.SharedApplication.Delegate).IsLandscape = true;
        //    UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)(UIInterfaceOrientation.LandscapeLeft)), new NSString("orientation"));
        //}
    }
}