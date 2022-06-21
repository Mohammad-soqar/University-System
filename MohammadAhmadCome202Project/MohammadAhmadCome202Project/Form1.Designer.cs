namespace MohammadAhmadCome202Project
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new Guna.UI2.WinForms.Guna2Button();
            this.loginEG = new Guna.UI2.WinForms.Guna2Button();
            this.Whatsapp = new Guna.UI2.WinForms.Guna2Button();
            this.Youtube = new Guna.UI2.WinForms.Guna2Button();
            this.Instagram = new Guna.UI2.WinForms.Guna2Button();
            this.Pinterest = new Guna.UI2.WinForms.Guna2Button();
            this.Twitter = new Guna.UI2.WinForms.Guna2Button();
            this.Facebook = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(192, 473);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // studentNumber
            // 
            this.studentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentNumber.Location = new System.Drawing.Point(134, 271);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.PlaceholderText = " Enter your student number";
            this.studentNumber.Size = new System.Drawing.Size(244, 30);
            this.studentNumber.TabIndex = 5;
            this.studentNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(134, 327);
            this.Password.Name = "Password";
            this.Password.PlaceholderText = " Enter your password";
            this.Password.Size = new System.Drawing.Size(244, 30);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.BorderRadius = 7;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(172)))));
            this.Login.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(151, 372);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(204, 38);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // loginEG
            // 
            this.loginEG.BorderRadius = 7;
            this.loginEG.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginEG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginEG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginEG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginEG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(172)))));
            this.loginEG.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginEG.ForeColor = System.Drawing.Color.White;
            this.loginEG.Location = new System.Drawing.Point(151, 416);
            this.loginEG.Name = "loginEG";
            this.loginEG.Size = new System.Drawing.Size(204, 38);
            this.loginEG.TabIndex = 9;
            this.loginEG.Text = " Login with E-Government";
            this.loginEG.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Whatsapp
            // 
            this.Whatsapp.BackColor = System.Drawing.Color.Transparent;
            this.Whatsapp.BorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Whatsapp.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Whatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Whatsapp.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Whatsapp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Whatsapp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Whatsapp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Whatsapp.FillColor = System.Drawing.Color.Transparent;
            this.Whatsapp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Whatsapp.ForeColor = System.Drawing.Color.Transparent;
            this.Whatsapp.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Whatsapp.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Whatsapp.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Whatsapp.Image = ((System.Drawing.Image)(resources.GetObject("Whatsapp.Image")));
            this.Whatsapp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Whatsapp.ImageSize = new System.Drawing.Size(18, 18);
            this.Whatsapp.Location = new System.Drawing.Point(736, 559);
            this.Whatsapp.Name = "Whatsapp";
            this.Whatsapp.PressedColor = System.Drawing.Color.Transparent;
            this.Whatsapp.Size = new System.Drawing.Size(33, 39);
            this.Whatsapp.TabIndex = 35;
            this.Whatsapp.Text = "guna2Button1";
            this.Whatsapp.Click += new System.EventHandler(this.Whatsapp_Click);
            // 
            // Youtube
            // 
            this.Youtube.BackColor = System.Drawing.Color.Transparent;
            this.Youtube.BorderColor = System.Drawing.Color.Transparent;
            this.Youtube.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Youtube.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Youtube.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Youtube.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Youtube.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Youtube.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Youtube.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Youtube.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Youtube.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Youtube.FillColor = System.Drawing.Color.Transparent;
            this.Youtube.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Youtube.ForeColor = System.Drawing.Color.Transparent;
            this.Youtube.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Youtube.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Youtube.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Youtube.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Youtube.Image = ((System.Drawing.Image)(resources.GetObject("Youtube.Image")));
            this.Youtube.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Youtube.ImageSize = new System.Drawing.Size(18, 13);
            this.Youtube.Location = new System.Drawing.Point(701, 559);
            this.Youtube.Name = "Youtube";
            this.Youtube.PressedColor = System.Drawing.Color.Transparent;
            this.Youtube.Size = new System.Drawing.Size(33, 39);
            this.Youtube.TabIndex = 34;
            this.Youtube.Text = "guna2Button1";
            this.Youtube.Click += new System.EventHandler(this.Youtube_Click);
            // 
            // Instagram
            // 
            this.Instagram.BackColor = System.Drawing.Color.Transparent;
            this.Instagram.BorderColor = System.Drawing.Color.Transparent;
            this.Instagram.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Instagram.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Instagram.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Instagram.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Instagram.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Instagram.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Instagram.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Instagram.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Instagram.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Instagram.FillColor = System.Drawing.Color.Transparent;
            this.Instagram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instagram.ForeColor = System.Drawing.Color.Transparent;
            this.Instagram.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Instagram.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Instagram.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Instagram.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Instagram.Image = ((System.Drawing.Image)(resources.GetObject("Instagram.Image")));
            this.Instagram.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Instagram.ImageSize = new System.Drawing.Size(18, 18);
            this.Instagram.Location = new System.Drawing.Point(770, 559);
            this.Instagram.Name = "Instagram";
            this.Instagram.PressedColor = System.Drawing.Color.Transparent;
            this.Instagram.Size = new System.Drawing.Size(33, 39);
            this.Instagram.TabIndex = 33;
            this.Instagram.Text = "guna2Button1";
            this.Instagram.Click += new System.EventHandler(this.Instagram_Click);
            // 
            // Pinterest
            // 
            this.Pinterest.BackColor = System.Drawing.Color.Transparent;
            this.Pinterest.BorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Pinterest.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Pinterest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pinterest.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pinterest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pinterest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pinterest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pinterest.FillColor = System.Drawing.Color.Transparent;
            this.Pinterest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pinterest.ForeColor = System.Drawing.Color.Transparent;
            this.Pinterest.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Pinterest.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Pinterest.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Pinterest.Image = ((System.Drawing.Image)(resources.GetObject("Pinterest.Image")));
            this.Pinterest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pinterest.ImageSize = new System.Drawing.Size(14, 19);
            this.Pinterest.Location = new System.Drawing.Point(806, 559);
            this.Pinterest.Name = "Pinterest";
            this.Pinterest.PressedColor = System.Drawing.Color.Transparent;
            this.Pinterest.Size = new System.Drawing.Size(33, 39);
            this.Pinterest.TabIndex = 32;
            this.Pinterest.Text = "guna2Button1";
            this.Pinterest.Click += new System.EventHandler(this.Pinterest_Click);
            // 
            // Twitter
            // 
            this.Twitter.BackColor = System.Drawing.Color.Transparent;
            this.Twitter.BorderColor = System.Drawing.Color.Transparent;
            this.Twitter.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Twitter.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Twitter.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Twitter.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Twitter.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Twitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Twitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Twitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Twitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Twitter.FillColor = System.Drawing.Color.Transparent;
            this.Twitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Twitter.ForeColor = System.Drawing.Color.Transparent;
            this.Twitter.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Twitter.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Twitter.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Twitter.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Twitter.Image = ((System.Drawing.Image)(resources.GetObject("Twitter.Image")));
            this.Twitter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Twitter.ImageSize = new System.Drawing.Size(19, 16);
            this.Twitter.Location = new System.Drawing.Point(839, 558);
            this.Twitter.Name = "Twitter";
            this.Twitter.PressedColor = System.Drawing.Color.Transparent;
            this.Twitter.Size = new System.Drawing.Size(33, 39);
            this.Twitter.TabIndex = 31;
            this.Twitter.Text = "guna2Button1";
            this.Twitter.Click += new System.EventHandler(this.Twitter_Click);
            // 
            // Facebook
            // 
            this.Facebook.BackColor = System.Drawing.Color.Transparent;
            this.Facebook.BorderColor = System.Drawing.Color.Transparent;
            this.Facebook.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Facebook.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Facebook.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Facebook.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.Facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Facebook.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Facebook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Facebook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Facebook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Facebook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Facebook.FillColor = System.Drawing.Color.Transparent;
            this.Facebook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Facebook.ForeColor = System.Drawing.Color.Transparent;
            this.Facebook.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Facebook.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Facebook.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Facebook.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.Facebook.Image = ((System.Drawing.Image)(resources.GetObject("Facebook.Image")));
            this.Facebook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Facebook.ImageSize = new System.Drawing.Size(10, 17);
            this.Facebook.Location = new System.Drawing.Point(876, 559);
            this.Facebook.Name = "Facebook";
            this.Facebook.PressedColor = System.Drawing.Color.Transparent;
            this.Facebook.Size = new System.Drawing.Size(33, 39);
            this.Facebook.TabIndex = 30;
            this.Facebook.Text = "guna2Button1";
            this.Facebook.Click += new System.EventHandler(this.Facebook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 594);
            this.Controls.Add(this.Whatsapp);
            this.Controls.Add(this.Youtube);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.Pinterest);
            this.Controls.Add(this.Twitter);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.loginEG);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.linkLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button loginEG;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button facebook;
        private TextBox studentNumber;
        private TextBox Password;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button pinterest;
        private Guna.UI2.WinForms.Guna2Button Twitter;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button Login;
        private Guna.UI2.WinForms.Guna2Button Whatsapp;
        private Guna.UI2.WinForms.Guna2Button Youtube;
        private Guna.UI2.WinForms.Guna2Button Instagram;
        private Guna.UI2.WinForms.Guna2Button Pinterest;
        private Guna.UI2.WinForms.Guna2Button Facebook;
    }
}