using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApps.MyProject
{
    public class SimpleMath
    {
        public static double Divide(int a, int b)
        {
            //return a / b;

            double result = (double)a / (double)b;
            return Math.Round(result);
        }

        public static int Surface(int height, int width)
        {
            if (height < 0 || width < 0)
                return 0;
            else
                return height * width;
        }

    }
}
