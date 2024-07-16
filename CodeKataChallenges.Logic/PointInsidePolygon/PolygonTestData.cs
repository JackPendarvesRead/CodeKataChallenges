using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.PointInsidePolygon
{
    internal static class PolygonTestData
    {
        public static Polygon Triangle()
        {
            return new Polygon(new Point[]
            {
                new Point(2, 2),
                new Point(6, 5),
                new Point(2, 5)         
            });
        }

        public static Polygon ConvexConcavePolygon()
        {
            return new Polygon(new Point[]
            {
                new Point(1, 1),
                new Point(3, 3),
                new Point(1, 6),
                new Point(4, 6),
                new Point(6, 3),
                new Point(4, 1)
            });
        }

        public static Polygon IrregularPolygon()
        {
            return new Polygon(new Point[] 
            { 
                new Point(0, 0), 
                new Point(2, 3), 
                new Point(1, 6), 
                new Point(5, 7), 
                new Point(8, 4), 
                new Point(7, 2), 
                new Point(4, 0) 
            });
        }
    }
}
