using System;
using System.Collections.Generic;

// Interfejs obserwatora
public interface IPlayerObserver
{
    void Update(Dictionary<string, int> scoreboard);
}