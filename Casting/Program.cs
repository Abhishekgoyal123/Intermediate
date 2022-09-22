// See https://aka.ms/new-console-template for more information
using Casting2;
Console.WriteLine("Hello, World!");

// UPCASTING ........................derived class to base class

// IT IS DONE WHEN WE HAVE COMMON METHODS IN BOTH BASD AND DERIVED CLASS AND WHEN WE WANT TO ACCESS THE METHOD OF DERIVED CLASS.

Circle c1 = new Circle();
c1.
Shape s1 = c1;
s1.abcd();                      //derived class method

Shape s22 = new Circle();
s22.abcd();

c1.abcd();
s22.
s1.Print_Shape();                                       // this is possible becuse circle is derived from shape 


// DOWNCASTING........................base class to derived class

Shape s2 = new Shape();

//Circle c2 = s2;                       // this will give error

                                         // for downcasting we need to do explicit casting

Circle c2 = (Circle)s2;



