namespace WinFormsExamples1;

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
        CenterOnThisButton = new Button();
        CenterOnFormButton = new Button();
        DialogWithActionsButton = new Button();
        SuspendLayout();
        // 
        // CenterOnThisButton
        // 
        CenterOnThisButton.Location = new Point(423, 313);
        CenterOnThisButton.Name = "CenterOnThisButton";
        CenterOnThisButton.Size = new Size(274, 29);
        CenterOnThisButton.TabIndex = 0;
        CenterOnThisButton.Text = "Center dialog on this button";
        CenterOnThisButton.UseVisualStyleBackColor = true;
        CenterOnThisButton.Click += CenterOnThisButton_Click;
        // 
        // CenterOnFormButton
        // 
        CenterOnFormButton.Location = new Point(23, 23);
        CenterOnFormButton.Name = "CenterOnFormButton";
        CenterOnFormButton.Size = new Size(274, 29);
        CenterOnFormButton.TabIndex = 1;
        CenterOnFormButton.Text = "Center dialog on this form";
        CenterOnFormButton.UseVisualStyleBackColor = true;
        CenterOnFormButton.Click += CenterOnFormButton_Click;
        // 
        // DialogWithActionsButton
        // 
        DialogWithActionsButton.Location = new Point(23, 71);
        DialogWithActionsButton.Name = "DialogWithActionsButton";
        DialogWithActionsButton.Size = new Size(274, 29);
        DialogWithActionsButton.TabIndex = 2;
        DialogWithActionsButton.Text = "Dialog with actions";
        DialogWithActionsButton.UseVisualStyleBackColor = true;
        DialogWithActionsButton.Click += DialogWithActionsButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(DialogWithActionsButton);
        Controls.Add(CenterOnFormButton);
        Controls.Add(CenterOnThisButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dialogs";
        ResumeLayout(false);
    }

    #endregion

    private Button CenterOnThisButton;
    private Button CenterOnFormButton;
    private Button DialogWithActionsButton;
}
