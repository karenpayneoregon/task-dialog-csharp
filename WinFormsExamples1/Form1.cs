using DesktopHelperLibrary.Classes;
using System.Diagnostics;

namespace WinFormsExamples1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CenterOnThisButton_Click(object sender, EventArgs e)
    {
        Dialogs.Question(CenterOnThisButton, "Center on button", "Do you like C#", "Is great", "Nope", DialogResult.Cancel);
    }

    private void CenterOnFormButton_Click(object sender, EventArgs e)
    {
        Dialogs.Question(this, "Center on form", "Do you like C#", "Is great", "Nope", DialogResult.Cancel);
    }

    public void YesMethod()
    {
        Debug.WriteLine(nameof(YesMethod));
    }
    public void NoMethod()
    {
        Debug.WriteLine(nameof(NoMethod));
    }

    private void DialogWithActionsButton_Click(object sender, EventArgs e)
    {
        Dialogs.QuestionWithActions(this, "Heading", YesMethod, NoMethod);
    }
}
