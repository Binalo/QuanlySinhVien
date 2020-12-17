using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1.ToString());

            Point p2= new Point(5,5);
            Console.WriteLine(p2.ToString());

            Point p3 = p2;
            p3.x = 10;
            p3.y = 20;
            Console.WriteLine(p2.ToString());

            Point p4 = new Point(p2);
            p4.x = 50;
            p4.y = 100;
            Console.WriteLine(p4.ToString());

            var d24 = p2.Distance(p4);
            var d42 = p4.Distance(p2);
            Console.WriteLine("D24 = {0}",d24);
            Console.WriteLine("D42 = {0}", d42);

            var dstatic = Point.Distance(p2, p4);
            Console.WriteLine("DStatic = {0}", dstatic);


            Console.ReadKey();
        }
    }
}
