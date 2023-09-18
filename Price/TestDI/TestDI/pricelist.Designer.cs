namespace TestDI
{
    partial class pricelist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPriceListName = new System.Windows.Forms.Label();
            this.tb_PriceList = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cListNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_ListNum = new System.Windows.Forms.TextBox();
            this.tb_ItemCode = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(625, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(224, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txtPriceListName
            // 
            this.txtPriceListName.AutoSize = true;
            this.txtPriceListName.Location = new System.Drawing.Point(22, 22);
            this.txtPriceListName.Name = "txtPriceListName";
            this.txtPriceListName.Size = new System.Drawing.Size(50, 13);
            this.txtPriceListName.TabIndex = 1;
            this.txtPriceListName.Text = "Price List";
            // 
            // tb_PriceList
            // 
            this.tb_PriceList.Location = new System.Drawing.Point(89, 19);
            this.tb_PriceList.Name = "tb_PriceList";
            this.tb_PriceList.Size = new System.Drawing.Size(268, 20);
            this.tb_PriceList.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cListName,
            this.cListNum,
            this.cItemCode,
            this.cPrice});
            this.dataGridView2.Location = new System.Drawing.Point(25, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(824, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // cListName
            // 
            this.cListName.HeaderText = "List Name";
            this.cListName.Name = "cListName";
            // 
            // cListNum
            // 
            this.cListNum.HeaderText = "ListNum";
            this.cListNum.Name = "cListNum";
            // 
            // cItemCode
            // 
            this.cItemCode.HeaderText = "Item Code";
            this.cItemCode.Name = "cItemCode";
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Price";
            this.cPrice.Name = "cPrice";
            // 
            // tb_ListNum
            // 
            this.tb_ListNum.Location = new System.Drawing.Point(89, 46);
            this.tb_ListNum.Name = "tb_ListNum";
            this.tb_ListNum.Size = new System.Drawing.Size(268, 20);
            this.tb_ListNum.TabIndex = 4;
            // 
            // tb_ItemCode
            // 
            this.tb_ItemCode.Location = new System.Drawing.Point(89, 73);
            this.tb_ItemCode.Name = "tb_ItemCode";
            this.tb_ItemCode.Size = new System.Drawing.Size(268, 20);
            this.tb_ItemCode.TabIndex = 5;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(89, 100);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(268, 20);
            this.tb_Price.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "List Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(89, 181);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pricelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 410);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_ItemCode);
            this.Controls.Add(this.tb_ListNum);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tb_PriceList);
            this.Controls.Add(this.txtPriceListName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pricelist";
            this.Text = "pricelist";
            this.Load += new System.EventHandler(this.pricelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtPriceListName;
        private System.Windows.Forms.TextBox tb_PriceList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tb_ListNum;
        private System.Windows.Forms.TextBox tb_ItemCode;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cListNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.Button btn_Update;
    }
}