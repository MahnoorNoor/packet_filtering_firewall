
namespace Group10_proj
{
    partial class AddCustomRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomRules));
            this.back_Btn = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ApptoLab = new System.Windows.Forms.Label();
            this.IpLab = new System.Windows.Forms.Label();
            this.PortLab = new System.Windows.Forms.Label();
            this.ProtocolLab = new System.Windows.Forms.Label();
            this.DecisionLab = new System.Windows.Forms.Label();
            this.comboboxappliedto = new System.Windows.Forms.ComboBox();
            this.comboboxProtocol = new System.Windows.Forms.ComboBox();
            this.comboboxDecision = new System.Windows.Forms.ComboBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.ViiewCustomRulesBtn = new System.Windows.Forms.Button();
            this.ResestBtn = new System.Windows.Forms.Button();
            this.AddRuleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_Btn
            // 
            this.back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.Location = new System.Drawing.Point(12, 12);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(39, 33);
            this.back_Btn.TabIndex = 2;
            this.back_Btn.Text = "<";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(70, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(418, 43);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Add Custom Rules";
            // 
            // ApptoLab
            // 
            this.ApptoLab.AutoSize = true;
            this.ApptoLab.BackColor = System.Drawing.Color.Transparent;
            this.ApptoLab.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptoLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ApptoLab.Location = new System.Drawing.Point(73, 129);
            this.ApptoLab.Name = "ApptoLab";
            this.ApptoLab.Size = new System.Drawing.Size(151, 26);
            this.ApptoLab.TabIndex = 22;
            this.ApptoLab.Text = "Applied to:";
            this.ApptoLab.Click += new System.EventHandler(this.ApptoLab_Click);
            // 
            // IpLab
            // 
            this.IpLab.AutoSize = true;
            this.IpLab.BackColor = System.Drawing.Color.Transparent;
            this.IpLab.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IpLab.Location = new System.Drawing.Point(73, 170);
            this.IpLab.Name = "IpLab";
            this.IpLab.Size = new System.Drawing.Size(155, 26);
            this.IpLab.TabIndex = 23;
            this.IpLab.Text = "IP address:";
            this.IpLab.Click += new System.EventHandler(this.IpLab_Click);
            // 
            // PortLab
            // 
            this.PortLab.AutoSize = true;
            this.PortLab.BackColor = System.Drawing.Color.Transparent;
            this.PortLab.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PortLab.Location = new System.Drawing.Point(73, 214);
            this.PortLab.Name = "PortLab";
            this.PortLab.Size = new System.Drawing.Size(82, 26);
            this.PortLab.TabIndex = 24;
            this.PortLab.Text = "Port:";
            this.PortLab.Click += new System.EventHandler(this.PortLab_Click);
            // 
            // ProtocolLab
            // 
            this.ProtocolLab.AutoSize = true;
            this.ProtocolLab.BackColor = System.Drawing.Color.Transparent;
            this.ProtocolLab.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtocolLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProtocolLab.Location = new System.Drawing.Point(73, 261);
            this.ProtocolLab.Name = "ProtocolLab";
            this.ProtocolLab.Size = new System.Drawing.Size(148, 26);
            this.ProtocolLab.TabIndex = 27;
            this.ProtocolLab.Text = "Protocol:";
            this.ProtocolLab.Click += new System.EventHandler(this.ProtocolLab_Click);
            // 
            // DecisionLab
            // 
            this.DecisionLab.AutoSize = true;
            this.DecisionLab.BackColor = System.Drawing.Color.Transparent;
            this.DecisionLab.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecisionLab.Location = new System.Drawing.Point(73, 313);
            this.DecisionLab.Name = "DecisionLab";
            this.DecisionLab.Size = new System.Drawing.Size(132, 26);
            this.DecisionLab.TabIndex = 28;
            this.DecisionLab.Text = "Decision:";
            this.DecisionLab.Click += new System.EventHandler(this.DecisionLab_Click);
            // 
            // comboboxappliedto
            // 
            this.comboboxappliedto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxappliedto.FormattingEnabled = true;
            this.comboboxappliedto.Items.AddRange(new object[] {
            "SRC",
            "DST",
            "PRO"});
            this.comboboxappliedto.Location = new System.Drawing.Point(256, 127);
            this.comboboxappliedto.Name = "comboboxappliedto";
            this.comboboxappliedto.Size = new System.Drawing.Size(333, 28);
            this.comboboxappliedto.TabIndex = 29;
            this.comboboxappliedto.Text = "select";
            this.comboboxappliedto.SelectedIndexChanged += new System.EventHandler(this.comboboxappliedto_SelectedIndexChanged);
            // 
            // comboboxProtocol
            // 
            this.comboboxProtocol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxProtocol.FormattingEnabled = true;
            this.comboboxProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "ICMP"});
            this.comboboxProtocol.Location = new System.Drawing.Point(256, 263);
            this.comboboxProtocol.Name = "comboboxProtocol";
            this.comboboxProtocol.Size = new System.Drawing.Size(333, 28);
            this.comboboxProtocol.TabIndex = 30;
            this.comboboxProtocol.Text = "Choose Protocol";
            this.comboboxProtocol.SelectedIndexChanged += new System.EventHandler(this.comboboxProtocol_SelectedIndexChanged);
            // 
            // comboboxDecision
            // 
            this.comboboxDecision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxDecision.FormattingEnabled = true;
            this.comboboxDecision.Items.AddRange(new object[] {
            "ALLOW ",
            "DENY"});
            this.comboboxDecision.Location = new System.Drawing.Point(256, 313);
            this.comboboxDecision.Name = "comboboxDecision";
            this.comboboxDecision.Size = new System.Drawing.Size(333, 28);
            this.comboboxDecision.TabIndex = 31;
            this.comboboxDecision.Text = "Select";
            this.comboboxDecision.SelectedIndexChanged += new System.EventHandler(this.comboboxDecision_SelectedIndexChanged);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(256, 172);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(333, 26);
            this.IPBox.TabIndex = 32;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(256, 216);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(333, 26);
            this.PortBox.TabIndex = 33;
            this.PortBox.TextChanged += new System.EventHandler(this.PortBox_TextChanged);
            // 
            // ViiewCustomRulesBtn
            // 
            this.ViiewCustomRulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViiewCustomRulesBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViiewCustomRulesBtn.Location = new System.Drawing.Point(182, 443);
            this.ViiewCustomRulesBtn.Name = "ViiewCustomRulesBtn";
            this.ViiewCustomRulesBtn.Size = new System.Drawing.Size(386, 48);
            this.ViiewCustomRulesBtn.TabIndex = 34;
            this.ViiewCustomRulesBtn.Text = "View Custom Rules";
            this.ViiewCustomRulesBtn.UseVisualStyleBackColor = true;
            this.ViiewCustomRulesBtn.Click += new System.EventHandler(this.ViiewCustomRulesBtn_Click);
            // 
            // ResestBtn
            // 
            this.ResestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResestBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResestBtn.Location = new System.Drawing.Point(182, 387);
            this.ResestBtn.Name = "ResestBtn";
            this.ResestBtn.Size = new System.Drawing.Size(193, 50);
            this.ResestBtn.TabIndex = 35;
            this.ResestBtn.Text = "Reset";
            this.ResestBtn.UseVisualStyleBackColor = true;
            this.ResestBtn.Click += new System.EventHandler(this.ResestBtn_Click);
            // 
            // AddRuleBtn
            // 
            this.AddRuleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRuleBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRuleBtn.Location = new System.Drawing.Point(381, 387);
            this.AddRuleBtn.Name = "AddRuleBtn";
            this.AddRuleBtn.Size = new System.Drawing.Size(187, 50);
            this.AddRuleBtn.TabIndex = 36;
            this.AddRuleBtn.Text = "Add Rule";
            this.AddRuleBtn.UseVisualStyleBackColor = true;
            this.AddRuleBtn.Click += new System.EventHandler(this.AddRuleBtn_Click);
            // 
            // AddCustomRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 570);
            this.Controls.Add(this.AddRuleBtn);
            this.Controls.Add(this.ResestBtn);
            this.Controls.Add(this.ViiewCustomRulesBtn);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.comboboxDecision);
            this.Controls.Add(this.comboboxProtocol);
            this.Controls.Add(this.comboboxappliedto);
            this.Controls.Add(this.DecisionLab);
            this.Controls.Add(this.ProtocolLab);
            this.Controls.Add(this.PortLab);
            this.Controls.Add(this.IpLab);
            this.Controls.Add(this.ApptoLab);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.back_Btn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomRules";
            this.Text = "AddCustomRules";
            this.Load += new System.EventHandler(this.AddCustomRules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Btn;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label ApptoLab;
        private System.Windows.Forms.Label IpLab;
        private System.Windows.Forms.Label PortLab;
        private System.Windows.Forms.Label ProtocolLab;
        private System.Windows.Forms.Label DecisionLab;
        private System.Windows.Forms.ComboBox comboboxappliedto;
        private System.Windows.Forms.ComboBox comboboxProtocol;
        private System.Windows.Forms.ComboBox comboboxDecision;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Button ViiewCustomRulesBtn;
        private System.Windows.Forms.Button ResestBtn;
        private System.Windows.Forms.Button AddRuleBtn;
    }
}