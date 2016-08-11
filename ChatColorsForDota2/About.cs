using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColouredTextForDota2
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ErikHumphrey");
        }

        private void picReddit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://reddit.com/u/CronosDage");
        }

        private void picSteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/id/cronosdage");
        }

        private void btnSourceCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ErikHumphrey/chat-colors-for-dota2");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/ErikHumphrey/2");
        }
    }
}
