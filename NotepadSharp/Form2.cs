using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotepadSharp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://anthony-lomeli.co.cc/notepad");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Width == 424)
            {
                this.Width = 905;
                button2.Text = "Less info";
            }
            else if (this.Width == 905)
            {
                this.Width = 424;
                button2.Text = "More info";
            }
        }
    }
}
