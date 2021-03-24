using Cmps253.Logger.Loggers;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new FileLogger(@"c:\trash\log.txt").Log("Form1_Load");
        }
    }
}