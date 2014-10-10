namespace Esim_7_1 {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LinksLabel = new System.Windows.Forms.Label();
            this.GeneralInfoLinklabel = new System.Windows.Forms.LinkLabel();
            this.VAMLinklabel = new System.Windows.Forms.LinkLabel();
            this.OtherLinks = new System.Windows.Forms.Label();
            this.YleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BeachBallLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LinksLabel
            // 
            this.LinksLabel.AutoSize = true;
            this.LinksLabel.Location = new System.Drawing.Point(13, 13);
            this.LinksLabel.Name = "LinksLabel";
            this.LinksLabel.Size = new System.Drawing.Size(69, 13);
            this.LinksLabel.TabIndex = 0;
            this.LinksLabel.Text = "Linkkiluettelo";
            // 
            // GeneralInfoLinklabel
            // 
            this.GeneralInfoLinklabel.AutoSize = true;
            this.GeneralInfoLinklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.GeneralInfoLinklabel.Location = new System.Drawing.Point(30, 26);
            this.GeneralInfoLinklabel.Name = "GeneralInfoLinklabel";
            this.GeneralInfoLinklabel.Size = new System.Drawing.Size(310, 13);
            this.GeneralInfoLinklabel.TabIndex = 1;
            this.GeneralInfoLinklabel.TabStop = true;
            this.GeneralInfoLinklabel.Text = "Tämä osoite tarjoaa tietoa Suomesta. Vaasasta saat tietoa tästä.";
            this.GeneralInfoLinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GeneralInfoLinklabel_LinkClicked);
            // 
            // VAMLinklabel
            // 
            this.VAMLinklabel.AutoSize = true;
            this.VAMLinklabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.VAMLinklabel.Location = new System.Drawing.Point(30, 39);
            this.VAMLinklabel.Name = "VAMLinklabel";
            this.VAMLinklabel.Size = new System.Drawing.Size(233, 13);
            this.VAMLinklabel.TabIndex = 2;
            this.VAMLinklabel.TabStop = true;
            this.VAMLinklabel.Text = "Vaasan ammattikorkeakoulu sijaitsee Vaasassa.";
            this.VAMLinklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VAMLinklabel_LinkClicked);
            // 
            // OtherLinks
            // 
            this.OtherLinks.AutoSize = true;
            this.OtherLinks.Location = new System.Drawing.Point(13, 79);
            this.OtherLinks.Name = "OtherLinks";
            this.OtherLinks.Size = new System.Drawing.Size(72, 13);
            this.OtherLinks.TabIndex = 3;
            this.OtherLinks.Text = "Muita linkkejä";
            // 
            // YleLinkLabel
            // 
            this.YleLinkLabel.AutoSize = true;
            this.YleLinkLabel.Location = new System.Drawing.Point(30, 92);
            this.YleLinkLabel.Name = "YleLinkLabel";
            this.YleLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.YleLinkLabel.TabIndex = 4;
            this.YleLinkLabel.TabStop = true;
            this.YleLinkLabel.Text = "www.yle.fi";
            this.YleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YleLinkLabel_LinkClicked);
            // 
            // BeachBallLinkLabel
            // 
            this.BeachBallLinkLabel.AutoSize = true;
            this.BeachBallLinkLabel.Location = new System.Drawing.Point(30, 105);
            this.BeachBallLinkLabel.Name = "BeachBallLinkLabel";
            this.BeachBallLinkLabel.Size = new System.Drawing.Size(88, 13);
            this.BeachBallLinkLabel.TabIndex = 5;
            this.BeachBallLinkLabel.TabStop = true;
            this.BeachBallLinkLabel.Text = "www.rantapallo.fi";
            this.BeachBallLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BeachBallLinkLabel_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.BeachBallLinkLabel);
            this.Controls.Add(this.YleLinkLabel);
            this.Controls.Add(this.OtherLinks);
            this.Controls.Add(this.VAMLinklabel);
            this.Controls.Add(this.GeneralInfoLinklabel);
            this.Controls.Add(this.LinksLabel);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LinksLabel;
        private System.Windows.Forms.LinkLabel GeneralInfoLinklabel;
        private System.Windows.Forms.LinkLabel VAMLinklabel;
        private System.Windows.Forms.Label OtherLinks;
        private System.Windows.Forms.LinkLabel YleLinkLabel;
        private System.Windows.Forms.LinkLabel BeachBallLinkLabel;
    }
}

