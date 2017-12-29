namespace Tools4URentalScrn
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Conrete Drillers and Saws");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Electric Powered Tools");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Wood Floors");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sidewalks");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Floors & Carpentry", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Power Generators");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Yard & Garden");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Flowers and Stone");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pressure Washers");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Landscaping", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Storage Units & Containers");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Hand Tools");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Waste Disposal");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Renovation");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Remodeling", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Painting Equitment");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Smal & Wheel barrows");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Large & Rental Trucks");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Trailers & Tractors");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Vechiles", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Concrete",
            "Drill",
            "$39.99",
            "56"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Power Tools",
            "Saw",
            "$39.99",
            "100"}, -1);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Catagory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tool = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Instock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(509, 396);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Checkout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Method";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(12, 46);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Conrete Drillers and Saws";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Electric Powered Tools";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Wood Floors";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Sidewalks";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Floors & Carpentry";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Power Generators";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Yard & Garden";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Flowers and Stone";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Pressure Washers";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Landscaping";
            treeNode11.Name = "Node10";
            treeNode11.Text = "Storage Units & Containers";
            treeNode12.Name = "Node12";
            treeNode12.Text = "Hand Tools";
            treeNode13.Name = "Node13";
            treeNode13.Text = "Waste Disposal";
            treeNode14.Name = "Node14";
            treeNode14.Text = "Renovation";
            treeNode15.Name = "Node11";
            treeNode15.Text = "Remodeling";
            treeNode16.Name = "Node15";
            treeNode16.Text = "Painting Equitment";
            treeNode17.Name = "Node18";
            treeNode17.Text = "Smal & Wheel barrows";
            treeNode18.Name = "Node20";
            treeNode18.Text = "Large & Rental Trucks";
            treeNode19.Name = "Node23";
            treeNode19.Text = "Trailers & Tractors";
            treeNode20.Name = "Node17";
            treeNode20.Text = "Vechiles";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode6,
            treeNode10,
            treeNode11,
            treeNode15,
            treeNode16,
            treeNode20});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(187, 438);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Debit",
            "Credit",
            "Paypal"});
            this.comboBox1.Location = new System.Drawing.Point(331, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Catagory,
            this.Tool,
            this.Price,
            this.Instock});
            listViewItem1.Tag = "Concrete";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(233, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 153);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Catagory
            // 
            this.Catagory.Text = "Catagory";
            this.Catagory.Width = 102;
            // 
            // Tool
            // 
            this.Tool.Text = "Tool";
            this.Tool.Width = 113;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 64;
            // 
            // Instock
            // 
            this.Instock.Text = "Instock";
            this.Instock.Width = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tools 4 U Rental System";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Location = new System.Drawing.Point(389, 253);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(187, 97);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Toal Price";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total Items";
            this.columnHeader2.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(713, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Catagory;
        private System.Windows.Forms.ColumnHeader Tool;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Instock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
                    
    }
}

