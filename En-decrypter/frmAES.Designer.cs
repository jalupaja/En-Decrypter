﻿
namespace En_decrypter
{
    partial class frmAES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAES));
            this.boxPlain = new System.Windows.Forms.TextBox();
            this.lblPlainTxt = new System.Windows.Forms.Label();
            this.lblEncTxt = new System.Windows.Forms.Label();
            this.boxEnc = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.boxPwd = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnFileEnc = new System.Windows.Forms.Button();
            this.checkDelFileAU = new System.Windows.Forms.CheckBox();
            this.btnFileDec = new System.Windows.Forms.Button();
            this.checkRandomFileName = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // boxPlain
            // 
            this.boxPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPlain.Location = new System.Drawing.Point(22, 179);
            this.boxPlain.Multiline = true;
            this.boxPlain.Name = "boxPlain";
            this.boxPlain.Size = new System.Drawing.Size(505, 129);
            this.boxPlain.TabIndex = 0;
            // 
            // lblPlainTxt
            // 
            this.lblPlainTxt.AutoSize = true;
            this.lblPlainTxt.Location = new System.Drawing.Point(22, 161);
            this.lblPlainTxt.Name = "lblPlainTxt";
            this.lblPlainTxt.Size = new System.Drawing.Size(60, 15);
            this.lblPlainTxt.TabIndex = 1;
            this.lblPlainTxt.Text = "Plain Text:";
            // 
            // lblEncTxt
            // 
            this.lblEncTxt.AutoSize = true;
            this.lblEncTxt.Location = new System.Drawing.Point(22, 319);
            this.lblEncTxt.Name = "lblEncTxt";
            this.lblEncTxt.Size = new System.Drawing.Size(87, 15);
            this.lblEncTxt.TabIndex = 3;
            this.lblEncTxt.Text = "Encrypted Text:";
            // 
            // boxEnc
            // 
            this.boxEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxEnc.Location = new System.Drawing.Point(22, 337);
            this.boxEnc.Multiline = true;
            this.boxEnc.Name = "boxEnc";
            this.boxEnc.Size = new System.Drawing.Size(505, 129);
            this.boxEnc.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(22, 32);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(60, 15);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "Password:";
            // 
            // boxPwd
            // 
            this.boxPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.boxPwd.Location = new System.Drawing.Point(22, 50);
            this.boxPwd.Name = "boxPwd";
            this.boxPwd.Size = new System.Drawing.Size(200, 23);
            this.boxPwd.TabIndex = 4;
            this.boxPwd.TextChanged += new System.EventHandler(this.boxPwd_TextChanged);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(22, 123);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 15);
            this.lblResponse.TabIndex = 6;
            // 
            // btnEnc
            // 
            this.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnc.Location = new System.Drawing.Point(22, 80);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(78, 34);
            this.btnEnc.TabIndex = 7;
            this.btnEnc.Text = "encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // btnDec
            // 
            this.btnDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDec.Location = new System.Drawing.Point(144, 80);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(78, 34);
            this.btnDec.TabIndex = 8;
            this.btnDec.Text = "decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnFileEnc
            // 
            this.btnFileEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileEnc.Location = new System.Drawing.Point(286, 80);
            this.btnFileEnc.Name = "btnFileEnc";
            this.btnFileEnc.Size = new System.Drawing.Size(78, 34);
            this.btnFileEnc.TabIndex = 9;
            this.btnFileEnc.Text = "encrypt file";
            this.btnFileEnc.UseVisualStyleBackColor = true;
            this.btnFileEnc.Click += new System.EventHandler(this.btnFileEnc_Click);
            // 
            // checkDelFileAU
            // 
            this.checkDelFileAU.AutoSize = true;
            this.checkDelFileAU.Location = new System.Drawing.Point(286, 51);
            this.checkDelFileAU.Name = "checkDelFileAU";
            this.checkDelFileAU.Size = new System.Drawing.Size(125, 19);
            this.checkDelFileAU.TabIndex = 14;
            this.checkDelFileAU.Text = "delete file after use";
            this.checkDelFileAU.UseVisualStyleBackColor = true;
            // 
            // btnFileDec
            // 
            this.btnFileDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileDec.Location = new System.Drawing.Point(381, 80);
            this.btnFileDec.Name = "btnFileDec";
            this.btnFileDec.Size = new System.Drawing.Size(78, 34);
            this.btnFileDec.TabIndex = 15;
            this.btnFileDec.Text = "decrypt file";
            this.btnFileDec.UseVisualStyleBackColor = true;
            this.btnFileDec.Click += new System.EventHandler(this.btnFileDec_Click);
            // 
            // checkRandomFileName
            // 
            this.checkRandomFileName.AutoSize = true;
            this.checkRandomFileName.Location = new System.Drawing.Point(286, 28);
            this.checkRandomFileName.Name = "checkRandomFileName";
            this.checkRandomFileName.Size = new System.Drawing.Size(141, 19);
            this.checkRandomFileName.TabIndex = 16;
            this.checkRandomFileName.Text = "use random file name";
            this.checkRandomFileName.UseVisualStyleBackColor = true;
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(552, 487);
            this.Controls.Add(this.checkRandomFileName);
            this.Controls.Add(this.btnFileDec);
            this.Controls.Add(this.checkDelFileAU);
            this.Controls.Add(this.btnFileEnc);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.boxPwd);
            this.Controls.Add(this.lblEncTxt);
            this.Controls.Add(this.boxEnc);
            this.Controls.Add(this.lblPlainTxt);
            this.Controls.Add(this.boxPlain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAES";
            this.Text = "frmAES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxPlain;
        private System.Windows.Forms.Label lblPlainTxt;
        private System.Windows.Forms.Label lblEncTxt;
        private System.Windows.Forms.TextBox boxEnc;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox boxPwd;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnFileEnc;
        private System.Windows.Forms.CheckBox checkDelFileAU;
        private System.Windows.Forms.Button btnFileDec;
        private System.Windows.Forms.CheckBox checkRandomFileName;
    }
}