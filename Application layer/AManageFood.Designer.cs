namespace Application_layer
{
    partial class AManageFood
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
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.FEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(769, 447);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(83, 32);
            this.button9.TabIndex = 65;
            this.button9.Text = "Logout";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(12, 447);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 66;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 21);
            this.comboBox1.TabIndex = 70;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FId,
            this.FName,
            this.FCategory,
            this.FDescription,
            this.FImage,
            this.FEdit,
            this.FDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 367);
            this.dataGridView1.TabIndex = 69;
            // 
            // FId
            // 
            this.FId.HeaderText = "Food ID";
            this.FId.Name = "FId";
            // 
            // FName
            // 
            this.FName.HeaderText = "Food Name";
            this.FName.Name = "FName";
            this.FName.Width = 120;
            // 
            // FCategory
            // 
            this.FCategory.HeaderText = "Food Category";
            this.FCategory.Name = "FCategory";
            this.FCategory.Width = 120;
            // 
            // FDescription
            // 
            this.FDescription.HeaderText = "Description";
            this.FDescription.Name = "FDescription";
            this.FDescription.Width = 150;
            // 
            // FImage
            // 
            this.FImage.HeaderText = "Picture";
            this.FImage.Name = "FImage";
            this.FImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FImage.Width = 120;
            // 
            // FEdit
            // 
            this.FEdit.HeaderText = "Edit";
            this.FEdit.Name = "FEdit";
            this.FEdit.Width = 90;
            // 
            // FDelete
            // 
            this.FDelete.HeaderText = "Delete";
            this.FDelete.Name = "FDelete";
            this.FDelete.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Select Category";
            // 
            // AManageFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "AManageFood";
            this.Text = "AManageFood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDescription;
        private System.Windows.Forms.DataGridViewImageColumn FImage;
        private System.Windows.Forms.DataGridViewButtonColumn FEdit;
        private System.Windows.Forms.DataGridViewButtonColumn FDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}