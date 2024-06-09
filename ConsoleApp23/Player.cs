using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player : IPlayerObserver
{
    private string name;

    public Player(string name)
    {
        this.name = name;
    }

    // Implementacja metody interfejsu IPlayerObserver
    public void Update(Dictionary<string, int> scoreboard)
    {
        Console.WriteLine($"{name}, updated scoreboard:");
        foreach (var entry in scoreboard)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}

