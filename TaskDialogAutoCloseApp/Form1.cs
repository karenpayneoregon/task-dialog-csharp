using System.Diagnostics;
using static TaskDialogAutoCloseApp.Classes.WinDialogs;

namespace TaskDialogAutoCloseApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ContinueOperation += WinDialogsOnContinueOperation;
    }

    private void WinDialogsOnContinueOperation(bool sender)
    {
        Debug.WriteLine(sender);
    }

    private void AutoCloseButton1_Click(object sender, EventArgs e)
    {
        AutoCloseDialog1(AutoCloseButton1, Properties.Resources.Timer_16x,"Header", 2);
    }

    private void AutoCloseButton2_Click(object sender, EventArgs e)
    {
        AutoCloseDialog2(this, "Header", 2, "More text to display");
    }
}
