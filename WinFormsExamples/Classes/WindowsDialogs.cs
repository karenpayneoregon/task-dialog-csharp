namespace WinFormsExamples.Classes;

public static class WindowsDialogs
{
    public static bool Question(string text) =>
        (MessageBox.Show(
            text,
            Application.ProductName,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes);
}