namespace DroosManegmentSystem
{
	partial class loginForm
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
			this.loginBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.remMe = new System.Windows.Forms.CheckBox();
			this.userName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.TextBox();
			this.fogetPassBtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
			this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginBtn.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.Color.White;
			this.loginBtn.Location = new System.Drawing.Point(47, 338);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(256, 52);
			this.loginBtn.TabIndex = 0;
			this.loginBtn.Text = "تسجيل الدخول";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(194, 171);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "اسم المستخدم";
			// 
			// remMe
			// 
			this.remMe.AutoSize = true;
			this.remMe.Cursor = System.Windows.Forms.Cursors.Hand;
			this.remMe.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.remMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.remMe.Location = new System.Drawing.Point(231, 294);
			this.remMe.Margin = new System.Windows.Forms.Padding(2);
			this.remMe.Name = "remMe";
			this.remMe.Padding = new System.Windows.Forms.Padding(4);
			this.remMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.remMe.Size = new System.Drawing.Size(80, 37);
			this.remMe.TabIndex = 2;
			this.remMe.Text = "تذكرني";
			this.remMe.UseVisualStyleBackColor = true;
			this.remMe.CheckedChanged += new System.EventHandler(this.remMe_CheckedChanged);
			// 
			// userName
			// 
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userName.Location = new System.Drawing.Point(47, 203);
			this.userName.Margin = new System.Windows.Forms.Padding(2);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(258, 26);
			this.userName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(69, 123);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 36);
			this.label2.TabIndex = 4;
			this.label2.Text = "سجل الدخول الى حسابك";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(214, 235);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 31);
			this.label3.TabIndex = 1;
			this.label3.Text = "كلمة المرور";
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(47, 265);
			this.password.Margin = new System.Windows.Forms.Padding(2);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(258, 26);
			this.password.TabIndex = 3;
			// 
			// fogetPassBtn
			// 
			this.fogetPassBtn.BackColor = System.Drawing.Color.White;
			this.fogetPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.fogetPassBtn.FlatAppearance.BorderSize = 0;
			this.fogetPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fogetPassBtn.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fogetPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
			this.fogetPassBtn.Location = new System.Drawing.Point(47, 295);
			this.fogetPassBtn.Margin = new System.Windows.Forms.Padding(2);
			this.fogetPassBtn.Name = "fogetPassBtn";
			this.fogetPassBtn.Size = new System.Drawing.Size(149, 39);
			this.fogetPassBtn.TabIndex = 0;
			this.fogetPassBtn.Text = "هل نسيت كلمة المرور؟";
			this.fogetPassBtn.UseVisualStyleBackColor = false;
			this.fogetPassBtn.Click += new System.EventHandler(this.fogetPassBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DroosManegmentSystem.Properties.Resources.login;
			this.pictureBox1.Location = new System.Drawing.Point(126, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// loginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(352, 401);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.remMe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fogetPassBtn);
			this.Controls.Add(this.loginBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "loginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.loginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox remMe;
		private System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button fogetPassBtn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

