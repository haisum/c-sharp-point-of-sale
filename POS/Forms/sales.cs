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
    public partial class sales : Form
    {
        int count = 1;
        int OrderCount = 0;
        int ItemCount = 0;
        App_Data.POSDataSetTableAdapters.OrdersTableAdapter myOrdersAd = new App_Data.POSDataSetTableAdapters.OrdersTableAdapter();
        App_Data.POSDataSetTableAdapters.Order_ItemsTableAdapter myOrderItemsAd = new App_Data.POSDataSetTableAdapters.Order_ItemsTableAdapter();

        public sales()
        {
            InitializeComponent();
        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkDelivery.Checked)
            {
                return;
            }
            new Forms.Delivery().ShowDialog();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.pOSDataSet.Categories);
            //if(cmbItems.SelectedIndex != -1)
                fillItems();
                PopulateListViewOrders();
        }

        private void fillItems()
        {
            cmbItemIds.Items.Clear();
            cmbItems.Items.Clear();
            App_Data.POSDataSetTableAdapters.ItemsTableAdapter myItAd = new App_Data.POSDataSetTableAdapters.ItemsTableAdapter();
            App_Data.POSDataSet.ItemsDataTable myItTbl = new App_Data.POSDataSet.ItemsDataTable();

            myItAd.FillItemViaCatBy(myItTbl, Convert.ToInt32(cmbCatIDs.SelectedValue));
            foreach (DataRow myRow in myItTbl.Rows)
            {
                cmbItems.Items.Add(myRow["item_name"].ToString());
                cmbItemIds.Items.Add(myRow["item_price"].ToString());
            }
            if(cmbItems.Items.Count>0)
                cmbItems.SelectedIndex = 0;
        }

        private void cmbCatIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (numPrice.Value == 0 || cmbCatIDs.SelectedIndex == -1 || cmbItems.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid Data!! Make Sure You have given Quantity and Selected an Item");
                    return;
                }
                    string[] strItems = new string[4];
                    strItems[0] = (count).ToString();
                    count++;
                    strItems[1] = cmbItems.SelectedItem.ToString();
                    strItems[2] = numPrice.Value.ToString();
                    strItems[3] = (Convert.ToInt32(cmbItemIds.Items[cmbItems.SelectedIndex]) * numPrice.Value).ToString();
                    ListViewItem newItem = new ListViewItem(strItems);
                    listViewSaleItems.Items.Add(newItem);
                    lblPrice.Text = (Convert.ToInt32(lblPrice.Text) + Convert.ToInt32(strItems[3])).ToString(); 
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in Adding!\n" + exc.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                count = 1;
                lblPrice.Text = (Convert.ToInt32(lblPrice.Text) - Convert.ToInt32(listViewSaleItems.FocusedItem.SubItems[3].Text)).ToString();
                listViewSaleItems.FocusedItem.Remove();

                for (int index = 0; index < listViewSaleItems.Items.Count; index++)
                {
                    ListViewItem.ListViewSubItem myItem = new ListViewItem.ListViewSubItem(listViewSaleItems.Items[index], count.ToString());
                    listViewSaleItems.Items[index].SubItems[0] = myItem;
                    count++;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Make sure you have selected an item\n" + exc.Message);
            }

        }

        private void btnAddtoDb_Click(object sender, EventArgs e)
        {
            count = 1;
            int OrderId = 0;
            App_Data.POSDataSet.OrdersDataTable myOrdTb = new App_Data.POSDataSet.OrdersDataTable();
            if (listViewSaleItems.Items.Count < 1)
            {
                MessageBox.Show("No Item Inserted");
                return;
            }
            try
            {
                int OrderType = 1;
                if (chkDelivery.Checked == true)
                    OrderType = 2;
                myOrdersAd.InsertOrderQuery(OrderType, Convert.ToInt32(lblPrice.Text), Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                myOrdersAd.Fill(myOrdTb);
                OrderId = Convert.ToInt32(myOrdTb.Rows[myOrdTb.Rows.Count-1][0].ToString());
                foreach (ListViewItem myItem in listViewSaleItems.Items)
                {
                    myOrderItemsAd.InsertOrderedItemQuery(myItem.SubItems[1].Text, OrderId, Convert.ToInt32(myItem.SubItems[3].Text), Convert.ToInt32(myItem.SubItems[2].Text));
                }
                PopulateListViewOrders();
                listViewSaleItems.Items.Clear();

             }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void PopulateListViewOrders()
        {
            try
            {
                OrderCount = 0;
                listViewOrder.Items.Clear();
                cmbOrderIds.Items.Clear();
                App_Data.POSDataSet.OrdersDataTable myOrdersTb = new App_Data.POSDataSet.OrdersDataTable();
                myOrdersAd.FillOrderDatewiseBy(myOrdersTb, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                string[] OrderCollection = new string[3];
                string OrderType = "";
                foreach (DataRow myRow in myOrdersTb.Rows)
                {
                    if (myRow["order_type_id"].ToString() == "1")
                        OrderType = "Normal";
                    else
                        OrderType = "Delivery";
                    OrderCollection[0] = (++OrderCount).ToString();
                    OrderCollection[1] = OrderType;
                    OrderCollection[2] = myRow["total_amount"].ToString();
                    cmbOrderIds.Items.Add(myRow["order_id"].ToString());
                    ListViewItem myIt = new ListViewItem(OrderCollection);
                    listViewOrder.Items.Add(myIt);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in Populating List View\n" + exc.Message);
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateOrderItemsListView();
        }

        void PopulateOrderItemsListView()
        {
            try
            {
                ItemCount = 0;
                cmbOrderItemIds.Items.Clear();
                listViewItems.Items.Clear();

                App_Data.POSDataSet.Order_ItemsDataTable myOrderItmsTbl = new App_Data.POSDataSet.Order_ItemsDataTable();
                myOrderItemsAd.FillOrderedItemsBy(myOrderItmsTbl, Convert.ToInt32(cmbOrderIds.Items[listViewOrder.FocusedItem.Index].ToString()));
                string[] mySUbItems = new string[4];
                foreach (DataRow myRow in myOrderItmsTbl.Rows)
                {
                    mySUbItems[0] = (++ItemCount).ToString();
                    mySUbItems[1] = myRow["item_name"].ToString();
                    mySUbItems[2] = myRow["charges"].ToString();
                    mySUbItems[3] = myRow["Quantity"].ToString();
                    cmbOrderItemIds.Items.Add(myRow["order_item_id"].ToString());
                    ListViewItem myIt = new ListViewItem(mySUbItems);
                    listViewItems.Items.Add(myIt);
                }
            }
            catch 
            {
               // MessageBox.Show("Error in Loading Items\n" + exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                myOrderItemsAd.DeleteOrderItemsQuery(Convert.ToInt32(cmbOrderItemIds.Items[listViewItems.FocusedItem.Index].ToString()));
                //PopulateOrderItemsListView();
                int itemcount = 0;
                foreach (ListViewItem myIt in listViewItems.Items)
                {
                    ListViewItem.ListViewSubItem mySubIt = new ListViewItem.ListViewSubItem(myIt, (++itemcount).ToString());
                    listViewItems.Items[itemcount - 1].SubItems[0] = mySubIt;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Make Sure You Have Selected an Order\n" + exc.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                myOrdersAd.DeleteOrderQuery(Convert.ToInt32(cmbOrderIds.Items[listViewOrder.FocusedItem.Index].ToString()));
                myOrderItemsAd.DeletebyOrderIdQuery(Convert.ToInt32(cmbOrderIds.Items[listViewOrder.FocusedItem.Index].ToString()));
                PopulateListViewOrders();
                listViewItems.Items.Clear();
            }

            catch (Exception exc)
            {
                MessageBox.Show("Make Sure You Have Selected an Item\n" + exc.Message);
            }
        }
        
    }
}
