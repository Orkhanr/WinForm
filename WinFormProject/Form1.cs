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

namespace WinFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.MdiParent = this;
            calc.WindowState = FormWindowState.Maximized;
            calc.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.WindowState = FormWindowState.Maximized;
            about.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r /t 1000");
        }

        private void withEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailForm email = new EmailForm();
            email.MdiParent = this;
            email.WindowState = FormWindowState.Maximized;
            email.Show();
        }
    }
}
