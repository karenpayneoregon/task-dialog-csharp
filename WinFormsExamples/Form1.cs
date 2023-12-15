using System.Diagnostics;
using System.Text.RegularExpressions;
using WindowsFormsLibrary.Classes;
using WindowsFormsLibrary.LanguageExtensions;
using WinFormsExamples.Classes;
#pragma warning disable CS0168
#pragma warning disable CS8622

namespace WinFormsExamples;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        Dialogs.ContinueOperation += OnContinueOperation;
        Dialogs.ComputerInformationEvent += OnComputerInformation;
        Dialogs.VisualStudioChecked += DialogsOnVisualStudioChecked;

        ShowAgainCheckBox.CheckedChanged += ShowAgainCheckBoxOnCheckedChanged;
        toolTip1.Draw += ToolTip1OnDraw;

        IconListBox.DataSource = ResourceImages.Instance.Icons;
        IconListBox.SelectedIndexChanged += IconListBoxOnSelectedIndexChanged;

        IconListBox.SelectedIndex = IconListBox.FindString("Csharp");

    }

    private void DialogsOnVisualStudioChecked(TaskDialogRadioButton radiobutton)
    {
        VersionLabel.Text = radiobutton.Version().ToString();
    }

    /// <summary>
    /// As coded DialogQuestion will center on this form, to center
    /// on the screen remove the first parameter for owner.
    /// </summary>
    private void AskQuestionButton_Click(object sender, EventArgs e)
    {
        // center on this form
        if (Dialogs.Question(this, "Do you like coffee?"))
        {
            MessageBox.Show("Yes");
        }
        else
        {
            MessageBox.Show("No");
        }
    }

    private void AutoCloseButton_Click(object sender, EventArgs e)
    {
        Dialogs.AutoCloseDialog(this, Properties.Resources.Timer_16x, 2);
    }

    private void AutoCloseProgressButton_Click(object sender, EventArgs e) =>
        Dialogs.AutoClosingTaskDialog(Properties.Resources.Timer_16x);

    private void ShowAgainCheckBoxOnCheckedChanged(object sender, EventArgs e)
    {
        var settings = SettingOperations.GetSetting;
        settings.ShowAgain = ShowAgainCheckBox.Checked;
        SettingOperations.SaveChanges(settings);

        ResultsListBox.Items.Add(ShowAgainCheckBox.Checked ? "Show again" : "Do not show again");
    }

    /// <summary>
    /// Use PowerShell to get computer information to a json file,
    /// ask user to open.
    ///
    /// result will be either 'Open' or 'Cancel'
    ///
    /// A callback is used to return the json data in a container.
    /// 
    /// </summary>
    private void OpenTextFileButton_Click(object sender, EventArgs e)
    {
        TaskDialogButton result = Dialogs.OpenFileAlert(this);
    }

    private void DoNotShowAgainButton_Click(object sender, EventArgs e)
    {
        var settings = SettingOperations.GetSetting;

        if (!settings.ShowAgain)
        {
            return;
        }

        Icon icon = (((ResourceItem)IconListBox.SelectedItem!)!).Icon;

        ShowAgainOptions options = new ShowAgainOptions
        {
            Heading = settings.Heading,
            Text = settings.Text,
            Caption = settings.Caption,
            Icon = icon,
            VerificationText = settings.VerificationText,
            Owner = this
        };

        (NoShowResult DialogResult, bool ShowAgain) result = Dialogs.DoNotShowAgain(options);

        ShowAgainCheckBox.Checked = result.ShowAgain;

        ResultsListBox.Items.Add(result.ToString());
    }

    public void YesMethod()
    {
        Debug.WriteLine(nameof(YesMethod));
    }
    public void NoMethod()
    {
        Debug.WriteLine(nameof(NoMethod));
    }

    private void ShowCurrentIcon()
    {
        if (IconListBox.SelectedIndex <= -1) return;
        var item = (ResourceItem)IconListBox.SelectedItem!;
        pictureBox1.SizeMode = item.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox1.Image = item.Image;
        Icon = item.Icon;
    }

    private void IconListBoxOnSelectedIndexChanged(object sender, EventArgs e)
    {
        ShowCurrentIcon();
    }

    private void LinkExampleButton_Click(object sender, EventArgs e)
    {
        Dialogs.OpenLink(this);
    }

    private void EventsButton_Click(object sender, EventArgs e)
    {
        Dialogs.ShowEventsTaskDialog();
    }

    private void ToolTip1OnDraw(object sender, DrawToolTipEventArgs e)
    {
        e.DrawBackground();
        e.DrawBorder();
        e.DrawText();
    }

    private void OnContinueOperation(bool sender)
    {
        Dialogs.Information(this, $"Continue: {sender.ToYesNoString()} ");
    }

    /// <summary>
    /// For <see cref="OpenTextFileButton_Click"/>
    /// </summary>
    /// <param name="information"><seealso cref="MachineComputerInformation"/></param>
    private void OnComputerInformation(MachineComputerInformation information)
    {
        var free = $"Free memory on this computer is {(information.OsFreePhysicalMemory / 1048576)} mb";
        Dialogs.Information(this, free);
    }

    /// <summary>
    /// Example for TaskDialog with radio buttons
    /// </summary>
    private void RadioGroupButton_Click(object sender, EventArgs e)
    {
        var (response, version) = Dialogs.VisualStudioVersionDialog();
        if (response)
        {
            var selected = Regex.Replace(version.ToString(), "[^0-9]", "");
            selected = string.IsNullOrWhiteSpace(selected) ? "No version" : $"Visual Studio {version}";
            VersionLabel.Text = selected;
        }
        else
        {
            VersionLabel.Text = @"Canceled";
        }
    }

    private void ConventionalQuestionButton_Click(object sender, EventArgs e)
    {
        var dir = new DirectoryInfo("C:\\Alstom\\NMS-IPv2\\NCM\\DevicesConfiguration");
        if (WindowsDialogs.Question("Remove files?"))
        {

            try
            {
                foreach (var file in dir.EnumerateFiles("test*.*\""))
                {
                    file.Delete();
                }
            }
            catch (Exception exception)
            {
                // log exception
            }
        }
    }

    private void ErrorExampleButton_Click(object sender, EventArgs e)
    {
        Dialogs.OpenHelp(this);
    }
}