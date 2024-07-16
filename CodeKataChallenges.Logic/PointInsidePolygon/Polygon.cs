using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.PointInsidePolygon
{
    internal class Polygon
    {
        public Polygon(Point[] points)
        {
            Points = points;
        }

        public Point[] Points { get; }

        public bool IsPointInside(Point point)
        {


            return true;
        }
    }
}
