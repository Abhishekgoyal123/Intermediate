// See https://aka.ms/new-console-template for more information
using Abstract;
Console.WriteLine("Hello, World!");

Class1 c1 = new child();           // UPCASTING

int abcd = c1.add(1, 2);            // override ---------abstract method 
Console.WriteLine(abcd);


c1.sub(1, 2);