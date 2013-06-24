using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoClassLib;


namespace Main
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            //comment
            MyMathClass m = new MyMathClass();

            Console.WriteLine("Result: {0}", m.multi(5, 6));
            Console.WriteLine("Result: {0}", m.sum(2, 2));
            Console.WriteLine("Result: {0}", m.sub(3, 1));
            Console.WriteLine();
            Console.WriteLine("Hit 'Enter' lo leave...");
            Console.ReadLine();

        }
    }
}
