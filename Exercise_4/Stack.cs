using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
   public class Stack
    {
        public List<Object> l1 = new List<object>();

        
        public void Push(object obj)
        {
            l1.Add(obj);
            
        }
        public Object Pop()
        {

            object poppedElement = l1[l1.Count - 1];
            l1.RemoveAt(l1.Count-1);
            return poppedElement;
        }
        public void Clear()
        {
            
            //l1.Clear();

            int length = l1.Count;
            int i = 0;
            while (i < length) 
            {
                l1.Remove(l1[i]);
                length --;
            }

        }

        public void print()
        {
            if (l1.Count == 0)
            {
                Console.WriteLine("empty stack");
            }
            l1.Reverse();

            foreach(var item in l1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
