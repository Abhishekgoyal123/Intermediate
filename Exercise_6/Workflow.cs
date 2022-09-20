using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    public class Workflow
    {
        public List<IActivity> l1;

        public Workflow(IActivity activity)
        {
            l1 = new List<IActivity>();
            l1.Add(activity);
        }

       
    }

    
}
