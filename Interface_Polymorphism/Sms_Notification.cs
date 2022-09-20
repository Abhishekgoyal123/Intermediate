using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    public class Sms_Notification : INotification

    {
        //INotification noti123;
        public void SendNotification()
        {
            Console.WriteLine("sms sent");
        }
        void add(int a, int b)
        {
            Console.WriteLine($"add = {a+b}");
        }
        
    // INotification.add(10,20);
}
}
