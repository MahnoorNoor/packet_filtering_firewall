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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.Location = new Point(982, 679);
        }
        #region Empty
        private void WelcomePage_Click(object sender, EventArgs e){}

        private void Welcome_Load(object sender, EventArgs e){}
        #endregion
        private void Tutorial_Btn_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            this.Hide();
            tutorial.ShowDialog();
            this.Close();
        }

        private void Firewall_btn_Click_1(object sender, EventArgs e)
        {
            Firewall firewallForm = new Firewall();
            this.Hide();
            firewallForm.ShowDialog();
            this.Close();
        }

        private void CreatorsCredit_Click(object sender, EventArgs e)
        {

        }
    }
}

