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
    public partial class EditCategories : Form
    {
        App_Data.POSDataSetTableAdapters.CategoriesTableAdapter myCatAd = new App_Data.POSDataSetTableAdapters.CategoriesTableAdapter();
        public EditCategories()
        {
            InitializeComponent();
        }

        private void EditCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pOSDataSet.Categories);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("You Must Select an Item First");
                return;
            }
            try
            {
                myCatAd.UpdateCategoryQuery(textBox1.Text, Convert.ToInt32(listBox1.SelectedValue));
                MessageBox.Show("Category Updated");
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 1)
            {
                MessageBox.Show("You Must Select an Item First");
                return;
            }
            try
            {
                myCatAd.DeleteCategoryQuery(Convert.ToInt32(listBox1.SelectedValue));
                MessageBox.Show("Category Deleted");                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
