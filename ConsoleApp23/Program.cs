using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();

        Player player1 = new Player("Alice");
        Player player2 = new Player("Bob");

        game.AddPlayerObserver(player1);
        game.AddPlayerObserver(player2);

        // Symulacja zmiany wyniku
        game.UpdateScore("Alice", 10);

        // Usunięcie jednego z graczy
        game.RemovePlayerObserver(player2);

        // Symulacja kolejnej zmiany wyniku
        game.UpdateScore("Alice", 20);
    }
}