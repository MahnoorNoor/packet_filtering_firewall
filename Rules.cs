using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group10_proj
{
    class Rules
    {
        public int Rule_Num { get; set; }
        public string App { get; set; } // "SRC" or "DST"
        public int Port { get; set; } // Source or destination port
        public string IP { get; set; } // Source or destination IP
        public string Protocol { get; set; } // "TCP", "UDP", "ICMP"
        public string Decision { get; set; } // "ALLOW" or "DENY"

        // Override the ToString method to return a string representation of the rule
        public override string ToString()
        {
            return $"{Rule_Num} {App} {Port} {IP} {Protocol} {Decision}";
        }
        // Define a static method to parse a rule from a string
        public static Rules ParseRule(string line)
        {
            // Split the line into fields
            string[] fields = line.Split(' ');

            // Create a new Rule object
            Rules rule = new Rules();

            // Set the Rule_Num property
            rule.Rule_Num = int.Parse(fields[0]);

            // Set the App, Port, IP, and Decision properties based on the second field
            switch (fields[1])
            {
                case "SRC":
                case "DST":
                    rule.App = fields[1];
                    rule.Port = int.Parse(fields[2]);
                    rule.IP = fields[3];
                    rule.Decision = fields[4];
                    break;
                case "PRO":
                    rule.App = fields[1];
                    rule.Protocol = fields[2];
                    rule.Decision = fields[3];
                    break;
            }
            return rule;
        }
    }
}