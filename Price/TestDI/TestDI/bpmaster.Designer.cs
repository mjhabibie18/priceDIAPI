namespace TestDI
{
    partial class bpmaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTYPE = new System.Windows.Forms.ComboBox();
            this.txtCODE = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtTAX = new System.Windows.Forms.TextBox();
            this.txtTEL = new System.Windows.Forms.TextBox();
            this.txtMOBILE = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cADDTYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDRNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSTREET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBLOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cZIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNEW = new System.Windows.Forms.Button();
            this.btnADDUP = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BP Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BP Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BP Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Federal Tax ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile Phone";
            // 
            // cmbTYPE
            // 
            this.cmbTYPE.FormattingEnabled = true;
            this.cmbTYPE.Location = new System.Drawing.Point(119, 26);
            this.cmbTYPE.Name = "cmbTYPE";
            this.cmbTYPE.Size = new System.Drawing.Size(181, 21);
            this.cmbTYPE.TabIndex = 6;
            this.cmbTYPE.DropDownClosed += new System.EventHandler(this.cmbTYPE_DropDownClosed);
            // 
            // txtCODE
            // 
            this.txtCODE.Location = new System.Drawing.Point(119, 54);
            this.txtCODE.Name = "txtCODE";
            this.txtCODE.Size = new System.Drawing.Size(181, 20);
            this.txtCODE.TabIndex = 7;
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(119, 81);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(181, 20);
            this.txtNAME.TabIndex = 8;
            // 
            // txtTAX
            // 
            this.txtTAX.Location = new System.Drawing.Point(119, 108);
            this.txtTAX.Name = "txtTAX";
            this.txtTAX.Size = new System.Drawing.Size(181, 20);
            this.txtTAX.TabIndex = 9;
            // 
            // txtTEL
            // 
            this.txtTEL.Location = new System.Drawing.Point(119, 137);
            this.txtTEL.Name = "txtTEL";
            this.txtTEL.Size = new System.Drawing.Size(181, 20);
            this.txtTEL.TabIndex = 10;
            // 
            // txtMOBILE
            // 
            this.txtMOBILE.Location = new System.Drawing.Point(119, 163);
            this.txtMOBILE.Name = "txtMOBILE";
            this.txtMOBILE.Size = new System.Drawing.Size(181, 20);
            this.txtMOBILE.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 157);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cADDTYPE,
            this.cADDRESS,
            this.cADDRNAME,
            this.cSTREET,
            this.cBLOCK,
            this.cCITY,
            this.cZIP});
            this.dataGridView2.Location = new System.Drawing.Point(32, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 150);
            this.dataGridView2.TabIndex = 13;
            // 
            // cADDTYPE
            // 
            this.cADDTYPE.HeaderText = "Address Type";
            this.cADDTYPE.Name = "cADDTYPE";
            this.cADDTYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cADDTYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cADDRESS
            // 
            this.cADDRESS.HeaderText = "Address ID";
            this.cADDRESS.Name = "cADDRESS";
            // 
            // cADDRNAME
            // 
            this.cADDRNAME.HeaderText = "Address Name";
            this.cADDRNAME.Name = "cADDRNAME";
            // 
            // cSTREET
            // 
            this.cSTREET.HeaderText = "Street";
            this.cSTREET.Name = "cSTREET";
            // 
            // cBLOCK
            // 
            this.cBLOCK.HeaderText = "Block";
            this.cBLOCK.Name = "cBLOCK";
            // 
            // cCITY
            // 
            this.cCITY.HeaderText = "City";
            this.cCITY.Name = "cCITY";
            // 
            // cZIP
            // 
            this.cZIP.HeaderText = "ZipCode";
            this.cZIP.Name = "cZIP";
            // 
            // btnNEW
            // 
            this.btnNEW.Location = new System.Drawing.Point(32, 376);
            this.btnNEW.Name = "btnNEW";
            this.btnNEW.Size = new System.Drawing.Size(75, 23);
            this.btnNEW.TabIndex = 14;
            this.btnNEW.Text = "New";
            this.btnNEW.UseVisualStyleBackColor = true;
            this.btnNEW.Click += new System.EventHandler(this.btnNEW_Click);
            // 
            // btnADDUP
            // 
            this.btnADDUP.Location = new System.Drawing.Point(587, 376);
            this.btnADDUP.Name = "btnADDUP";
            this.btnADDUP.Size = new System.Drawing.Size(89, 23);
            this.btnADDUP.TabIndex = 15;
            this.btnADDUP.Text = "Save/Update";
            this.btnADDUP.UseVisualStyleBackColor = true;
            this.btnADDUP.Click += new System.EventHandler(this.btnADDUP_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Location = new System.Drawing.Point(506, 376);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(75, 23);
            this.btnCANCEL.TabIndex = 16;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(701, 189);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // bpmaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 415);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnADDUP);
            this.Controls.Add(this.btnNEW);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMOBILE);
            this.Controls.Add(this.txtTEL);
            this.Controls.Add(this.txtTAX);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtCODE);
            this.Controls.Add(this.cmbTYPE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bpmaster";
            this.Text = "Business Partner Master Data";
            this.Load += new System.EventHandler(this.bpmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTYPE;
        private System.Windows.Forms.TextBox txtCODE;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtTAX;
        private System.Windows.Forms.TextBox txtTEL;
        private System.Windows.Forms.TextBox txtMOBILE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNEW;
        private System.Windows.Forms.Button btnADDUP;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.DataGridViewComboBoxColumn cADDTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDRNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTREET;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBLOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cZIP;
        private System.Windows.Forms.Button btn_Refresh;
    }
}