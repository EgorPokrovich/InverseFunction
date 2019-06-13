using System;
using System.Collections.Generic;
using System.Text;

namespace InvertFunc
{
    class Invert
    {
        public delegate double InFunc (double x);
        public event InFunc InFuncCallBack;

        public double ff(double a, double b, InFunc Func, double y, double eps)
        {
            double x;
            x = 1;
            return x;
        }
        public double CallBackTest (double x)
        {
            if (x == 0) InFuncCallBack(1);
            if (x == 1) InFuncCallBack(0.1);
            return 0;
        }

        public double FirstFunc2(double x)
        {
            Console.WriteLine("=== внутри функции FirstFunc2(double x) ===");
            InFuncCallBack(x);
            return Math.Sin(x);

        }


    }
}
