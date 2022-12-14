using System;

class King
{
    public delegate void KingDelegate();
    public event KingDelegate KingAttack;

    public string Name { get;private set; }

    List<RoyalGuard> royalGuards = new();
    List<FootMan> footMen = new();

    public King(string name)
    {
        Name = name; 
    }

    public void AddGuard(RoyalGuard guards)
    {
        if (guards != null)
        {
            royalGuards.Add(guards);
            KingAttack += guards.Reaction;
        }
    }

    public void AddFootman(FootMan footMan)
    {
        if (footMan != null)
        {
            footMen.Add(footMan);
            KingAttack += footMan.Reaction;
        }
    }

    public void Kiils(string namekill)
    {
        for (int i = 0; i < royalGuards.Count; i++)
        {
            if (royalGuards[i]._name == namekill)
            {
                royalGuards.Remove(royalGuards[i]);
                KingAttack -= royalGuards[i].Reaction;
            }
        }

        for (int i = 0; i < footMen.Count; i++)
        {
            if (footMen[i]._name == namekill)
            {
                footMen.Remove(footMen[i]);
                KingAttack -= footMen[i].Reaction;
            }
        }
    }

    public void Attack()
    {
        Console.WriteLine($"King {Name}is under attack!");
        KingAttack?.Invoke();
    }

}