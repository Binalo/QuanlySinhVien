using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Circle
    {
        #region Properties
        public Point Center { get; set; }
        public double Radius { get; set; }
        #endregion

        #region Contructor
        public Circle()
        {
            Center = new Point();
            Radius = 0;
        }
        public Circle(int x, int y, double r)
        {
            Center = new Point(x, y);
            Radius = r;
        }
        public Circle(Point c, double r)
        {
            Radius = r;
            Center = new Point(c);
        }

        public Circle(Circle circle)
        {
            Radius = circle.Radius;
            Center = new Point(circle.Center);
        }
        #endregion

        #region Method
        public double Perimeter()
        {
            var p = 2 * Math.PI * Radius;
            return p;
        }
        public double acreage()
        {
            var s = Math.Pow(Radius,2) * Math.PI;
            return s;
        }

        public POSITIONRELATIVE PositionRelative(Circle c2)
        {
            double c1c2 = Point.Distance(Center, c2.Center);
            double r1r2 = Radius + c2.Radius;
            double r1Tr2 = Math.Abs(Radius - c2.Radius);
            if (c1c2 > r1r2)
                return POSITIONRELATIVE.LayingOutSide; //Lying outside each other
            else if (c1c2 == r1r2)
                return POSITIONRELATIVE.TouchingExternally; //Touching Externally
            else if (c1c2 > r1Tr2 && c1c2 < r1r2)
                return POSITIONRELATIVE.IntersectingAtTwoPoint; //Intersecting at two point
            else if (c1c2 == r1Tr2)
                return POSITIONRELATIVE.TouchingInternally; //Touching Internally
            else
                return POSITIONRELATIVE.LayingInside; // One lying inside other
         
        }
        #endregion

    }
}
