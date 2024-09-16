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
            SuspendLayout();
            // 
            // comboWeekDay
            // 
            comboWeekDay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboWeekDay.FormattingEnabled = true;
            comboWeekDay.Location = new Point(305, 86);
            comboWeekDay.Name = "comboWeekDay";
            comboWeekDay.Size = new Size(151, 28);
            comboWeekDay.TabIndex = 0;
            // 
            // FormControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboWeekDay);
            Name = "FormControl";
            Text = "FormControl";
            Load += OnLoad;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboWeekDay;
    }
}