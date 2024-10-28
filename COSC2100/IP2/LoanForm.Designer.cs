namespace COSC2100.IP2
{
    partial class LoanForm
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
            textBoxLoanNumber = new TextBox();
            textBoxCustomerName = new TextBox();
            textBoxLoanAmount = new TextBox();
            textBoxCustomerAddress = new TextBox();
            textBoxLoanDuration = new TextBox();
            textBoxInterestRate = new TextBox();
            labelLoanNumber = new Label();
            labelCustomerName = new Label();
            labelLoanAmount = new Label();
            labelCustomerAddress = new Label();
            labelLoanDuration = new Label();
            labelInterestRate = new Label();
            textBoxLoanReport = new TextBox();
            label7 = new Label();
            buttonCalculate = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            toolTipLoanForm = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxLoanNumber
            // 
            textBoxLoanNumber.Location = new Point(164, 36);
            textBoxLoanNumber.Name = "textBoxLoanNumber";
            textBoxLoanNumber.Size = new Size(136, 27);
            textBoxLoanNumber.TabIndex = 0;
            toolTipLoanForm.SetToolTip(textBoxLoanNumber, "Enter the Loan Number");
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(164, 79);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(136, 27);
            textBoxCustomerName.TabIndex = 1;
            toolTipLoanForm.SetToolTip(textBoxCustomerName, "Enter Customer Name");
            // 
            // textBoxLoanAmount
            // 
            textBoxLoanAmount.Location = new Point(164, 251);
            textBoxLoanAmount.Name = "textBoxLoanAmount";
            textBoxLoanAmount.Size = new Size(136, 27);
            textBoxLoanAmount.TabIndex = 5;
            toolTipLoanForm.SetToolTip(textBoxLoanAmount, "Enter Loan Amount");
            // 
            // textBoxCustomerAddress
            // 
            textBoxCustomerAddress.Location = new Point(164, 120);
            textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            textBoxCustomerAddress.Size = new Size(136, 27);
            textBoxCustomerAddress.TabIndex = 2;
            toolTipLoanForm.SetToolTip(textBoxCustomerAddress, "Enter Customer Address");
            // 
            // textBoxLoanDuration
            // 
            textBoxLoanDuration.Location = new Point(164, 208);
            textBoxLoanDuration.Name = "textBoxLoanDuration";
            textBoxLoanDuration.Size = new Size(136, 27);
            textBoxLoanDuration.TabIndex = 4;
            toolTipLoanForm.SetToolTip(textBoxLoanDuration, "Enter duration of the loan");
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(164, 162);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(136, 27);
            textBoxInterestRate.TabIndex = 3;
            toolTipLoanForm.SetToolTip(textBoxInterestRate, "Enter Interest Rate");
            // 
            // labelLoanNumber
            // 
            labelLoanNumber.AutoSize = true;
            labelLoanNumber.Location = new Point(29, 39);
            labelLoanNumber.Name = "labelLoanNumber";
            labelLoanNumber.Size = new Size(99, 20);
            labelLoanNumber.TabIndex = 6;
            labelLoanNumber.Text = "Loan Number";
            toolTipLoanForm.SetToolTip(labelLoanNumber, "The number of the loan");
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(29, 79);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(116, 20);
            labelCustomerName.TabIndex = 7;
            labelCustomerName.Text = "Customer Name";
            toolTipLoanForm.SetToolTip(labelCustomerName, "Name for the customer");
            // 
            // labelLoanAmount
            // 
            labelLoanAmount.AutoSize = true;
            labelLoanAmount.Location = new Point(30, 254);
            labelLoanAmount.Name = "labelLoanAmount";
            labelLoanAmount.Size = new Size(98, 20);
            labelLoanAmount.TabIndex = 11;
            labelLoanAmount.Text = "Loan Amount";
            toolTipLoanForm.SetToolTip(labelLoanAmount, "Loan amount in dollars ($)");
            // 
            // labelCustomerAddress
            // 
            labelCustomerAddress.AutoSize = true;
            labelCustomerAddress.Location = new Point(29, 123);
            labelCustomerAddress.Name = "labelCustomerAddress";
            labelCustomerAddress.Size = new Size(129, 20);
            labelCustomerAddress.TabIndex = 8;
            labelCustomerAddress.Text = "Customer Address";
            toolTipLoanForm.SetToolTip(labelCustomerAddress, "Address for the customer");
            // 
            // labelLoanDuration
            // 
            labelLoanDuration.AutoSize = true;
            labelLoanDuration.Location = new Point(29, 211);
            labelLoanDuration.Name = "labelLoanDuration";
            labelLoanDuration.Size = new Size(103, 20);
            labelLoanDuration.TabIndex = 10;
            labelLoanDuration.Text = "Loan Duration";
            toolTipLoanForm.SetToolTip(labelLoanDuration, "Loan duration in years");
            // 
            // labelInterestRate
            // 
            labelInterestRate.AutoSize = true;
            labelInterestRate.Location = new Point(29, 165);
            labelInterestRate.Name = "labelInterestRate";
            labelInterestRate.Size = new Size(92, 20);
            labelInterestRate.TabIndex = 9;
            labelInterestRate.Text = "Interest Rate";
            toolTipLoanForm.SetToolTip(labelInterestRate, "Interest rate in percentage (%)");
            // 
            // textBoxLoanReport
            // 
            textBoxLoanReport.Location = new Point(349, 63);
            textBoxLoanReport.Multiline = true;
            textBoxLoanReport.Name = "textBoxLoanReport";
            textBoxLoanReport.ReadOnly = true;
            textBoxLoanReport.Size = new Size(326, 150);
            textBoxLoanReport.TabIndex = 12;
            toolTipLoanForm.SetToolTip(textBoxLoanReport, "Displays the generated loan report");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 36);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 13;
            label7.Text = "Loan Report";
            toolTipLoanForm.SetToolTip(label7, "Loan report displays all relevent loan information");
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(349, 228);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 14;
            buttonCalculate.Text = "Calculate";
            toolTipLoanForm.SetToolTip(buttonCalculate, "Press or click 'enter' to generate loan report");
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += OnCalculate;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(464, 228);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 15;
            buttonReset.Text = "Reset";
            toolTipLoanForm.SetToolTip(buttonReset, "Click or press 'esc' to reset the values");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += OnReset;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(581, 228);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 16;
            buttonExit.Text = "Exit";
            toolTipLoanForm.SetToolTip(buttonExit, "Press to exit the loan form");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += OnExit;
            buttonExit.KeyDown += buttonExit_KeyDown;
            // 
            // LoanForm
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonReset;
            ClientSize = new Size(705, 296);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalculate);
            Controls.Add(label7);
            Controls.Add(textBoxLoanReport);
            Controls.Add(labelInterestRate);
            Controls.Add(labelLoanDuration);
            Controls.Add(labelCustomerAddress);
            Controls.Add(labelLoanAmount);
            Controls.Add(labelCustomerName);
            Controls.Add(labelLoanNumber);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxLoanDuration);
            Controls.Add(textBoxCustomerAddress);
            Controls.Add(textBoxLoanAmount);
            Controls.Add(textBoxCustomerName);
            Controls.Add(textBoxLoanNumber);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLoanNumber;
        private TextBox textBoxCustomerName;
        private TextBox textBoxLoanAmount;
        private TextBox textBoxCustomerAddress;
        private TextBox textBoxLoanDuration;
        private TextBox textBoxInterestRate;
        private Label labelLoanNumber;
        private Label labelCustomerName;
        private Label labelLoanAmount;
        private Label labelCustomerAddress;
        private Label labelLoanDuration;
        private Label labelInterestRate;
        private TextBox textBoxLoanReport;
        private Label label7;
        private Button buttonCalculate;
        private Button buttonReset;
        private Button buttonExit;
        private ToolTip toolTipLoanForm;
    }
}