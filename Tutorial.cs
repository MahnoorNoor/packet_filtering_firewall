using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group10_proj
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
           
        }
        #region Empty
        private void Tutorial_Load(object sender, EventArgs e) {}
        private void Tutorial_label_Click(object sender, EventArgs e) {}
        private void InstructionsLabel_Click(object sender, EventArgs e) { }

        #endregion
        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            // Close the Tutorial form after the Welcome form is closed
            this.Close();
        }

        private void RunningFirewallBtn_Click(object sender, EventArgs e)
        {
            InstructionsLabel.Text = @"
 - Launch the application and navigate to the Firewall form.
 - Here, you'll find fields to enter your packet data.
 - Carefully enter the Source IP and Destination IP, 
    ensuring they're in the correct format.
 - Next, input the Source Port and Destination Port.
 - From the dropdown menu, select the protocol. 
    You have three options: TCP, UDP, or ICMP.
 - Now, it's time to enter your data. Make sure it's 
   in hexadecimal form.
 - Hit the 'Check' button and our program will do the rest! 
    It will verify if the firewall will allow your packet through 
    and display the result.
 - Feel free to explore the program's default rules and other
    user-added rules.
 - Want to add custom rules? You can! But remember, 
    you'll need admin permission for that.";
        }

        private void AddingCustomRulesBtn_Click(object sender, EventArgs e)
        {
            InstructionsLabel.Text = @"
 - Click on the 'Add Custom Rules' button. 
    This will take you to the Admin Login form.
 - Enter your admin username and password. 
    Don't worry, it's all secure!
 - Once you're in, you'll see a dropdown box. 
    Here, you can choose SRC, DST, or PRO.
 - Depending on your choice, you can add the 
    respective IP and protocol. 
   Note that if you choose PRO, the IP and port box will 
    be disabled, leaving only the protocol dropdown box enabled.
 - Now, make your decision. Do you want to allow 
    or deny it?
 - Click the 'Add Rules' button and voila! 
    Your rules are now added to the custom rules.
 - You can view them anytime by clicking the 
    'View Custom Rules' button.";
        }
    }
}
