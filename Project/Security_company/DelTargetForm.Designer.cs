namespace Security_company {
    partial class DelTargetForm {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DelTarget = new System.Windows.Forms.ComboBox();
            this.databaseDataSet = new Security_company.DatabaseDataSet();
            this.targetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetTableAdapter = new Security_company.DatabaseDataSetTableAdapters.TargetTableAdapter();
            this.tableAdapterManager = new Security_company.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose which target to remove";
            // 
            // comboBox_DelTarget
            // 
            this.comboBox_DelTarget.DataSource = this.targetBindingSource;
            this.comboBox_DelTarget.DisplayMember = "TargetAddress";
            this.comboBox_DelTarget.FormattingEnabled = true;
            this.comboBox_DelTarget.Location = new System.Drawing.Point(13, 46);
            this.comboBox_DelTarget.Name = "comboBox_DelTarget";
            this.comboBox_DelTarget.Size = new System.Drawing.Size(154, 21);
            this.comboBox_DelTarget.TabIndex = 1;
            this.comboBox_DelTarget.ValueMember = "TargetID";
            this.comboBox_DelTarget.SelectedIndexChanged += new System.EventHandler(this.comboBox_DelTarget_SelectedIndexChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // targetBindingSource
            // 
            this.targetBindingSource.DataMember = "Target";
            this.targetBindingSource.DataSource = this.databaseDataSet;
            // 
            // targetTableAdapter
            // 
            this.targetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.TagLogTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.TargetTableAdapter = this.targetTableAdapter;
            this.tableAdapterManager.UpdateOrder = Security_company.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelTargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 88);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_DelTarget);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DelTargetForm";
            this.Text = "Remove Target";
            this.Load += new System.EventHandler(this.DelTargetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DelTarget;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource targetBindingSource;
        private DatabaseDataSetTableAdapters.TargetTableAdapter targetTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
    }
}