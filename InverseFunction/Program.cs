using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverseFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InverseFunction GetInverse = new InverseFunction();
                InverseFunction.UsedFunc DelegatFunc = new InverseFunction.UsedFunc(SelfFunc);
                GetInverse.GetAcc += eps => Console.WriteLine($"current accurasy: {eps}");
                Console.WriteLine(GetInverse.CountDif(0.1, 1.3, 0.5, 0.0001, x => Math.Sin(x)));
                Console.WriteLine("===================");               
                Console.WriteLine(GetInverse.CountDif(1.1, 2.3, 1.5, 0.01, DelegatFunc));
                Console.WriteLine("===================");
                Console.WriteLine(GetInverse.CountDif(2.5, 3.5, 8, 0.0001, delegate (double x) { return (x * x + Math.Sin(x - 2)); }));                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        private static double SelfFunc(double x)
        {
            return (Math.Pow(x, 3));
        }
    }
}
