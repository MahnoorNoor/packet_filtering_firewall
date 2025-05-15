using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Group10_proj
{
    public partial class Firewall : Form
    // Define a class named Firewall that inherits from Form
    {
        private FirewallClass firewall;
        // Define a private field for the FirewallClass
        // Define the constructor of the Firewall class
        public Firewall()
        {
            InitializeComponent();
            firewall = new FirewallClass(); 
            this.AcceptButton = CheckPacketBtn; // Set the CheckPacketBtn as the accept button
            this.Shown += Firewall_Shown; // Add an event handler for the Shown event
        }
        private void Firewall_Shown(object sender, EventArgs e)
        {
            firewall.LoadRules(); // Load the firewall rules when the form is shown
        }
        // Define a method to update the firewall
        public void UpdateFirewall(string decision, string ruleApplied, string appliedFrom)
        {
            Decision.Text = decision;
            RuleApplied.Text = ruleApplied;
            AppliedFrom.Text = appliedFrom;
        }
        // Define an event handler for the CheckPacketBtn button's click event
        private void CheckPacketBtn_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrEmpty(BoxSrcIP.Text) ||
                string.IsNullOrEmpty(boxDstIP.Text) ||
                string.IsNullOrEmpty(BoxSrcPort.Text) ||
                string.IsNullOrEmpty(boxDstPort.Text) ||
                string.IsNullOrEmpty(BoxPacketData.Text) ||
                string.IsNullOrEmpty(comboboxProtocol.SelectedItem?.ToString()))
            {
                MessageBox.Show("All fields must be filled out.", "Error");
                return;
            }
            //Exception Handling;
            if (!Regex.IsMatch(BoxSrcIP.Text, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$") ||
                !Regex.IsMatch(boxDstIP.Text, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))
            {
                MessageBox.Show("IP address is not in the correct format.", "Error");
                return;
            }
            if (!Regex.IsMatch(BoxSrcPort.Text, @"^\d{2,4}$") || !Regex.IsMatch(boxDstPort.Text, @"^\d{2,4}$"))
            {
                MessageBox.Show("Port number should only be 2, 3 or 4 numbers.", "Error");
                return;
            }
            if (!Regex.IsMatch(BoxPacketData.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Data should be in hexadecimal format.", "Error");
                return;
            }

            Packet packet = new Packet
            {
                Src_IP = BoxSrcIP.Text,
                Dst_IP = boxDstIP.Text,
                Src_Port = int.Parse(BoxSrcPort.Text),
                Dst_Port = int.Parse(boxDstPort.Text),
                Protocol = comboboxProtocol.SelectedItem.ToString(),
                Data = BoxPacketData.Text,
                Timestamp = DateTime.Now
            };
            // Check the packet against the rules
            firewall.CheckPacket(packet, this);
        }
        private void ResestBtn_Click(object sender, EventArgs e)
        {
            BoxSrcIP.Text = "";
            boxDstIP.Text = "";
            BoxSrcPort.Text = "";
            boxDstPort.Text = "";
            BoxPacketData.Text = "";
            comboboxProtocol.SelectedIndex = -1; // Clear the selected item in the combobox
            DecisionBox.Text = "";
        }
        private void ViewDeafultRulesBtn_Click(object sender, EventArgs e)
        {
            string rulesText = firewall.GetDefaultRules();
            MessageBox.Show(rulesText, "Default Rules");
        }
        private void ViiewCustomRulesBtn_Click(object sender, EventArgs e)
        {
            string rulesText = firewall.GetCustomRules();
            MessageBox.Show(rulesText, "Custom Rules");
        }
        private void AddCustomRulesBtn_Click(object sender, EventArgs e)
        {
            {
                // Create the AdminLogin form
                AdminLogin form = new AdminLogin(this); // Pass the current form as a parameter
                this.Hide(); // Hide the Firewall form
                form.ShowDialog(); // Show the AdminLogin form
            }
            
        }
        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Close();
        }
        #region Empty Methods
        private void Firewall_Load(object sender, EventArgs e)
        {

        }

        private void boxDstPort_TextChanged(object sender, EventArgs e)
        {

        }


        private void BoxSrcIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxSrcPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDstIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxPacketData_TextChanged(object sender, EventArgs e)
        {

        }

        private void DecisionBox_Enter(object sender, EventArgs e)
        {

        }
        private void Decision_Click(object sender, EventArgs e)
        {

        }

        private void RuleApplied_Click(object sender, EventArgs e)
        {

        }

        private void AppliedFrom_Click(object sender, EventArgs e)
        {

        }  
        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

      
    }
}