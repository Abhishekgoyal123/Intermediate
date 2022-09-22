using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_2
{


    public class Class2
    {
        protected string mame;
        protected int add2(int a, int b)
        {
            return a + b;
        }
    }

    public class child : Class2
    {

        public void nain()
        {
            
           add2(1, 2);
            Console.WriteLine(abcd);
            
        }

        public void dis(int a , int b)
        {
            int c = add2(a , b);
            Console.WriteLine(a);

        }





    }
}

