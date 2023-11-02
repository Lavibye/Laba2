using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class Segment
    {
        public string Name { get; set; }
        public (double X1, double Y1) Start { get; set; }
        public (double X2, double Y2) End { get; set; }
        public Segment(string name, double x1, double y1, double x2, double y2)
        {
            Name = name;
            Start = (x1, y1);
            End = (x2, y2);
        }
        public virtual double Lenght()
        {
            double dx = End.X2 - Start.X1;
            double dy = End.Y2 - Start.Y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
