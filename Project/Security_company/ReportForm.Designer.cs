namespace Security_company {
    partial class ReportForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_RepOfficers = new System.Windows.Forms.TextBox();
            this.textBox_RepVehicles = new System.Windows.Forms.TextBox();
            this.textBox_RepCustomers = new System.Windows.Forms.TextBox();
            this.textBox_RepTargets = new System.Windows.Forms.TextBox();
            this.textBox_RepTagsPerDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Officers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Targets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Average tags per day:";
            // 
            // textBox_RepOfficers
            // 
            this.textBox_RepOfficers.Location = new System.Drawing.Point(64, 10);
            this.textBox_RepOfficers.Name = "textBox_RepOfficers";
            this.textBox_RepOfficers.ReadOnly = true;
            this.textBox_RepOfficers.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepOfficers.TabIndex = 5;
            // 
            // textBox_RepVehicles
            // 
            this.textBox_RepVehicles.Location = new System.Drawing.Point(278, 10);
            this.textBox_RepVehicles.Name = "textBox_RepVehicles";
            this.textBox_RepVehicles.ReadOnly = true;
            this.textBox_RepVehicles.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepVehicles.TabIndex = 6;
            // 
            // textBox_RepCustomers
            // 
            this.textBox_RepCustomers.Location = new System.Drawing.Point(74, 182);
            this.textBox_RepCustomers.Name = "textBox_RepCustomers";
            this.textBox_RepCustomers.ReadOnly = true;
            this.textBox_RepCustomers.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepCustomers.TabIndex = 7;
            // 
            // textBox_RepTargets
            // 
            this.textBox_RepTargets.Location = new System.Drawing.Point(277, 182);
            this.textBox_RepTargets.Name = "textBox_RepTargets";
            this.textBox_RepTargets.ReadOnly = true;
            this.textBox_RepTargets.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepTargets.TabIndex = 8;
            // 
            // textBox_RepTagsPerDay
            // 
            this.textBox_RepTagsPerDay.Location = new System.Drawing.Point(132, 352);
            this.textBox_RepTagsPerDay.Name = "textBox_RepTagsPerDay";
            this.textBox_RepTagsPerDay.ReadOnly = true;
            this.textBox_RepTagsPerDay.Size = new System.Drawing.Size(100, 20);
            this.textBox_RepTagsPerDay.TabIndex = 9;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 528);
            this.Controls.Add(this.textBox_RepTagsPerDay);
            this.Controls.Add(this.textBox_RepTargets);
            this.Controls.Add(this.textBox_RepCustomers);
            this.Controls.Add(this.textBox_RepVehicles);
            this.Controls.Add(this.textBox_RepOfficers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_RepOfficers;
        private System.Windows.Forms.TextBox textBox_RepVehicles;
        private System.Windows.Forms.TextBox textBox_RepCustomers;
        private System.Windows.Forms.TextBox textBox_RepTargets;
        private System.Windows.Forms.TextBox textBox_RepTagsPerDay;
    }
}