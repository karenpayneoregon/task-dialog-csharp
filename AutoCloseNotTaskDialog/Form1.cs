using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCloseNotTaskDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AutoCloseButton_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show(text: "Chunking completed", caption: "Information", timeout: SecondsUpDown.Seconds);
        }
    }
}
