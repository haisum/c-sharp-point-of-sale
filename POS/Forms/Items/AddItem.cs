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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pOSDataSet.Categories);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text == "" || numPrice.Value == 0 || cmbCategories.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid input make sure everything is specified!");
                    return;
                }
                App_Data.POSDataSetTableAdapters.ItemsTableAdapter myItAd = new App_Data.POSDataSetTableAdapters.ItemsTableAdapter();
                myItAd.InsertItemQuery(txtItemName.Text, Convert.ToInt32(cmbCategories.SelectedValue), Convert.ToInt32(numPrice.Value));
                MessageBox.Show("New Item Added");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
