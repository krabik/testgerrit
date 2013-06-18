using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClass
{
    public class MyMath
    {
        public Boolean MathStatus()
        {
            return true;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Multi(int x, int y)
        {
            return x*y;
        }

        public int Subst(int x, int y)
        {
            return x - y;
        }


    }

    public class MyString
    {
        public string AddSpaceToString(string[] strArray)
        {
            string str = default(string);

            foreach (string item in strArray)
            {
                str += item + " ";
            }

            return str.Trim();
        }

    }
}
