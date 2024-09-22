namespace COSC2100.IP1
{
    partial class IP1Patrick
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
            labelFirstInput = new Label();
            textFirstBox = new TextBox();
            labelSecondInput = new Label();
            textSecondBox = new TextBox();
            buttonAdd = new Button();
            buttonMultiply = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            labelOutput = new Label();
            textOutputBox = new TextBox();
            toolTips = new ToolTip(components);
            SuspendLayout();
            // 
            // labelFirstInput
            // 
            labelFirstInput.AutoSize = true;
            labelFirstInput.Location = new Point(90, 83);
            labelFirstInput.Name = "labelFirstInput";
            labelFirstInput.Size = new Size(74, 20);
            labelFirstInput.TabIndex = 0;
            labelFirstInput.Text = "First Input";
            toolTips.SetToolTip(labelFirstInput, "First Input");
            // 
            // textFirstBox
            // 
            textFirstBox.Location = new Point(183, 80);
            textFirstBox.Name = "textFirstBox";
            textFirstBox.Size = new Size(125, 27);
            textFirstBox.TabIndex = 1;
            toolTips.SetToolTip(textFirstBox, "Enter the first number");
            // 
            // labelSecondInput
            // 
            labelSecondInput.AutoSize = true;
            labelSecondInput.Location = new Point(68, 140);
            labelSecondInput.Name = "labelSecondInput";
            labelSecondInput.Size = new Size(96, 20);
            labelSecondInput.TabIndex = 2;
            labelSecondInput.Text = "Second Input";
            toolTips.SetToolTip(labelSecondInput, "Second Input");
            // 
            // textSecondBox
            // 
            textSecondBox.Location = new Point(183, 137);
            textSecondBox.Name = "textSecondBox";
            textSecondBox.Size = new Size(125, 27);
            textSecondBox.TabIndex = 3;
            toolTips.SetToolTip(textSecondBox, "Enter the second number");
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(68, 231);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Add";
            toolTips.SetToolTip(buttonAdd, "Click or press ctrl + a to add");
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += OnClickAdd;
            buttonAdd.KeyDown += buttonAdd_KeyDown;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(214, 231);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(94, 29);
            buttonMultiply.TabIndex = 5;
            buttonMultiply.Text = "Multiply";
            toolTips.SetToolTip(buttonMultiply, "Click or press ctrl + m to multiply");
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += OnClickMultiply;
            buttonMultiply.KeyDown += buttonMultiply_KeyDown;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(68, 294);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            toolTips.SetToolTip(buttonReset, "Click or press esc to reset the values");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += OnClickReset;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(214, 294);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            toolTips.SetToolTip(buttonExit, "Click or press F4 to exit");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += OnClickExit;
            buttonExit.KeyDown += buttonExit_KeyDown;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(90, 364);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(55, 20);
            labelOutput.TabIndex = 8;
            labelOutput.Text = "Output";
            toolTips.SetToolTip(labelOutput, "Output value");
            // 
            // textOutputBox
            // 
            textOutputBox.Location = new Point(183, 361);
            textOutputBox.Name = "textOutputBox";
            textOutputBox.ReadOnly = true;
            textOutputBox.Size = new Size(125, 27);
            textOutputBox.TabIndex = 9;
            toolTips.SetToolTip(textOutputBox, "Displays the sum or product of the two given numbers");
            // 
            // IP1Patrick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new Size(391, 457);
            Controls.Add(textOutputBox);
            Controls.Add(labelOutput);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonAdd);
            Controls.Add(textSecondBox);
            Controls.Add(labelSecondInput);
            Controls.Add(textFirstBox);
            Controls.Add(labelFirstInput);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IP1Patrick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculations Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstInput;
        private TextBox textFirstBox;
        private Label labelSecondInput;
        private TextBox textSecondBox;
        private Button buttonAdd;
        private Button buttonMultiply;
        private Button buttonReset;
        private Button buttonExit;
        private Label labelOutput;
        private TextBox textOutputBox;
        private ToolTip toolTips;
    }
}