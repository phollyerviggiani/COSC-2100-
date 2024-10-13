/* 
Assignmnet 2: Tic-Tac-Toe Game
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: October 15, 2024
Description: Create a program that allows the user to play the game Tic-Tac-Toe. The playfield
             is generated from a 2d array, and it lets the user dynamically play the game.
*/

namespace COSC2100.Assignment2
{
    internal class TicTacToeGame
    {
        public const int MaxPlayers = 2;
        public const int Rows = 3;
        public const int Cols = 3;
        private const int MaxSteps = 9;
        private int[,] status = { { MaxPlayers, MaxPlayers, MaxPlayers },
                                  { MaxPlayers, MaxPlayers, MaxPlayers },
                                  { MaxPlayers, MaxPlayers, MaxPlayers }};
        private string[] players = new string[MaxPlayers];
        private string[] symbols = new string[MaxPlayers];
        private List<string> gameResult = new List<string>();
        private BindingSource bsResult;
        private int currentPlayer = -1;
        private int winner = -1; //-1 - no concluded, 2 - tie
        private int steps = 0;
        private int gameSequence = 1;
        public TicTacToeGame()
        {
            bsResult = new BindingSource(gameResult, null);
        }
        public string CurrentPlayer
        {
            get { return currentPlayer >= 0 ? players[currentPlayer] : string.Empty; }
        }
        public string Winner
        {
            get { return winner < 0 ? "" : winner == MaxPlayers ? "Draw" : players[winner]; }
        }

        public BindingSource GameResult
        {
            get { return bsResult; }
        }
        public void SetPlayers(string playerA, string symbolA, string playerB, string symbolB)
        {
            players[0] = playerA;
            players[1] = playerB;
            symbols[0] = symbolA;
            symbols[1] = symbolB;
        }
        public void Start()
        {
            currentPlayer = 0;
        }
        public void ClearStatus()
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    status[row, col] = MaxPlayers;
                }
            }
            winner = -1;
            steps = 0;
            gameSequence++;
            currentPlayer = ++currentPlayer % MaxPlayers;
        }
        public void Reset()
        {
            ClearStatus();
            currentPlayer = -1;
            gameSequence = 1;
        }
        public bool SetTicToe(int row, int col)
        {
            if (currentPlayer == -1 || winner != -1 || status[row,col] != MaxPlayers)
            {
                return false;
            }
            status[row, col] = currentPlayer;
            if (HasConcluded() == false)
            {
                currentPlayer = ++currentPlayer % MaxPlayers;
            }
            else
            {
                gameResult.Add($"Game{gameSequence}: {this.Winner}");
                bsResult.ResetBindings(false);
            }
            return true;
        }
        private bool HasConcluded()
        {
            return false;
        }
        public string GetStatus(int row, int col)
        {
            return status[row, col] != MaxPlayers ? symbols[status[row, col]] : string.Empty;
        }
    }
}
