namespace ColouredTextForDota2
{
    partial class frmAbout
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAttribution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picSteam = new System.Windows.Forms.PictureBox();
            this.picReddit = new System.Windows.Forms.PictureBox();
            this.picGitHub = new System.Windows.Forms.PictureBox();
            this.btnSourceCode = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReddit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(326, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chat Colors for Dota 2";
            // 
            // lblAttribution
            // 
            this.lblAttribution.AutoSize = true;
            this.lblAttribution.Location = new System.Drawing.Point(79, 181);
            this.lblAttribution.Name = "lblAttribution";
            this.lblAttribution.Size = new System.Drawing.Size(201, 13);
            this.lblAttribution.TabIndex = 1;
            this.lblAttribution.Text = "Dota is a trademark of Valve Corporation.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "by Erik Humphrey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "based off of Colorful Dota 2 by Summ";
            // 
            // picSteam
            // 
            this.picSteam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSteam.Image = global::ColouredTextForDota2.Properties.Resources.steamIcon;
            this.picSteam.Location = new System.Drawing.Point(202, 94);
            this.picSteam.Name = "picSteam";
            this.picSteam.Size = new System.Drawing.Size(49, 40);
            this.picSteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSteam.TabIndex = 6;
            this.picSteam.TabStop = false;
            this.picSteam.Click += new System.EventHandler(this.picSteam_Click);
            // 
            // picReddit
            // 
            this.picReddit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReddit.Image = global::ColouredTextForDota2.Properties.Resources.snoo;
            this.picReddit.Location = new System.Drawing.Point(152, 94);
            this.picReddit.Name = "picReddit";
            this.picReddit.Size = new System.Drawing.Size(50, 40);
            this.picReddit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReddit.TabIndex = 5;
            this.picReddit.TabStop = false;
            this.picReddit.Click += new System.EventHandler(this.picReddit_Click);
            // 
            // picGitHub
            // 
            this.picGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGitHub.Image = global::ColouredTextForDota2.Properties.Resources.Github;
            this.picGitHub.Location = new System.Drawing.Point(112, 93);
            this.picGitHub.Name = "picGitHub";
            this.picGitHub.Size = new System.Drawing.Size(39, 41);
            this.picGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGitHub.TabIndex = 4;
            this.picGitHub.TabStop = false;
            this.picGitHub.Click += new System.EventHandler(this.picGitHub_Click);
            // 
            // btnSourceCode
            // 
            this.btnSourceCode.Location = new System.Drawing.Point(67, 148);
            this.btnSourceCode.Name = "btnSourceCode";
            this.btnSourceCode.Size = new System.Drawing.Size(91, 23);
            this.btnSourceCode.TabIndex = 7;
            this.btnSourceCode.Text = "Source code";
            this.btnSourceCode.UseVisualStyleBackColor = true;
            this.btnSourceCode.Click += new System.EventHandler(this.btnSourceCode_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(164, 148);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(116, 23);
            this.btnDonate.TabIndex = 8;
            this.btnDonate.Text = "Donate via PayPal";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 205);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnSourceCode);
            this.Controls.Add(this.picSteam);
            this.Controls.Add(this.picReddit);
            this.Controls.Add(this.picGitHub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttribution);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About Chat Colors for Dota 2";
            ((System.ComponentModel.ISupportInitialize)(this.picSteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReddit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAttribution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picGitHub;
        private System.Windows.Forms.PictureBox picReddit;
        private System.Windows.Forms.PictureBox picSteam;
        private System.Windows.Forms.Button btnSourceCode;
        private System.Windows.Forms.Button btnDonate;
    }
}