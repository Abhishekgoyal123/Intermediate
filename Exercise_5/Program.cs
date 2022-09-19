// See https://aka.ms/new-console-template for more information
using Exercise_5;
Console.WriteLine("enter string");
string abc = Console.ReadLine();

int choice;
do
{
    Console.WriteLine("1 SQL");
    Console.WriteLine("2 ORACLE");


    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {

        case 1:
            SqlConnection sql = new SqlConnection(abc);
            sql.OpenConnection();
            sql.StopConnection();
            
            break;
        case 2:
            OracleConnection oracle = new OracleConnection(abc);
            oracle.OpenConnection();
            oracle.StopConnection();
            break;

    }
} while (choice != 0);