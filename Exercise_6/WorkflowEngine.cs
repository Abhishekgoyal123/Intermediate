using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    public class WorkflowEngine
    {
        //public Workflow wf;
        
        public void Run(Workflow wf)
        {
           
            foreach(var item in wf.l1)
            {
                item.Execute();
            }
        }
    }
}
