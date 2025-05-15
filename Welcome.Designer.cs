
namespace Group10_proj
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.WelcomePage = new System.Windows.Forms.Label();
            this.Tutorial_Btn = new System.Windows.Forms.Button();
            this.Firewall_Btn = new System.Windows.Forms.Button();
            this.CreatorsCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomePage
            // 
            this.WelcomePage.AutoSize = true;
            this.WelcomePage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePage.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomePage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomePage.Location = new System.Drawing.Point(217, 142);
            this.WelcomePage.Name = "WelcomePage";
            this.WelcomePage.Size = new System.Drawing.Size(742, 53);
            this.WelcomePage.TabIndex = 0;
            this.WelcomePage.Text = "Packet Filtering Firewall";
            this.WelcomePage.Click += new System.EventHandler(this.WelcomePage_Click);
            // 
            // Tutorial_Btn
            // 
            this.Tutorial_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tutorial_Btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_Btn.Location = new System.Drawing.Point(269, 302);
            this.Tutorial_Btn.Name = "Tutorial_Btn";
            this.Tutorial_Btn.Size = new System.Drawing.Size(366, 59);
            this.Tutorial_Btn.TabIndex = 1;
            this.Tutorial_Btn.Text = "Take a Tutorial!";
            this.Tutorial_Btn.UseVisualStyleBackColor = false;
            this.Tutorial_Btn.Click += new System.EventHandler(this.Tutorial_Btn_Click);
            // 
            // Firewall_Btn
            // 
            this.Firewall_Btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Firewall_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Firewall_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Firewall_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Firewall_Btn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firewall_Btn.Location = new System.Drawing.Point(269, 402);
            this.Firewall_Btn.Name = "Firewall_Btn";
            this.Firewall_Btn.Size = new System.Drawing.Size(366, 60);
            this.Firewall_Btn.TabIndex = 2;
            this.Firewall_Btn.Text = "Go to Firewall!";
            this.Firewall_Btn.UseVisualStyleBackColor = false;
            this.Firewall_Btn.Click += new System.EventHandler(this.Firewall_btn_Click_1);
            // 
            // CreatorsCredit
            // 
            this.CreatorsCredit.AutoSize = true;
            this.CreatorsCredit.BackColor = System.Drawing.Color.Transparent;
            this.CreatorsCredit.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorsCredit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreatorsCredit.Location = new System.Drawing.Point(181, 578);
            this.CreatorsCredit.Name = "CreatorsCredit";
            this.CreatorsCredit.Size = new System.Drawing.Size(778, 36);
            this.CreatorsCredit.TabIndex = 3;
            this.CreatorsCredit.Text = "OOP Semester End Project  created by Abeera Mehtab (232087), Mahnoor (232083)\r\nMa" +
    "hnoor Ikran(232115), Eman Mansoor(232149)";
            this.CreatorsCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreatorsCredit.Click += new System.EventHandler(this.CreatorsCredit_Click);
            // 
            // Welcome
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 623);
            this.Controls.Add(this.CreatorsCredit);
            this.Controls.Add(this.Firewall_Btn);
            this.Controls.Add(this.Tutorial_Btn);
            this.Controls.Add(this.WelcomePage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomePage;
        private System.Windows.Forms.Button Tutorial_Btn;
        private System.Windows.Forms.Button Firewall_Btn;
        private System.Windows.Forms.Label CreatorsCredit;
    }
}