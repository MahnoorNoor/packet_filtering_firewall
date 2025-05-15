
namespace Group10_proj
{
    partial class Firewall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firewall));
            this.back_Btn = new System.Windows.Forms.Button();
            this.labelSrcIP = new System.Windows.Forms.Label();
            this.labelDstIP = new System.Windows.Forms.Label();
            this.labelSrcPort = new System.Windows.Forms.Label();
            this.labelDstPort = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPacketData = new System.Windows.Forms.Label();
            this.BoxSrcIP = new System.Windows.Forms.TextBox();
            this.BoxSrcPort = new System.Windows.Forms.TextBox();
            this.boxDstIP = new System.Windows.Forms.TextBox();
            this.boxDstPort = new System.Windows.Forms.TextBox();
            this.BoxPacketData = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboboxProtocol = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.CheckPacketBtn = new System.Windows.Forms.Button();
            this.ResestBtn = new System.Windows.Forms.Button();
            this.ViewDeafultRulesBtn = new System.Windows.Forms.Button();
            this.ViiewCustomRulesBtn = new System.Windows.Forms.Button();
            this.AddCustomRulesBtn = new System.Windows.Forms.Button();
            this.Decision = new System.Windows.Forms.Label();
            this.RuleApplied = new System.Windows.Forms.Label();
            this.DecisionBox = new System.Windows.Forms.GroupBox();
            this.AppliedFrom = new System.Windows.Forms.Label();
            this.MoreControls = new System.Windows.Forms.GroupBox();
            this.DecisionBox.SuspendLayout();
            this.MoreControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_Btn
            // 
            this.back_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Btn.Location = new System.Drawing.Point(15, 8);
            this.back_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(26, 21);
            this.back_Btn.TabIndex = 1;
            this.back_Btn.Text = "<";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.back_Btn_Click);
            // 
            // labelSrcIP
            // 
            this.labelSrcIP.AutoSize = true;
            this.labelSrcIP.BackColor = System.Drawing.Color.Transparent;
            this.labelSrcIP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcIP.ForeColor = System.Drawing.Color.Transparent;
            this.labelSrcIP.Location = new System.Drawing.Point(50, 80);
            this.labelSrcIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSrcIP.Name = "labelSrcIP";
            this.labelSrcIP.Size = new System.Drawing.Size(100, 18);
            this.labelSrcIP.TabIndex = 3;
            this.labelSrcIP.Text = "Source IP:";
            // 
            // labelDstIP
            // 
            this.labelDstIP.AutoSize = true;
            this.labelDstIP.BackColor = System.Drawing.Color.Transparent;
            this.labelDstIP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDstIP.ForeColor = System.Drawing.Color.Transparent;
            this.labelDstIP.Location = new System.Drawing.Point(50, 142);
            this.labelDstIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDstIP.Name = "labelDstIP";
            this.labelDstIP.Size = new System.Drawing.Size(141, 18);
            this.labelDstIP.TabIndex = 5;
            this.labelDstIP.Text = "Destination IP:";
            // 
            // labelSrcPort
            // 
            this.labelSrcPort.AutoSize = true;
            this.labelSrcPort.BackColor = System.Drawing.Color.Transparent;
            this.labelSrcPort.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcPort.ForeColor = System.Drawing.Color.Transparent;
            this.labelSrcPort.Location = new System.Drawing.Point(50, 111);
            this.labelSrcPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSrcPort.Name = "labelSrcPort";
            this.labelSrcPort.Size = new System.Drawing.Size(126, 18);
            this.labelSrcPort.TabIndex = 8;
            this.labelSrcPort.Text = "Source Port:";
            // 
            // labelDstPort
            // 
            this.labelDstPort.AutoSize = true;
            this.labelDstPort.BackColor = System.Drawing.Color.Transparent;
            this.labelDstPort.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDstPort.ForeColor = System.Drawing.Color.Transparent;
            this.labelDstPort.Location = new System.Drawing.Point(50, 177);
            this.labelDstPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDstPort.Name = "labelDstPort";
            this.labelDstPort.Size = new System.Drawing.Size(167, 18);
            this.labelDstPort.TabIndex = 10;
            this.labelDstPort.Text = "Destination Port:";
            // 
            // labelProtocol
            // 
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.BackColor = System.Drawing.Color.Transparent;
            this.labelProtocol.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProtocol.ForeColor = System.Drawing.Color.Transparent;
            this.labelProtocol.Location = new System.Drawing.Point(51, 211);
            this.labelProtocol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(98, 18);
            this.labelProtocol.TabIndex = 12;
            this.labelProtocol.Text = "Portocol:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Location = new System.Drawing.Point(50, 240);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(137, 18);
            this.labelDateTime.TabIndex = 13;
            this.labelDateTime.Text = "Date and Time:";
            // 
            // labelPacketData
            // 
            this.labelPacketData.AutoSize = true;
            this.labelPacketData.BackColor = System.Drawing.Color.Transparent;
            this.labelPacketData.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacketData.ForeColor = System.Drawing.Color.Transparent;
            this.labelPacketData.Location = new System.Drawing.Point(50, 273);
            this.labelPacketData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPacketData.Name = "labelPacketData";
            this.labelPacketData.Size = new System.Drawing.Size(125, 18);
            this.labelPacketData.TabIndex = 14;
            this.labelPacketData.Text = "Packet Data:";
            // 
            // BoxSrcIP
            // 
            this.BoxSrcIP.Location = new System.Drawing.Point(246, 80);
            this.BoxSrcIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxSrcIP.Name = "BoxSrcIP";
            this.BoxSrcIP.Size = new System.Drawing.Size(239, 20);
            this.BoxSrcIP.TabIndex = 15;
            this.BoxSrcIP.TextChanged += new System.EventHandler(this.BoxSrcIP_TextChanged);
            // 
            // BoxSrcPort
            // 
            this.BoxSrcPort.Location = new System.Drawing.Point(246, 111);
            this.BoxSrcPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxSrcPort.Name = "BoxSrcPort";
            this.BoxSrcPort.Size = new System.Drawing.Size(239, 20);
            this.BoxSrcPort.TabIndex = 16;
            this.BoxSrcPort.TextChanged += new System.EventHandler(this.BoxSrcPort_TextChanged);
            // 
            // boxDstIP
            // 
            this.boxDstIP.Location = new System.Drawing.Point(246, 142);
            this.boxDstIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxDstIP.Name = "boxDstIP";
            this.boxDstIP.Size = new System.Drawing.Size(239, 20);
            this.boxDstIP.TabIndex = 17;
            this.boxDstIP.TextChanged += new System.EventHandler(this.boxDstIP_TextChanged);
            // 
            // boxDstPort
            // 
            this.boxDstPort.Location = new System.Drawing.Point(246, 177);
            this.boxDstPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxDstPort.Name = "boxDstPort";
            this.boxDstPort.Size = new System.Drawing.Size(239, 20);
            this.boxDstPort.TabIndex = 18;
            this.boxDstPort.TextChanged += new System.EventHandler(this.boxDstPort_TextChanged);
            // 
            // BoxPacketData
            // 
            this.BoxPacketData.Location = new System.Drawing.Point(246, 273);
            this.BoxPacketData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BoxPacketData.Name = "BoxPacketData";
            this.BoxPacketData.Size = new System.Drawing.Size(239, 20);
            this.BoxPacketData.TabIndex = 19;
            this.BoxPacketData.TextChanged += new System.EventHandler(this.BoxPacketData_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(65, 27);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(380, 30);
            this.labelTitle.TabIndex = 20;
            this.labelTitle.Text = "Enter your Packet data";
            // 
            // comboboxProtocol
            // 
            this.comboboxProtocol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxProtocol.FormattingEnabled = true;
            this.comboboxProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "ICMP"});
            this.comboboxProtocol.Location = new System.Drawing.Point(246, 210);
            this.comboboxProtocol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboboxProtocol.Name = "comboboxProtocol";
            this.comboboxProtocol.Size = new System.Drawing.Size(239, 21);
            this.comboboxProtocol.TabIndex = 22;
            this.comboboxProtocol.Text = "Choose Protocol";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(246, 242);
            this.date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(239, 20);
            this.date.TabIndex = 23;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // CheckPacketBtn
            // 
            this.CheckPacketBtn.BackColor = System.Drawing.Color.White;
            this.CheckPacketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckPacketBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPacketBtn.Location = new System.Drawing.Point(175, 304);
            this.CheckPacketBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckPacketBtn.Name = "CheckPacketBtn";
            this.CheckPacketBtn.Size = new System.Drawing.Size(147, 30);
            this.CheckPacketBtn.TabIndex = 24;
            this.CheckPacketBtn.Text = "Check Packet";
            this.CheckPacketBtn.UseVisualStyleBackColor = false;
            this.CheckPacketBtn.Click += new System.EventHandler(this.CheckPacketBtn_Click);
            // 
            // ResestBtn
            // 
            this.ResestBtn.BackColor = System.Drawing.Color.White;
            this.ResestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResestBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResestBtn.Location = new System.Drawing.Point(337, 304);
            this.ResestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResestBtn.Name = "ResestBtn";
            this.ResestBtn.Size = new System.Drawing.Size(146, 30);
            this.ResestBtn.TabIndex = 25;
            this.ResestBtn.Text = "Reset";
            this.ResestBtn.UseVisualStyleBackColor = false;
            this.ResestBtn.Click += new System.EventHandler(this.ResestBtn_Click);
            // 
            // ViewDeafultRulesBtn
            // 
            this.ViewDeafultRulesBtn.BackColor = System.Drawing.Color.White;
            this.ViewDeafultRulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDeafultRulesBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDeafultRulesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViewDeafultRulesBtn.Location = new System.Drawing.Point(29, 38);
            this.ViewDeafultRulesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewDeafultRulesBtn.Name = "ViewDeafultRulesBtn";
            this.ViewDeafultRulesBtn.Size = new System.Drawing.Size(251, 31);
            this.ViewDeafultRulesBtn.TabIndex = 26;
            this.ViewDeafultRulesBtn.Text = "View Default Rules";
            this.ViewDeafultRulesBtn.UseVisualStyleBackColor = false;
            this.ViewDeafultRulesBtn.Click += new System.EventHandler(this.ViewDeafultRulesBtn_Click);
            // 
            // ViiewCustomRulesBtn
            // 
            this.ViiewCustomRulesBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViiewCustomRulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViiewCustomRulesBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViiewCustomRulesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ViiewCustomRulesBtn.Location = new System.Drawing.Point(29, 100);
            this.ViiewCustomRulesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViiewCustomRulesBtn.Name = "ViiewCustomRulesBtn";
            this.ViiewCustomRulesBtn.Size = new System.Drawing.Size(251, 32);
            this.ViiewCustomRulesBtn.TabIndex = 27;
            this.ViiewCustomRulesBtn.Text = "View Custom Rules";
            this.ViiewCustomRulesBtn.UseVisualStyleBackColor = false;
            this.ViiewCustomRulesBtn.Click += new System.EventHandler(this.ViiewCustomRulesBtn_Click);
            // 
            // AddCustomRulesBtn
            // 
            this.AddCustomRulesBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCustomRulesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomRulesBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomRulesBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCustomRulesBtn.Location = new System.Drawing.Point(29, 165);
            this.AddCustomRulesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCustomRulesBtn.Name = "AddCustomRulesBtn";
            this.AddCustomRulesBtn.Size = new System.Drawing.Size(251, 32);
            this.AddCustomRulesBtn.TabIndex = 28;
            this.AddCustomRulesBtn.Text = "Add Custom Rules";
            this.AddCustomRulesBtn.UseVisualStyleBackColor = false;
            this.AddCustomRulesBtn.Click += new System.EventHandler(this.AddCustomRulesBtn_Click);
            // 
            // Decision
            // 
            this.Decision.AutoSize = true;
            this.Decision.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decision.Location = new System.Drawing.Point(17, 32);
            this.Decision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Decision.Name = "Decision";
            this.Decision.Size = new System.Drawing.Size(20, 17);
            this.Decision.TabIndex = 0;
            this.Decision.Text = "----";
            this.Decision.Click += new System.EventHandler(this.Decision_Click);
            // 
            // RuleApplied
            // 
            this.RuleApplied.AutoSize = true;
            this.RuleApplied.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RuleApplied.Location = new System.Drawing.Point(177, 32);
            this.RuleApplied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RuleApplied.Name = "RuleApplied";
            this.RuleApplied.Size = new System.Drawing.Size(20, 17);
            this.RuleApplied.TabIndex = 1;
            this.RuleApplied.Text = "----";
            this.RuleApplied.Click += new System.EventHandler(this.RuleApplied_Click);
            // 
            // DecisionBox
            // 
            this.DecisionBox.BackColor = System.Drawing.Color.Transparent;
            this.DecisionBox.Controls.Add(this.AppliedFrom);
            this.DecisionBox.Controls.Add(this.RuleApplied);
            this.DecisionBox.Controls.Add(this.Decision);
            this.DecisionBox.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecisionBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DecisionBox.Location = new System.Drawing.Point(35, 354);
            this.DecisionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecisionBox.Name = "DecisionBox";
            this.DecisionBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecisionBox.Size = new System.Drawing.Size(788, 73);
            this.DecisionBox.TabIndex = 29;
            this.DecisionBox.TabStop = false;
            this.DecisionBox.Text = "Decision:";
            this.DecisionBox.Enter += new System.EventHandler(this.DecisionBox_Enter);
            // 
            // AppliedFrom
            // 
            this.AppliedFrom.AutoSize = true;
            this.AppliedFrom.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppliedFrom.Location = new System.Drawing.Point(578, 32);
            this.AppliedFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AppliedFrom.Name = "AppliedFrom";
            this.AppliedFrom.Size = new System.Drawing.Size(20, 17);
            this.AppliedFrom.TabIndex = 2;
            this.AppliedFrom.Text = "----";
            this.AppliedFrom.Click += new System.EventHandler(this.AppliedFrom_Click);
            // 
            // MoreControls
            // 
            this.MoreControls.BackColor = System.Drawing.Color.Transparent;
            this.MoreControls.Controls.Add(this.AddCustomRulesBtn);
            this.MoreControls.Controls.Add(this.ViiewCustomRulesBtn);
            this.MoreControls.Controls.Add(this.ViewDeafultRulesBtn);
            this.MoreControls.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreControls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoreControls.Location = new System.Drawing.Point(515, 80);
            this.MoreControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoreControls.Name = "MoreControls";
            this.MoreControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoreControls.Size = new System.Drawing.Size(309, 241);
            this.MoreControls.TabIndex = 30;
            this.MoreControls.TabStop = false;
            this.MoreControls.Text = "More Controls";
            // 
            // Firewall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 447);
            this.Controls.Add(this.MoreControls);
            this.Controls.Add(this.DecisionBox);
            this.Controls.Add(this.ResestBtn);
            this.Controls.Add(this.CheckPacketBtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.comboboxProtocol);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.BoxPacketData);
            this.Controls.Add(this.boxDstPort);
            this.Controls.Add(this.boxDstIP);
            this.Controls.Add(this.BoxSrcPort);
            this.Controls.Add(this.BoxSrcIP);
            this.Controls.Add(this.labelPacketData);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelProtocol);
            this.Controls.Add(this.labelDstPort);
            this.Controls.Add(this.labelSrcPort);
            this.Controls.Add(this.labelDstIP);
            this.Controls.Add(this.labelSrcIP);
            this.Controls.Add(this.back_Btn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Firewall";
            this.Text = "Firewall";
            this.Load += new System.EventHandler(this.Firewall_Load);
            this.DecisionBox.ResumeLayout(false);
            this.DecisionBox.PerformLayout();
            this.MoreControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Btn;
        private System.Windows.Forms.Label labelSrcIP;
        private System.Windows.Forms.Label labelDstIP;
        private System.Windows.Forms.Label labelSrcPort;
        private System.Windows.Forms.Label labelDstPort;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelPacketData;
        private System.Windows.Forms.TextBox BoxSrcIP;
        private System.Windows.Forms.TextBox BoxSrcPort;
        private System.Windows.Forms.TextBox boxDstIP;
        private System.Windows.Forms.TextBox boxDstPort;
        private System.Windows.Forms.TextBox BoxPacketData;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboboxProtocol;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button CheckPacketBtn;
        private System.Windows.Forms.Button ResestBtn;
        private System.Windows.Forms.Button ViewDeafultRulesBtn;
        private System.Windows.Forms.Button ViiewCustomRulesBtn;
        private System.Windows.Forms.Button AddCustomRulesBtn;
        private System.Windows.Forms.Label Decision;
        private System.Windows.Forms.Label RuleApplied;
        private System.Windows.Forms.GroupBox DecisionBox;
        private System.Windows.Forms.Label AppliedFrom;
        private System.Windows.Forms.GroupBox MoreControls;
    }
}