﻿namespace COSC2100.Assignment2
{
    partial class TicTacToeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textSymbol2 = new TextBox();
            label2 = new Label();
            textPlayer2 = new TextBox();
            label3 = new Label();
            textSymbol1 = new TextBox();
            label4 = new Label();
            textPlayer1 = new TextBox();
            grpGameArea = new GroupBox();
            textNextPlayer = new TextBox();
            label5 = new Label();
            btnStart = new Button();
            btnContinue = new Button();
            btnReset = new Button();
            groupBox3 = new GroupBox();
            listBoxStatus = new ListBox();
            textWinner = new TextBox();
            label6 = new Label();
            toolTipTicTacToe = new ToolTip(components);
            groupBox1.SuspendLayout();
            grpGameArea.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Play 1 Name:";
            toolTipTicTacToe.SetToolTip(label1, "Name for player 1");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textSymbol2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textPlayer2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textSymbol1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textPlayer1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Setup";
            // 
            // textSymbol2
            // 
            textSymbol2.Location = new Point(437, 82);
            textSymbol2.Name = "textSymbol2";
            textSymbol2.Size = new Size(58, 27);
            textSymbol2.TabIndex = 3;
            textSymbol2.Text = "O";
            textSymbol2.TextAlign = HorizontalAlignment.Center;
            toolTipTicTacToe.SetToolTip(textSymbol2, "Please enter player 2's symbol");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 82);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Play 2 Symbol:";
            toolTipTicTacToe.SetToolTip(label2, "Symbol for player 2");
            // 
            // textPlayer2
            // 
            textPlayer2.Location = new Point(124, 82);
            textPlayer2.Name = "textPlayer2";
            textPlayer2.Size = new Size(125, 27);
            textPlayer2.TabIndex = 1;
            toolTipTicTacToe.SetToolTip(textPlayer2, "Please enter player 2's name");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 82);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "Play 2 Name:";
            toolTipTicTacToe.SetToolTip(label3, "Name for player 2");
            // 
            // textSymbol1
            // 
            textSymbol1.Location = new Point(437, 36);
            textSymbol1.Name = "textSymbol1";
            textSymbol1.Size = new Size(58, 27);
            textSymbol1.TabIndex = 2;
            textSymbol1.Text = "X";
            textSymbol1.TextAlign = HorizontalAlignment.Center;
            toolTipTicTacToe.SetToolTip(textSymbol1, "Please enter player 1's symbol");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 36);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Play 1 Symbol:";
            toolTipTicTacToe.SetToolTip(label4, "Symbol for player 1");
            // 
            // textPlayer1
            // 
            textPlayer1.Location = new Point(124, 36);
            textPlayer1.Name = "textPlayer1";
            textPlayer1.Size = new Size(125, 27);
            textPlayer1.TabIndex = 0;
            toolTipTicTacToe.SetToolTip(textPlayer1, "Please enter player 1's name");
            // 
            // grpGameArea
            // 
            grpGameArea.Controls.Add(textNextPlayer);
            grpGameArea.Controls.Add(label5);
            grpGameArea.Controls.Add(btnStart);
            grpGameArea.Controls.Add(btnContinue);
            grpGameArea.Controls.Add(btnReset);
            grpGameArea.Location = new Point(39, 187);
            grpGameArea.Name = "grpGameArea";
            grpGameArea.Size = new Size(313, 251);
            grpGameArea.TabIndex = 2;
            grpGameArea.TabStop = false;
            grpGameArea.Text = "Game Area";
            // 
            // textNextPlayer
            // 
            textNextPlayer.Location = new Point(128, 218);
            textNextPlayer.Name = "textNextPlayer";
            textNextPlayer.ReadOnly = true;
            textNextPlayer.Size = new Size(125, 27);
            textNextPlayer.TabIndex = 12;
            toolTipTicTacToe.SetToolTip(textNextPlayer, "Next players turn");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 218);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 6;
            label5.Text = "Next Turn:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(222, 38);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(63, 52);
            btnStart.TabIndex = 3;
            btnStart.Text = "&Start";
            toolTipTicTacToe.SetToolTip(btnStart, "Click to start the games");
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += OnStart;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(222, 96);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(63, 52);
            btnContinue.TabIndex = 7;
            btnContinue.Text = "&Cont.";
            toolTipTicTacToe.SetToolTip(btnContinue, "Click to continue after game has concluded");
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += OnContinue;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(222, 154);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 52);
            btnReset.TabIndex = 11;
            btnReset.Text = "&Reset";
            toolTipTicTacToe.SetToolTip(btnReset, "Click or press 'esc' to reset to default");
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += OnReset;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxStatus);
            groupBox3.Controls.Add(textWinner);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(371, 187);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(193, 251);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Game Stats";
            // 
            // listBoxStatus
            // 
            listBoxStatus.FormattingEnabled = true;
            listBoxStatus.ItemHeight = 20;
            listBoxStatus.Location = new Point(19, 34);
            listBoxStatus.Name = "listBoxStatus";
            listBoxStatus.Size = new Size(150, 164);
            listBoxStatus.TabIndex = 9;
            toolTipTicTacToe.SetToolTip(listBoxStatus, "Shows game outcomes");
            // 
            // textWinner
            // 
            textWinner.Location = new Point(77, 215);
            textWinner.Name = "textWinner";
            textWinner.ReadOnly = true;
            textWinner.Size = new Size(88, 27);
            textWinner.TabIndex = 0;
            toolTipTicTacToe.SetToolTip(textWinner, "Shows current game winner");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 218);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 8;
            label6.Text = "Winner:";
            // 
            // TicTacToeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new Size(610, 483);
            Controls.Add(groupBox3);
            Controls.Add(grpGameArea);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicTacToeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            Load += OnLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpGameArea.ResumeLayout(false);
            grpGameArea.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textPlayer1;
        private TextBox textSymbol2;
        private Label label2;
        private TextBox textPlayer2;
        private Label label3;
        private TextBox textSymbol1;
        private Label label4;
        private GroupBox grpGameArea;
        private GroupBox groupBox3;
        private Button btnStart;
        private Button btnContinue;
        private Button btnReset;
        private Button btn12;
        private Button btn01;
        private Button btn02;
        private Button btn20;
        private Button btn10;
        private Button btn21;
        private Button btn22;
        private Button btn11;
        private Button btn00;
        private TextBox textNextPlayer;
        private Label label5;
        private TextBox textWinner;
        private Label label6;
        private ListBox listBoxStatus;
        private ToolTip toolTipTicTacToe;
    }
}