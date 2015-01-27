namespace Security_company {
    partial class AddOfficerForm {
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
            this.textBox_AddOfficerId = new System.Windows.Forms.TextBox();
            this.textBox_AddOfficerName = new System.Windows.Forms.TextBox();
            this.textBox_AddOfficerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddOfficer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox_AddOfficerId
            // 
            this.textBox_AddOfficerId.Location = new System.Drawing.Point(54, 10);
            this.textBox_AddOfficerId.Name = "textBox_AddOfficerId";
            this.textBox_AddOfficerId.Size = new System.Drawing.Size(218, 20);
            this.textBox_AddOfficerId.TabIndex = 1;
            // 
            // textBox_AddOfficerName
            // 
            this.textBox_AddOfficerName.Location = new System.Drawing.Point(54, 37);
            this.textBox_AddOfficerName.Name = "textBox_AddOfficerName";
            this.textBox_AddOfficerName.Size = new System.Drawing.Size(218, 20);
            this.textBox_AddOfficerName.TabIndex = 2;
            // 
            // textBox_AddOfficerPhone
            // 
            this.textBox_AddOfficerPhone.Location = new System.Drawing.Point(54, 64);
            this.textBox_AddOfficerPhone.Name = "textBox_AddOfficerPhone";
            this.textBox_AddOfficerPhone.Size = new System.Drawing.Size(218, 20);
            this.textBox_AddOfficerPhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // button_AddOfficer
            // 
            this.button_AddOfficer.Location = new System.Drawing.Point(16, 96);
            this.button_AddOfficer.Name = "button_AddOfficer";
            this.button_AddOfficer.Size = new System.Drawing.Size(256, 23);
            this.button_AddOfficer.TabIndex = 6;
            this.button_AddOfficer.Text = "Add Officer";
            this.button_AddOfficer.UseVisualStyleBackColor = true;
            this.button_AddOfficer.Click += new System.EventHandler(this.button_AddOfficer_Click);
            // 
            // AddOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.button_AddOfficer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_AddOfficerPhone);
            this.Controls.Add(this.textBox_AddOfficerName);
            this.Controls.Add(this.textBox_AddOfficerId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddOfficerForm";
            this.Text = "Add Officer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AddOfficerId;
        private System.Windows.Forms.TextBox textBox_AddOfficerName;
        private System.Windows.Forms.TextBox textBox_AddOfficerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddOfficer;
    }
}