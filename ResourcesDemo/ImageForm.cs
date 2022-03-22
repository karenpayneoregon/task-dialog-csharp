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
using ResourcesDemo.Classes;

namespace ResourcesDemo
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            ImageNamesListBox.DataSource = ResourceImages.Instance.Images();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResourceItem item = (ResourceItem)ImageNamesListBox.SelectedItem;
            pictureBox1.Image = item.Image;
        }
    }
}
