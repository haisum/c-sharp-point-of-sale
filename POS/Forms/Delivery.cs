using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS.Forms
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtCn.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("All fields must be specified");
                return;
            }
            Classes.DeliveryOrderData.CustomerName = txtname.Text;
            Classes.DeliveryOrderData.CustomerCellNo = txtCn.Text;
            Classes.DeliveryOrderData.CustomerAddress = txtAddress.Text;
            Classes.DeliveryOrderData.DeliveryCharges = Convert.ToInt32(numCharges.Value);
            this.Close();
        }
    }
}
