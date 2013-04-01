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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("You Must Insert A Name For Category");
                    return;
                }
                App_Data.POSDataSetTableAdapters.CategoriesTableAdapter myCatAd = new App_Data.POSDataSetTableAdapters.CategoriesTableAdapter();
                myCatAd.InsertCategoryQuery(textBox1.Text.Trim());
                MessageBox.Show("Category Successfully Added!");                
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
