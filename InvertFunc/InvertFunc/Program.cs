using System;

namespace InvertFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("инициализируем обект класса");
            Invert test = new Invert();
            Console.WriteLine("присваиваем делагату функцию, в которой есть событие");
            Invert.InFunc deleg = new Invert.InFunc(FirstFunc1);
            Console.WriteLine("подписываем на событие функцию через лямбда-выражения");
            test.InFuncCallBack += x => { Console.WriteLine($"(1)Math.Sin(x): {Math.Sin(x)}"); return Math.Sin(x); };
            Console.WriteLine("подписываем на событие функцию через анонимные методы");
            test.InFuncCallBack += delegate (double x) { Console.WriteLine($"(2)x + 3.1: {x + 3.1}"); return x + 3.1; };
            Console.WriteLine("подписываем на событие функцию через делегат, указывающий на ff1");
            test.InFuncCallBack += deleg;
            Console.WriteLine("вызываем функцию с событием");
            test.FirstFunc2(1);
            Console.ReadLine();
        }
         public static double FirstFunc1 (double x)
        {
            Console.WriteLine("(3)вызвалось FirstFunc1 (double x)");
            return Math.Sin(x);
            
        }
    }
}
