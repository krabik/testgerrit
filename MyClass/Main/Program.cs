using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyClass;



namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMath inst = new MyMath();
            

            Console.WriteLine("Result: {0}", inst.Multi(5, 6));
            Console.WriteLine();
            Console.WriteLine("Hit 'Enter' lo leave...");
            Console.ReadLine();

        }
    }
}
