// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int func1(int a,out int b )
//{
//    a = 100;
//    b = 3;
//    return a;
//}

//int pqr = 1000;
//int abcd;

//int xyz = func1(pqr, out abcd);

//Console.WriteLine($"value from function ={xyz}");
//Console.WriteLine($"value from out ={abcd}");


int func1(int a, ref int b)
{
    a = 100;
    //b = 3;
    return a;
}

int pqr = 1000;
int abcd = 9999;

int xyz = func1(pqr, ref abcd);

Console.WriteLine($"value from function ={xyz}");
Console.WriteLine($"value from ref ={abcd}");