using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Line : Segment
    {
        public string LineColor { get; set; }
        public double ScaleFactor { get; set; }
        public Line(string name, double x1, double y1, double x2, double y2, string lineColor, double scaleFactor)
            : base(name, x1, y1, x2, y2)
        {
            LineColor = lineColor;
            ScaleFactor = scaleFactor;
        }
        public override double Lenght()
        {
            return base.Lenght() * ScaleFactor;
        }
    }
}
