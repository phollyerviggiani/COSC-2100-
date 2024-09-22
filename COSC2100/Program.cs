// Program file which lets us run the desired program
using System.Diagnostics;

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);


// Application.Run(new COSC2100.W3Demo.FormControl());

// Chooses which file to run based on the text of currentShow string value


string currentShow = "IP1Patrick";
switch (currentShow)
{
    case "TempConversion":
        Application.Run(new COSC2100.W1Demo.TempConversion());
        break;
    case "FormControl":
        Application.Run(new COSC2100.W3Demo.FormControl());
        break;
    case "IP1Patrick":
        Application.Run(new COSC2100.IP1.IP1Patrick());
        break;
    default:
        Debug.WriteLine($"{currentShow} is not designed");
        break;
}

