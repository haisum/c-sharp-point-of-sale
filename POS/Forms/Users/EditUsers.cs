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
    public partial class EditUsers : Form
    {
        App_Data.POSDataSetTableAdapters.UsersTableAdapter myUserAd = new App_Data.POSDataSetTableAdapters.UsersTableAdapter();
 
        public EditUsers()
        {
            InitializeComponent();
        }

        private void EditUsers_Load(object sender, EventArgs e)
        {
            WriteListView();
        }

        private void WriteListView()
        {
            App_Data.POSDataSet.UsersDataTable objDT = new App_Data.POSDataSet.UsersDataTable();
            myUserAd.FillUsersBy(objDT);
            cmbIDs.Items.Clear();
            listView1.Items.Clear();
            cmbIDs.Items.Clear();
            string[] str = new string[objDT.Columns.Count];
            string type = "";
            //adding Datarows as listview Grids

            foreach (DataRow objRR in objDT.Rows)
            {

                for (int col = 0; col <= objDT.Columns.Count - 1; col++)
                {
                    if (col == 0)
                    {
                        cmbIDs.Items.Add(objRR[col].ToString());
                        continue;
                    }
                    if (col == 3)
                    {
                        if (objRR[3].ToString() == "1")
                        {
                            type = "Regular";
                            str[2] = type;

                            
                        }
                        else if (objRR[3].ToString() == "2")
                        {
                            type = "Moderator";
                            str[2] = type;

                        }
                        continue;
                    }

                    str[col - 1] = objRR[col].ToString();
                }
                ListViewItem ii;
                ii = new ListViewItem(str);
                listView1.Items.Add(ii);

             }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string type = "Regular";
            try
            {
                txtUserName.Text = listView1.FocusedItem.Text;
                txtPassword.Text = listView1.FocusedItem.SubItems[1].Text;
                if (listView1.FocusedItem.SubItems[2].Text == "Moderator")
                {
                    //type = "Moderator";
                    cmbUserType.SelectedItem = cmbUserType.Items[1];
                }
                else if (listView1.FocusedItem.SubItems[2].Text == "Regular")
                {
                    cmbUserType.SelectedItem = cmbUserType.Items[0];
                }

            }
            catch
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count!=1)
            {
                MessageBox.Show("No Record Selected!");
                return;
            }
            byte typeId = 1;
            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("User Name and Password must not be empty");
                    return;
                }
                else
                {
                    if(cmbUserType.SelectedItem.ToString() == "Moderator")
                        typeId = 2;
                    myUserAd.UpdateUsersDataQuery(typeId, txtUserName.Text, txtPassword.Text, Convert.ToInt32(cmbIDs.Items[listView1.FocusedItem.Index].ToString()));
                    MessageBox.Show("Record Updated Successfully");
                    WriteListView();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Make Sure You Have Selected A Record and User Type is Selected\n" + exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                myUserAd.DeleteUsersQuery(Convert.ToInt32(cmbIDs.Items[listView1.FocusedItem.Index].ToString()));
                MessageBox.Show("Record Deleted Successfully!");
                WriteListView();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Make Sure You Have Selected A Record\n" + exc.Message);
            }
        }
    }
}
