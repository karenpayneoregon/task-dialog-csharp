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
            this.AutoCloseButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutoCloseButton1
            // 
            this.AutoCloseButton1.Location = new System.Drawing.Point(142, 81);
            this.AutoCloseButton1.Name = "AutoCloseButton1";
            this.AutoCloseButton1.Size = new System.Drawing.Size(118, 29);
            this.AutoCloseButton1.TabIndex = 0;
            this.AutoCloseButton1.Text = "Auto close 1";
            this.AutoCloseButton1.UseVisualStyleBackColor = true;
            this.AutoCloseButton1.Click += new System.EventHandler(this.AutoCloseButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Auto close 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AutoCloseButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoCloseButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private Button AutoCloseButton1;
    private Button button1;
}
