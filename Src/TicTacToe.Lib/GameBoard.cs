using System;
using System.Text;

namespace TicTacToeLib
{
    public enum Player
    {
        Player1,
        Player2
    };

    public class GameBoard
    {
         public static readonly int[][] WinStates =
        [
            [0, 1, 2],
            [3, 4, 5],
            [6, 7, 8],
            [0, 3, 6],
            [1, 4, 7],
            [2, 5, 8],
            [0, 4, 8],
            [2, 4, 6]
        ];

        private readonly int[] boardArray = [0, 0, 0, 0, 0, 0, 0, 0, 0];

        private IUserInput userInput = null;

        public Player ActivePlayer { get; set; } = Player.Player1;

        // The methods necessary for capturing user input is injected as 
        // an interface so that it can be replaced by a stub for better
        // unit testing the GameState.
        public GameBoard(IUserInput userInput)
        {
            this.userInput = userInput;
        }

        // Retrieves the input of a player, i.e. the field to set
        public int GetField()
        {
            return this.userInput.GetField(this.ActivePlayer);
        }

        /// <summary>
        /// Creates a textual represenation of the board.
        /// </summary>
        /// <returns>String representation of the board.</returns>
        public override string ToString()
        {
            var nextCharacter = string.Empty;
            var sb = new StringBuilder();

            for (int i = 8; i >= 0; i--)
            {
                nextCharacter = "#"; // An empty field
                if (boardArray[i] == 1) nextCharacter = "O"; 
                if (boardArray[i] == 2) nextCharacter = "X";

                sb.Append(nextCharacter);

                // Linebreak
                if (i % 3 == 0) sb.AppendLine();
            }

            return sb.ToString();
        }

        public void Set(int pos)
        {
            if (pos < 0 || pos > 8) throw new ArgumentOutOfRangeException("The gameboard only consists of nine fields. Please set a new coin only on positions from zero to eight.");
            if (boardArray[pos] != 0) throw new ArgumentException("This field is already occupied");

            if (this.ActivePlayer == Player.Player1)
            {
                boardArray[pos] = 1;
            } else
            {
                boardArray[pos] = 2;
            }

            // After making a move, switch to the other player
            this.SwitchPlayer();
        }

        /// <summary>
        /// Switches the active player.
        /// </summary>
        private void SwitchPlayer()
        {
            this.ActivePlayer = this.ActivePlayer == Player.Player1 ? Player.Player2 : Player.Player1;
        }
        
        /// <summary>
        /// Checks if there is a winner in town.
        /// </summary>
        /// <returns>True if there is a winner.</returns>
        /// <remarks>
        /// Currently, there is no need for this method to return who 
        /// actually has won the game, because this information is presented
        /// right after a move has been made and thus it is clear who won.
        /// </remarks>
        public bool CheckWinner()
        {
            foreach (int[] field in WinStates)
            {
                if (boardArray[field[0]] == boardArray[field[1]] 
                && boardArray[field[0]] == boardArray[field[2]] 
                && boardArray[field[0]] != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}