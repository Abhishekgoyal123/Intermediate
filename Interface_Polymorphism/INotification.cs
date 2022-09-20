using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    public interface INotification
    {
        void SendNotification();

        void add(int a, int b)
        {
            Console.WriteLine($"add = {a+b}");
        }
    }
}
