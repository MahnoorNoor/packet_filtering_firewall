
namespace Group10_proj
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.back_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_username = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.Label_password = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_Btn
            // 
            this.back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.Location = new System.Drawing.Point(12, 12);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(47, 42);
            this.back_Btn.TabIndex = 1;
            this.back_Btn.Text = "<";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Label_username
            // 
            this.Label_username.AutoSize = true;
            this.Label_username.BackColor = System.Drawing.Color.Transparent;
            this.Label_username.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_username.Location = new System.Drawing.Point(149, 187);
            this.Label_username.Name = "Label_username";
            this.Label_username.Size = new System.Drawing.Size(148, 26);
            this.Label_username.TabIndex = 5;
            this.Label_username.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(339, 187);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(454, 26);
            this.Username.TabIndex = 7;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginLabel.Location = new System.Drawing.Point(39, 73);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(875, 35);
            this.loginLabel.TabIndex = 9;
            this.loginLabel.Text = "To add, Custom rules, First verify your Identity";
            // 
            // Label_password
            // 
            this.Label_password.AutoSize = true;
            this.Label_password.BackColor = System.Drawing.Color.Transparent;
            this.Label_password.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_password.Location = new System.Drawing.Point(147, 250);
            this.Label_password.Name = "Label_password";
            this.Label_password.Size = new System.Drawing.Size(150, 26);
            this.Label_password.TabIndex = 10;
            this.Label_password.Text = "Password";
            this.Label_password.Click += new System.EventHandler(this.Label_password_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(356, 322);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(189, 38);
            this.LoginBtn.TabIndex = 11;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(569, 322);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(183, 38);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(339, 250);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(454, 26);
            this.Password.TabIndex = 13;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged_1);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 491);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Label_password);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Label_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_Btn);
            this.Name = "AdminLogin";
            this.Text = "Admin_login";
            this.Load += new System.EventHandler(this.Admin_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_username;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label Label_password;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.TextBox Password;
    }
}