using Casting2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting2
{
    public class Shape
    {
        public void Print_Shape()
        {
            Console.WriteLine("this is shape");
        }

        public  virtual void abcd()
        {
            Console.WriteLine("common parent shape");
        }
    }

    public class Circle : Shape
    {
        public void Print_circle()
        {
            Console.WriteLine("this is circle");
        }

        public override void abcd()
        {
            Console.WriteLine("common child circle");
        }

    }
}

