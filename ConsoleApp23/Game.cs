using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game
{
    private Dictionary<string, int> scoreboard = new Dictionary<string, int>();
    private List<IPlayerObserver> observers = new List<IPlayerObserver>();

    // Metoda do dodawania obserwatorów (graczy)
    public void AddPlayerObserver(IPlayerObserver observer)
    {
        observers.Add(observer);
        observer.Update(scoreboard); // Inicjalne powiadomienie o aktualnym stanie tablicy wyników
    }

    // Metoda do usuwania obserwatorów (graczy)
    public void RemovePlayerObserver(IPlayerObserver observer)
    {
        observers.Remove(observer);
    }

    // Metoda do aktualizowania wyniku danego gracza
    public void UpdateScore(string playerName, int score)
    {
        scoreboard[playerName] = score;
        NotifyObservers();
    }

    // Metoda do powiadamiania wszystkich obserwatorów (graczy) o zmianie
    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(scoreboard);
        }
    }
}