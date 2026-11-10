using TicTacToe.Console.GameStates;
using TicTacToeLib;

namespace TicTacToe.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new GameBoard(new UserInput());

            IGameState currentState = new GameStateRunning();

            while (currentState != null)
            {
                currentState = currentState.Execute(board);
            }
        }
    }
}
