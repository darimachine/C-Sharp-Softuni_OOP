using System;

namespace MathOperation
{
    class MathOperation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a, double b,double c)
        {
            return a + b+c;
        }
        public decimal Add(decimal a, decimal b, decimal c)
        {
            return a + b+c;
        }
        
    }
    class BEL:MathOperation
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3,5.5));
            Console.WriteLine(mo.Add(3.2m, 4.3m, 7.5m));
        }
    }
}
