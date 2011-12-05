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
        Scintilla newtext = new Scintilla();
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "New " + (tabControl1.TabCount + 1).ToString();
            string newtextt = title;
            TabPage myTabPage = new TabPage(title);
            myTabPage.Controls.Add(newtext);
            myTabPage.Tag = "1";
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
            string title = "New " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            myTabPage.Tag = "1";
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
        //Some languages are so similar, it's easier to use the same lexer than make a custome one. Anyone who wants to make one for me just for a

        private void adaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "ada";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void aSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "asm";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "batch";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void blizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "blitsbasic";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "cs";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "cpp";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void camToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "caml";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void cmakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "cmake";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "css";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void dToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "d";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void diffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "diff";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void fortanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "fortran";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void gAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "gap";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void gui4CliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "gui4cli";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void haskellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "haskell";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "html";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void iNNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "inno";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void javascriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "js";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.CustomLocation = @"cfg\cx.xml";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "cs";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void kIXTartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "kix";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void lISPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "lisp";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void lunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "lua";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void makeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "make";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void matLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "matlab";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void normalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void nSISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "nsis";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void octaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "octave";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void pascalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "pascal";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void perlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "perl";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "html";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "python";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void rubyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "ruby";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void smalltalkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "smalltalk";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "sql";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void tCLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "tcl";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void teXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "tex";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "vb";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void verilogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "verilog";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "xml";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void yAMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).ConfigurationManager.Language = "yaml";
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Refresh();
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
                ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text = data;
                tabControl1.SelectedTab.Text = this.openFileDialog1.SafeFileName;
                tabControl1.SelectedTab.Tag = this.openFileDialog1.FileName;
                this.Text = "Notepad# - " + this.openFileDialog1.FileName;
                this.openFileDialog1.FileName = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Text == "Notepad#")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text == "Notepad# - ")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text != "Notepad#")
            {
                File.WriteAllText(tabControl1.SelectedTab.Tag.ToString(), ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(this.saveFileDialog1.FileName, ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text);

            this.Text = "Notepad# - " + this.saveFileDialog1.FileName;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string data = this.Read(this.openFileDialog1.FileName);
                ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text = data;
                tabControl1.SelectedTab.Text = this.openFileDialog1.SafeFileName;
                tabControl1.SelectedTab.Tag = this.openFileDialog1.FileName;
                this.Text = "Notepad# - " + this.openFileDialog1.FileName;
                this.openFileDialog1.FileName = "";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.Text == "Notepad#")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text == "Notepad# - ")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text != "Notepad#")
            {
                File.WriteAllText(tabControl1.SelectedTab.Tag.ToString(), ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Text);
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pasted = System.Windows.Forms.Clipboard.GetText();
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).InsertText(pasted);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Clear();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.SelectAll();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Text);
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Clear();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.newtext.Selection.Text);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string pasted = System.Windows.Forms.Clipboard.GetText();
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).InsertText(pasted);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).Selection.Clear();
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
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).UndoRedo.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).UndoRedo.Redo();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string title = "New" + (tabControl1.TabCount + 1).ToString();
            string newtextt = title;
            TabPage myTabPage = new TabPage(title);
            ScintillaNet.Scintilla newtext = new ScintillaNet.Scintilla();
            myTabPage.Controls.Add(newtext);
            myTabPage.Tag = "1";
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
                ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text = data;
                tabControl1.SelectedTab.Text = this.openFileDialog1.SafeFileName;
                tabControl1.SelectedTab.Tag = this.openFileDialog1.FileName;
                this.Text = "Notepad# - " + this.openFileDialog1.FileName;
                this.openFileDialog1.FileName = "";
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.Text == "Notepad#")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text == "Notepad# - ")
            {
                this.saveFileDialog1.ShowDialog();
            }
            else if (this.Text != "Notepad#")
            {
                File.WriteAllText(tabControl1.SelectedTab.Tag.ToString(), ((Scintilla)tabControl1.SelectedTab.Controls[0]).Text);
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string title = "New " + (tabControl1.TabCount).ToString();
            string newtextt = title;
            tabControl1.SelectedTab.Controls.Add(newtext);
            tabControl1.SelectedTab.Text = title;
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
            openFileDialog1.FileName = "";
        }

        private void closeAllButAcitveDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.Name != tabControl1.SelectedTab.Name)
            {
                tabControl1.TabPages.Clear();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.TabCount < 1)
            {
                
            }
            else
            {
                this.Text = "Notepad# - " + tabControl1.SelectedTab.Tag;
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).FindReplace.ShowFind();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            ((Scintilla)tabControl1.SelectedTab.Controls[0]).FindReplace.ShowFind();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Size.Width - 805;
            int h = this.Size.Height - 503;
            int neww = 797 + w;
            int newh = 392 + h;
            tabControl1.Size = new Size(neww, newh);
            this.Refresh();
        }
        /*
        private void newtext_CharAdded(object sender, ScintillaNet.CharAddedEventArgs e)
        {
            string autoc = Environment.CurrentDirectory + @"\autoc.xml";
            newtext.AutoComplete.List = @"\autoc.xml";
            newtext.AutoComplete.Show();
            newtext.AutoComplete.AutoHide = true;
        }*/
    }
}
