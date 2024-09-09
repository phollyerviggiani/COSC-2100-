using System.Diagnostics;


string message = "Your Visual Studio environmement looks good. Close this message box?";
string caption = "Welcome to COSC 2100";
MessageBoxButtons buttons = MessageBoxButtons.YesNo;
DialogResult result;

// Displays the MessageBox.
result = MessageBox.Show(message, caption, buttons);
while (result != System.Windows.Forms.DialogResult.Yes)
{
    Debug.WriteLine("You choose No");
    result = MessageBox.Show(message, caption, buttons);
}

Debug.WriteLine("You choose Yes");
