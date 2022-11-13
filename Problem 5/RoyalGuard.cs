using System;
using System.Collections.Generic;

class RoyalGuard
{
    public string _name;
    public int hitpoint = 3;

    public RoyalGuard(string Name)
    {
        _name = Name;
    }

    public void Reaction()
    {
        Console.WriteLine($"Royal Guard {_name} is defending");
    }
}