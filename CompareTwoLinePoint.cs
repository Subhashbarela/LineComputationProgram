using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputationProgram
{
    internal class CompareTwoLinePoint
    {
        public static void Compare()
        {
            int x1 = 10, y1 = 10;
            int x2 = 20, y2 = 10;

            int p1 = 30, q1 = 30;
            int p2 = 40, q2 = 30;
            {
                double Line1 = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);

                double Line2 = Math.Sqrt((p2 - p1) * 2 + (q2 - q1) * 2);


                Double Equality = Line1.CompareTo(Line2);

                if (Equality > 0)
                {
                    Console.WriteLine("line1 is greater than Line2");
                    Console.WriteLine(Line1 + " is greater than" + Line2);
                }
                else if (Equality < 0)
                {
                    Console.WriteLine("line1 is Less than Line2");
                    Console.WriteLine(Line1 + " is less than than" + Line2);
                }
                else
                {
                    Console.WriteLine("line1 is Equal To Line2");
                    Console.WriteLine(Line1 + " is equal to" + Line2);
                }

            }
        }
    }
}
