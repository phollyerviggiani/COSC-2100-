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
        // Setting up the structure, buttons, grid, list, for the tiktactoe game
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
        // Updating each click showing the text player and winner
        // Enables the continue button once the game has concluded
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

            btnContinue.Enabled = !string.IsNullOrEmpty(game.Winner);
        }
        // On clicking the continue button, clear board for next game and disable the button again
        // Clicking continue makes it player 1's turn again, regardless of outcome
        private void OnContinue(object sender, EventArgs e)
        {
            game.ClearStatus();
            game.Start();
            UpdateStatus();
            btnContinue.Enabled = false;
        }

        // On clicking the start button, ensure both names/symbols arent matching and are filled in
        private void OnStart(object sender, EventArgs e)
        {

            if (textSymbol1.Text == textSymbol2.Text)
            {
                MessageBox.Show("Players must choose different symbols!");
                return;
            }

            if (textPlayer1.Text == textPlayer2.Text)
            {
                MessageBox.Show("Players must choose different names!");
                return;
            }


                if (string.IsNullOrWhiteSpace(textPlayer1.Text) || string.IsNullOrWhiteSpace(textPlayer2.Text))
            {
                MessageBox.Show("Please enter names for both players.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textSymbol1.Text) || string.IsNullOrWhiteSpace(textSymbol2.Text))
            {
                MessageBox.Show("Please choose symbols for both players.");
                return;
            }

            game.SetPlayers(textPlayer1.Text, textSymbol1.Text, textPlayer2.Text, textSymbol2.Text);
            textPlayer1.Enabled = false;
            textPlayer2.Enabled = false;
            textSymbol1.Enabled = false;
            textSymbol2.Enabled = false;
            btnContinue.Enabled = false;
            btnStart.Enabled = false;
            game.Start();
            UpdateStatus();
        }

        // On loading, assign default values to player 1 and 2 names, focus player 1
        // and disable the continue button
        private void OnLoad(object sender, EventArgs e)
        {
            textPlayer1.Text = "Player 1";
            textPlayer2.Text = "Player 2";
            textPlayer1.Focus();
            btnContinue.Enabled = false;
        }

        // Upon pressing the reset button, clear board, listbox, and re-enable all buttons
        private void OnReset(object sender, EventArgs e)
        {
            textPlayer1.Enabled = true;
            textPlayer2.Enabled = true;
            textSymbol1.Enabled = true;
            textSymbol2.Enabled = true;
            btnContinue.Enabled = true;
            btnStart.Enabled = true;
            game.Reset();
            UpdateStatus();

            game.GameResult.Clear(); 
            listBoxStatus.DataSource = null;
            listBoxStatus.DataSource = game.GameResult; 
        }
    }
}
