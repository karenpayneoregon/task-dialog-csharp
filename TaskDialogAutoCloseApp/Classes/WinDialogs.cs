
using Timer = System.Windows.Forms.Timer;

namespace TaskDialogAutoCloseApp.Classes;

public class WinDialogs
{
    public static void AutoCloseDialog1(Control owner, Icon icon, string header, int seconds, string caption = "Notification")
    {

        var remaining = seconds * 10;

        TaskDialogButton continueButton = new("Ok");

        TaskDialogPage page = new()
        {
            Heading = header,
            Icon = new TaskDialogIcon(icon),
            Buttons = new TaskDialogButtonCollection() { continueButton },
            Caption = caption
        };

        using Timer timer = new()
        {
            Enabled = true,
            Interval = 100
        };

        timer.Tick += (_, _) =>
        {
            remaining -= 1;

            if (remaining != 0) return;
            timer.Enabled = false;
            if (continueButton.BoundPage is not null)
            {
                continueButton.PerformClick();
            }
        };

        TaskDialog.ShowDialog(owner, page);
    }

    public static void AutoCloseDialog2(Control owner, string header, int seconds, string additionalText = "")
    {

        var remaining = seconds * 10;

        TaskDialogButton continueButton = new("Continue");
        TaskDialogButton cancelButton = new("Stop");

        TaskDialogPage page = new()
        {
            Heading = header,
            Text = additionalText,
            Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton },
            Caption = "Auto-close" // this could be a param
        };

        using Timer timer = new()
        {
            Enabled = true,
            Interval = 100
        };

        timer.Tick += (_, _) =>
        {
            remaining -= 1;

            if (remaining != 0) return;
            timer.Enabled = false;
            if (continueButton.BoundPage is not null)
            {
                continueButton.PerformClick();
            }
        };

        TaskDialogButton result = TaskDialog.ShowDialog(owner, page);

        ContinueOperation?.Invoke(result == continueButton);
    }

    public delegate void OnContinue(bool sender);
    public static event OnContinue? ContinueOperation;

}