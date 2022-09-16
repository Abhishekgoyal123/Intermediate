// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void abc(params int[] a)
{

}

abc(1, 2, 3, 4, 5);      // params keyword is use to pass variable number of arguments to a method. 
                         // Params internally works as an array, so it converts all the parameters into an array.


abc();                     // We can pass method with no arguments, to a method which takes param argument.

static void a1(int[] arr)
{

}

a1(new int[] { 1, 2, 3, 4, 5 });
//a1();