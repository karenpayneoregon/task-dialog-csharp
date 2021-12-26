
namespace AutoCloseNotTaskDialog
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
            this.SecondsUpDown = new AutoCloseNotTaskDialog.Classes.SpecialNumericUpDown();
            this.AutoCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Location = new System.Drawing.Point(163, 14);
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(67, 23);
            this.SecondsUpDown.TabIndex = 0;
            this.SecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AutoCloseButton
            // 
            this.AutoCloseButton.Location = new System.Drawing.Point(12, 14);
            this.AutoCloseButton.Name = "AutoCloseButton";
            this.AutoCloseButton.Size = new System.Drawing.Size(145, 23);
            this.AutoCloseButton.TabIndex = 1;
            this.AutoCloseButton.Text = "Auto-close";
            this.AutoCloseButton.UseVisualStyleBackColor = true;
            this.AutoCloseButton.Click += new System.EventHandler(this.AutoCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seconds delay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoCloseButton);
            this.Controls.Add(this.SecondsUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Close code sample";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.SpecialNumericUpDown SecondsUpDown;
        private System.Windows.Forms.Button AutoCloseButton;
        private System.Windows.Forms.Label label1;
    }
}

