﻿namespace Application_layer
{
    partial class AddCategory
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
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.CategoryPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCategoryButton.Location = new System.Drawing.Point(115, 265);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(130, 23);
            this.AddCategoryButton.TabIndex = 15;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(56, 178);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 14;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // CategoryPictureBox
            // 
            this.CategoryPictureBox.Location = new System.Drawing.Point(170, 149);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(146, 102);
            this.CategoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CategoryPictureBox.TabIndex = 13;
            this.CategoryPictureBox.TabStop = false;
            // 
            // CategoryDescriptionRBox
            // 
            this.CategoryDescriptionRBox.Location = new System.Drawing.Point(170, 70);
            this.CategoryDescriptionRBox.Name = "CategoryDescriptionRBox";
            this.CategoryDescriptionRBox.Size = new System.Drawing.Size(146, 73);
            this.CategoryDescriptionRBox.TabIndex = 12;
            this.CategoryDescriptionRBox.Text = "";
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(170, 44);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(146, 20);
            this.CategoryNameBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category Picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category Name";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 331);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.CategoryPictureBox);
            this.Controls.Add(this.CategoryDescriptionRBox);
            this.Controls.Add(this.CategoryNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.PictureBox CategoryPictureBox;
        private System.Windows.Forms.RichTextBox CategoryDescriptionRBox;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}