﻿
namespace En_decrypter
{
    partial class frmPGP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPGP));
            this.checkRandomFileName = new System.Windows.Forms.CheckBox();
            this.btnFileDec = new System.Windows.Forms.Button();
            this.checkDelFileAU = new System.Windows.Forms.CheckBox();
            this.btnFileEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lblEncTxt = new System.Windows.Forms.Label();
            this.boxEnc = new System.Windows.Forms.TextBox();
            this.lblPlainTxt = new System.Windows.Forms.Label();
            this.boxPlain = new System.Windows.Forms.TextBox();
            this.boxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxPwd = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSwitchKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkRandomFileName
            // 
            this.checkRandomFileName.AutoSize = true;
            this.checkRandomFileName.Location = new System.Drawing.Point(407, 75);
            this.checkRandomFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkRandomFileName.Name = "checkRandomFileName";
            this.checkRandomFileName.Size = new System.Drawing.Size(210, 29);
            this.checkRandomFileName.TabIndex = 29;
            this.checkRandomFileName.Text = "use random file name";
            this.checkRandomFileName.UseVisualStyleBackColor = true;
            // 
            // btnFileDec
            // 
            this.btnFileDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDec.Location = new System.Drawing.Point(542, 152);
            this.btnFileDec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileDec.Name = "btnFileDec";
            this.btnFileDec.Size = new System.Drawing.Size(111, 57);
            this.btnFileDec.TabIndex = 28;
            this.btnFileDec.Text = "verify file";
            this.btnFileDec.UseVisualStyleBackColor = true;
            this.btnFileDec.Click += new System.EventHandler(this.btnFileDec_Click);
            // 
            // checkDelFileAU
            // 
            this.checkDelFileAU.AutoSize = true;
            this.checkDelFileAU.Location = new System.Drawing.Point(407, 113);
            this.checkDelFileAU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkDelFileAU.Name = "checkDelFileAU";
            this.checkDelFileAU.Size = new System.Drawing.Size(187, 29);
            this.checkDelFileAU.TabIndex = 27;
            this.checkDelFileAU.Text = "delete file after use";
            this.checkDelFileAU.UseVisualStyleBackColor = true;
            // 
            // btnFileEnc
            // 
            this.btnFileEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEnc.Location = new System.Drawing.Point(407, 152);
            this.btnFileEnc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileEnc.Name = "btnFileEnc";
            this.btnFileEnc.Size = new System.Drawing.Size(111, 57);
            this.btnFileEnc.TabIndex = 26;
            this.btnFileEnc.Text = "encrypt file";
            this.btnFileEnc.UseVisualStyleBackColor = true;
            this.btnFileEnc.Click += new System.EventHandler(this.btnFileEnc_Click);
            // 
            // btnDec
            // 
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Location = new System.Drawing.Point(206, 152);
            this.btnDec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(111, 57);
            this.btnDec.TabIndex = 25;
            this.btnDec.Text = "verify";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnc.Location = new System.Drawing.Point(31, 152);
            this.btnEnc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(111, 57);
            this.btnEnc.TabIndex = 24;
            this.btnEnc.Text = "encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(31, 232);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 25);
            this.lblResponse.TabIndex = 23;
            // 
            // lblEncTxt
            // 
            this.lblEncTxt.AutoSize = true;
            this.lblEncTxt.Location = new System.Drawing.Point(31, 532);
            this.lblEncTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncTxt.Name = "lblEncTxt";
            this.lblEncTxt.Size = new System.Drawing.Size(130, 25);
            this.lblEncTxt.TabIndex = 20;
            this.lblEncTxt.Text = "Encrypted Text:";
            // 
            // boxEnc
            // 
            this.boxEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxEnc.Location = new System.Drawing.Point(31, 562);
            this.boxEnc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxEnc.Multiline = true;
            this.boxEnc.Name = "boxEnc";
            this.boxEnc.Size = new System.Drawing.Size(720, 212);
            this.boxEnc.TabIndex = 19;
            // 
            // lblPlainTxt
            // 
            this.lblPlainTxt.AutoSize = true;
            this.lblPlainTxt.Location = new System.Drawing.Point(31, 268);
            this.lblPlainTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlainTxt.Name = "lblPlainTxt";
            this.lblPlainTxt.Size = new System.Drawing.Size(88, 25);
            this.lblPlainTxt.TabIndex = 18;
            this.lblPlainTxt.Text = "Plain Text:";
            // 
            // boxPlain
            // 
            this.boxPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPlain.Location = new System.Drawing.Point(31, 298);
            this.boxPlain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxPlain.Multiline = true;
            this.boxPlain.Name = "boxPlain";
            this.boxPlain.Size = new System.Drawing.Size(720, 212);
            this.boxPlain.TabIndex = 17;
            // 
            // boxKey
            // 
            this.boxKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxKey.Location = new System.Drawing.Point(31, 35);
            this.boxKey.Multiline = true;
            this.boxKey.Name = "boxKey";
            this.boxKey.Size = new System.Drawing.Size(286, 46);
            this.boxKey.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Password/ Passphrase";
            // 
            // boxPwd
            // 
            this.boxPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwd.Location = new System.Drawing.Point(31, 113);
            this.boxPwd.Name = "boxPwd";
            this.boxPwd.Size = new System.Drawing.Size(286, 31);
            this.boxPwd.TabIndex = 32;
            // 
            // btnSwitchKey
            // 
            this.btnSwitchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchKey.Location = new System.Drawing.Point(407, 35);
            this.btnSwitchKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitchKey.Name = "btnSwitchKey";
            this.btnSwitchKey.Size = new System.Drawing.Size(210, 38);
            this.btnSwitchKey.TabIndex = 34;
            this.btnSwitchKey.Text = "use private Key";
            this.btnSwitchKey.UseVisualStyleBackColor = true;
            this.btnSwitchKey.Click += new System.EventHandler(this.btnSwitchKey_Click);
            // 
            // frmPGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(789, 812);
            this.Controls.Add(this.btnSwitchKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxKey);
            this.Controls.Add(this.checkRandomFileName);
            this.Controls.Add(this.btnFileDec);
            this.Controls.Add(this.checkDelFileAU);
            this.Controls.Add(this.btnFileEnc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblEncTxt);
            this.Controls.Add(this.boxEnc);
            this.Controls.Add(this.lblPlainTxt);
            this.Controls.Add(this.boxPlain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPGP";
            this.Text = "frmPGP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkRandomFileName;
        private System.Windows.Forms.Button btnFileDec;
        private System.Windows.Forms.CheckBox checkDelFileAU;
        private System.Windows.Forms.Button btnFileEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lblEncTxt;
        private System.Windows.Forms.TextBox boxEnc;
        private System.Windows.Forms.Label lblPlainTxt;
        private System.Windows.Forms.TextBox boxPlain;
        private System.Windows.Forms.TextBox boxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxPwd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSwitchKey;
    }
}