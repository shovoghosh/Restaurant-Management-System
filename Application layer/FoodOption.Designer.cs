namespace Application_layer
{
    partial class FoodOption
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
            this.ac = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.af = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ac
            // 
            this.ac.Location = new System.Drawing.Point(56, 155);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(171, 54);
            this.ac.TabIndex = 0;
            this.ac.Text = "Add Category";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // uc
            // 
            this.uc.Location = new System.Drawing.Point(180, 243);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(171, 54);
            this.uc.TabIndex = 0;
            this.uc.Text = "Update Category";
            this.uc.UseVisualStyleBackColor = true;
            this.uc.Click += new System.EventHandler(this.uc_Click);
            // 
            // af
            // 
            this.af.Location = new System.Drawing.Point(299, 155);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(171, 54);
            this.af.TabIndex = 0;
            this.af.Text = "Add Food";
            this.af.UseVisualStyleBackColor = true;
            this.af.Click += new System.EventHandler(this.af_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Foods";
            // 
            // FoodOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.af);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.ac);
            this.Name = "FoodOption";
            this.Text = "FoodOption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.Button af;
        private System.Windows.Forms.Label label1;
    }
}