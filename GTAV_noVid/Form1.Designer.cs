namespace GTAV_noVid
{
    partial class Form1
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
            this.btnPatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.Location = new System.Drawing.Point(497, 12);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(99, 23);
            this.btnPatch.TabIndex = 0;
            this.btnPatch.Text = "Patch GTA5.exe";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "This tool cuts the into video from GTA V. \r\nYou will need to use this tool after " +
    "every patch.  \r\nWarning: This could be considered as a cheat since it edits the " +
    "GTA5.exe";
            // 
            // lblDebug
            // 
            this.lblDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDebug.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDebug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDebug.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDebug.Location = new System.Drawing.Point(103, 50);
            this.lblDebug.Multiline = true;
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.ReadOnly = true;
            this.lblDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblDebug.Size = new System.Drawing.Size(496, 119);
            this.lblDebug.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::GTAV_noVid.Properties.Resources._4;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 175);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 173);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "༼ つ ◕_◕ ༽つ GTAV - No intro video - by Xeramon v0.9.8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblDebug;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

