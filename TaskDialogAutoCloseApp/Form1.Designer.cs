namespace TaskDialogAutoCloseApp;

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
        AutoCloseButton1 = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // AutoCloseButton1
        // 
        AutoCloseButton1.Location = new Point(142, 81);
        AutoCloseButton1.Name = "AutoCloseButton1";
        AutoCloseButton1.Size = new Size(118, 29);
        AutoCloseButton1.TabIndex = 0;
        AutoCloseButton1.Text = "Auto close 1";
        AutoCloseButton1.UseVisualStyleBackColor = true;
        AutoCloseButton1.Click += AutoCloseButton1_Click;
        // 
        // button1
        // 
        button1.Location = new Point(142, 116);
        button1.Name = "button1";
        button1.Size = new Size(118, 29);
        button1.TabIndex = 1;
        button1.Text = "Auto close 2";
        button1.UseVisualStyleBackColor = true;
        button1.Click += AutoCloseButton2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(436, 273);
        Controls.Add(button1);
        Controls.Add(AutoCloseButton1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ResumeLayout(false);
    }

    #endregion

    private Button AutoCloseButton1;
    private Button button1;
}
