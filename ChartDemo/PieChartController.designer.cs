// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ChartDemo
{
    [Register ("PieChartController")]
    partial class PieChartController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        OxyPlot.Xamarin.iOS.PlotView vwPieChart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        OxyPlot.Xamarin.iOS.PlotView vwPieChart2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (vwPieChart != null) {
                vwPieChart.Dispose ();
                vwPieChart = null;
            }

            if (vwPieChart2 != null) {
                vwPieChart2.Dispose ();
                vwPieChart2 = null;
            }
        }
    }
}