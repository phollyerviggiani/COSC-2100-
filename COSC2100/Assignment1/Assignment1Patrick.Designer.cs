namespace COSC2100.Assignment1
{
    partial class Assignment1Patrick
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
            labelGameSales = new Label();
            textBoxGameSales = new TextBox();
            textBoxOutputSum = new TextBox();
            buttonEnter = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            listBoxData = new ListBox();
            labelDayNumber = new Label();
            comboBoxDayNumber = new ComboBox();
            SuspendLayout();
            // 
            // labelGameSales
            // 
            labelGameSales.AutoSize = true;
            labelGameSales.Location = new Point(28, 60);
            labelGameSales.Name = "labelGameSales";
            labelGameSales.Size = new Size(129, 20);
            labelGameSales.TabIndex = 0;
            labelGameSales.Text = "Video Game Sales";
            // 
            // textBoxGameSales
            // 
            textBoxGameSales.Location = new Point(163, 57);
            textBoxGameSales.Name = "textBoxGameSales";
            textBoxGameSales.Size = new Size(139, 27);
            textBoxGameSales.TabIndex = 1;
            // 
            // textBoxOutputSum
            // 
            textBoxOutputSum.Location = new Point(28, 396);
            textBoxOutputSum.Name = "textBoxOutputSum";
            textBoxOutputSum.ReadOnly = true;
            textBoxOutputSum.Size = new Size(435, 27);
            textBoxOutputSum.TabIndex = 2;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(44, 463);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(94, 29);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += OnEnter;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(190, 463);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += OnReset;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(340, 463);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += OnExit;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 20;
            listBoxData.Location = new Point(28, 117);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(435, 244);
            listBoxData.TabIndex = 6;
            // 
            // labelDayNumber
            // 
            labelDayNumber.AutoSize = true;
            labelDayNumber.Location = new Point(324, 60);
            labelDayNumber.Name = "labelDayNumber";
            labelDayNumber.Size = new Size(35, 20);
            labelDayNumber.TabIndex = 7;
            labelDayNumber.Text = "Day";
            // 
            // comboBoxDayNumber
            // 
            comboBoxDayNumber.FormattingEnabled = true;
            comboBoxDayNumber.Location = new Point(365, 57);
            comboBoxDayNumber.Name = "comboBoxDayNumber";
            comboBoxDayNumber.Size = new Size(98, 28);
            comboBoxDayNumber.TabIndex = 8;
            // 
            // Assignment1Patrick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 545);
            Controls.Add(comboBoxDayNumber);
            Controls.Add(labelDayNumber);
            Controls.Add(listBoxData);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxOutputSum);
            Controls.Add(textBoxGameSales);
            Controls.Add(labelGameSales);
            Name = "Assignment1Patrick";
            Text = "Average Weekly Video Game Sales";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameSales;
        private TextBox textBoxGameSales;
        private TextBox textBoxOutputSum;
        private Button buttonEnter;
        private Button buttonReset;
        private Button buttonExit;
        private ListBox listBoxData;
        private Label labelDayNumber;
        private ComboBox comboBoxDayNumber;
    }
}