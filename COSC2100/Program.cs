// Program file which lets us run the desired program
using System.Diagnostics;

Application.SetHighDpiMode(HighDpiMode.SystemAware);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);


// Application.Run(new COSC2100.W3Demo.FormControl());

// Chooses which file to run based on the text of currentShow string value


string currentShow = "Assignment3";
switch (currentShow)
{
    case "TempConversion":
        Application.Run(new COSC2100.W1Demo.TempConversion());
        break;
    case "FormControl":
        Application.Run(new COSC2100.W3Demo.FormControl());
        break;
    case "IP1":
        Application.Run(new COSC2100.IP1.IP1Patrick());
        break;
    case "IP2":
        Application.Run(new COSC2100.IP2.LoanForm());
        break;
    case "Assignment1":
        Application.Run(new COSC2100.Assignment1.Assignment1Patrick());
        break;
    case "Assignment2":
        Application.Run(new COSC2100.Assignment2.TicTacToeFrm());
        break;
    case "Assignment3":
        Application.Run(new COSC2100.Assignment3A.CarServiceFrm());
        break;
    default:
        Debug.WriteLine($"{currentShow} is not designed");
        break;
}

