using Casting2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting2
{
    internal class Shape
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
namespace Casting1
{
    public class Class2
    {
        Casting2.Shape ss = new Shape();
    }
}
