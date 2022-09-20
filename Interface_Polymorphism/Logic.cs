using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism
{
    public class Logic
    {
        public void notification_Logic(INotification noti)  
        {
            noti.SendNotification();
            noti.add(1, 2);
        }
        //INotification noti ;
        //noti.
    }
}
