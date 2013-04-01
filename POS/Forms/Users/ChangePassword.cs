using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POS.Classes;

namespace POS.Forms.Users
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            lblUserName.Text = global.user_name;

        }

        private void btnChngPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPass.Text.Trim() == global.password)
                {
                    App_Data.POSDataSetTableAdapters.UsersTableAdapter myUserAd = new App_Data.POSDataSetTableAdapters.UsersTableAdapter();
                    myUserAd.UpdatePasswordQuery(txtNewPass.Text, global.user_id);
                    MessageBox.Show("Password Updated Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Old Password!\nTry again.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
         }
    }
}

