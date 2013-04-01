using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.App_Data;
using POS.App_Data.POSDataSetTableAdapters;
using POS.Classes;

namespace POS
{
    public partial class homescreen : Form
    {
        public homescreen()
        {
            InitializeComponent();
        }


        private void homescreen_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + global.user_name; 
            if (global.user_type != 2)
            {
                btnControlPanel.Enabled = false;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnControlPanel_Click(object sender, EventArgs e)
        {
            new ControlPanel().ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new sales().ShowDialog();
        }
    }
}
