// See https://aka.ms/new-console-template for more information
using Casting2;
Console.WriteLine("Hello, World!");

// UPCASTING ........................derived class to base class

Shape s1 = new Circle();

                       // this is possible becuse circle is derived from shape 

s1.Print_Shape


// DOWNCASTING........................base class to derived class

Shape s2 = new Shape();

//Circle c2 = s2;                       // this will give error

                                         // for downcasting we need to do explicit casting

Circle c2 = (Circle)s2;

