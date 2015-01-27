namespace Security_company {
    partial class Form2Simulation {
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
            this.lb_tagsimList = new System.Windows.Forms.ListBox();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Security_company.DatabaseDataSet();
            this.tagTableAdapter = new Security_company.DatabaseDataSetTableAdapters.TagTableAdapter();
            this.tableAdapterManager = new Security_company.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tagLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagLogTableAdapter = new Security_company.DatabaseDataSetTableAdapters.TagLogTableAdapter();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tagsimOfficerID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tagsimList
            // 
            this.lb_tagsimList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tagBindingSource, "TagID", true));
            this.lb_tagsimList.DataSource = this.tagBindingSource;
            this.lb_tagsimList.DisplayMember = "TargetID";
            this.lb_tagsimList.FormattingEnabled = true;
            this.lb_tagsimList.Location = new System.Drawing.Point(13, 13);
            this.lb_tagsimList.MultiColumn = true;
            this.lb_tagsimList.Name = "lb_tagsimList";
            this.lb_tagsimList.Size = new System.Drawing.Size(247, 264);
            this.lb_tagsimList.TabIndex = 0;
            this.lb_tagsimList.ValueMember = "TagID";
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.TagLogTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = this.tagTableAdapter;
            this.tableAdapterManager.TargetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Security_company.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Info:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.targetIDDataGridViewTextBoxColumn,
            this.officerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tagLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 264);
            this.dataGridView1.TabIndex = 3;
            // 
            // tagLogBindingSource
            // 
            this.tagLogBindingSource.DataMember = "TagLog";
            this.tagLogBindingSource.DataSource = this.databaseDataSet;
            // 
            // tagLogTableAdapter
            // 
            this.tagLogTableAdapter.ClearBeforeFill = true;
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "TagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "TagID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // targetIDDataGridViewTextBoxColumn
            // 
            this.targetIDDataGridViewTextBoxColumn.DataPropertyName = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.HeaderText = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.Name = "targetIDDataGridViewTextBoxColumn";
            // 
            // officerIDDataGridViewTextBoxColumn
            // 
            this.officerIDDataGridViewTextBoxColumn.DataPropertyName = "OfficerID";
            this.officerIDDataGridViewTextBoxColumn.HeaderText = "OfficerID";
            this.officerIDDataGridViewTextBoxColumn.Name = "officerIDDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Officer ID";
            // 
            // tb_tagsimOfficerID
            // 
            this.tb_tagsimOfficerID.Location = new System.Drawing.Point(68, 305);
            this.tb_tagsimOfficerID.Name = "tb_tagsimOfficerID";
            this.tb_tagsimOfficerID.Size = new System.Drawing.Size(100, 20);
            this.tb_tagsimOfficerID.TabIndex = 5;
            // 
            // Form2Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 371);
            this.Controls.Add(this.tb_tagsimOfficerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_tagsimList);
            this.Name = "Form2Simulation";
            this.Text = "Form2Simulation";
            this.Load += new System.EventHandler(this.Form2Simulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_tagsimList;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private DatabaseDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tagLogBindingSource;
        private DatabaseDataSetTableAdapters.TagLogTableAdapter tagLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tagsimOfficerID;
    }
}