﻿namespace NotepadSharp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.linkLabel1 = new System.Windows.Forms.LinkLabel();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
        	this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.textBox1.Location = new System.Drawing.Point(6, 19);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.ReadOnly = true;
        	this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.textBox1.Size = new System.Drawing.Size(388, 132);
        	this.textBox1.TabIndex = 0;
        	this.textBox1.Text = resources.GetString("textBox1.Text");
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(233, 79);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(79, 13);
        	this.label5.TabIndex = 14;
        	this.label5.Text = "Anthony Lomeli";
        	// 
        	// linkLabel1
        	// 
        	this.linkLabel1.AutoSize = true;
        	this.linkLabel1.Location = new System.Drawing.Point(233, 105);
        	this.linkLabel1.Name = "linkLabel1";
        	this.linkLabel1.Size = new System.Drawing.Size(179, 13);
        	this.linkLabel1.TabIndex = 13;
        	this.linkLabel1.TabStop = true;
        	this.linkLabel1.Text = "http://anthony-lomeli.co.cc/notepad";
        	this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(150, 105);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(62, 13);
        	this.label4.TabIndex = 12;
        	this.label4.Text = "Homepage:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(150, 79);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(41, 13);
        	this.label3.TabIndex = 11;
        	this.label3.Text = "Author:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(150, 36);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(262, 26);
        	this.label2.TabIndex = 9;
        	this.label2.Text = "An attempt to remake Notepad++\'s basic features, like\r\ncode folding and highlight" +
        	"ing, in C#";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(150, 12);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(73, 13);
        	this.label1.TabIndex = 8;
        	this.label1.Text = "Notepad# 1.0";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.textBox1);
        	this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.groupBox1.Location = new System.Drawing.Point(12, 144);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(400, 161);
        	this.groupBox1.TabIndex = 16;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "GNU General Public Licence";
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(173, 311);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 17;
        	this.button1.Text = "Ok";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(254, 311);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 18;
        	this.button2.Text = "More Info";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.textBox2);
        	this.groupBox2.Location = new System.Drawing.Point(418, 12);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(467, 293);
        	this.groupBox2.TabIndex = 19;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "More stuff you might wanna know...";
        	// 
        	// textBox2
        	// 
        	this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
        	this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textBox2.Location = new System.Drawing.Point(3, 16);
        	this.textBox2.Multiline = true;
        	this.textBox2.Name = "textBox2";
        	this.textBox2.ReadOnly = true;
        	this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.textBox2.Size = new System.Drawing.Size(461, 274);
        	this.textBox2.TabIndex = 1;
        	this.textBox2.Text = resources.GetString("textBox2.Text");
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = global::NotepadSharp.Properties.Resources.notepad;
        	this.pictureBox1.Location = new System.Drawing.Point(12, 12);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(132, 126);
        	this.pictureBox1.TabIndex = 10;
        	this.pictureBox1.TabStop = false;
        	// 
        	// Form2
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(416, 342);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.linkLabel1);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.MaximizeBox = false;
        	this.Name = "Form2";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "About";
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}