// See https://aka.ms/new-console-template for more information
using Exercise1_1;
Console.WriteLine("Hello, World!");

Stopwatch sw = new Stopwatch();
try
{
    int choice;
    do
    {
        Console.WriteLine("1 start");
        Console.WriteLine("2 stop");


        choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
           
            case 1:
                sw.start();
                Console.WriteLine("stopwatch started");
                break;
            case 2:
                sw.stop();
                Console.WriteLine("stopwatch stopped");
                TimeSpan duration = sw.endTime - sw.startTime;
                Console.WriteLine($"total duration = {duration}");
                break;

        }
    } while (choice != 0);

}

catch (InvalidOperationException ex)
{

    Console.WriteLine(ex.Message);
}

