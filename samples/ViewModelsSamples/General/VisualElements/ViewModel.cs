﻿using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;

namespace ViewModelsSamples.General.VisualElements;

public partial class ViewModel
{
    public IEnumerable<ChartElement<SkiaSharpDrawingContext>> VisualElements { get; set; } = new List<ChartElement<SkiaSharpDrawingContext>>
    {
         new RectangleVisualElement
         {
             X = 5,
             Y = 1,
             LocationUnit = MeasureUnit.ChartValues,
             Width = 1,
             Height = 1,
             SizeUnit = MeasureUnit.ChartValues,
             Stroke = new SolidColorPaint(SKColors.Red, 2)
         }
    };

    public ISeries[] Series { get; set; } =
    {
        new LineSeries<int>
        {
            GeometrySize = 13,
            Values = new int[] { 1,2,3,4,2,1,3,6,3,5,2,1,4,5,2,3,1,4,5,3,1,6,2,4,5,8,4,5,6,4,7,5,8,4,6,5,4,7,8,9,9,8,7,9,8,7,9,9,8,6,8 }
        }
    };
}
