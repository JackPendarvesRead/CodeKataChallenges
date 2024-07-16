using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.PointInsidePolygon
{
    internal static class PolygonExtensions
    {
        public static int MaxX(this Polygon polygon)
        {
            return polygon.Points.Max(p => p.X);
        }

        public static int MaxY(this Polygon polygon)
        {
            return polygon.Points.Max(p => p.Y);
        }

        public static int MinX(this Polygon polygon)
        {
            return polygon.Points.Min(p => p.X);
        }

        public static int MinY(this Polygon polygon)
        {
            return polygon.Points.Min(p => p.Y);
        }
    }
}
