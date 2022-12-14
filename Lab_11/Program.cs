using System;


class Program
{
    static void Main()
    {
        Dispatcher dispatcher = new Dispatcher();
        Handler handler = new Handler();

        dispatcher.NameChange += handler.OnDispatcherNameChange;

        while (true)
        {
            string name = Console.ReadLine();
            if (name == "End")
                break;

            dispatcher.Name = name;
        }
    }
}