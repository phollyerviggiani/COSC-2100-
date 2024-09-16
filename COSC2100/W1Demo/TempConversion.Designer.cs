using System;
namespace COSC2100.W1Demo
{
    partial class TempConversion
    {

       /* static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new COSC2100.W1Demo.TempConversion());
        }
       */

      public TempConversion()
        {
          InitializeComponent();
          this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private Label label1;
        private TextBox textBoxTemperatureInput;
        private RadioButton radioButtonToFahrenheit;
        private RadioButton radioButtonToCelcius;
        private TextBox textBoxOutput;
        private Button buttonConvert;
        private Button buttonClear;
        private Button buttonExit;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
    }
}