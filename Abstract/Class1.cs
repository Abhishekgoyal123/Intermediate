using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Class1
    {
        public virtual int sub(int a, int b)
        {
            return a - b;
        }
        public abstract int add(int a,int b);
    }

    public class child : Class1
    {
        public override int add(int a, int b)
        {
            return a + b;
        }

        public new int sub(int a,int b)
        {
            return a * b;

        }
    }


}
