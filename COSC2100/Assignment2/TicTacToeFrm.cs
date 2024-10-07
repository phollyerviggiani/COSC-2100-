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
    /// <summary>
    /// COSC2100 Assignment 2, TicTacToe Winform
    /// </summary>
    public partial class TicTacToeFrm : Form
    {
        private TicTacToeGame game = new();
        private Button[,] btnActions = new Button[TicTacToeGame.Rows, TicTacToeGame.Cols];
        public TicTacToeFrm()
        {
            InitializeComponent();
            Size btnSize = new(63, 52);
            const int PositionGap = 5;
            const int StartPositionX = 15;
            int positionX = StartPositionX;
            int positionY = 38;
            for (int row = 0; row < TicTacToeGame.Rows; row++)
            {
                for (int col = 0; col < TicTacToeGame.Cols; col++)
                {
                    btnActions[row, col] = new Button();
                    btnActions[row, col].Click += OnAction;
                    grpGameArea.Controls.Add(btnActions[row, col]);
                    btnActions[row, col].Size = btnSize;
                    btnActions[row, col].Name = $"btnX{row}X{col}";
                    btnActions[row, col].UseVisualStyleBackColor = true;
                    btnActions[row, col].Location = new Point(positionX, positionY);
                    positionX += btnSize.Width + PositionGap;
                }
                positionX = StartPositionX;
                positionY += btnSize.Height + PositionGap;
            }

            listBoxStatus.DataSource = game.GameResult;
        }
        private void OnAction(object? sender, EventArgs e)
        {
            if (sender is Button actionButton)
            {
                string[] words = actionButton.Name.Split('X');
                int row = Convert.ToInt32(words[1]);
                int col = Convert.ToInt32(words[2]);
                game.SetTicToe(row, col);
                UpdateStatus();
            }
        }
        private void UpdateStatus()
        {
            for (int row = 0; row < TicTacToeGame.Rows; row++)
            {
                for (int col = 0; col < TicTacToeGame.Cols; col++)
                {
                    btnActions[row, col].Text = game.GetStatus(row, col).ToString();
                }
            }
            textNextPlayer.Text = game.CurrentPlayer;
            textWinner.Text = game.Winner;
        }
        private void OnContinue(object sender, EventArgs e)
        {
            game.ClearStatus();
            UpdateStatus();
        }

        private void OnStart(object sender, EventArgs e)
        {
            game.SetPlayers("Dan", textSymbol1.Text, "Joe", textSymbol2.Text);
            game.Start();
            UpdateStatus();
        }
    }
}
