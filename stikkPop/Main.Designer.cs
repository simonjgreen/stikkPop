﻿namespace stikkPop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PasteClipboardButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyLinkButton = new System.Windows.Forms.Button();
            this.syntaxBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.privateCheckBox = new System.Windows.Forms.CheckBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expiryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(173, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Configure";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PasteClipboardButton
            // 
            this.PasteClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PasteClipboardButton.Location = new System.Drawing.Point(72, 12);
            this.PasteClipboardButton.Name = "PasteClipboardButton";
            this.PasteClipboardButton.Size = new System.Drawing.Size(96, 23);
            this.PasteClipboardButton.TabIndex = 1;
            this.PasteClipboardButton.Text = "Paste Clipboard";
            this.PasteClipboardButton.UseVisualStyleBackColor = true;
            this.PasteClipboardButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlBox
            // 
            this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlBox.Location = new System.Drawing.Point(13, 67);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(180, 20);
            this.urlBox.TabIndex = 2;
            this.urlBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasted URL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CopyLinkButton
            // 
            this.CopyLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyLinkButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyLinkButton.Image")));
            this.CopyLinkButton.Location = new System.Drawing.Point(200, 65);
            this.CopyLinkButton.Name = "CopyLinkButton";
            this.CopyLinkButton.Size = new System.Drawing.Size(25, 23);
            this.CopyLinkButton.TabIndex = 4;
            this.CopyLinkButton.UseVisualStyleBackColor = true;
            this.CopyLinkButton.Click += new System.EventHandler(this.CopyLinkButton_Click);
            // 
            // syntaxBox
            // 
            this.syntaxBox.FormattingEnabled = true;
            this.syntaxBox.Location = new System.Drawing.Point(13, 166);
            this.syntaxBox.Name = "syntaxBox";
            this.syntaxBox.Size = new System.Drawing.Size(212, 21);
            this.syntaxBox.TabIndex = 5;
            this.syntaxBox.SelectedIndexChanged += new System.EventHandler(this.syntaxBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Syntax Highlighting";
            // 
            // privateCheckBox
            // 
            this.privateCheckBox.AutoSize = true;
            this.privateCheckBox.Location = new System.Drawing.Point(16, 234);
            this.privateCheckBox.Name = "privateCheckBox";
            this.privateCheckBox.Size = new System.Drawing.Size(59, 17);
            this.privateCheckBox.TabIndex = 7;
            this.privateCheckBox.Text = "Private";
            this.privateCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(13, 117);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(212, 20);
            this.titleBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Expiry (Mins)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // expiryBox
            // 
            this.expiryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expiryBox.FormattingEnabled = true;
            this.expiryBox.Location = new System.Drawing.Point(86, 203);
            this.expiryBox.Name = "expiryBox";
            this.expiryBox.Size = new System.Drawing.Size(139, 21);
            this.expiryBox.TabIndex = 12;
            // 
            // Main
            // 
            this.AcceptButton = this.PasteClipboardButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 265);
            this.Controls.Add(this.expiryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.privateCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.syntaxBox);
            this.Controls.Add(this.CopyLinkButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.PasteClipboardButton);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "stikkPop";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button PasteClipboardButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyLinkButton;
        private System.Windows.Forms.ComboBox syntaxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox privateCheckBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox expiryBox;
    }
}
