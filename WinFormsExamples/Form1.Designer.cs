
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AutoCloseButton = new System.Windows.Forms.Button();
            this.OpenTextFileButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.DoNotShowAgainButton = new System.Windows.Forms.Button();
            this.ShowAgainCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoCloseProgressButton = new System.Windows.Forms.Button();
            this.SecondsUpDown = new WinFormsExamples.Classes.SpecialNumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.IconListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AskQuestionButton = new System.Windows.Forms.Button();
            this.LinkExampleButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.RadioGroupButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoCloseButton
            // 
            this.AutoCloseButton.Image = global::WinFormsExamples.Properties.Resources.SplashScreen_16x;
            this.AutoCloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoCloseButton.Location = new System.Drawing.Point(24, 12);
            this.AutoCloseButton.Name = "AutoCloseButton";
            this.AutoCloseButton.Size = new System.Drawing.Size(187, 28);
            this.AutoCloseButton.TabIndex = 0;
            this.AutoCloseButton.Text = "Auto-close";
            this.AutoCloseButton.UseVisualStyleBackColor = true;
            this.AutoCloseButton.Click += new System.EventHandler(this.AutoCloseButton_Click);
            // 
            // OpenTextFileButton
            // 
            this.OpenTextFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenTextFileButton.Image")));
            this.OpenTextFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenTextFileButton.Location = new System.Drawing.Point(24, 99);
            this.OpenTextFileButton.Name = "OpenTextFileButton";
            this.OpenTextFileButton.Size = new System.Drawing.Size(187, 28);
            this.OpenTextFileButton.TabIndex = 1;
            this.OpenTextFileButton.Text = "Open text file";
            this.OpenTextFileButton.UseVisualStyleBackColor = true;
            this.OpenTextFileButton.Click += new System.EventHandler(this.OpenTextFileButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 15;
            this.ResultsListBox.Location = new System.Drawing.Point(379, 27);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(281, 154);
            this.ResultsListBox.TabIndex = 2;
            // 
            // DoNotShowAgainButton
            // 
            this.DoNotShowAgainButton.Image = global::WinFormsExamples.Properties.Resources.ShowDetails_16x;
            this.DoNotShowAgainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoNotShowAgainButton.Location = new System.Drawing.Point(24, 70);
            this.DoNotShowAgainButton.Name = "DoNotShowAgainButton";
            this.DoNotShowAgainButton.Size = new System.Drawing.Size(187, 28);
            this.DoNotShowAgainButton.TabIndex = 3;
            this.DoNotShowAgainButton.Text = "Do not show again";
            this.DoNotShowAgainButton.UseVisualStyleBackColor = true;
            this.DoNotShowAgainButton.Click += new System.EventHandler(this.DoNotShowAgainButton_Click);
            // 
            // ShowAgainCheckBox
            // 
            this.ShowAgainCheckBox.AutoSize = true;
            this.ShowAgainCheckBox.Location = new System.Drawing.Point(217, 74);
            this.ShowAgainCheckBox.Name = "ShowAgainCheckBox";
            this.ShowAgainCheckBox.Size = new System.Drawing.Size(124, 19);
            this.ShowAgainCheckBox.TabIndex = 4;
            this.ShowAgainCheckBox.Text = "Toggle show again";
            this.toolTip1.SetToolTip(this.ShowAgainCheckBox, "Toggle enabled/disable of do not show again in json settings file");
            this.ShowAgainCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoCloseProgressButton
            // 
            this.AutoCloseProgressButton.Image = global::WinFormsExamples.Properties.Resources.SplashScreen_16x;
            this.AutoCloseProgressButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoCloseProgressButton.Location = new System.Drawing.Point(24, 41);
            this.AutoCloseProgressButton.Name = "AutoCloseProgressButton";
            this.AutoCloseProgressButton.Size = new System.Drawing.Size(187, 28);
            this.AutoCloseProgressButton.TabIndex = 5;
            this.AutoCloseProgressButton.Text = "Auto-close";
            this.AutoCloseProgressButton.UseVisualStyleBackColor = true;
            this.AutoCloseProgressButton.Click += new System.EventHandler(this.AutoCloseProgressButton_Click);
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Location = new System.Drawing.Point(217, 14);
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(42, 23);
            this.SecondsUpDown.TabIndex = 6;
            this.SecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.SecondsUpDown, "Specify number of second before auto-closing the dialog");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightGreen;
            this.toolTip1.OwnerDraw = true;
            // 
            // IconListBox
            // 
            this.IconListBox.FormattingEnabled = true;
            this.IconListBox.ItemHeight = 15;
            this.IconListBox.Location = new System.Drawing.Point(379, 210);
            this.IconListBox.Name = "IconListBox";
            this.IconListBox.Size = new System.Drawing.Size(205, 229);
            this.IconListBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Icons for do not show again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Do not show again results";
            // 
            // AskQuestionButton
            // 
            this.AskQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("AskQuestionButton.Image")));
            this.AskQuestionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AskQuestionButton.Location = new System.Drawing.Point(24, 128);
            this.AskQuestionButton.Name = "AskQuestionButton";
            this.AskQuestionButton.Size = new System.Drawing.Size(187, 28);
            this.AskQuestionButton.TabIndex = 12;
            this.AskQuestionButton.Text = "Question";
            this.AskQuestionButton.UseVisualStyleBackColor = true;
            this.AskQuestionButton.Click += new System.EventHandler(this.AskQuestionButton_Click);
            // 
            // LinkExampleButton
            // 
            this.LinkExampleButton.Image = ((System.Drawing.Image)(resources.GetObject("LinkExampleButton.Image")));
            this.LinkExampleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LinkExampleButton.Location = new System.Drawing.Point(24, 157);
            this.LinkExampleButton.Name = "LinkExampleButton";
            this.LinkExampleButton.Size = new System.Drawing.Size(187, 28);
            this.LinkExampleButton.TabIndex = 13;
            this.LinkExampleButton.Text = "Link button sample";
            this.LinkExampleButton.UseVisualStyleBackColor = true;
            this.LinkExampleButton.Click += new System.EventHandler(this.LinkExampleButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.Image = ((System.Drawing.Image)(resources.GetObject("EventsButton.Image")));
            this.EventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsButton.Location = new System.Drawing.Point(24, 186);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(187, 28);
            this.EventsButton.TabIndex = 14;
            this.EventsButton.Text = "Events sample";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // RadioGroupButton
            // 
            this.RadioGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("RadioGroupButton.Image")));
            this.RadioGroupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RadioGroupButton.Location = new System.Drawing.Point(24, 215);
            this.RadioGroupButton.Name = "RadioGroupButton";
            this.RadioGroupButton.Size = new System.Drawing.Size(187, 28);
            this.RadioGroupButton.TabIndex = 15;
            this.RadioGroupButton.Text = "Radio buttons";
            this.RadioGroupButton.UseVisualStyleBackColor = true;
            this.RadioGroupButton.Click += new System.EventHandler(this.RadioGroupButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(217, 222);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(36, 15);
            this.VersionLabel.TabIndex = 16;
            this.VersionLabel.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.RadioGroupButton);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.LinkExampleButton);
            this.Controls.Add(this.AskQuestionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IconListBox);
            this.Controls.Add(this.SecondsUpDown);
            this.Controls.Add(this.AutoCloseProgressButton);
            this.Controls.Add(this.ShowAgainCheckBox);
            this.Controls.Add(this.DoNotShowAgainButton);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.OpenTextFileButton);
            this.Controls.Add(this.AutoCloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskDialog examples";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

