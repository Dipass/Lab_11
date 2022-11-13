using System;

class Program
{
    static void Main()
    {
        string kingname = Console.ReadLine();
        King king = new King(kingname);

        string[] guard = Console.ReadLine().Split(' ');
        foreach (string s in guard)
        {
            king.AddGuard(new RoyalGuard (s));
        }
        string[] foot = Console.ReadLine().Split(' ');
        foreach (string s in foot)
        {
            king.AddFootman(new FootMan(s));
        }

        string comand;
        while ((comand = Console.ReadLine()) != "End")
        {
            string[] select = comand.Split(' ');

            switch (select[0])
            {
                case "Attack_king":
                    king.Attack();
                    break;
                case "Kill":
                    king.Kiils(select[1]);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        Console.ReadLine();
    }
}