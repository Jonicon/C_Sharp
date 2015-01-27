namespace Security_company {
    partial class AddVehicleForm {
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
            this.textBox_AddVehicleID = new System.Windows.Forms.TextBox();
            this.textBox_AddVehiclePlate = new System.Windows.Forms.TextBox();
            this.textBox_AddVehDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddVehicleOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle ID";
            // 
            // textBox_AddVehicleID
            // 
            this.textBox_AddVehicleID.Location = new System.Drawing.Point(95, 10);
            this.textBox_AddVehicleID.Name = "textBox_AddVehicleID";
            this.textBox_AddVehicleID.Size = new System.Drawing.Size(177, 20);
            this.textBox_AddVehicleID.TabIndex = 1;
            // 
            // textBox_AddVehiclePlate
            // 
            this.textBox_AddVehiclePlate.Location = new System.Drawing.Point(95, 37);
            this.textBox_AddVehiclePlate.Name = "textBox_AddVehiclePlate";
            this.textBox_AddVehiclePlate.Size = new System.Drawing.Size(177, 20);
            this.textBox_AddVehiclePlate.TabIndex = 2;
            // 
            // textBox_AddVehDesc
            // 
            this.textBox_AddVehDesc.Location = new System.Drawing.Point(95, 64);
            this.textBox_AddVehDesc.Name = "textBox_AddVehDesc";
            this.textBox_AddVehDesc.Size = new System.Drawing.Size(177, 20);
            this.textBox_AddVehDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plate number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // button_AddVehicleOk
            // 
            this.button_AddVehicleOk.Location = new System.Drawing.Point(13, 98);
            this.button_AddVehicleOk.Name = "button_AddVehicleOk";
            this.button_AddVehicleOk.Size = new System.Drawing.Size(153, 23);
            this.button_AddVehicleOk.TabIndex = 6;
            this.button_AddVehicleOk.Text = "Add Vehicle";
            this.button_AddVehicleOk.UseVisualStyleBackColor = true;
            this.button_AddVehicleOk.Click += new System.EventHandler(this.button_AddVehicleOk_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.button_AddVehicleOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_AddVehDesc);
            this.Controls.Add(this.textBox_AddVehiclePlate);
            this.Controls.Add(this.textBox_AddVehicleID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddVehicleForm";
            this.Text = "AddVehicleForm";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AddVehicleID;
        private System.Windows.Forms.TextBox textBox_AddVehiclePlate;
        private System.Windows.Forms.TextBox textBox_AddVehDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddVehicleOk;
    }
}