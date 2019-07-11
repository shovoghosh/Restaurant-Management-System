namespace Application_layer
{
    partial class AllAdmin
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rMSDataSet1 = new Application_layer.RMSDataSet1();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Application_layer.RMSDataSet1TableAdapters.AdminTableAdapter();
            this.aIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(771, 446);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 33);
            this.button9.TabIndex = 59;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 446);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 33);
            this.button8.TabIndex = 60;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aIdDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.aPasswordDataGridViewTextBoxColumn,
            this.aPhoneDataGridViewTextBoxColumn,
            this.aEmailDataGridViewTextBoxColumn,
            this.aSalDataGridViewTextBoxColumn,
            this.aPictureDataGridViewImageColumn,
            this.Edit,
            this.Delete});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 342);
            this.dataGridView1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Admin List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Search Admin";
            // 
            // rMSDataSet1
            // 
            this.rMSDataSet1.DataSetName = "RMSDataSet1";
            this.rMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.rMSDataSet1;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // aIdDataGridViewTextBoxColumn
            // 
            this.aIdDataGridViewTextBoxColumn.DataPropertyName = "AId";
            this.aIdDataGridViewTextBoxColumn.HeaderText = "AId";
            this.aIdDataGridViewTextBoxColumn.Name = "aIdDataGridViewTextBoxColumn";
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "AName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "AName";
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            // 
            // aPasswordDataGridViewTextBoxColumn
            // 
            this.aPasswordDataGridViewTextBoxColumn.DataPropertyName = "APassword";
            this.aPasswordDataGridViewTextBoxColumn.HeaderText = "APassword";
            this.aPasswordDataGridViewTextBoxColumn.Name = "aPasswordDataGridViewTextBoxColumn";
            // 
            // aPhoneDataGridViewTextBoxColumn
            // 
            this.aPhoneDataGridViewTextBoxColumn.DataPropertyName = "APhone";
            this.aPhoneDataGridViewTextBoxColumn.HeaderText = "APhone";
            this.aPhoneDataGridViewTextBoxColumn.Name = "aPhoneDataGridViewTextBoxColumn";
            // 
            // aEmailDataGridViewTextBoxColumn
            // 
            this.aEmailDataGridViewTextBoxColumn.DataPropertyName = "AEmail";
            this.aEmailDataGridViewTextBoxColumn.HeaderText = "AEmail";
            this.aEmailDataGridViewTextBoxColumn.Name = "aEmailDataGridViewTextBoxColumn";
            // 
            // aSalDataGridViewTextBoxColumn
            // 
            this.aSalDataGridViewTextBoxColumn.DataPropertyName = "ASal";
            this.aSalDataGridViewTextBoxColumn.HeaderText = "ASal";
            this.aSalDataGridViewTextBoxColumn.Name = "aSalDataGridViewTextBoxColumn";
            // 
            // aPictureDataGridViewImageColumn
            // 
            this.aPictureDataGridViewImageColumn.DataPropertyName = "APicture";
            this.aPictureDataGridViewImageColumn.HeaderText = "APicture";
            this.aPictureDataGridViewImageColumn.Name = "aPictureDataGridViewImageColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Width = 80;
            // 
            // AllAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 492);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "AllAdmin";
            this.Text = "AllAdmin";
            this.Load += new System.EventHandler(this.AllAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private RMSDataSet1 rMSDataSet1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private RMSDataSet1TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aPictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}