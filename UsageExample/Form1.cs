using System;
using System.Windows.Forms;
using WindowUtils;

namespace UsageExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this makes the form appear as a wallpaper
            this.SetAsWallpaper();

            //this makes the form appear as a regular desktop window
            //this.SetAsDesktopWindow();
        }
    }
}