namespace Security_company {
    partial class AddCustomerForm {
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
            this.textBox_AddCustomerID = new System.Windows.Forms.TextBox();
            this.textBox_AddCustomerName = new System.Windows.Forms.TextBox();
            this.textBox_AddCustomerPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddCustomerOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // textBox_AddCustomerID
            // 
            this.textBox_AddCustomerID.Location = new System.Drawing.Point(102, 10);
            this.textBox_AddCustomerID.Name = "textBox_AddCustomerID";
            this.textBox_AddCustomerID.Size = new System.Drawing.Size(170, 20);
            this.textBox_AddCustomerID.TabIndex = 1;
            // 
            // textBox_AddCustomerName
            // 
            this.textBox_AddCustomerName.Location = new System.Drawing.Point(102, 37);
            this.textBox_AddCustomerName.Name = "textBox_AddCustomerName";
            this.textBox_AddCustomerName.Size = new System.Drawing.Size(170, 20);
            this.textBox_AddCustomerName.TabIndex = 2;
            // 
            // textBox_AddCustomerPhone
            // 
            this.textBox_AddCustomerPhone.Location = new System.Drawing.Point(102, 64);
            this.textBox_AddCustomerPhone.Name = "textBox_AddCustomerPhone";
            this.textBox_AddCustomerPhone.Size = new System.Drawing.Size(170, 20);
            this.textBox_AddCustomerPhone.TabIndex = 3;
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
            // button_AddCustomerOK
            // 
            this.button_AddCustomerOK.Location = new System.Drawing.Point(129, 97);
            this.button_AddCustomerOK.Name = "button_AddCustomerOK";
            this.button_AddCustomerOK.Size = new System.Drawing.Size(143, 23);
            this.button_AddCustomerOK.TabIndex = 6;
            this.button_AddCustomerOK.Text = "Add Customer";
            this.button_AddCustomerOK.UseVisualStyleBackColor = true;
            this.button_AddCustomerOK.Click += new System.EventHandler(this.button_AddCustomerOK_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.button_AddCustomerOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_AddCustomerPhone);
            this.Controls.Add(this.textBox_AddCustomerName);
            this.Controls.Add(this.textBox_AddCustomerID);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AddCustomerID;
        private System.Windows.Forms.TextBox textBox_AddCustomerName;
        private System.Windows.Forms.TextBox textBox_AddCustomerPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddCustomerOK;
    }
}