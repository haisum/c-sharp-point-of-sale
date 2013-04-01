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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
            UsersTableAdapter myUsersAd = new UsersTableAdapter();
            POSDataSet.UsersDataTable myUsersTbl = new POSDataSet.UsersDataTable();
            myUsersTbl = myUsersAd.GetUsersDataBy();

            bool UserRecordFound = false;

            foreach (DataRow myRow in myUsersTbl.Rows)
                {

                    if (myRow["User_Name"].ToString().ToLower().Trim() == txtUserName.Text.ToLower().Trim() && myRow["Password"].ToString().Trim() == txtPassword.Text.Trim())
                    {
                        global.user_id = Convert.ToInt32(myRow["User_ID"]);
                        global.user_type = Convert.ToByte(myRow["Type"].ToString());
                        global.user_name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myRow["User_Name"].ToString());
                        global.password = myRow["Password"].ToString().Trim();

                        UserRecordFound = true;

                        new homescreen().Show();
                        this.Hide();
                        //this.Close();

                        break;
                    }


                }

                if (!UserRecordFound)
                {
                    MessageBox.Show("Invalid User Name/Password\nPlease Try Again");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Unable to Load Database\n" + exc.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
