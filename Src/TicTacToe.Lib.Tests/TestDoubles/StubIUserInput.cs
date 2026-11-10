using System;

namespace TicTacToeLib.Tests
{
    // Ersetzt den frueher von Microsoft Fakes generierten Stub (TicTacToeLib.Fakes.StubIUserInput).
    // Name und Aufbau entsprechen dem generierten Original, damit die Tests unveraendert bleiben.
    public class StubIUserInput : IUserInput
    {
        public Func<Player, int> GetFieldPlayer { get; set; }

        public int GetField(Player player)
        {
            return this.GetFieldPlayer(player);
        }
    }
}
