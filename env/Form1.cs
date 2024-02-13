using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace env
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "os version :"+Environment.OSVersion.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "machine name:" + Environment.MachineName.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "processors count:" + Environment.ProcessorCount.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "system directory:" + Environment.SystemDirectory.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "system page size:" + Environment.SystemPageSize.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "is a 64 os system:" + Environment.Is64BitOperatingSystem.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "current directory:" + Environment.CurrentDirectory.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "user name:" + Environment.UserName.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "user domain name:" + Environment.UserDomainName.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "system page size:" + Environment.SystemPageSize.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "system directory:" + Environment.SystemDirectory.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "is a 64 proces:" + Environment.Is64BitProcess.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "current managed thread id:" + Environment.CurrentManagedThreadId.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "working set:" + Environment.WorkingSet.ToString();
            this.textBox1.Text += Environment.NewLine;
            this.textBox1.Text += "ticks count:" + Environment.TickCount.ToString();
            this.textBox1.Text += Environment.NewLine;

            string[] drives = Environment.GetLogicalDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                this.textBox1.Text += "logic drive:" + i.ToString() + " -> "+ drives[i].ToString();
                this.textBox1.Text += Environment.NewLine;
            }

            IDictionary envvars = Environment.GetEnvironmentVariables();
           
            int nrofenvvars = envvars.Count;

            this.textBox1.Text += "environment variables counter :" + nrofenvvars.ToString() ;
            this.textBox1.Text += Environment.NewLine;


          
        }
    }
}
