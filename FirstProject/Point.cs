using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Point
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Contructor
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        #endregion

        #region Method
        /// <summary>
        /// Tinh khoang cach cua doi tuong den O(0,0)
        /// </summary>
        /// <returns></returns>
        public double Distance()
        {
            var d = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));

            return d;
        }
        /// <summary>
        /// Tinh khoang cach den diem Q(xq,yq)
        /// </summary>
        /// <param name="q"></param>
        /// <returns>Khoang cach den q</returns>
        public double Distance(Point q)
        {
            var d = Math.Sqrt(Math.Pow(x-q.x, 2) + Math.Pow(y-q.y, 2));

            return d;
        }
        /// <summary>
        /// Tinh khoang cahc 2 diem
        /// </summary>
        /// <param name="p">Diem thu nhat </param>
        /// <param name="q">Diem thu hai</param>
        /// <returns></returns>
        public static double Distance(Point p, Point q)
        {
            var d = Math.Sqrt(Math.Pow(p.x - q.x, 2) + Math.Pow(p.y - q.y, 2));

            return d;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})",x,y);
        }
        #endregion
    }
}
