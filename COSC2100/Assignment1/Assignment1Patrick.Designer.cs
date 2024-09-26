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
            components = new System.ComponentModel.Container();
            labelGameSales = new Label();
            textBoxGameSales = new TextBox();
            textBoxOutputSum = new TextBox();
            buttonEnter = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            listBoxData = new ListBox();
            labelDayNumber = new Label();
            comboBoxDayNumber = new ComboBox();
            toolTipAssignment1 = new ToolTip(components);
            SuspendLayout();
            // 
            // labelGameSales
            // 
            labelGameSales.AutoSize = true;
            labelGameSales.Location = new Point(24, 37);
            labelGameSales.Name = "labelGameSales";
            labelGameSales.Size = new Size(100, 15);
            labelGameSales.TabIndex = 0;
            labelGameSales.Text = "Video Game Sales";
            // 
            // textBoxGameSales
            // 
            textBoxGameSales.Location = new Point(143, 34);
            textBoxGameSales.Margin = new Padding(3, 2, 3, 2);
            textBoxGameSales.Name = "textBoxGameSales";
            textBoxGameSales.Size = new Size(104, 23);
            textBoxGameSales.TabIndex = 1;
            toolTipAssignment1.SetToolTip(textBoxGameSales, "Enter the amount earned in sales");
            // 
            // textBoxOutputSum
            // 
            textBoxOutputSum.Location = new Point(24, 224);
            textBoxOutputSum.Margin = new Padding(3, 2, 3, 2);
            textBoxOutputSum.Name = "textBoxOutputSum";
            textBoxOutputSum.ReadOnly = true;
            textBoxOutputSum.Size = new Size(275, 23);
            textBoxOutputSum.TabIndex = 2;
            textBoxOutputSum.TextAlign = HorizontalAlignment.Center;
            toolTipAssignment1.SetToolTip(textBoxOutputSum, "Displays the total weekly earnings");
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(24, 274);
            buttonEnter.Margin = new Padding(3, 2, 3, 2);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(82, 22);
            buttonEnter.TabIndex = 3;
            buttonEnter.Text = "Enter";
            toolTipAssignment1.SetToolTip(buttonEnter, "Press ctrl + e to enter the value");
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += OnEnter;
            buttonEnter.KeyDown += buttonEnter_KeyDown;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(121, 274);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(82, 22);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            toolTipAssignment1.SetToolTip(buttonReset, "Press esc to reset the window");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += OnReset;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(217, 274);
            buttonExit.Margin = new Padding(3, 2, 3, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(82, 22);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            toolTipAssignment1.SetToolTip(buttonExit, "Press F4 to exit the window");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += OnExit;
            buttonExit.KeyDown += buttonExit_KeyDown;
            // 
            // listBoxData
            // 
            listBoxData.FormattingEnabled = true;
            listBoxData.ItemHeight = 15;
            listBoxData.Location = new Point(24, 78);
            listBoxData.Margin = new Padding(3, 2, 3, 2);
            listBoxData.Name = "listBoxData";
            listBoxData.Size = new Size(163, 109);
            listBoxData.TabIndex = 6;
            // 
            // labelDayNumber
            // 
            labelDayNumber.AutoSize = true;
            labelDayNumber.Location = new Point(198, 78);
            labelDayNumber.Name = "labelDayNumber";
            labelDayNumber.Size = new Size(27, 15);
            labelDayNumber.TabIndex = 7;
            labelDayNumber.Text = "Day";
            toolTipAssignment1.SetToolTip(labelDayNumber, "Select the day number");
            // 
            // comboBoxDayNumber
            // 
            comboBoxDayNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDayNumber.FormattingEnabled = true;
            comboBoxDayNumber.Location = new Point(231, 75);
            comboBoxDayNumber.Margin = new Padding(3, 2, 3, 2);
            comboBoxDayNumber.Name = "comboBoxDayNumber";
            comboBoxDayNumber.Size = new Size(60, 23);
            comboBoxDayNumber.TabIndex = 8;
            toolTipAssignment1.SetToolTip(comboBoxDayNumber, "Click the dropdown arrow");
            // 
            // Assignment1Patrick
            // 
            AcceptButton = buttonEnter;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new Size(311, 318);
            Controls.Add(comboBoxDayNumber);
            Controls.Add(labelDayNumber);
            Controls.Add(listBoxData);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxOutputSum);
            Controls.Add(textBoxGameSales);
            Controls.Add(labelGameSales);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Assignment1Patrick";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolTip toolTipAssignment1;
    }
}