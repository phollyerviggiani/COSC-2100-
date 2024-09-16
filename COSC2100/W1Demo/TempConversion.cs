using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100.W1Demo
{
    public partial class TempConversion : Form
    {
        public void InitializeComponent()
        {
            components = new Container();
            label1 = new Label();
            textBoxTemperatureInput = new TextBox();
            radioButtonToFahrenheit = new RadioButton();
            radioButtonToCelcius = new RadioButton();
            textBoxOutput = new TextBox();
            buttonConvert = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 81);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Please enter a temperature:";
            toolTip1.SetToolTip(label1, "Enter the temperature");
            // 
            // textBoxTemperatureInput
            // 
            textBoxTemperatureInput.Location = new Point(283, 78);
            textBoxTemperatureInput.Name = "textBoxTemperatureInput";
            textBoxTemperatureInput.Size = new Size(125, 27);
            textBoxTemperatureInput.TabIndex = 1;
            toolTip1.SetToolTip(textBoxTemperatureInput, "Enter the temperature");
            // 
            // radioButtonToFahrenheit
            // 
            radioButtonToFahrenheit.AutoSize = true;
            radioButtonToFahrenheit.Checked = true;
            radioButtonToFahrenheit.Location = new Point(87, 151);
            radioButtonToFahrenheit.Name = "radioButtonToFahrenheit";
            radioButtonToFahrenheit.Size = new Size(171, 24);
            radioButtonToFahrenheit.TabIndex = 2;
            radioButtonToFahrenheit.TabStop = true;
            radioButtonToFahrenheit.Text = "Convert to &Fahrenheit";
            toolTip1.SetToolTip(radioButtonToFahrenheit, "Convert to Fahrenheit");
            radioButtonToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonToCelcius
            // 
            radioButtonToCelcius.AutoSize = true;
            radioButtonToCelcius.Location = new Point(283, 151);
            radioButtonToCelcius.Name = "radioButtonToCelcius";
            radioButtonToCelcius.Size = new Size(149, 24);
            radioButtonToCelcius.TabIndex = 3;
            radioButtonToCelcius.Text = "Convert to Cel&cius";
            toolTip1.SetToolTip(radioButtonToCelcius, "Convert to Celcius");
            radioButtonToCelcius.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(87, 227);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(320, 27);
            textBoxOutput.TabIndex = 4;
            toolTip1.SetToolTip(textBoxOutput, "Converted Temperature");
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(87, 305);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(94, 29);
            buttonConvert.TabIndex = 5;
            buttonConvert.Text = "&Convert";
            toolTip1.SetToolTip(buttonConvert, "Click to convert temperatures");
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += OnConvert;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(198, 305);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "C&lear";
            toolTip1.SetToolTip(buttonClear, "Click to clear the temperature");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += OnClear;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(314, 305);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "E&xit";
            toolTip1.SetToolTip(buttonExit, "Click to exit the program");
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += OnExit;
            // 
            // TempConversion
            // 
            ClientSize = new Size(546, 429);
            Controls.Add(buttonExit);
            Controls.Add(buttonClear);
            Controls.Add(buttonConvert);
            Controls.Add(textBoxOutput);
            Controls.Add(radioButtonToCelcius);
            Controls.Add(radioButtonToFahrenheit);
            Controls.Add(textBoxTemperatureInput);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TempConversion";
            Text = "Temperature Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        // Method for coverting the temparature values
        private void OnConvert(object sender, EventArgs e)
        {
            // Variable declarations
            double validatedInput;
            double convertedTemperature;

            // Constant declarations
            const double additiveConversionConstant = 32.0;
            const double conversionNumerator = 5.0;
            const double conversionDenominator = 9.0;

            // Check if the contents of textBoxTemperatureInput are a valid number
            if (double.TryParse(textBoxTemperatureInput.Text, out validatedInput))
            {
                // If we're converting to fahrenheit
                if (radioButtonToFahrenheit.Checked)
                {
                    // Convert to fahrenheit and output the value
                    convertedTemperature = validatedInput * conversionDenominator / conversionNumerator + additiveConversionConstant;
                    textBoxOutput.Text = textBoxTemperatureInput.Text + "°C converts to " + convertedTemperature.ToString() + "°F";
                }
                // If we're converting to celsius
                else
                {
                    // Convert to celsius and output the value
                    convertedTemperature = (validatedInput - additiveConversionConstant) * conversionNumerator / conversionDenominator;
                    textBoxOutput.Text = textBoxTemperatureInput.Text + "°F converts to " + convertedTemperature.ToString() + "°C";
                }
            }
            // If the textbox's contents were not a valid number, show an error
            else
            {
                MessageBox.Show(Resources.errMessage, "Error");
                textBoxTemperatureInput.SelectAll();
                textBoxTemperatureInput.Focus();
            }

        }

        // Clear function that clears the current input window and refocuses on the input window
        private void OnClear(object sender, EventArgs e)
        {
            // Clears the window
            textBoxTemperatureInput.Clear();

            // Highlights the input window
            textBoxTemperatureInput.Focus();
        }

        // Function to exit the program 
        private void OnExit(object sender, EventArgs e)
        {
            // Closing the current window (temperature conversion form)
            this.Close();
        }
    }
}
