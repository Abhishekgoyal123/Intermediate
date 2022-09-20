// See https://aka.ms/new-console-template for more information
using Exercise5_2;
Console.WriteLine("enter instruction");
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
            DbCommand dc = new DbCommand(,abc);
            dc.Execute();

            break;
        case 2:
            OracleConnection oracle = new OracleConnection(abc);
            DbCommand dc1 = new DbCommand(oracle, abc);
            dc1.Execute();
            break;

    }
} while (choice != 0);