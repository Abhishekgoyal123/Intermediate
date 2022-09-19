using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    public class Shape
    {
        public void Print_Shape()
        {
            Console.WriteLine("this is shape");
        }
    }

    public class Circle : Shape
    {
        public void Print_circle()
        {
            Console.WriteLine("this is circle");
        }
    }
}
