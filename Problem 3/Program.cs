using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Calculatormode Calculatormode = new();
        string comand;

        while ((comand = Console.ReadLine()) != "End")
        {
            string[] select = comand.Split(' ');

            if (select[0] == "mode")
            {
                Calculatormode.ChangeStrategy(Convert.ToChar(select[1]));
            }
            else
            {
                int first = int.Parse(select[0]);
                int second = int.Parse(select[1]);

                int result = Calculatormode.PerformCalculation(first, second);
                Console.WriteLine(result);
            }

        }
        Console.ReadLine();
    }
}