namespace COSC2100.Assignment3A
{
    partial class CarServiceFrm
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
            groupBox1 = new GroupBox();
            textPhone = new TextBox();
            label2 = new Label();
            textLastName = new TextBox();
            label3 = new Label();
            textFirstName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            numericYear = new NumericUpDown();
            comboMake = new ComboBox();
            textColor = new TextBox();
            label7 = new Label();
            label4 = new Label();
            textModel = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnNew = new Button();
            lvCarServices = new ListView();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnRemoveAll = new Button();
            btnExit = new Button();
            label8 = new Label();
            chkEngineOil = new CheckBox();
            chkTransOil = new CheckBox();
            chkAirFilter = new CheckBox();
            label9 = new Label();
            textCost = new TextBox();
            lblResult = new Label();
            toolTipCarService = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericYear).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(98, 76);
            textPhone.Margin = new Padding(3, 2, 3, 2);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(107, 23);
            textPhone.TabIndex = 3;
            toolTipCarService.SetToolTip(textPhone, "Please enter your phone number");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 79);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Phone:";
            toolTipCarService.SetToolTip(label2, "Person's phone number");
            // 
            // textLastName
            // 
            textLastName.Location = new Point(98, 52);
            textLastName.Margin = new Padding(3, 2, 3, 2);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(107, 23);
            textLastName.TabIndex = 2;
            toolTipCarService.SetToolTip(textLastName, "Please enter your last name");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 54);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            toolTipCarService.SetToolTip(label3, "Person's last name");
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(98, 27);
            textFirstName.Margin = new Padding(3, 2, 3, 2);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(107, 23);
            textFirstName.TabIndex = 1;
            toolTipCarService.SetToolTip(textFirstName, "Please enter your first name");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            toolTipCarService.SetToolTip(label1, "Person's first name");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericYear);
            groupBox2.Controls.Add(comboMake);
            groupBox2.Controls.Add(textColor);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textModel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(24, 136);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(219, 134);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Car Information";
            // 
            // numericYear
            // 
            numericYear.Location = new Point(98, 77);
            numericYear.Margin = new Padding(3, 2, 3, 2);
            numericYear.Name = "numericYear";
            numericYear.Size = new Size(107, 23);
            numericYear.TabIndex = 6;
            toolTipCarService.SetToolTip(numericYear, "Please select the year of the car");
            // 
            // comboMake
            // 
            comboMake.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMake.FormattingEnabled = true;
            comboMake.Location = new Point(98, 27);
            comboMake.Margin = new Padding(3, 2, 3, 2);
            comboMake.Name = "comboMake";
            comboMake.Size = new Size(107, 23);
            comboMake.TabIndex = 4;
            toolTipCarService.SetToolTip(comboMake, "Please select the make of car");
            // 
            // textColor
            // 
            textColor.Location = new Point(98, 101);
            textColor.Margin = new Padding(3, 2, 3, 2);
            textColor.Name = "textColor";
            textColor.Size = new Size(107, 23);
            textColor.TabIndex = 7;
            toolTipCarService.SetToolTip(textColor, "Please enter the colour of your car");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 104);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 0;
            label7.Text = "Colour:";
            toolTipCarService.SetToolTip(label7, "Person's car colour");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 79);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 0;
            label4.Text = "Year:";
            toolTipCarService.SetToolTip(label4, "Year of person's car");
            // 
            // textModel
            // 
            textModel.Location = new Point(98, 52);
            textModel.Margin = new Padding(3, 2, 3, 2);
            textModel.Name = "textModel";
            textModel.Size = new Size(107, 23);
            textModel.TabIndex = 5;
            toolTipCarService.SetToolTip(textModel, "Please enter your car model");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 54);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 0;
            label5.Text = "Model:";
            toolTipCarService.SetToolTip(label5, "Person's car model");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 29);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 0;
            label6.Text = "Make:";
            toolTipCarService.SetToolTip(label6, "Person's car make");
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(49, 382);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 22);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "&Add";
            toolTipCarService.SetToolTip(btnAdd, "Select or press 'enter' to add the information");
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(146, 382);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 7;
            btnNew.Text = "&New";
            toolTipCarService.SetToolTip(btnNew, "Select to add new information");
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += OnNew;
            // 
            // lvCarServices
            // 
            lvCarServices.FullRowSelect = true;
            lvCarServices.GridLines = true;
            lvCarServices.Location = new Point(304, 28);
            lvCarServices.Margin = new Padding(3, 2, 3, 2);
            lvCarServices.MultiSelect = false;
            lvCarServices.Name = "lvCarServices";
            lvCarServices.Size = new Size(403, 253);
            lvCarServices.Sorting = SortOrder.Ascending;
            lvCarServices.TabIndex = 12;
            lvCarServices.UseCompatibleStateImageBehavior = false;
            lvCarServices.View = View.Details;
            lvCarServices.SelectedIndexChanged += OnSelectItem;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(244, 382);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "&Update";
            toolTipCarService.SetToolTip(btnUpdate, "Select information to be updated");
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += OnUpdate;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(346, 382);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(82, 22);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "&Remove";
            toolTipCarService.SetToolTip(btnRemove, "Select to remove information ");
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += OnRemove;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(448, 382);
            btnRemoveAll.Margin = new Padding(3, 2, 3, 2);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(82, 22);
            btnRemoveAll.TabIndex = 10;
            btnRemoveAll.Text = "Remove &All";
            toolTipCarService.SetToolTip(btnRemoveAll, "Select to remove all information");
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += OnRemoveAll;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(548, 382);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 11;
            btnExit.Text = "E&xit";
            toolTipCarService.SetToolTip(btnExit, "Select or press 'esc' to close the window");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += OnExit;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 279);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 2;
            label8.Text = "Services";
            toolTipCarService.SetToolTip(label8, "Services available");
            // 
            // chkEngineOil
            // 
            chkEngineOil.AutoSize = true;
            chkEngineOil.Location = new Point(122, 280);
            chkEngineOil.Margin = new Padding(3, 2, 3, 2);
            chkEngineOil.Name = "chkEngineOil";
            chkEngineOil.Size = new Size(124, 19);
            chkEngineOil.TabIndex = 2;
            chkEngineOil.Text = "Engine Oil Change";
            toolTipCarService.SetToolTip(chkEngineOil, "Check if engine oil change");
            chkEngineOil.UseVisualStyleBackColor = true;
            chkEngineOil.CheckedChanged += OnServiceChange;
            // 
            // chkTransOil
            // 
            chkTransOil.AutoSize = true;
            chkTransOil.Location = new Point(122, 302);
            chkTransOil.Margin = new Padding(3, 2, 3, 2);
            chkTransOil.Name = "chkTransOil";
            chkTransOil.Size = new Size(156, 19);
            chkTransOil.TabIndex = 3;
            chkTransOil.Text = "Transmission Oil Change";
            toolTipCarService.SetToolTip(chkTransOil, "Check if transmission oil change");
            chkTransOil.UseVisualStyleBackColor = true;
            chkTransOil.CheckedChanged += OnServiceChange;
            // 
            // chkAirFilter
            // 
            chkAirFilter.AutoSize = true;
            chkAirFilter.Location = new Point(122, 323);
            chkAirFilter.Margin = new Padding(3, 2, 3, 2);
            chkAirFilter.Name = "chkAirFilter";
            chkAirFilter.Size = new Size(114, 19);
            chkAirFilter.TabIndex = 4;
            chkAirFilter.Text = "Air Filter Change";
            toolTipCarService.SetToolTip(chkAirFilter, "Check if air filter change");
            chkAirFilter.UseVisualStyleBackColor = true;
            chkAirFilter.CheckedChanged += OnServiceChange;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 352);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 3;
            label9.Text = "Cost";
            toolTipCarService.SetToolTip(label9, "Total cost for visit");
            // 
            // textCost
            // 
            textCost.Location = new Point(122, 349);
            textCost.Margin = new Padding(3, 2, 3, 2);
            textCost.Name = "textCost";
            textCost.ReadOnly = true;
            textCost.Size = new Size(107, 23);
            textCost.TabIndex = 5;
            toolTipCarService.SetToolTip(textCost, "Total cost for the visit");
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(304, 292);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 13;
            // 
            // CarServiceFrm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(737, 428);
            Controls.Add(lblResult);
            Controls.Add(textCost);
            Controls.Add(label9);
            Controls.Add(chkAirFilter);
            Controls.Add(chkTransOil);
            Controls.Add(chkEngineOil);
            Controls.Add(label8);
            Controls.Add(btnExit);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lvCarServices);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarServiceFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Service";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textPhone;
        private Label label2;
        private TextBox textLastName;
        private Label label3;
        private TextBox textFirstName;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textColor;
        private Label label7;
        private Label label4;
        private TextBox textModel;
        private Label label5;
        private Label label6;
        private ListView lvCarServices;
        private Button btnAdd;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnRemoveAll;
        private Button btnExit;
        private Label label8;
        private CheckBox chkEngineOil;
        private CheckBox chkTransOil;
        private CheckBox chkAirFilter;
        private Label label9;
        private TextBox textCost;
        private ComboBox comboMake;
        private NumericUpDown numericYear;
        private Label lblResult;
        private ToolTip toolTipCarService;
    }
}