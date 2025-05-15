using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Group10_proj
{
    public partial class AddCustomRules : Form
    {
        public AddCustomRules()
        {
            InitializeComponent();
            comboboxappliedto.SelectedIndexChanged += comboboxappliedto_SelectedIndexChanged;
        }
        private void comboboxappliedto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check the selected item in the combobox
            switch (comboboxappliedto.SelectedItem?.ToString())
            {
                case "SRC":
                case "DST":
                    // If "SRC" or "DST" is selected, enable the IPBox and PortBox, and disable the comboboxProtocol
                    IPBox.Enabled = true;
                    PortBox.Enabled = true;
                    comboboxProtocol.Enabled = false;
                    break;
                case "PRO":
                    // If "PRO" is selected, disable the IPBox and PortBox, and enable the comboboxProtocol
                    IPBox.Enabled = false;
                    PortBox.Enabled = false;
                    comboboxProtocol.Enabled = true;
                    break;
                default:
                    // If nothing or an unrecognized item is selected, enable all controls
                    IPBox.Enabled = true;
                    PortBox.Enabled = true;
                    comboboxProtocol.Enabled = true;
                    break;
            }
            // Refresh the controls
            IPBox.Refresh();
            PortBox.Refresh();
            comboboxProtocol.Refresh();
        }

        #region Empty Methods
        private void IPBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void PortBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboboxProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboboxDecision_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void AddCustomRules_Load(object sender, EventArgs e)
        {
        }
        #endregion
        private void ViiewCustomRulesBtn_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("CustomRules.txt");

            // Combine all lines into a single string
            string allRules = string.Join(Environment.NewLine, lines);

            // Display the rules in a message box
            MessageBox.Show(allRules, "Custom Rules");
        }

        private void ResestBtn_Click(object sender, EventArgs e)
        {
            comboboxappliedto.SelectedIndex = -1;
            IPBox.Text = "";
            PortBox.Text = "";
            comboboxProtocol.SelectedIndex = -1;
            comboboxDecision.SelectedIndex = -1;
        }

        private void AddRuleBtn_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (string.IsNullOrEmpty(comboboxappliedto.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(IPBox.Text) ||
                string.IsNullOrEmpty(PortBox.Text) ||
                string.IsNullOrEmpty(comboboxProtocol.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(comboboxDecision.SelectedItem?.ToString()))
            {
                MessageBox.Show("All fields must be filled out.", "Error");
                return;
            }

            if (!Regex.IsMatch(IPBox.Text, @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))
            {
                MessageBox.Show("IP address is not in the correct format.", "Error");
                return;
            }

            if (!Regex.IsMatch(PortBox.Text, @"^\d{2,4}$"))
            {
                MessageBox.Show("Port number should only be 2, 3 or 4 numbers.", "Error");
                return;
            }

            // Create a new rule based on the values in your form
            Rules newRule = new Rules
            {
                App = comboboxappliedto.SelectedItem.ToString(),
                IP = IPBox.Text,
                Port = int.Parse(PortBox.Text),
                Protocol = comboboxProtocol.SelectedItem.ToString(),
                Decision = comboboxDecision.SelectedItem.ToString()
            };
            // Read all lines from the file
            string[] lines = System.IO.File.ReadAllLines("CustomRules.txt");

            // Determine the rule number for the new rule
            newRule.Rule_Num = lines.Length > 0 ? int.Parse(lines[lines.Length - 1].Split(' ')[0]) + 1 : 1;

            // Convert the new rule to a string
            string newRuleString = $"{newRule.Rule_Num} {newRule.App} {newRule.Port} {newRule.IP} {newRule.Decision}";

            // Append the new rule to the file
            System.IO.File.AppendAllText("CustomRules.txt", newRuleString + Environment.NewLine);
        }

        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Firewall firewall = new Firewall();
            firewall.ShowDialog();
            this.Close();
        }

        private void ApptoLab_Click(object sender, EventArgs e)
        {

        }

        private void ProtocolLab_Click(object sender, EventArgs e)
        {

        }

        private void PortLab_Click(object sender, EventArgs e)
        {

        }

        private void IpLab_Click(object sender, EventArgs e)
        {

        }

        private void DecisionLab_Click(object sender, EventArgs e)
        {

        }
    }
}