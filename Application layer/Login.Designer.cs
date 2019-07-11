namespace Application_layer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginbtn = new System.Windows.Forms.Button();
            this.uidlbl = new System.Windows.Forms.Label();
            this.tboxlogin = new System.Windows.Forms.TextBox();
            this.tboxpass = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.descrip1 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.reglbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(421, 317);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(86, 43);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // uidlbl
            // 
            this.uidlbl.AutoSize = true;
            this.uidlbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidlbl.Location = new System.Drawing.Point(236, 156);
            this.uidlbl.Name = "uidlbl";
            this.uidlbl.Size = new System.Drawing.Size(70, 25);
            this.uidlbl.TabIndex = 1;
            this.uidlbl.Text = "UserID";
            // 
            // tboxlogin
            // 
            this.tboxlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxlogin.Location = new System.Drawing.Point(348, 146);
            this.tboxlogin.Multiline = true;
            this.tboxlogin.Name = "tboxlogin";
            this.tboxlogin.Size = new System.Drawing.Size(241, 44);
            this.tboxlogin.TabIndex = 2;
            // 
            // tboxpass
            // 
            this.tboxpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxpass.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxpass.Location = new System.Drawing.Point(348, 217);
            this.tboxpass.Multiline = true;
            this.tboxpass.Name = "tboxpass";
            this.tboxpass.PasswordChar = '*';
            this.tboxpass.Size = new System.Drawing.Size(241, 44);
            this.tboxpass.TabIndex = 2;
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(209, 232);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(97, 25);
            this.passlbl.TabIndex = 1;
            this.passlbl.Text = "Password";
            // 
            // descrip1
            // 
            this.descrip1.AutoSize = true;
            this.descrip1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrip1.Location = new System.Drawing.Point(302, 440);
            this.descrip1.Name = "descrip1";
            this.descrip1.Size = new System.Drawing.Size(196, 25);
            this.descrip1.TabIndex = 1;
            this.descrip1.Text = "Not Have A Account?";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(359, 25);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(216, 33);
            this.title1.TabIndex = 1;
            this.title1.Text = "AIUB Resturent";
            this.title1.Click += new System.EventHandler(this.title1_Click);
            // 
            // reglbl
            // 
            this.reglbl.AutoSize = true;
            this.reglbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reglbl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reglbl.Location = new System.Drawing.Point(504, 440);
            this.reglbl.Name = "reglbl";
            this.reglbl.Size = new System.Drawing.Size(85, 25);
            this.reglbl.TabIndex = 1;
            this.reglbl.Text = "Register";
            this.reglbl.Click += new System.EventHandler(this.reglbl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(811, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tboxpass);
            this.Controls.Add(this.tboxlogin);
            this.Controls.Add(this.reglbl);
            this.Controls.Add(this.descrip1);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.uidlbl);
            this.Controls.Add(this.loginbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label uidlbl;
        private System.Windows.Forms.TextBox tboxlogin;
        private System.Windows.Forms.TextBox tboxpass;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label descrip1;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label reglbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}