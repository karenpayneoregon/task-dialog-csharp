using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using WindowsFormsLibrary.Classes;
using WpfExamples.Classes;

namespace WpfExamples;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private IntPtr _intPtr;
        
    private bool _shown;

    private Icon _agentIcon;
    private Icon _sqlServerIcon;
    private Icon _DatabaseIcon;
    protected override void OnContentRendered(EventArgs e)
    {
        base.OnContentRendered(e);

        if (_shown)
        {
            return;
        }

        _shown = true;

        Window window = GetWindow(this);

        var windowInterop = new WindowInteropHelper(window ?? throw new InvalidOperationException());
        _intPtr = windowInterop.Handle;
         
        _agentIcon = ImageHelpers.BitmapImageToIcon("Resources\\agent1.ico");
        _sqlServerIcon = ImageHelpers.BitmapImageToIcon("Resources\\sql_server.ico");
        _DatabaseIcon = ImageHelpers.BitmapImageToIcon("Resources\\Database_16x.ico");

        var settings = SettingOperations.GetSetting;
        ShowAgainCheckBox.IsChecked = settings.ShowAgain;
        ShowAgainCheckBox.Checked += ShowAgainCheckBox_Checked;
        ShowAgainCheckBox.Unchecked += ShowAgainCheckBox_Checked;

    }

    public MainWindow()
    {
        InitializeComponent();
    }

    private void QuestionButtonComplex_Click(object sender, RoutedEventArgs e)
    {
        ComplexLabel.Content = Dialogs.Question(_intPtr, "Question", "Do you like coffee?", "Sure do", "Tea for me") ? 
            "Coffee it is" : 
            "Tea it is";
    }

    private void QuestionButton_Click(object sender, RoutedEventArgs e)
    {
            
        if (Dialogs.Question(_intPtr,  "Do you like coffee?", _agentIcon))
        {
            Dialogs.Information(_intPtr, "Continue","Woo-hoo");
        }
        else
        {
            Dialogs.Information(_intPtr, "Exit stage right", "Sad face");
        }
    }

    /// <summary>
    /// Numbers only for text box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }

    private void AutoCloseButton_Click(object sender, RoutedEventArgs e)
    {
        int seconds = Convert.ToInt32(SecondsTextBox.Text);
        Dialogs.AutoCloseDialog(_intPtr, _sqlServerIcon, seconds, $"Backing up in {seconds} seconds!!!");
    }
        
    private void DoNotShowAgainReset_OnClick(object sender, RoutedEventArgs e)
    {
        var checkBox = (CheckBox)sender;
    }

    /// <summary>
    /// Display a dialog with option to not display again where their choice
    /// is stored in appsettings.json
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DoNotShowAgainButton_Click(object sender, RoutedEventArgs e)
    {
        var settings = SettingOperations.GetSetting;

        if (!settings.ShowAgain) return;
        ShowAgainOptions options = new()
        {
            Heading = settings.Heading,
            Text = settings.Text,
            Caption = settings.Caption,
            Icon = _DatabaseIcon,
            VerificationText = settings.VerificationText,
            IntPtr = _intPtr
        };

        (NoShowResult DialogResult, bool ShowAgain) result = Dialogs.DoNotShowAgain(options);
        ShowAgainCheckBox.IsChecked = result.ShowAgain;

    }

    /// <summary>
    /// When the check box is checked/un-checked save back to appsettings.json
    /// </summary>
    private void ShowAgainCheckBox_Checked(object sender, RoutedEventArgs e)
    {
        var settings = SettingOperations.GetSetting;
        settings.ShowAgain = ShowAgainCheckBox.IsChecked.Value;
        SettingOperations.SaveChanges(settings);
           
    }
}