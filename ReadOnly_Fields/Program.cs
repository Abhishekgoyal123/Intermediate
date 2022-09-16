// See https://aka.ms/new-console-template for more information
using ReadOnly_Fields;

Customer c1 = new Customer();

Customer.l1.Add(1);


c1.dis();
c1.abc();


foreach (var item in Customer.l1)
{
    Console.WriteLine(item);
}

