namespace Employment_center_v2._0
{
    partial class searchformcs
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobDatabaseDataSet = new Employment_center_v2._0.JobDatabaseDataSet();
            this.vacantiondbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacantiondbTableAdapter = new Employment_center_v2._0.JobDatabaseDataSetTableAdapters.vacantiondbTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantiondbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 20);
            this.textBox1.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(489, 48);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.profileDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.requirementsDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.expDataGridViewTextBoxColumn,
            this.graphDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.aboutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vacantiondbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 344);
            this.dataGridView1.TabIndex = 2;
            // 
            // jobDatabaseDataSet
            // 
            this.jobDatabaseDataSet.DataSetName = "JobDatabaseDataSet";
            this.jobDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacantiondbBindingSource
            // 
            this.vacantiondbBindingSource.DataMember = "vacantiondb";
            this.vacantiondbBindingSource.DataSource = this.jobDatabaseDataSet;
            // 
            // vacantiondbTableAdapter
            // 
            this.vacantiondbTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            this.profileDataGridViewTextBoxColumn.DataPropertyName = "profile";
            this.profileDataGridViewTextBoxColumn.HeaderText = "profile";
            this.profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // requirementsDataGridViewTextBoxColumn
            // 
            this.requirementsDataGridViewTextBoxColumn.DataPropertyName = "requirements";
            this.requirementsDataGridViewTextBoxColumn.HeaderText = "requirements";
            this.requirementsDataGridViewTextBoxColumn.Name = "requirementsDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // expDataGridViewTextBoxColumn
            // 
            this.expDataGridViewTextBoxColumn.DataPropertyName = "exp";
            this.expDataGridViewTextBoxColumn.HeaderText = "exp";
            this.expDataGridViewTextBoxColumn.Name = "expDataGridViewTextBoxColumn";
            // 
            // graphDataGridViewTextBoxColumn
            // 
            this.graphDataGridViewTextBoxColumn.DataPropertyName = "graph";
            this.graphDataGridViewTextBoxColumn.HeaderText = "graph";
            this.graphDataGridViewTextBoxColumn.Name = "graphDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // aboutDataGridViewTextBoxColumn
            // 
            this.aboutDataGridViewTextBoxColumn.DataPropertyName = "about";
            this.aboutDataGridViewTextBoxColumn.HeaderText = "about";
            this.aboutDataGridViewTextBoxColumn.Name = "aboutDataGridViewTextBoxColumn";
            // 
            // searchformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.textBox1);
            this.Name = "searchformcs";
            this.Text = "searchformcs";
            this.Load += new System.EventHandler(this.searchformcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacantiondbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JobDatabaseDataSet jobDatabaseDataSet;
        private System.Windows.Forms.BindingSource vacantiondbBindingSource;
        private JobDatabaseDataSetTableAdapters.vacantiondbTableAdapter vacantiondbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requirementsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graphDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutDataGridViewTextBoxColumn;
    }
}