using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_Fields
{
    public class Customer
    {
        public int id;
        public static string name="Mukund";

        public static List<int> l1 = new List<int>();     // redonly keyword helps to prevent the list to get initialized again. 
                                                          // readonly helps 
       

        public void abc()
        {
            l1 = new List<int>();
            name = "jhjh";
        }


    }
}
