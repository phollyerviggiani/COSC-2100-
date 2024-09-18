namespace COSC2100.W3Demo
{
    partial class FormControl
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
            comboWeekDay = new ComboBox();
            listBoxItem = new ListBox();
            textValue = new TextBox();
            labelValue = new Label();
            ButtonInput = new Button();
            textResult = new TextBox();
            SuspendLayout();
            // 
            // comboWeekDay
            // 
            comboWeekDay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboWeekDay.FormattingEnabled = true;
            comboWeekDay.Location = new Point(375, 82);
            comboWeekDay.Name = "comboWeekDay";
            comboWeekDay.Size = new Size(202, 28);
            comboWeekDay.TabIndex = 0;
            // 
            // listBoxItem
            // 
            listBoxItem.FormattingEnabled = true;
            listBoxItem.ItemHeight = 20;
            listBoxItem.Location = new Point(172, 82);
            listBoxItem.Name = "listBoxItem";
            listBoxItem.Size = new Size(179, 164);
            listBoxItem.TabIndex = 1;
            // 
            // textValue
            // 
            textValue.Location = new Point(426, 131);
            textValue.Name = "textValue";
            textValue.Size = new Size(151, 27);
            textValue.TabIndex = 2;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(375, 134);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(45, 20);
            labelValue.TabIndex = 3;
            labelValue.Text = "Value";
            // 
            // ButtonInput
            // 
            ButtonInput.Location = new Point(426, 182);
            ButtonInput.Name = "ButtonInput";
            ButtonInput.Size = new Size(94, 29);
            ButtonInput.TabIndex = 4;
            ButtonInput.Text = "Input";
            ButtonInput.UseVisualStyleBackColor = true;
            ButtonInput.Click += OnInput;
            // 
            // textResult
            // 
            textResult.Location = new Point(172, 290);
            textResult.Name = "textResult";
            textResult.ReadOnly = true;
            textResult.Size = new Size(405, 27);
            textResult.TabIndex = 5;
            // 
            // FormControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textResult);
            Controls.Add(ButtonInput);
            Controls.Add(labelValue);
            Controls.Add(textValue);
            Controls.Add(listBoxItem);
            Controls.Add(comboWeekDay);
            Name = "FormControl";
            Text = "FormControl";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboWeekDay;
        private ListBox listBoxItem;
        private TextBox textValue;
        private Label labelValue;
        private Button ButtonInput;
        private TextBox textResult;
    }
}