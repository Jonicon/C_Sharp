namespace T_3 {
    partial class Links {
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
            this.GoogleLinkLabe = new System.Windows.Forms.LinkLabel();
            this.BingLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StackOverFlowLink = new System.Windows.Forms.LinkLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MuropakettiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // GoogleLinkLabe
            // 
            this.GoogleLinkLabe.AutoSize = true;
            this.GoogleLinkLabe.Location = new System.Drawing.Point(12, 17);
            this.GoogleLinkLabe.Name = "GoogleLinkLabe";
            this.GoogleLinkLabe.Size = new System.Drawing.Size(64, 13);
            this.GoogleLinkLabe.TabIndex = 0;
            this.GoogleLinkLabe.TabStop = true;
            this.GoogleLinkLabe.Text = "Google.com";
            this.GoogleLinkLabe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GoogleLinkLabe_LinkClicked);
            // 
            // BingLinkLabel
            // 
            this.BingLinkLabel.AutoSize = true;
            this.BingLinkLabel.Location = new System.Drawing.Point(12, 30);
            this.BingLinkLabel.Name = "BingLinkLabel";
            this.BingLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.BingLinkLabel.TabIndex = 1;
            this.BingLinkLabel.TabStop = true;
            this.BingLinkLabel.Text = "Bing.com";
            this.BingLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // StackOverFlowLink
            // 
            this.StackOverFlowLink.AutoSize = true;
            this.StackOverFlowLink.Location = new System.Drawing.Point(12, 78);
            this.StackOverFlowLink.Name = "StackOverFlowLink";
            this.StackOverFlowLink.Size = new System.Drawing.Size(98, 13);
            this.StackOverFlowLink.TabIndex = 2;
            this.StackOverFlowLink.TabStop = true;
            this.StackOverFlowLink.Text = "Stackoverflow.com";
            this.StackOverFlowLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StackOverFlowLink_LinkClicked);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(289, 521);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 287;
            this.lineShape1.Y1 = 55;
            this.lineShape1.Y2 = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search engines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IT";
            // 
            // MuropakettiLinkLabel
            // 
            this.MuropakettiLinkLabel.AutoSize = true;
            this.MuropakettiLinkLabel.Location = new System.Drawing.Point(12, 91);
            this.MuropakettiLinkLabel.Name = "MuropakettiLinkLabel";
            this.MuropakettiLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.MuropakettiLinkLabel.TabIndex = 6;
            this.MuropakettiLinkLabel.TabStop = true;
            this.MuropakettiLinkLabel.Text = "Muropaketti.com";
            this.MuropakettiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MuropakettiLinkLabel_LinkClicked);
            // 
            // Links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 521);
            this.Controls.Add(this.MuropakettiLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StackOverFlowLink);
            this.Controls.Add(this.BingLinkLabel);
            this.Controls.Add(this.GoogleLinkLabe);
            this.Controls.Add(this.shapeContainer1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Links";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel GoogleLinkLabe;
        private System.Windows.Forms.LinkLabel BingLinkLabel;
        private System.Windows.Forms.LinkLabel StackOverFlowLink;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel MuropakettiLinkLabel;
    }
}

