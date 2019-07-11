namespace Application_layer
{
    partial class CustomerRegistration
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
            this.regcbtn = new System.Windows.Forms.Button();
            this.titlereg1 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.aPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // regcbtn
            // 
            this.regcbtn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regcbtn.Location = new System.Drawing.Point(442, 400);
            this.regcbtn.Name = "regcbtn";
            this.regcbtn.Size = new System.Drawing.Size(122, 55);
            this.regcbtn.TabIndex = 0;
            this.regcbtn.Text = "Register";
            this.regcbtn.UseVisualStyleBackColor = true;
            this.regcbtn.Click += new System.EventHandler(this.regcbtn_Click);
            // 
            // titlereg1
            // 
            this.titlereg1.AutoSize = true;
            this.titlereg1.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlereg1.Location = new System.Drawing.Point(296, 22);
            this.titlereg1.Name = "titlereg1";
            this.titlereg1.Size = new System.Drawing.Size(249, 35);
            this.titlereg1.TabIndex = 2;
            this.titlereg1.Text = "Registration Form";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(142, 102);
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(240, 50);
            this.tbname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(142, 176);
            this.tbid.Multiline = true;
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(240, 50);
            this.tbid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone No.";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(541, 97);
            this.tbphone.Multiline = true;
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(240, 50);
            this.tbphone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(541, 165);
            this.tbpass.Multiline = true;
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(240, 50);
            this.tbpass.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Location = new System.Drawing.Point(33, 303);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(85, 23);
            this.UploadPictureButton.TabIndex = 40;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // aPictureBox
            // 
            this.aPictureBox.Location = new System.Drawing.Point(211, 244);
            this.aPictureBox.Name = "aPictureBox";
            this.aPictureBox.Size = new System.Drawing.Size(171, 131);
            this.aPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aPictureBox.TabIndex = 39;
            this.aPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Picture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(541, 244);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(240, 50);
            this.tbemail.TabIndex = 3;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.aPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titlereg1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regcbtn);
            this.Name = "CustomerRegistration";
            this.Text = "CustomerRegistration";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regcbtn;
        private System.Windows.Forms.Label titlereg1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.PictureBox aPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbemail;
    }
}