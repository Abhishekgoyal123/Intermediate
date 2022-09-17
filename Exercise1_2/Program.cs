// See https://aka.ms/new-console-template for more information
using Exercise1_2;
Console.WriteLine("Hello, World!");

StackOverFlow sf = new StackOverFlow();

Console.WriteLine("enter title");

string title = Console.ReadLine();

Console.WriteLine("enter description");

string description = Console.ReadLine();

sf.Post(title, description);

Console.WriteLine("1 upvote");
Console.WriteLine("2. downvote");

int choice;
do
{
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1 : 
            int upvote = sf.Upvoting();
            Console.WriteLine("POST");
            Console.WriteLine($"TITLE = {sf.Title}");
            Console.WriteLine($"DESCRIPTION = {sf.Description}");

            Console.WriteLine($"Total upvotes =, {upvote}");
            break;
            
        case 2:

            Console.WriteLine("POST");
            Console.WriteLine($"TITLE = {sf.Title}");
            Console.WriteLine($"DESCRIPTION = {sf.Description}");

            int downvote = sf.Downvoting();
            Console.WriteLine($"Total downvotes = {downvote}");
            break;
    }


}
while (choice!=0);