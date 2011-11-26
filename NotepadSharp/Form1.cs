using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ScintillaNet;

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
            string newtextt = title;
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            newtext.AllowDrop = true;
            newtext.AutoComplete.DropRestOfWord = true;
            newtext.AutoComplete.ListString = "";
            newtext.Dock = System.Windows.Forms.DockStyle.Fill;
            newtext.Folding.UseCompactFolding = true;
            newtext.Location = new System.Drawing.Point(3, 3);
            newtext.Margins.Margin0.Width = 20;
            newtext.Margins.Margin1.IsClickable = true;
            newtext.Margins.Margin1.IsFoldMargin = true;
            newtext.Margins.Margin1.Width = 3;
            newtext.Margins.Margin2.IsMarkerMargin = true;
            newtext.Margins.Margin2.Width = 16;
            newtext.Name = title;
            newtext.Size = new System.Drawing.Size(783, 353);
            newtext.Styles.BraceBad.FontName = "Verdana";
            newtext.Styles.BraceLight.FontName = "Verdana";
            newtext.Styles.ControlChar.FontName = "Verdana";
            newtext.Styles.Default.FontName = "Verdana";
            newtext.Styles.IndentGuide.FontName = "Verdana";
            newtext.Styles.LastPredefined.FontName = "Verdana";
            newtext.Styles.LineNumber.FontName = "Verdana";
            newtext.Styles.Max.FontName = "Verdana";
            newtext.TabIndex = 0;
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
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            newtext.AllowDrop = true;
            newtext.AutoComplete.DropRestOfWord = true;
            newtext.AutoComplete.ListString = "";
            newtext.Dock = System.Windows.Forms.DockStyle.Fill;
            newtext.Folding.UseCompactFolding = true;
            newtext.Location = new System.Drawing.Point(3, 3);
            newtext.Margins.Margin0.Width = 20;
            newtext.Margins.Margin1.IsClickable = true;
            newtext.Margins.Margin1.IsFoldMargin = true;
            newtext.Margins.Margin1.Width = 3;
            newtext.Margins.Margin2.IsMarkerMargin = true;
            newtext.Margins.Margin2.Width = 16;
            newtext.Name = title;
            newtext.Size = new System.Drawing.Size(783, 353);
            newtext.Styles.BraceBad.FontName = "Verdana";
            newtext.Styles.BraceLight.FontName = "Verdana";
            newtext.Styles.ControlChar.FontName = "Verdana";
            newtext.Styles.Default.FontName = "Verdana";
            newtext.Styles.IndentGuide.FontName = "Verdana";
            newtext.Styles.LastPredefined.FontName = "Verdana";
            newtext.Styles.LineNumber.FontName = "Verdana";
            newtext.Styles.Max.FontName = "Verdana";
            newtext.TabIndex = 0;
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount < 1)
            {
                string title = "New" + (tabControl1.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
                myTabPage.Controls.Add(newtext);
                newtext.AllowDrop = true;
                newtext.AutoComplete.DropRestOfWord = true;
                newtext.AutoComplete.ListString = "";
                newtext.Dock = System.Windows.Forms.DockStyle.Fill;
                newtext.Folding.UseCompactFolding = true;
                newtext.Location = new System.Drawing.Point(3, 3);
                newtext.Margins.Margin0.Width = 20;
                newtext.Margins.Margin1.IsClickable = true;
                newtext.Margins.Margin1.IsFoldMargin = true;
                newtext.Margins.Margin1.Width = 3;
                newtext.Margins.Margin2.IsMarkerMargin = true;
                newtext.Margins.Margin2.Width = 16;
                newtext.Name = title;
                newtext.Size = new System.Drawing.Size(783, 353);
                newtext.Styles.BraceBad.FontName = "Verdana";
                newtext.Styles.BraceLight.FontName = "Verdana";
                newtext.Styles.ControlChar.FontName = "Verdana";
                newtext.Styles.Default.FontName = "Verdana";
                newtext.Styles.IndentGuide.FontName = "Verdana";
                newtext.Styles.LastPredefined.FontName = "Verdana";
                newtext.Styles.LineNumber.FontName = "Verdana";
                newtext.Styles.Max.FontName = "Verdana";
                newtext.TabIndex = 0;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedTab = myTabPage;
            }
            else if (tabControl1.TabCount >= 1) { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            newtext.AllowDrop = true;
            newtext.AutoComplete.DropRestOfWord = true;
            newtext.AutoComplete.ListString = "";
            newtext.Dock = System.Windows.Forms.DockStyle.Fill;
            newtext.Folding.UseCompactFolding = true;
            newtext.Location = new System.Drawing.Point(3, 3);
            newtext.Margins.Margin0.Width = 20;
            newtext.Margins.Margin1.IsClickable = true;
            newtext.Margins.Margin1.IsFoldMargin = true;
            newtext.Margins.Margin1.Width = 3;
            newtext.Margins.Margin2.IsMarkerMargin = true;
            newtext.Margins.Margin2.Width = 16;
            newtext.Name = title;
            newtext.Size = new System.Drawing.Size(783, 353);
            newtext.Styles.BraceBad.FontName = "Verdana";
            newtext.Styles.BraceLight.FontName = "Verdana";
            newtext.Styles.ControlChar.FontName = "Verdana";
            newtext.Styles.Default.FontName = "Verdana";
            newtext.Styles.IndentGuide.FontName = "Verdana";
            newtext.Styles.LastPredefined.FontName = "Verdana";
            newtext.Styles.LineNumber.FontName = "Verdana";
            newtext.Styles.Max.FontName = "Verdana";
            newtext.TabIndex = 0;
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
                ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
                myTabPage.Controls.Add(newtext);
                newtext.AllowDrop = true;
                newtext.AutoComplete.DropRestOfWord = true;
                newtext.AutoComplete.ListString = "";
                newtext.Dock = System.Windows.Forms.DockStyle.Fill;
                newtext.Folding.UseCompactFolding = true;
                newtext.Location = new System.Drawing.Point(3, 3);
                newtext.Margins.Margin0.Width = 20;
                newtext.Margins.Margin1.IsClickable = true;
                newtext.Margins.Margin1.IsFoldMargin = true;
                newtext.Margins.Margin1.Width = 3;
                newtext.Margins.Margin2.IsMarkerMargin = true;
                newtext.Margins.Margin2.Width = 16;
                newtext.Name = title;
                newtext.Size = new System.Drawing.Size(783, 353);
                newtext.Styles.BraceBad.FontName = "Verdana";
                newtext.Styles.BraceLight.FontName = "Verdana";
                newtext.Styles.ControlChar.FontName = "Verdana";
                newtext.Styles.Default.FontName = "Verdana";
                newtext.Styles.IndentGuide.FontName = "Verdana";
                newtext.Styles.LastPredefined.FontName = "Verdana";
                newtext.Styles.LineNumber.FontName = "Verdana";
                newtext.Styles.Max.FontName = "Verdana";
                newtext.TabIndex = 0;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedTab = myTabPage;
            }
            else if (tabControl1.TabCount >= 1) { }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Clear();
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            newtext.AllowDrop = true;
            newtext.AutoComplete.DropRestOfWord = true;
            newtext.AutoComplete.ListString = "";
            newtext.Dock = System.Windows.Forms.DockStyle.Fill;
            newtext.Folding.UseCompactFolding = true;
            newtext.Location = new System.Drawing.Point(3, 3);
            newtext.Margins.Margin0.Width = 20;
            newtext.Margins.Margin1.IsClickable = true;
            newtext.Margins.Margin1.IsFoldMargin = true;
            newtext.Margins.Margin1.Width = 3;
            newtext.Margins.Margin2.IsMarkerMargin = true;
            newtext.Margins.Margin2.Width = 16;
            newtext.Name = title;
            newtext.Size = new System.Drawing.Size(783, 353);
            newtext.Styles.BraceBad.FontName = "Verdana";
            newtext.Styles.BraceLight.FontName = "Verdana";
            newtext.Styles.ControlChar.FontName = "Verdana";
            newtext.Styles.Default.FontName = "Verdana";
            newtext.Styles.IndentGuide.FontName = "Verdana";
            newtext.Styles.LastPredefined.FontName = "Verdana";
            newtext.Styles.LineNumber.FontName = "Verdana";
            newtext.Styles.Max.FontName = "Verdana";
            newtext.TabIndex = 0;
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
        }

        private void aboutNotepadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private void updateNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\updater\Sharp-Updater.exe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LANGUAGES!
        //private string texter(string texter)
        //{
            
        //}
        private void adaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "ada";
            newtext.Refresh();
        }

        private void aSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "asm";
            newtext.Refresh();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "batch";
            newtext.Refresh();
        }

        private void blizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "blitsbasic";
            newtext.Refresh();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "cs";
            newtext.Refresh();
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "cpp";
            newtext.Refresh();
        }

        private void camToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "caml";
            newtext.Refresh();
        }

        private void cmakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "cmake";
            newtext.Refresh();
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "css";
            newtext.Refresh();
        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "d";
            newtext.Refresh();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "diff";
            newtext.Refresh();
        }

        private void fortanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "fortran";
            newtext.Refresh();
        }

        private void gAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "gap";
            newtext.Refresh();
        }

        private void gui4CliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "gui4cli";
            newtext.Refresh();
        }

        private void haskellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "haskell";
            newtext.Refresh();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "hypertext";
            newtext.Refresh();
        }

        private void iNNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "innosetup";
            newtext.Refresh();
        }

        private void javascriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "js";
            newtext.Refresh();
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.CustomLocation = Environment.CurrentDirectory + @"\cfg\cx.xml";
            newtext.ConfigurationManager.Language = "java";
            newtext.Refresh();
        }

        private void kIXTartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "kix";
            newtext.Refresh();
        }

        private void lISPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "lisp";
            newtext.Refresh();
        }

        private void lunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "lua";
            newtext.Refresh();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "make";
            newtext.Refresh();
        }

        private void matLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "matlab";
            newtext.Refresh();
        }

        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "";
            newtext.Refresh();
        }

        private void nSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "nsis";
            newtext.Refresh();
        }

        private void octaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "octave";
            newtext.Refresh();
        }

        private void pascalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "pascal";
            newtext.Refresh();
        }

        private void perlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "perl";
            newtext.Refresh();
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "hypertext";
            newtext.Refresh();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "python";
            newtext.Refresh();
        }

        private void rubyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "ruby";
            newtext.Refresh();
        }

        private void smalltalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "smalltalk";
            newtext.Refresh();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "sql";
            newtext.Refresh();
        }

        private void tCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "tcl";
            newtext.Refresh();
        }

        private void teXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "tex";
            newtext.Refresh();
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "vb";
            newtext.Refresh();
        }

        private void verilogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "verilog";
            newtext.Refresh();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "xml";
            newtext.Refresh();
        }

        private void yAMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newtext.ConfigurationManager.Language = "yaml";
            newtext.Refresh();
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
                newtext.Text = data;
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
            File.WriteAllText(this.saveFileDialog1.FileName, this.newtext.Text);

            this.Text = "Notepad# - " + this.saveFileDialog1.FileName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = this.Read(this.openFileDialog1.FileName);
                newtext.Text = data;
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

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.newtext.Selection.Text);
            this.newtext.Selection.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.newtext.Selection.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pasted = System.Windows.Forms.Clipboard.GetText();
            this.newtext.InsertText(pasted);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.newtext.Selection.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.newtext.Selection.SelectAll();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.newtext.Selection.Text);
            this.newtext.Selection.Clear();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.newtext.Selection.Text);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string pasted = System.Windows.Forms.Clipboard.GetText();
            this.newtext.InsertText(pasted);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.newtext.Selection.Clear();
        }

        private void donateDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=86XKATDATCJRW&lc=US&item_name=AnthonyL&item_number=123&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.anthony-lomeli.co.cc/notepad");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.newtext.UndoRedo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.newtext.UndoRedo.Redo();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            string newtextt = title;
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            newtext.AllowDrop = true;
            newtext.AutoComplete.DropRestOfWord = true;
            newtext.AutoComplete.ListString = "";
            newtext.Dock = System.Windows.Forms.DockStyle.Fill;
            newtext.Folding.UseCompactFolding = true;
            newtext.Location = new System.Drawing.Point(3, 3);
            newtext.Margins.Margin0.Width = 20;
            newtext.Margins.Margin1.IsClickable = true;
            newtext.Margins.Margin1.IsFoldMargin = true;
            newtext.Margins.Margin1.Width = 3;
            newtext.Margins.Margin2.IsMarkerMargin = true;
            newtext.Margins.Margin2.Width = 16;
            newtext.Name = title;
            newtext.Size = new System.Drawing.Size(783, 353);
            newtext.Styles.BraceBad.FontName = "Verdana";
            newtext.Styles.BraceLight.FontName = "Verdana";
            newtext.Styles.ControlChar.FontName = "Verdana";
            newtext.Styles.Default.FontName = "Verdana";
            newtext.Styles.IndentGuide.FontName = "Verdana";
            newtext.Styles.LastPredefined.FontName = "Verdana";
            newtext.Styles.LineNumber.FontName = "Verdana";
            newtext.Styles.Max.FontName = "Verdana";
            newtext.TabIndex = 0;
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = this.Read(this.openFileDialog1.FileName);
                newtext.Text = data;
                this.Text = "Notepad# - " + this.openFileDialog1.SafeFileName;
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            if (tabControl1.TabCount < 1)
            {
                string title = "New" + (tabControl1.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
                myTabPage.Controls.Add(newtext);
                newtext.AllowDrop = true;
                newtext.AutoComplete.DropRestOfWord = true;
                newtext.AutoComplete.ListString = "";
                newtext.Dock = System.Windows.Forms.DockStyle.Fill;
                newtext.Folding.UseCompactFolding = true;
                newtext.Location = new System.Drawing.Point(3, 3);
                newtext.Margins.Margin0.Width = 20;
                newtext.Margins.Margin1.IsClickable = true;
                newtext.Margins.Margin1.IsFoldMargin = true;
                newtext.Margins.Margin1.Width = 3;
                newtext.Margins.Margin2.IsMarkerMargin = true;
                newtext.Margins.Margin2.Width = 16;
                newtext.Name = title;
                newtext.Size = new System.Drawing.Size(783, 353);
                newtext.Styles.BraceBad.FontName = "Verdana";
                newtext.Styles.BraceLight.FontName = "Verdana";
                newtext.Styles.ControlChar.FontName = "Verdana";
                newtext.Styles.Default.FontName = "Verdana";
                newtext.Styles.IndentGuide.FontName = "Verdana";
                newtext.Styles.LastPredefined.FontName = "Verdana";
                newtext.Styles.LineNumber.FontName = "Verdana";
                newtext.Styles.Max.FontName = "Verdana";
                newtext.TabIndex = 0;
                tabControl1.TabPages.Add(myTabPage);
                tabControl1.SelectedTab = myTabPage;
            }
            else if (tabControl1.TabCount >= 1) { }
        }

    }
}
