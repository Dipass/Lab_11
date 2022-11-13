using System;

class FootMan
{
    public string _name;
    public int hitpoint = 2;

    public FootMan(string Name)
    {
        _name = Name;
    }

    public void Reaction()
    {
        Console.WriteLine($"Footman {_name} is panicking");
    }
}