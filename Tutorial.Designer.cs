
namespace Group10_proj
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.back_Btn = new System.Windows.Forms.Button();
            this.Tutorial_label = new System.Windows.Forms.Label();
            this.RunningFirewallBtn = new System.Windows.Forms.Button();
            this.AddingCustomRulesBtn = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_Btn
            // 
            this.back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.Location = new System.Drawing.Point(22, 23);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(39, 49);
            this.back_Btn.TabIndex = 0;
            this.back_Btn.Text = "<";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // Tutorial_label
            // 
            this.Tutorial_label.AutoSize = true;
            this.Tutorial_label.BackColor = System.Drawing.Color.Transparent;
            this.Tutorial_label.Font = new System.Drawing.Font("Copperplate Gothic Bold", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tutorial_label.Location = new System.Drawing.Point(27, 75);
            this.Tutorial_label.Name = "Tutorial_label";
            this.Tutorial_label.Size = new System.Drawing.Size(1198, 49);
            this.Tutorial_label.TabIndex = 2;
            this.Tutorial_label.Text = "Packet Filtering Firewall:  Your How to? Guide";
            this.Tutorial_label.Click += new System.EventHandler(this.Tutorial_label_Click);
            // 
            // RunningFirewallBtn
            // 
            this.RunningFirewallBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningFirewallBtn.Location = new System.Drawing.Point(36, 140);
            this.RunningFirewallBtn.Name = "RunningFirewallBtn";
            this.RunningFirewallBtn.Size = new System.Drawing.Size(588, 46);
            this.RunningFirewallBtn.TabIndex = 3;
            this.RunningFirewallBtn.Text = "How To Use Firewall?";
            this.RunningFirewallBtn.UseVisualStyleBackColor = true;
            this.RunningFirewallBtn.Click += new System.EventHandler(this.RunningFirewallBtn_Click);
            // 
            // AddingCustomRulesBtn
            // 
            this.AddingCustomRulesBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingCustomRulesBtn.Location = new System.Drawing.Point(621, 140);
            this.AddingCustomRulesBtn.Name = "AddingCustomRulesBtn";
            this.AddingCustomRulesBtn.Size = new System.Drawing.Size(527, 46);
            this.AddingCustomRulesBtn.TabIndex = 4;
            this.AddingCustomRulesBtn.Text = "How to Add Custom Rules?";
            this.AddingCustomRulesBtn.UseVisualStyleBackColor = true;
            this.AddingCustomRulesBtn.Click += new System.EventHandler(this.AddingCustomRulesBtn_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InstructionsLabel.Location = new System.Drawing.Point(47, 211);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(546, 23);
            this.InstructionsLabel.TabIndex = 5;
            this.InstructionsLabel.Text = "Choose the button to show Instructions here...";
            this.InstructionsLabel.Click += new System.EventHandler(this.InstructionsLabel_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 689);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.AddingCustomRulesBtn);
            this.Controls.Add(this.RunningFirewallBtn);
            this.Controls.Add(this.Tutorial_label);
            this.Controls.Add(this.back_Btn);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Btn;
        private System.Windows.Forms.Label Tutorial_label;
        private System.Windows.Forms.Button RunningFirewallBtn;
        private System.Windows.Forms.Button AddingCustomRulesBtn;
        private System.Windows.Forms.Label InstructionsLabel;
    }
}