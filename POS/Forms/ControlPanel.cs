using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }


        private void btnChngPass_Click(object sender, EventArgs e)
        {
            new Forms.Users.ChangePassword().ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            new Forms.Users.AddUser().ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new Forms.Users.EditUsers().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Forms.Items.AddCategory().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Forms.Items.EditCategories().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Forms.Items.AddItem().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Forms.Items.EditItems().ShowDialog();
        }
    }
}
