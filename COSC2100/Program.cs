// Program file which lets us run the desired program
using System.Diagnostics;

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);


// Application.Run(new COSC2100.W3Demo.FormControl());

// Chooses which file to run based on the text of currentShow string value
string currentShow = "FormControl";
switch (currentShow)
{
    case "TempConversion":
        Application.Run(new COSC2100.W1Demo.TempConversion());
        break;
    case "FormControl":
        Application.Run(new COSC2100.W3Demo.FormControl());
        break;
    default:
        Debug.WriteLine($"{currentShow} is not designed");
        break;
}
