using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputationProgram
{
    internal class DistanceBtwnTwoLine
    {
        public static void length(double x1, double y1, double x2, double y2)
        {
            double Distance = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
            Console.WriteLine("Length Between two Line is : " + Distance);
        }
    }
}
