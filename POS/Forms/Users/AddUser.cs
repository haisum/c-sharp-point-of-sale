using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Forms.Users
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please Insert Password and User Name");
                    return;
                }
                byte type = 1;
                if (cmbType.SelectedItem.ToString() == "Moderator")
                    type = 2;
                App_Data.POSDataSetTableAdapters.UsersTableAdapter myUserAd = new App_Data.POSDataSetTableAdapters.UsersTableAdapter();
                myUserAd.InsertUserQuery(txtUserName.Text.Trim(), txtPassword.Text, type);
                MessageBox.Show("New User Added");
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
