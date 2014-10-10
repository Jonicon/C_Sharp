namespace T_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewEmplyeeLabel = new System.Windows.Forms.Label();
            this.NewEmployeeTextBox1 = new System.Windows.Forms.TextBox();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.NewEmployeeFlagLabel = new System.Windows.Forms.Label();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.ChosenEmployeesCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siirrä >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Työntekijät";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valitut työntekijät";
            // 
            // NewEmplyeeLabel
            // 
            this.NewEmplyeeLabel.AutoSize = true;
            this.NewEmplyeeLabel.Location = new System.Drawing.Point(15, 127);
            this.NewEmplyeeLabel.Name = "NewEmplyeeLabel";
            this.NewEmplyeeLabel.Size = new System.Drawing.Size(80, 13);
            this.NewEmplyeeLabel.TabIndex = 5;
            this.NewEmplyeeLabel.Text = "Uusi Työntekijä";
            // 
            // NewEmployeeTextBox1
            // 
            this.NewEmployeeTextBox1.Location = new System.Drawing.Point(12, 144);
            this.NewEmployeeTextBox1.Name = "NewEmployeeTextBox1";
            this.NewEmployeeTextBox1.Size = new System.Drawing.Size(154, 20);
            this.NewEmployeeTextBox1.TabIndex = 6;
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Location = new System.Drawing.Point(176, 141);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.NewEmployeeButton.TabIndex = 7;
            this.NewEmployeeButton.Text = "Lisää";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // NewEmployeeFlagLabel
            // 
            this.NewEmployeeFlagLabel.AutoSize = true;
            this.NewEmployeeFlagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmployeeFlagLabel.Location = new System.Drawing.Point(12, 167);
            this.NewEmployeeFlagLabel.Name = "NewEmployeeFlagLabel";
            this.NewEmployeeFlagLabel.Size = new System.Drawing.Size(41, 13);
            this.NewEmployeeFlagLabel.TabIndex = 8;
            this.NewEmployeeFlagLabel.Text = "label3";
            this.NewEmployeeFlagLabel.Visible = false;
            this.NewEmployeeFlagLabel.Click += new System.EventHandler(this.NewEmployeeFlagLabel_Click);
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.Location = new System.Drawing.Point(12, 25);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(154, 21);
            this.EmployeesComboBox.TabIndex = 9;
            // 
            // ChosenEmployeesCheckBox
            // 
            this.ChosenEmployeesCheckBox.FormattingEnabled = true;
            this.ChosenEmployeesCheckBox.Location = new System.Drawing.Point(258, 26);
            this.ChosenEmployeesCheckBox.Name = "ChosenEmployeesCheckBox";
            this.ChosenEmployeesCheckBox.Size = new System.Drawing.Size(154, 139);
            this.ChosenEmployeesCheckBox.TabIndex = 11;
            this.ChosenEmployeesCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChosenEmployeesCheckBox_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 189);
            this.Controls.Add(this.ChosenEmployeesCheckBox);
            this.Controls.Add(this.EmployeesComboBox);
            this.Controls.Add(this.NewEmployeeFlagLabel);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.NewEmployeeTextBox1);
            this.Controls.Add(this.NewEmplyeeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "T_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NewEmplyeeLabel;
        private System.Windows.Forms.TextBox NewEmployeeTextBox1;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.Label NewEmployeeFlagLabel;
        private System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.CheckedListBox ChosenEmployeesCheckBox;
    }
}

