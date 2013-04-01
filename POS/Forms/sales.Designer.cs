namespace POS
{
    partial class sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbItemIds = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.btnAddtoDb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewSaleItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCatIDs = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource();
            this.pOSDataSet = new POS.App_Data.POSDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new POS.App_Data.POSDataSetTableAdapters.CategoriesTableAdapter();
            this.cmbOrderIds = new System.Windows.Forms.ComboBox();
            this.cmbOrderItemIds = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbItemIds);
            this.groupBox1.Controls.Add(this.numPrice);
            this.groupBox1.Controls.Add(this.chkDelivery);
            this.groupBox1.Controls.Add(this.btnAddtoDb);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listViewSaleItems);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbItems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCatIDs);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 646);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New order";
            // 
            // cmbItemIds
            // 
            this.cmbItemIds.FormattingEnabled = true;
            this.cmbItemIds.Location = new System.Drawing.Point(66, 139);
            this.cmbItemIds.Name = "cmbItemIds";
            this.cmbItemIds.Size = new System.Drawing.Size(32, 27);
            this.cmbItemIds.TabIndex = 19;
            this.cmbItemIds.Visible = false;
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(106, 98);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(236, 27);
            this.numPrice.TabIndex = 18;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(15, 484);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(64, 17);
            this.chkDelivery.TabIndex = 17;
            this.chkDelivery.Text = "Delivery";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // btnAddtoDb
            // 
            this.btnAddtoDb.Location = new System.Drawing.Point(33, 595);
            this.btnAddtoDb.Name = "btnAddtoDb";
            this.btnAddtoDb.Size = new System.Drawing.Size(294, 37);
            this.btnAddtoDb.TabIndex = 16;
            this.btnAddtoDb.Text = "Print and add to queue";
            this.btnAddtoDb.UseVisualStyleBackColor = true;
            this.btnAddtoDb.Click += new System.EventHandler(this.btnAddtoDb_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete Selected Item From List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Corbel", 24.25F);
            this.lblPrice.Location = new System.Drawing.Point(162, 542);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 40);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 24.25F);
            this.label5.Location = new System.Drawing.Point(70, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // listViewSaleItems
            // 
            this.listViewSaleItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewSaleItems.FullRowSelect = true;
            this.listViewSaleItems.Location = new System.Drawing.Point(6, 219);
            this.listViewSaleItems.MultiSelect = false;
            this.listViewSaleItems.Name = "listViewSaleItems";
            this.listViewSaleItems.Size = new System.Drawing.Size(375, 251);
            this.listViewSaleItems.TabIndex = 12;
            this.listViewSaleItems.UseCompatibleStateImageBehavior = false;
            this.listViewSaleItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "S.No.";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 129;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add to list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(106, 64);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(237, 27);
            this.cmbItems.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category";
            // 
            // cmbCatIDs
            // 
            this.cmbCatIDs.DataSource = this.categoriesBindingSource;
            this.cmbCatIDs.DisplayMember = "category_name";
            this.cmbCatIDs.FormattingEnabled = true;
            this.cmbCatIDs.Location = new System.Drawing.Point(106, 31);
            this.cmbCatIDs.Name = "cmbCatIDs";
            this.cmbCatIDs.Size = new System.Drawing.Size(238, 27);
            this.cmbCatIDs.TabIndex = 0;
            this.cmbCatIDs.ValueMember = "category_id";
            this.cmbCatIDs.SelectedIndexChanged += new System.EventHandler(this.cmbCatIDs_SelectedIndexChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.pOSDataSet;
            // 
            // pOSDataSet
            // 
            this.pOSDataSet.DataSetName = "POSDataSet";
            this.pOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.listViewItems);
            this.groupBox2.Controls.Add(this.listViewOrder);
            this.groupBox2.Location = new System.Drawing.Point(429, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 646);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today\'s Order queue";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 595);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 37);
            this.button4.TabIndex = 17;
            this.button4.Text = "Delete Selected Item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(189, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 37);
            this.button5.TabIndex = 17;
            this.button5.Text = "Delete Selected Order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.Location = new System.Drawing.Point(6, 301);
            this.listViewItems.MultiSelect = false;
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(375, 281);
            this.listViewItems.TabIndex = 13;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "S.No.";
            this.columnHeader6.Width = 49;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item";
            this.columnHeader7.Width = 127;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 74;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Price";
            this.columnHeader9.Width = 125;
            // 
            // listViewOrder
            // 
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader12,
            this.columnHeader10});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.Location = new System.Drawing.Point(6, 26);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(375, 269);
            this.listViewOrder.TabIndex = 0;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.SelectedIndexChanged += new System.EventHandler(this.listViewOrder_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order number";
            this.columnHeader5.Width = 158;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Order type";
            this.columnHeader12.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Amount";
            this.columnHeader10.Width = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 697);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "powered by designplox";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 42);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sales";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbOrderIds
            // 
            this.cmbOrderIds.FormattingEnabled = true;
            this.cmbOrderIds.Location = new System.Drawing.Point(784, 27);
            this.cmbOrderIds.Name = "cmbOrderIds";
            this.cmbOrderIds.Size = new System.Drawing.Size(32, 27);
            this.cmbOrderIds.TabIndex = 20;
            this.cmbOrderIds.Visible = false;
            // 
            // cmbOrderItemIds
            // 
            this.cmbOrderItemIds.FormattingEnabled = true;
            this.cmbOrderItemIds.Location = new System.Drawing.Point(816, 316);
            this.cmbOrderItemIds.Name = "cmbOrderItemIds";
            this.cmbOrderItemIds.Size = new System.Drawing.Size(32, 27);
            this.cmbOrderItemIds.TabIndex = 21;
            this.cmbOrderItemIds.Visible = false;
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 713);
            this.Controls.Add(this.cmbOrderItemIds);
            this.Controls.Add(this.cmbOrderIds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCatIDs;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSaleItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddtoDb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkDelivery;
        private App_Data.POSDataSet pOSDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private App_Data.POSDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cmbItemIds;
        private System.Windows.Forms.ComboBox cmbOrderIds;
        private System.Windows.Forms.ComboBox cmbOrderItemIds;
    }
}