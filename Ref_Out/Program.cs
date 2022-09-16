// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x;
int y = 20;

//normalMethod(x, y);

//Console.WriteLine($"after exchange x= {x} y={y}"); // 10,20


static void normalMethod(int a, int b)
{
    int c = a;
    a = b;
    b = c;

    Console.WriteLine($"after exchange in method a ={a}");  //20
    Console.WriteLine($"after exchange in method b ={b}");  //10
}

int p = 10;
int q = 20;
RefMethod(ref p, ref q);
Console.WriteLine($"after exchange p= {p} q={q}");        //20,10


static void RefMethod(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;

    Console.WriteLine($"after exchange in method a ={a}");  //20
    Console.WriteLine($"after exchange in method b ={b}"); //10
}

int m=2;
int n=1;

OutMethod(out m, out n);
Console.WriteLine($"after exchange m= {m} n={n}");        //200,100


static void OutMethod( out int a, out int b)                // Out keyword return the value to the caller 
{                                                           // we have passed 2 and 1 to the outmethod, but it will ignore that and will consider the values which are defined in the function declaration.
    a = 100;
    b = 200;
    int c = a;
       a = b;
        b = c;

    Console.WriteLine($"after exchange in method a ={a}");  //200
    Console.WriteLine($"after exchange in method b ={b}"); //100
}

