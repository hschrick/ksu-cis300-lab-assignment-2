﻿namespace Ksu.Cis300.Lab2
{
    partial class TextEditor
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
            this.uxMenu = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenu
            // 
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(476, 24);
            this.uxMenu.TabIndex = 0;
            this.uxMenu.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSaveAs});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(152, 22);
            this.uxOpen.Text = "Open";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSaveAs
            // 
            this.uxSaveAs.Name = "uxSaveAs";
            this.uxSaveAs.Size = new System.Drawing.Size(152, 22);
            this.uxSaveAs.Text = "Save As";
            this.uxSaveAs.Click += new System.EventHandler(this.uxSaveAs_Click);
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(0, 27);
            this.uxTextBox.Multiline = true;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(476, 442);
            this.uxTextBox.TabIndex = 1;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 467);
            this.Controls.Add(this.uxTextBox);
            this.Controls.Add(this.uxMenu);
            this.MainMenuStrip = this.uxMenu;
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.uxMenu.ResumeLayout(false);
            this.uxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}

