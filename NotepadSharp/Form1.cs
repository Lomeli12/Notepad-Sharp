using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotepadSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(scintilla1);
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(scintilla1);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount < 1)
            {
                string title = "New" + (tabControl1.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                myTabPage.Controls.Add(scintilla1);
                tabControl1.TabPages.Add(myTabPage);
            }
            else if (tabControl1.TabCount >= 1) { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(scintilla1);
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount < 1)
            {
                string title = "New" + (tabControl1.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                myTabPage.Controls.Add(scintilla1);
                tabControl1.TabPages.Add(myTabPage);
            }
            else if (tabControl1.TabCount >= 1) { }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(scintilla1);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void aboutNotepadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void updateNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo(Environment.CurrentDirectory + @"\updater\GUP.exe", "/user:Anthony\administrator");
            processStartInfo.Verb = "runas";

            using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();
                process.WaitForExit();
            }

            //System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\updater\GUP.exe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LANGUAGES!
        private void adaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "ada";
            scintilla1.Refresh();
        }

        private void aSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "asm";
            scintilla1.Refresh();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "batch";
            scintilla1.Refresh();
        }

        private void blizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "blitsbasic";
            scintilla1.Refresh();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "cs";
            scintilla1.Refresh();
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "cpp";
            scintilla1.Refresh();
        }

        private void camToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "caml";
            scintilla1.Refresh();
        }

        private void cmakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "cmake";
            scintilla1.Refresh();
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "css";
            scintilla1.Refresh();
        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "d";
            scintilla1.Refresh();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "diff";
            scintilla1.Refresh();
        }

        private void fortanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "fortran";
            scintilla1.Refresh();
        }

        private void gAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "gap";
            scintilla1.Refresh();
        }

        private void gui4CliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "gui4cli";
            scintilla1.Refresh();
        }

        private void haskellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "haskell";
            scintilla1.Refresh();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "hypertext";
            scintilla1.Refresh();
        }

        private void iNNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "innosetup";
            scintilla1.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "js";
            scintilla1.Refresh();
        }

        private void kIXTartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "kix";
            scintilla1.Refresh();
        }

        private void lISPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "lisp";
            scintilla1.Refresh();
        }

        private void lunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "lua";
            scintilla1.Refresh();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "make";
            scintilla1.Refresh();
        }

        private void matLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "matlab";
            scintilla1.Refresh();
        }

        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "";
            scintilla1.Refresh();
        }

        private void nSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "nsis";
            scintilla1.Refresh();
        }

        private void octaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "octave";
            scintilla1.Refresh();
        }

        private void pascalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "pascal";
            scintilla1.Refresh();
        }

        private void perlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "perl";
            scintilla1.Refresh();
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "hypertext";
            scintilla1.Refresh();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "python";
            scintilla1.Refresh();
        }

        private void rubyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "ruby";
            scintilla1.Refresh();
        }

        private void smalltalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "smalltalk";
            scintilla1.Refresh();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "sql";
            scintilla1.Refresh();
        }

        private void tCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "tcl";
            scintilla1.Refresh();
        }

        private void teXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "tex";
            scintilla1.Refresh();
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "vb";
            scintilla1.Refresh();
        }

        private void verilogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "verilog";
            scintilla1.Refresh();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "xml";
            scintilla1.Refresh();
        }

        private void yAMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scintilla1.ConfigurationManager.Language = "yaml";
            scintilla1.Refresh();
        }
        //End of Languages
        private string Read(string file)
        {
            StreamReader reader = new StreamReader(this.openFileDialog1.FileName);
            string data = reader.ReadToEnd();
            reader.Close();
            return data;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = this.Read(this.openFileDialog1.FileName);
                this.scintilla1.Text = data;
                this.Text = "Notepad# - " + this.openFileDialog1.SafeFileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.saveFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(this.saveFileDialog1.FileName, this.scintilla1.Text);
            this.Text = "Notepad# - " + this.saveFileDialog1.FileName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = this.Read(this.openFileDialog1.FileName);
                this.scintilla1.Text = data;
                this.Text = "Notepad# - " + this.openFileDialog1.SafeFileName;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }
    }
}
