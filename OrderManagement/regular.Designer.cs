namespace OrderManagement
{
    partial class regular
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
            System.Windows.Forms.Button addBtn;
            System.Windows.Forms.Button updateBtn;
            System.Windows.Forms.Button deleteBtn;
            System.Windows.Forms.Button viewBtn;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.colorTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addproducttoorderBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.iduserTxt = new System.Windows.Forms.TextBox();
            this.idproductTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.viewoBtn = new System.Windows.Forms.Button();
            this.updateoBtn = new System.Windows.Forms.Button();
            this.addoBtn = new System.Windows.Forms.Button();
            this.statusoTxt = new System.Windows.Forms.TextBox();
            this.adressoTxt = new System.Windows.Forms.TextBox();
            this.nameoTxt = new System.Windows.Forms.TextBox();
            this.idoTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            addBtn = new System.Windows.Forms.Button();
            updateBtn = new System.Windows.Forms.Button();
            deleteBtn = new System.Windows.Forms.Button();
            viewBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new System.Drawing.Point(31, 193);
            addBtn.Name = "addBtn";
            addBtn.Size = new System.Drawing.Size(75, 23);
            addBtn.TabIndex = 14;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            updateBtn.Location = new System.Drawing.Point(180, 193);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new System.Drawing.Size(75, 23);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new System.Drawing.Point(333, 193);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(75, 23);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewBtn
            // 
            viewBtn.Location = new System.Drawing.Point(508, 193);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new System.Drawing.Size(75, 23);
            viewBtn.TabIndex = 17;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 543);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(viewBtn);
            this.tabPage1.Controls.Add(deleteBtn);
            this.tabPage1.Controls.Add(updateBtn);
            this.tabPage1.Controls.Add(addBtn);
            this.tabPage1.Controls.Add(this.stockTxt);
            this.tabPage1.Controls.Add(this.priceTxt);
            this.tabPage1.Controls.Add(this.sizeTxt);
            this.tabPage1.Controls.Add(this.colorTxt);
            this.tabPage1.Controls.Add(this.descTxt);
            this.tabPage1.Controls.Add(this.titleTxt);
            this.tabPage1.Controls.Add(this.idTxt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(6, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 258);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idproduct";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "title";
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "description";
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "color";
            this.Column4.HeaderText = "Color";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "size";
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "price";
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "stock";
            this.Column7.HeaderText = "Stock";
            this.Column7.Name = "Column7";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(496, 98);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(100, 20);
            this.stockTxt.TabIndex = 13;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(283, 141);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 12;
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(137, 141);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(100, 20);
            this.sizeTxt.TabIndex = 11;
            // 
            // colorTxt
            // 
            this.colorTxt.Location = new System.Drawing.Point(6, 141);
            this.colorTxt.Name = "colorTxt";
            this.colorTxt.Size = new System.Drawing.Size(100, 20);
            this.colorTxt.TabIndex = 10;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(283, 62);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(100, 20);
            this.descTxt.TabIndex = 9;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(137, 62);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 8;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(6, 62);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 20);
            this.idTxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.addproducttoorderBtn);
            this.tabPage2.Controls.Add(this.quantityTxt);
            this.tabPage2.Controls.Add(this.iduserTxt);
            this.tabPage2.Controls.Add(this.idproductTxt);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.viewoBtn);
            this.tabPage2.Controls.Add(this.updateoBtn);
            this.tabPage2.Controls.Add(this.addoBtn);
            this.tabPage2.Controls.Add(this.statusoTxt);
            this.tabPage2.Controls.Add(this.adressoTxt);
            this.tabPage2.Controls.Add(this.nameoTxt);
            this.tabPage2.Controls.Add(this.idoTxt);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.Customer,
            this.Adress,
            this.delivery,
            this.status});
            this.dataGridView2.Location = new System.Drawing.Point(61, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 191);
            this.dataGridView2.TabIndex = 28;
            // 
            // idOrder
            // 
            this.idOrder.DataPropertyName = "idOrder";
            this.idOrder.HeaderText = "ID Order";
            this.idOrder.Name = "idOrder";
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "name";
            this.Customer.HeaderText = "Customer Name";
            this.Customer.Name = "Customer";
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            // 
            // delivery
            // 
            this.delivery.DataPropertyName = "delivery";
            this.delivery.HeaderText = "Delivery Date";
            this.delivery.Name = "delivery";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // addproducttoorderBtn
            // 
            this.addproducttoorderBtn.Location = new System.Drawing.Point(500, 149);
            this.addproducttoorderBtn.Name = "addproducttoorderBtn";
            this.addproducttoorderBtn.Size = new System.Drawing.Size(175, 23);
            this.addproducttoorderBtn.TabIndex = 27;
            this.addproducttoorderBtn.Text = "Add Product to Order";
            this.addproducttoorderBtn.UseVisualStyleBackColor = true;
            this.addproducttoorderBtn.Click += new System.EventHandler(this.addproducttoorderBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(676, 64);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 26;
            // 
            // iduserTxt
            // 
            this.iduserTxt.Location = new System.Drawing.Point(547, 64);
            this.iduserTxt.Name = "iduserTxt";
            this.iduserTxt.Size = new System.Drawing.Size(100, 20);
            this.iduserTxt.TabIndex = 25;
            // 
            // idproductTxt
            // 
            this.idproductTxt.Location = new System.Drawing.Point(411, 64);
            this.idproductTxt.Name = "idproductTxt";
            this.idproductTxt.Size = new System.Drawing.Size(100, 20);
            this.idproductTxt.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(700, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(570, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "ID User";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "ID Product";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // viewoBtn
            // 
            this.viewoBtn.Location = new System.Drawing.Point(274, 210);
            this.viewoBtn.Name = "viewoBtn";
            this.viewoBtn.Size = new System.Drawing.Size(75, 23);
            this.viewoBtn.TabIndex = 19;
            this.viewoBtn.Text = "View Orders";
            this.viewoBtn.UseVisualStyleBackColor = true;
            this.viewoBtn.Click += new System.EventHandler(this.viewoBtn_Click);
            // 
            // updateoBtn
            // 
            this.updateoBtn.Location = new System.Drawing.Point(166, 210);
            this.updateoBtn.Name = "updateoBtn";
            this.updateoBtn.Size = new System.Drawing.Size(98, 23);
            this.updateoBtn.TabIndex = 18;
            this.updateoBtn.Text = "Update Order";
            this.updateoBtn.UseVisualStyleBackColor = true;
            this.updateoBtn.Click += new System.EventHandler(this.updateoBtn_Click);
            // 
            // addoBtn
            // 
            this.addoBtn.Location = new System.Drawing.Point(66, 210);
            this.addoBtn.Name = "addoBtn";
            this.addoBtn.Size = new System.Drawing.Size(75, 23);
            this.addoBtn.TabIndex = 17;
            this.addoBtn.Text = "Add Order";
            this.addoBtn.UseVisualStyleBackColor = true;
            this.addoBtn.Click += new System.EventHandler(this.addoBtn_Click);
            // 
            // statusoTxt
            // 
            this.statusoTxt.Location = new System.Drawing.Point(249, 155);
            this.statusoTxt.Name = "statusoTxt";
            this.statusoTxt.Size = new System.Drawing.Size(100, 20);
            this.statusoTxt.TabIndex = 13;
            // 
            // adressoTxt
            // 
            this.adressoTxt.Location = new System.Drawing.Point(249, 64);
            this.adressoTxt.Name = "adressoTxt";
            this.adressoTxt.Size = new System.Drawing.Size(100, 20);
            this.adressoTxt.TabIndex = 11;
            // 
            // nameoTxt
            // 
            this.nameoTxt.Location = new System.Drawing.Point(131, 64);
            this.nameoTxt.Name = "nameoTxt";
            this.nameoTxt.Size = new System.Drawing.Size(100, 20);
            this.nameoTxt.TabIndex = 10;
            // 
            // idoTxt
            // 
            this.idoTxt.Location = new System.Drawing.Point(3, 64);
            this.idoTxt.Name = "idoTxt";
            this.idoTxt.Size = new System.Drawing.Size(100, 20);
            this.idoTxt.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Delivery Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Adress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Customer Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID Order";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(516, 198);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 24);
            this.lbl.TabIndex = 29;
            // 
            // regular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "regular";
            this.Text = "regular";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.TextBox colorTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button viewoBtn;
        private System.Windows.Forms.Button updateoBtn;
        private System.Windows.Forms.Button addoBtn;
        private System.Windows.Forms.TextBox statusoTxt;
        private System.Windows.Forms.TextBox adressoTxt;
        private System.Windows.Forms.TextBox nameoTxt;
        private System.Windows.Forms.TextBox idoTxt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addproducttoorderBtn;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox iduserTxt;
        private System.Windows.Forms.TextBox idproductTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lbl;
    }
}