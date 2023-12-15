
namespace WinFormsExamples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AutoCloseButton = new Button();
            OpenTextFileButton = new Button();
            ResultsListBox = new ListBox();
            DoNotShowAgainButton = new Button();
            ShowAgainCheckBox = new CheckBox();
            AutoCloseProgressButton = new Button();
            SecondsUpDown = new Classes.SpecialNumericUpDown();
            toolTip1 = new ToolTip(components);
            IconListBox = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            AskQuestionButton = new Button();
            LinkExampleButton = new Button();
            EventsButton = new Button();
            RadioGroupButton = new Button();
            VersionLabel = new Label();
            ConventionalQuestionButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)SecondsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AutoCloseButton
            // 
            AutoCloseButton.AccessibleDescription = "Auto close dialog sample with user define timeout";
            AutoCloseButton.Image = Properties.Resources.SplashScreen_16x;
            AutoCloseButton.ImageAlign = ContentAlignment.MiddleLeft;
            AutoCloseButton.Location = new Point(27, 16);
            AutoCloseButton.Margin = new Padding(3, 4, 3, 4);
            AutoCloseButton.Name = "AutoCloseButton";
            AutoCloseButton.Size = new Size(214, 37);
            AutoCloseButton.TabIndex = 0;
            AutoCloseButton.Text = "Auto-close";
            AutoCloseButton.UseVisualStyleBackColor = true;
            AutoCloseButton.Click += AutoCloseButton_Click;
            // 
            // OpenTextFileButton
            // 
            OpenTextFileButton.AccessibleDescription = "Use PowerShell to get computer information to a json file";
            OpenTextFileButton.Image = (Image)resources.GetObject("OpenTextFileButton.Image");
            OpenTextFileButton.ImageAlign = ContentAlignment.MiddleLeft;
            OpenTextFileButton.Location = new Point(27, 132);
            OpenTextFileButton.Margin = new Padding(3, 4, 3, 4);
            OpenTextFileButton.Name = "OpenTextFileButton";
            OpenTextFileButton.Size = new Size(214, 37);
            OpenTextFileButton.TabIndex = 1;
            OpenTextFileButton.Text = "Open text file";
            OpenTextFileButton.UseVisualStyleBackColor = true;
            OpenTextFileButton.Click += OpenTextFileButton_Click;
            // 
            // ResultsListBox
            // 
            ResultsListBox.AccessibleDescription = "results from donot show again";
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.ItemHeight = 20;
            ResultsListBox.Location = new Point(433, 36);
            ResultsListBox.Margin = new Padding(3, 4, 3, 4);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(321, 204);
            ResultsListBox.TabIndex = 2;
            // 
            // DoNotShowAgainButton
            // 
            DoNotShowAgainButton.AccessibleDescription = "Display donot show again dialog";
            DoNotShowAgainButton.Image = Properties.Resources.ShowDetails_16x;
            DoNotShowAgainButton.ImageAlign = ContentAlignment.MiddleLeft;
            DoNotShowAgainButton.Location = new Point(27, 93);
            DoNotShowAgainButton.Margin = new Padding(3, 4, 3, 4);
            DoNotShowAgainButton.Name = "DoNotShowAgainButton";
            DoNotShowAgainButton.Size = new Size(214, 37);
            DoNotShowAgainButton.TabIndex = 3;
            DoNotShowAgainButton.Text = "Do not show again";
            DoNotShowAgainButton.UseVisualStyleBackColor = true;
            DoNotShowAgainButton.Click += DoNotShowAgainButton_Click;
            // 
            // ShowAgainCheckBox
            // 
            ShowAgainCheckBox.AccessibleDescription = "Used to toggle show again";
            ShowAgainCheckBox.AutoSize = true;
            ShowAgainCheckBox.Location = new Point(248, 99);
            ShowAgainCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowAgainCheckBox.Name = "ShowAgainCheckBox";
            ShowAgainCheckBox.Size = new Size(156, 24);
            ShowAgainCheckBox.TabIndex = 4;
            ShowAgainCheckBox.Text = "Toggle show again";
            toolTip1.SetToolTip(ShowAgainCheckBox, "Toggle enabled/disable of do not show again in json settings file");
            ShowAgainCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoCloseProgressButton
            // 
            AutoCloseProgressButton.AccessibleDescription = "Auto close dialog demo fix fimeout";
            AutoCloseProgressButton.Image = Properties.Resources.SplashScreen_16x;
            AutoCloseProgressButton.ImageAlign = ContentAlignment.MiddleLeft;
            AutoCloseProgressButton.Location = new Point(27, 55);
            AutoCloseProgressButton.Margin = new Padding(3, 4, 3, 4);
            AutoCloseProgressButton.Name = "AutoCloseProgressButton";
            AutoCloseProgressButton.Size = new Size(214, 37);
            AutoCloseProgressButton.TabIndex = 5;
            AutoCloseProgressButton.Text = "Auto-close";
            AutoCloseProgressButton.UseVisualStyleBackColor = true;
            AutoCloseProgressButton.Click += AutoCloseProgressButton_Click;
            // 
            // SecondsUpDown
            // 
            SecondsUpDown.AccessibleDescription = "Timeout input in seconds";
            SecondsUpDown.Location = new Point(248, 19);
            SecondsUpDown.Margin = new Padding(3, 4, 3, 4);
            SecondsUpDown.Name = "SecondsUpDown";
            SecondsUpDown.Size = new Size(48, 27);
            SecondsUpDown.TabIndex = 6;
            SecondsUpDown.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(SecondsUpDown, "Specify number of second before auto-closing the dialog");
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.LightGreen;
            toolTip1.OwnerDraw = true;
            // 
            // IconListBox
            // 
            IconListBox.AccessibleDescription = "List of icons for donot show again dialog";
            IconListBox.FormattingEnabled = true;
            IconListBox.ItemHeight = 20;
            IconListBox.Location = new Point(433, 280);
            IconListBox.Margin = new Padding(3, 4, 3, 4);
            IconListBox.Name = "IconListBox";
            IconListBox.Size = new Size(234, 304);
            IconListBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(674, 280);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 83);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(433, 255);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 10;
            label1.Text = "Icons for do not show again";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 7);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 11;
            label2.Text = "Do not show again results";
            // 
            // AskQuestionButton
            // 
            AskQuestionButton.AccessibleDescription = "Question dialog example";
            AskQuestionButton.Image = (Image)resources.GetObject("AskQuestionButton.Image");
            AskQuestionButton.ImageAlign = ContentAlignment.MiddleLeft;
            AskQuestionButton.Location = new Point(27, 171);
            AskQuestionButton.Margin = new Padding(3, 4, 3, 4);
            AskQuestionButton.Name = "AskQuestionButton";
            AskQuestionButton.Size = new Size(214, 37);
            AskQuestionButton.TabIndex = 12;
            AskQuestionButton.Text = "Question";
            AskQuestionButton.UseVisualStyleBackColor = true;
            AskQuestionButton.Click += AskQuestionButton_Click;
            // 
            // LinkExampleButton
            // 
            LinkExampleButton.AccessibleDescription = "Dialog with link button";
            LinkExampleButton.Image = (Image)resources.GetObject("LinkExampleButton.Image");
            LinkExampleButton.ImageAlign = ContentAlignment.MiddleLeft;
            LinkExampleButton.Location = new Point(27, 209);
            LinkExampleButton.Margin = new Padding(3, 4, 3, 4);
            LinkExampleButton.Name = "LinkExampleButton";
            LinkExampleButton.Size = new Size(214, 37);
            LinkExampleButton.TabIndex = 13;
            LinkExampleButton.Text = "Link button sample";
            LinkExampleButton.UseVisualStyleBackColor = true;
            LinkExampleButton.Click += LinkExampleButton_Click;
            // 
            // EventsButton
            // 
            EventsButton.AccessibleDescription = "Task dialog with events example";
            EventsButton.Image = (Image)resources.GetObject("EventsButton.Image");
            EventsButton.ImageAlign = ContentAlignment.MiddleLeft;
            EventsButton.Location = new Point(27, 248);
            EventsButton.Margin = new Padding(3, 4, 3, 4);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(214, 37);
            EventsButton.TabIndex = 14;
            EventsButton.Text = "Events sample";
            EventsButton.UseVisualStyleBackColor = true;
            EventsButton.Click += EventsButton_Click;
            // 
            // RadioGroupButton
            // 
            RadioGroupButton.AccessibleDescription = "TaskDialog with radio buttons";
            RadioGroupButton.Image = (Image)resources.GetObject("RadioGroupButton.Image");
            RadioGroupButton.ImageAlign = ContentAlignment.MiddleLeft;
            RadioGroupButton.Location = new Point(27, 287);
            RadioGroupButton.Margin = new Padding(3, 4, 3, 4);
            RadioGroupButton.Name = "RadioGroupButton";
            RadioGroupButton.Size = new Size(214, 37);
            RadioGroupButton.TabIndex = 15;
            RadioGroupButton.Text = "Radio buttons";
            RadioGroupButton.UseVisualStyleBackColor = true;
            RadioGroupButton.Click += RadioGroupButton_Click;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(248, 296);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(45, 20);
            VersionLabel.TabIndex = 16;
            VersionLabel.Text = "None";
            // 
            // ConventionalQuestionButton
            // 
            ConventionalQuestionButton.AccessibleDescription = "Convental message box example";
            ConventionalQuestionButton.Image = (Image)resources.GetObject("ConventionalQuestionButton.Image");
            ConventionalQuestionButton.ImageAlign = ContentAlignment.MiddleLeft;
            ConventionalQuestionButton.Location = new Point(27, 332);
            ConventionalQuestionButton.Margin = new Padding(3, 4, 3, 4);
            ConventionalQuestionButton.Name = "ConventionalQuestionButton";
            ConventionalQuestionButton.Size = new Size(214, 37);
            ConventionalQuestionButton.TabIndex = 17;
            ConventionalQuestionButton.Text = "Question conventional";
            ConventionalQuestionButton.UseVisualStyleBackColor = true;
            ConventionalQuestionButton.Click += ConventionalQuestionButton_Click;
            // 
            // button1
            // 
            button1.AccessibleDescription = "Convental message box example";
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(27, 377);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(214, 37);
            button1.TabIndex = 18;
            button1.Text = "Fatal Error example";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ErrorExampleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 600);
            Controls.Add(button1);
            Controls.Add(ConventionalQuestionButton);
            Controls.Add(VersionLabel);
            Controls.Add(RadioGroupButton);
            Controls.Add(EventsButton);
            Controls.Add(LinkExampleButton);
            Controls.Add(AskQuestionButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(IconListBox);
            Controls.Add(SecondsUpDown);
            Controls.Add(AutoCloseProgressButton);
            Controls.Add(ShowAgainCheckBox);
            Controls.Add(DoNotShowAgainButton);
            Controls.Add(ResultsListBox);
            Controls.Add(OpenTextFileButton);
            Controls.Add(AutoCloseButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskDialog examples";
            ((System.ComponentModel.ISupportInitialize)SecondsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AutoCloseButton;
        private System.Windows.Forms.Button OpenTextFileButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button DoNotShowAgainButton;
        private System.Windows.Forms.CheckBox ShowAgainCheckBox;
        private System.Windows.Forms.Button AutoCloseProgressButton;
        private Classes.SpecialNumericUpDown SecondsUpDown;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox IconListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AskQuestionButton;
        private System.Windows.Forms.Button LinkExampleButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button RadioGroupButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button ConventionalQuestionButton;
        private Button button1;
    }
}

