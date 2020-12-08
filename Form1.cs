using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SystemBridge
{
    public partial class SystemBridge : Form
    {
        public SystemBridge()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Running File Explorer....";
            Process.Start("C:/Windows/explorer.exe");
            richTextBox1.Text = "Process finished!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Running Control Pannel...";
            Process.Start("C:/Windows/System32/control.exe");
            richTextBox1.Text = "Process finished!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Shutting Down....";
            Process.Start("C:/Windows/System32/shutdown.exe", "/s /t 0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Logging Out...";
            Process.Start("C:/Windows/System32/shutdown.exe","/l");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Restarting...";
            Process.Start("C:/Windows/System32/shutdown.exe", "/r /t 0");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Running Task Manager....";
            Process.Start("C:/Windows/System32/Taskmgr.exe");
            richTextBox1.Text = "Process finished!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Running Command Line....";
            Process.Start("C:/Windows/System32/cmd.exe");
            richTextBox1.Text = "Process finished!";
        }
    }
}
