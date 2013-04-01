using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Forms.Items
{
    public partial class EditItems : Form
    {



        public EditItems()
        {
            InitializeComponent();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {
            try
            {
                WriteListView();
                // TODO: This line of code loads data into the 'pOSDataSet.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.pOSDataSet.Categories);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void WriteListView()
        {
            try
            {
                App_Data.POSDataSetTableAdapters.SelectItemsTableAdapter myItAd = new App_Data.POSDataSetTableAdapters.SelectItemsTableAdapter();
                App_Data.POSDataSet.SelectItemsDataTable objDT = new App_Data.POSDataSet.SelectItemsDataTable();
                myItAd.FillItemsBy(objDT);
                cmbIDs.Items.Clear();
                listView1.Items.Clear();
                cmbIDs.Items.Clear();
                string[] str = new string[objDT.Columns.Count];
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
                       /* if (col == 2)
                        {
                            if (objRR[2].ToString() == "1")
                            {
                                type = "Regular";
                                str[1] = type;


                            }
                            else if (objRR[2].ToString() == "2")
                            {
                                type = "Moderator";
                                str[1] = type;

                            }
                            continue;
                        }*/

                        str[col - 1] = objRR[col].ToString();
                    }
                    ListViewItem ii;
                    ii = new ListViewItem(str);
                    listView1.Items.Add(ii);

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtItName.Text = listView1.FocusedItem.SubItems[0].Text;
                numPrice.Value = Convert.ToDecimal(listView1.FocusedItem.SubItems[2].Text);
                cmbCats.SelectedItem = cmbCats.Items[cmbCats.FindStringExact(listView1.FocusedItem.SubItems[1].Text)];
                //MessageBox.Show(cmbCats.FindStringExact(listView1.FocusedItem.SubItems[1].Text).ToString());
                
            }
            catch
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Make sure a record is selected");
                    return;
                }
                else if(txtItName.Text == "" || numPrice.Value == 0 || cmbCats.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid Data! Make sure everything is inserted and category is selected");
                    return;
                }
                App_Data.POSDataSetTableAdapters.ItemsTableAdapter myItAd = new App_Data.POSDataSetTableAdapters.ItemsTableAdapter();
                myItAd.UpdateItemsQuery(txtItName.Text, Convert.ToInt32(cmbCats.SelectedValue.ToString()), Convert.ToInt32(numPrice.Value), Convert.ToInt32(cmbIDs.Items[listView1.FocusedItem.Index].ToString()));
                MessageBox.Show("Record Updated Successfully");
                WriteListView();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count != 1)
                {
                    MessageBox.Show("Make sure a record is selected");
                    return;
                }
                App_Data.POSDataSetTableAdapters.ItemsTableAdapter myItAd = new App_Data.POSDataSetTableAdapters.ItemsTableAdapter();
                myItAd.DeleteItemsQuery(Convert.ToInt32(cmbIDs.Items[listView1.FocusedItem.Index].ToString()));
                MessageBox.Show("Record Deleted Successfully");
                WriteListView();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
