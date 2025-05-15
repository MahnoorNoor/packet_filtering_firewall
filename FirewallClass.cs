using System;
using System.Collections.Generic; // for making lists like vectors and dynamic arrays
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //streamreader for reading files, like fstream
using System.Text.RegularExpressions;

namespace Group10_proj
{
    class FirewallClass
    {
        private List<Rules> defaultRules;
        private List<Rules> customRules;
        // Define the constructor of the FirewallClass
        public FirewallClass()
        {
            // Initialize the lists
            defaultRules = new List<Rules>();
            customRules = new List<Rules>();
            LoadRules();
        }
        // Define a method to get a string representation of all the default rules
        public string GetDefaultRules()
        {
            return string.Join("\n", defaultRules);
        }
        // Define a method to get a string representation of all the custom rules
        public string GetCustomRules()
        {
            return string.Join("\n", customRules);
        }
        public void LoadRules()
        {
            // Clear the existing rules
            defaultRules.Clear();
            customRules.Clear();

            // Load the default rules
            using (StreamReader reader = new StreamReader("DefaultRules.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse the line into a Rule object and add it to the list
                    Rules rule = Rules.ParseRule(line);
                    defaultRules.Add(rule);
                }
            }
            // Load the custom rules
            if (File.Exists("CustomRules.txt"))
            {
                using (StreamReader reader = new StreamReader("CustomRules.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Parse the line into a Rule object and add it to the list
                        Rules rule = Rules.ParseRule(line);
                        customRules.Add(rule);
                    }
                }
            }
        }
        public void CheckPacket(Packet packet, Firewall firewall)
        {
            // First check the packet against the default rules
            foreach (Rules rule in defaultRules)
            {
                if ((rule.App == "SRC" && rule.IP == packet.Src_IP && rule.Port == packet.Src_Port) ||
                    (rule.App == "DST" && rule.IP == packet.Dst_IP && rule.Port == packet.Dst_Port) ||
                    (rule.App == "PRO" && rule.Protocol == packet.Protocol))
                {
                    firewall.UpdateFirewall(rule.Decision, rule.ToString(), "DefaultRules.txt");
                    return;
                }
            }
            // If no default rule applies, check the packet against the custom rules
            foreach (Rules rule in customRules)
            {
                if ((rule.App == "SRC" && rule.IP == packet.Src_IP && rule.Port == packet.Src_Port) ||
                    (rule.App == "DST" && rule.IP == packet.Dst_IP && rule.Port == packet.Dst_Port) ||
                    (rule.App == "PRO" && rule.Protocol == packet.Protocol))
                {
                    firewall.UpdateFirewall(rule.Decision, rule.ToString(), "CustomRules.txt");
                    return;
                }
            }
            firewall.UpdateFirewall("No rule found", "", "");
        }
    }
}
