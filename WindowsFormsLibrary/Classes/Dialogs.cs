using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibrary.LanguageExtensions;
using static System.DateTime;


namespace WindowsFormsLibrary.Classes
{
    /// <summary>
    /// Example for using <see cref="TaskDialog"/>
    /// </summary>
    /// <remarks>
    /// - Methods with a parameter for owner will default to centering on owner
    ///   while without owner parameter will center on the display screen.
    /// - IMPORTANT Some methods have Debug.WriteLine and should be removed for use
    ///   in your projects/applications.
    /// </remarks>
    public class Dialogs
    {

        /// <summary>
        /// Simple message box wrapper to ask a question where the default button is No.
        /// </summary>
        /// <param name="text">Question text</param>
        /// <returns>true or false</returns>
        public static bool Question(string text) =>
            (MessageBox.Show(text, "Question", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);

        /// <summary>
        /// Dialog to ask a question
        /// </summary>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(string caption, string heading, string yesText, string noText, DialogResult defaultButton)
        {

            TaskDialogButton yesButton = new (yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new (noText) { Tag = DialogResult.No };
            
            TaskDialogButtonCollection buttons = new ();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new ()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Information,
                Buttons = buttons
            };


            TaskDialogButton result = TaskDialog.ShowDialog(page);
            
            return (DialogResult)result.Tag == DialogResult.Yes;

        }

        /// <summary>
        /// Dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Form owner, string caption, string heading, string yesText, string noText, DialogResult defaultButton)
        {

            TaskDialogButton yesButton = new (yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new (noText) { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }


            TaskDialogPage page = new ()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Information,
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(owner, page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
        /// <summary>
        /// WPF Dialog to ask a question
        /// </summary>
        /// <param name="owner">window</param>
        /// <param name="caption">text for dialog caption</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesText">text for yes button</param>
        /// <param name="noText">text for no button</param>
        /// <param name="defaultButton">specifies the default button for this dialog</param>
        /// <returns>true for yes button, false for no button</returns>
        /// <remarks>
        /// Using a standard Icon will cause the dialog to beep so this version uses a Icon
        /// from resources which in turn will not beep.
        /// </remarks>
        public static bool Question(IntPtr owner, string caption, string heading, string yesText, string noText, DialogResult defaultButton = DialogResult.No)
        {

            TaskDialogButton yesButton = new(yesText) { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new(noText) { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add("yesButton");
                buttons.Add("noButton");
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }
            
            TaskDialogPage page = new()
            {
                Caption = caption,
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.question32),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(owner, page, TaskDialogStartupLocation.CenterOwner);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }

        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="icon">Icon to display</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Control owner, string heading, Icon icon, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(icon),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(owner, page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(Control owner, string heading, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };
            
            TaskDialogButtonCollection buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
                Buttons = buttons, 
                AllowCancel = true
            };

            var result = TaskDialog.ShowDialog(owner, page);
            return result.Tag is not null && (DialogResult)result.Tag == DialogResult.Yes;
        }

        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="yesAction"></param>
        /// <returns>true for yes button, false for no button</returns>
        /// <remarks>
        /// Dialogs.Question(this, "Ask something", YesMethod, NoMethod);
        ///
        /// Last two parameters are the actions to perform
        /// </remarks>
        public static void Question(Control owner, string heading, Action yesAction, Action noAction)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection
            {
                yesButton,
                noButton
            };
            

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
                Buttons = buttons
            };
            
            var result = TaskDialog.ShowDialog(owner, page);

            if ((DialogResult)result.Tag == DialogResult.Yes)
            {
                yesAction?.Invoke();
            }
            else
            {
                noAction?.Invoke();
            }
            
        }
        /// <summary>
        /// Windows Forms dialog to ask a question
        /// </summary>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="icon">Icon to display</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(string heading, Icon icon, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(icon),
                Buttons = buttons
            };

            var result = TaskDialog.ShowDialog(page);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
        /// <summary>
        /// WPF dialog to ask a question
        /// </summary>
        /// <param name="owner">window</param>
        /// <param name="heading">text for dialog heading</param>
        /// <param name="icon">Icon to display</param>
        /// <param name="defaultButton">Button to focus</param>
        /// <returns>true for yes button, false for no button</returns>
        public static bool Question(IntPtr owner, string heading, Icon icon, DialogResult defaultButton = DialogResult.Yes)
        {

            TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
            TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

            var buttons = new TaskDialogButtonCollection();

            if (defaultButton == DialogResult.Yes)
            {
                buttons.Add(yesButton);
                buttons.Add(noButton);
            }
            else
            {
                buttons.Add(noButton);
                buttons.Add(yesButton);
            }

            TaskDialogPage page = new()
            {
                Caption = "Question",
                SizeToContent = true,
                Heading = heading,
                Icon = new TaskDialogIcon(icon),
                Buttons = buttons
            };
            
            var result = TaskDialog.ShowDialog(owner, page, TaskDialogStartupLocation.CenterOwner);

            return (DialogResult)result.Tag == DialogResult.Yes;

        }
        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="heading">head for dialog</param>
        /// <param name="buttonText">button text</param>
        public static void Information(string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new (buttonText);

            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Warning,
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };


            TaskDialog.ShowDialog(page, TaskDialogStartupLocation.CenterScreen);

        }

        /// <summary>
        /// displays a message with option to assign button text
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="heading"></param>
        /// <param name="buttonText"></param>
        public static void Information(Control owner, string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new (buttonText);

            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Icon = TaskDialogIcon.Warning,
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };
            
            TaskDialog.ShowDialog(owner, page);

        }
        /// <summary>
        /// WPF Information dialog
        /// </summary>
        /// <param name="owner">IntPtr</param>
        /// <param name="heading">Text to display</param>
        /// <param name="buttonText">Optional button text</param>
        public static void Information(IntPtr owner, string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new(buttonText);

            TaskDialogPage page = new()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                //Icon = TaskDialogIcon.Information, -- will invoke a beep
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };
            
            TaskDialog.ShowDialog(owner, page);

        }
        public static void InformationModeless( string heading, string buttonText = "Ok")
        {

            TaskDialogButton okayButton = new(buttonText);

            TaskDialogPage page = new()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = heading,
                Buttons = new TaskDialogButtonCollection() { okayButton }
            };

            TaskDialog.ShowDialog(IntPtr.Zero, page);

        }
        /// <summary>
        /// Mocked example for showing a auto-close dialog which by not passing parent like the
        /// overloaded version below centers the dialog on the monitor
        /// </summary>
        /// <param name="Icon">Icon to display in dialog</param>
        public static void AutoClosingTaskDialog(Icon Icon)
        {

            const string textFormat = "Closing in {0} seconds...";
            var remainingTenthSeconds = 30;

            TaskDialogButton continueButton = new ("Just do it");
            TaskDialogButton cancelButton = TaskDialogButton.Cancel;
            
            TaskDialogPage page = new ()
            {
                Heading = "Continuing with next process...",
                Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10),
                Icon = new TaskDialogIcon(Icon),
                ProgressBar = new TaskDialogProgressBar() { State = TaskDialogProgressBarState.Paused },
                Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton }, 
                Caption = "Auto-close"
            };

            using Timer timer = new ()
            {
                Enabled = true,
                Interval = 100
            };

            timer.Tick += (_, _) =>
            {
                remainingTenthSeconds -= 1;

                if (remainingTenthSeconds > 0)
                {
                    page.Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10);
                    page.ProgressBar.Value = 100 - remainingTenthSeconds * 2;
                }
                else
                {
                    timer.Enabled = false;

                    if (continueButton.BoundPage is not null)
                    {
                        continueButton.PerformClick();
                    }
                    
                }
            };

            TaskDialogButton result = TaskDialog.ShowDialog(page);

            ContinueOperation?.Invoke(result == continueButton);

        }

        /// <summary>
        /// Mocked example for showing a auto-close dialog which by passing the parent control
        /// will be default display this dialog centered on the parent control.
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="Icon">Icon to display in dialog</param>
        public static void AutoClosingTaskDialog(Control owner, Icon Icon)
        {

            const string textFormat = "Closing in {0} seconds...";
            var remainingTenthSeconds = 50;

            TaskDialogButton continueButton = new ("Just do it");
            TaskDialogButton cancelButton = TaskDialogButton.Cancel;

            // Display the form's icon in the task dialog.
            // Note however that the task dialog will not scale the icon.
            TaskDialogPage page = new ()
            {
                Heading = "Continuing with next process...",
                Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10),
                Icon = new TaskDialogIcon(Icon),
                ProgressBar = new TaskDialogProgressBar() { State = TaskDialogProgressBarState.Paused },
                Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton },
                Caption = "Auto-close"
            };

            using Timer timer = new()
            {
                Enabled = true,
                Interval = 100
            };

            timer.Tick += (_, _) =>
            {
                remainingTenthSeconds -= 1;

                if (remainingTenthSeconds > 0)
                {
                    page.Text = string.Format(textFormat, (remainingTenthSeconds + 9) / 10);
                    page.ProgressBar.Value = 100 - remainingTenthSeconds * 2;
                }
                else
                {
                    timer.Enabled = false;

                    if (continueButton.BoundPage is not null)
                    {
                        continueButton.PerformClick();
                    }
                }
            };

            TaskDialogButton result = TaskDialog.ShowDialog(owner,page);

            ContinueOperation?.Invoke(result == continueButton);
        }

        /// <summary>
        /// Auto close dialog by specified seconds, if timed out
        /// invoke continue button.
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="Icon">icon to present</param>
        /// <param name="seconds">seconds to timeout</param>
        /// <param name="okText">text for continue button</param>
        /// <param name="cancelText">text for cancel button</param>
        public static void AutoCloseDialog(Control owner, Icon Icon, int seconds, string okText = "OK", string cancelText = "Cancel")
        {

            var remaining = seconds * 10;

            TaskDialogButton continueButton = new(okText);
            TaskDialogButton cancelButton = new(cancelText);

            TaskDialogPage page = new()
            {
                Heading = "Continuing with next process...",
                Text = "Some text",
                Icon = new TaskDialogIcon(Icon),
                Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton },
                Caption = "Auto-close"
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
        /// <summary>
        /// Auto close dialog by specified seconds, if timed out
        /// invoke continue button.
        /// </summary>
        /// <param name="owner">control or form</param>
        /// <param name="Icon">icon to present</param>
        /// <param name="seconds">seconds to timeout</param>
        /// <param name="okText">text for continue button</param>
        /// <param name="cancelText">text for cancel button</param>
        public static void AutoCloseDialog(IntPtr owner, Icon Icon, int seconds, string text, string okText = "OK", string cancelText = "Cancel")
        {

            var remaining = seconds * 10;

            TaskDialogButton continueButton = new(okText);
            TaskDialogButton cancelButton = new(cancelText);

            TaskDialogPage page = new()
            {
                Heading = "To cancel select the cancel button",
                Text = text,
                Icon = new TaskDialogIcon(Icon),
                Buttons = new TaskDialogButtonCollection() { continueButton, cancelButton },
                Caption = "Data operations"
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

        /// <summary>
        /// Used for development to display exception information
        /// </summary>
        /// <param name="exception">Exception thrown</param>
        /// <param name="buttonText">optional text for button</param>
        public static void ErrorBox(Exception exception, string buttonText = "Silly programmer")
        {

            TaskDialogButton singleButton = new (buttonText);

            var text = $"Encountered the following{"\n"}{exception.Message}";


            TaskDialogPage page = new ()
            {
                Caption = "Information",
                SizeToContent = true,
                Heading = text,
                Icon = TaskDialogIcon.Error,
                Buttons = new TaskDialogButtonCollection() { singleButton }
            };

            TaskDialog.ShowDialog(page);

        }

        /// <summary>
        /// A dialog with option to not display again
        /// </summary>
        /// <param name="options"><seealso cref="ShowAgainOptions"/></param>
        /// <returns><seealso cref="NoShowResult"/></returns>
        public static (NoShowResult DialogResult, bool showAgain) DoNotShowAgain(ShowAgainOptions options)
        {

            TaskDialogPage page = new ()
            {
                Heading = options.Heading,
                Text = options.Text,
                Caption = options.Caption,
                Icon = new TaskDialogIcon(options.Icon),
                AllowCancel = true,
                Verification = new TaskDialogVerificationCheckBox()
                {
                    Text = options.VerificationText
                },
                Buttons = new TaskDialogButtonCollection()
                {
                    TaskDialogButton.Yes, TaskDialogButton.No
                },
                DefaultButton = TaskDialogButton.No
            };

            if (TaskDialog.ShowDialog(options.IntPtr,page) == TaskDialogButton.Yes)
            {

                bool showAgain = false;

                if (page.Verification.Checked)
                {
                    SettingOperations.SetShowAgain(false);
                    showAgain = false;
                }
                else
                {
                    SettingOperations.SetShowAgain(true);
                    showAgain = true;
                }

                return (NoShowResult.StopOperation, showAgain);

            }
            else
            {

                return (NoShowResult.No, true);

            }

        }
        public delegate void OnContinue(bool sender);
        public static event OnContinue ContinueOperation;

        /// <summary>
        /// Example for opening a web page
        /// </summary>
        public static void OpenLink()
        {
            TaskDialogCommandLinkButton continueButton = new ("&Quit", "Return to caller");
            TaskDialogCommandLinkButton linkButton     = new ("&Google", "Open in default browser");

            linkButton.Click += LinkButtonClick;

            var page = new TaskDialogPage()
            {
                Caption = "Question",
                Heading = "Open in browser",
                AllowCancel = true,
                Footnote = new TaskDialogFootnote() { Text = "Copyright: Some company"},
                Buttons = { linkButton, continueButton }
            };
            
            TaskDialog.ShowDialog(page);

        }

        /// <summary>
        /// Example for opening a web page for windows forms
        /// </summary>
        /// <param name="owner">control or form</param>
        public static void OpenLink(Control owner)
        {
            TaskDialogCommandLinkButton continueButton = new("&Quit", "Return to caller");
            TaskDialogCommandLinkButton linkButton = new("&Microsoft docs", "Open in default browser");

            linkButton.SetAddress("https://docs.microsoft.com/en-us/documentation/");

            linkButton.Click += LinkButtonClick;

            TaskDialogPage page = new()
            {
                Caption = "Question",
                Heading = "Open in browser",
                AllowCancel = true,
                Footnote = new TaskDialogFootnote() { Text = $"Copyright {Now:yyyy}: Some company" },
                Buttons = { linkButton, continueButton }, 
                Icon = TaskDialogIcon.Information
            };

            TaskDialog.ShowDialog(owner,page);

        }

        /// <summary>
        /// Dialogs.WithStrings(this, System.Globalization.DateTimeFormatInfo.CurrentInfo!.MonthNames[..^1].ToList());
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="items"></param>
        public static void WithStrings(Control owner, List<string> items)
        {
            
            var buttons = new TaskDialogButtonCollection();
            foreach (var item in items)
            {
                buttons.Add(new TaskDialogCommandLinkButton(item));
            }

            foreach (var button in buttons)
            {
                button.Enabled = false;
            }

            buttons.Add(new TaskDialogCommandLinkButton("&OK", "Close"));
 
            TaskDialogPage page = new()
            {
                Caption = "Items",
                Heading = "List",
                AllowCancel = true,
                Icon = TaskDialogIcon.Information,
                Buttons = buttons
            };

            TaskDialog.ShowDialog(owner, page);

        }
        /// <summary>
        /// Example for opening a web page for WPF
        /// </summary>
        /// <param name="owner">IntPtr</param>
        public static void OpenLink(IntPtr owner)
        {
            TaskDialogCommandLinkButton continueButton = new("&Quit", "Return to caller");
            TaskDialogCommandLinkButton linkButton = new("&Microsoft docs", "Open in default browser");

            linkButton.SetAddress("https://docs.microsoft.com/en-us/documentation/");

            linkButton.Click += LinkButtonClick;

            TaskDialogPage page = new ()
            {
                Caption = "Question",
                Heading = "Open in browser",
                AllowCancel = true,
                Footnote = new TaskDialogFootnote() { Text = $"Copyright {Now:yyyy}: Some company" },
                Buttons = { linkButton, continueButton },
                Icon = TaskDialogIcon.Information
            };

            TaskDialog.ShowDialog(owner, page);

        }
        /// <summary>
        /// Open web page from method above
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void LinkButtonClick(object sender, EventArgs e)
        {
            var (hasUrl, address) = (sender as TaskDialogCommandLinkButton).GetAddress();

            if (!hasUrl) return;
            var startInfo = new ProcessStartInfo
            {
                FileName = address,
                UseShellExecute = true
            };

            Process.Start(startInfo);

        }

        /// <summary>
        /// Simple example to open a text file via a button click
        /// </summary>
        /// <param name="owner">control or form</param>
        public static TaskDialogButton OpenFileAlert(Control owner) 
        {
            var openButton = new TaskDialogButton("Open");
            var cancelButton = new TaskDialogButton("Cancel");

            openButton.Click += OnOpenButtonOnClick;

            TaskDialogPage page = new ()
            {
                Caption = "Information",
                Heading = "Example for opening a file",
                Buttons = { cancelButton, openButton },
                Icon = TaskDialogIcon.None
            };

            return TaskDialog.ShowDialog(owner, page);
        }

        public delegate void GetComputerInformation(MachineComputerInformation information);
        public static event GetComputerInformation ComputerInformationEvent;
        private static async void OnOpenButtonOnClick(object o, EventArgs eventArgs)
        {
            var machine = await PowerShellOperations.GetComputerInformationTask();
            ComputerInformationEvent?.Invoke(machine);
            Process.Start("notepad.exe",PowerShellOperations.ComputerInfoFileName);
        }

        public delegate void OnCheck(TaskDialogRadioButton radioButton);
        public static event OnCheck VisualStudioChecked;

        /// <summary>
        /// Simple example using RadioButton group
        /// </summary>
        /// <returns>response, button clicked, Visual Studio version</returns>
        /// <remarks>
        /// Adding owner will center for form
        /// </remarks>
        public static (bool response, VisualStudioVersion version) VisualStudioVersionDialog()
        {

            TaskDialogButton selectButton = new("Select") { Tag = DialogResult.Yes };
            TaskDialogButton cancelButton = new("Cancel") { Tag = DialogResult.No };

            TaskDialogPage page = new()
            {
                Caption = "Question",
                Heading = "Which version are you using?",
                AllowCancel = true,
                Footnote = new TaskDialogFootnote() { Text = $"Copyright {Now:yyyy}: Some company" },
                Buttons = { selectButton, cancelButton } , 
                Icon = new TaskDialogIcon(Properties.Resources.visualstudio32)
            };

            TaskDialogRadioButton radioButton2017 = page.RadioButtons.Add("Visual Studio 201&7");
            radioButton2017.Tag = VisualStudioVersion.V2017;

            var radioButton2019 = page.RadioButtons.Add("Visual Studio 201&9");
            radioButton2019.Tag = VisualStudioVersion.V2019;

            var radioButton2022 = page.RadioButtons.Add("Visual Studio 20&22");
            radioButton2022.Tag = VisualStudioVersion.V2022;
            
            page.RadioButtons.ToList().ForEach(rb => rb.CheckedChanged += RadioButtonOnCheckedChanged);
            
            TaskDialogButton dialogResult = TaskDialog.ShowDialog(page);
            
            VisualStudioVersion selectedVersion = page.RadioButtons.FirstOrDefault(button => button.Checked).Version();
            
            return dialogResult.Text == "Select" ? 
                (true, selected: selectedVersion) : 
                (false, selected: selectedVersion);

        }

        private static void RadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (!Debugger.IsAttached) return;
            TaskDialogRadioButton current = (TaskDialogRadioButton)sender;
            if (current.Checked)
            {
                VisualStudioChecked?.Invoke(current);
            }
        }

        /// <summary>
        /// Base example to show how to handle events.
        /// </summary>
        public static void ShowEventsTaskDialog()
        {
            var page1 = new TaskDialogPage()
            {
                Caption = "Text",
                Heading = "Event Demo",
                Text = "Event Demo...",
            };

            page1.Created += (s, e) => Debug.WriteLine($"{nameof(page1)} Created");
            page1.Destroyed += (s, e) => Debug.WriteLine($"{nameof(page1)} Destroyed");
            page1.HelpRequest += (s, e) => Debug.WriteLine($"{nameof(page1)} HelpRequest");

            page1.Expander = new TaskDialogExpander("Expander")
            {
                Position = TaskDialogExpanderPosition.AfterFootnote
            };

            page1.Expander.ExpandedChanged += (s, e) => 
                Debug.WriteLine($"Expander ExpandedChanged: {page1.Expander.Expanded}");

            var buttonOK = TaskDialogButton.OK;
            var buttonHelp = TaskDialogButton.Help;

            var buttonCancelClose = new TaskDialogCommandLinkButton("C&ancel Close", allowCloseDialog: false);
            
            var buttonShowInnerDialog = new TaskDialogCommandLinkButton(
                "&Show (modeless) Inner Dialog", "(and don't cancel the Close)");

            var buttonNavigate = new TaskDialogCommandLinkButton("&Navigate", allowCloseDialog: false);

            page1.Buttons.Add(buttonOK);
            page1.Buttons.Add(buttonHelp);
            page1.Buttons.Add(buttonCancelClose);
            page1.Buttons.Add(buttonShowInnerDialog);
            page1.Buttons.Add(buttonNavigate);

            buttonOK.Click += (sender, _) => 
                Debug.WriteLine($"Button '{sender}' Click");

            buttonHelp.Click += (sender, _) => 
                Debug.WriteLine($"Button '{sender}' Click");

            buttonCancelClose.Click += (sender, _) => 
                Debug.WriteLine($"Button '{sender}' Click");

            buttonShowInnerDialog.Click += (sender, e) =>
            {
                Debug.WriteLine($"Button '{sender}' Click");
                TaskDialog.ShowDialog(new TaskDialogPage()
                {
                    Text = "Inner Dialog"
                });

                Debug.WriteLine($"(returns) Button '{sender}' Click");

            };

            buttonNavigate.Click += (sender, _) =>
            {
                Debug.WriteLine($"Button '{sender}' Click");

                // Navigate to a new page.
                var page2 = new TaskDialogPage()
                {
                    Heading = "AfterNavigation.",
                    Buttons = { TaskDialogButton.Close }
                };
                page2.Created += (_, _) => Debug.WriteLine("Page2 Created");
                page2.Destroyed += (_, _) => Debug.WriteLine("Page2 Destroyed");

                page1.Navigate(page2);
            };

            page1.Verification = new TaskDialogVerificationCheckBox("&CheckBox");

            page1.Verification.CheckedChanged += (_, _) => 
                Debug.WriteLine("CheckBox CheckedChanged: " + page1.Verification.Checked);

            var radioButton1 = page1.RadioButtons.Add("Radi&oButton 1");
            var radioButton2 = page1.RadioButtons.Add("RadioB&utton 2");

            radioButton1.CheckedChanged += (_, _) => 
                Debug.WriteLine($"{nameof(radioButton1)} CheckedChanged: {radioButton1.Checked.ToYesNoString()}");

            radioButton2.CheckedChanged += (_, _) =>
                Debug.WriteLine($"{nameof(radioButton2)} CheckedChanged: {radioButton2.Checked.ToYesNoString()}");

            var dialogResult = TaskDialog.ShowDialog(page1);
            Debug.WriteLine($"---> Dialog Result: {dialogResult}");
        }

        public static void ChristmasDialog(Control owner, Icon Icon, int seconds, string okText = "Merry Christmas")
        {

            var remaining = seconds * 10;

            TaskDialogButton continueButton = new(okText);
            
            TaskDialogPage page = new()
            {
                Heading = "May your holidays be the best ever",
                Text = "From Karen Payne",
                Icon = new TaskDialogIcon(Icon),
                Buttons = new TaskDialogButtonCollection() { continueButton },
                Caption = "Happy holidays"
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
    }
}
