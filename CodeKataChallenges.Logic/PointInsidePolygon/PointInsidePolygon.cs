using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKataChallenges.Logic.PointInsidePolygon
{
    internal class PointInsidePolygon
    {
        public bool IsInside(Polygon polygon, Point point)
        {
            if(point.X > polygon.MaxX()
                || point.Y > polygon.MaxY()
                || point.X < polygon.MinX() 
                || point.Y < polygon.MinY())
            {
                return false;
            }



            return true;
        }
    }   
}
