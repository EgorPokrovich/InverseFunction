using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverseFunction
{
    class InverseFunction
    {
        public  delegate double UsedFunc (double y);
        public delegate void GetAccuracy(double acc);
        public event GetAccuracy GetAcc;
        public double CountDif (double a, double b, double y, double accuracy, UsedFunc Func)
        {
            if (a < y && b > y)
            {
                double xfirst;
                double xsecond;
                double eps;
                do
                {
                    xfirst = (a + b) / 2;
                    if (Func(xfirst) >= y)
                    {
                        b = xfirst;
                    }
                    else
                    {
                        a = xfirst;
                    }
                    xsecond = (a + b) / 2;
                    eps = Math.Abs(xfirst - xsecond);
                    GetAcc?.Invoke(Math.Round(eps, 5));
                }
                while (eps > accuracy);
                return xsecond;                
            }
            else
            {
                throw new Exception("Incorrect params\ny is not betwin a - b.");
            }

        }
    }
}
