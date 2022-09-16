using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string ?Name;
        
        // List is a refrence type and we need to assign memory to it using NEW KEYWORD.
        
        // If we dont do it, we will get Null Refrence Error : Object refrence not set to instance of object.

        // this is because list is a object of a class and we need to create an instance of the class object.

        // Null Refrence Error means list is not pointing to anywhere in the memory and we are trying to do some operations in it.


        public List<int> l1=new List<int>();

        public Customer()
           
        {

        }

        public Customer(int id)
            : this()                // this() will call the first default constructor and then this parameterised constructor will be called.
                                    // we have to write :this() outside the scope of constructor

        {
            
            this.Id = id;

        }

        public Customer(int id, string name)
            :this(id)
        {
            this.Id = id;
            this.Name = name;

        }
    }

}
