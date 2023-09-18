using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDI
{
    public partial class pricelist : Form
    {
        public pricelist()
        {
            InitializeComponent();
        }

        private void pricelist_Load(object sender, EventArgs e)
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            DataTable DataSales;
            SAPbobsCOM.Recordset orec = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            orec.DoQuery("SELECT \"ListName\" FROM OPLN");

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (orec.RecordCount > 0) //Check Hasil Query, jika ada hasil, maka lanjut
            {
                for (int N = 0; N < orec.Fields.Count; N++) //Looping untuk menambahkan column pada datagridview ( 7 Column)
                {
                    dataGridView1.Columns.Add(orec.Fields.Item(N).Description, orec.Fields.Item(N).Description);
                }


                for (int M = 0; M < orec.RecordCount; M++) //Looping untuyk menambhakan row pada datagridview sejumlah hasil query
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[M].Cells["ListName"].Value = orec.Fields.Item("ListName").Value;
                    orec.MoveNext();
                }
                dataGridView1.AutoResizeColumns(); //untuk adjust ukuran colum
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e) // DATA GRID KLIK
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            string ListName = dataGridView1.Rows[CurrentIndex].Cells["ListName"].Value.ToString();

            tb_PriceList.Text = Convert.ToString(ListName);

            SAPbobsCOM.Recordset orec = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            orec.DoQuery("SELECT T0.\"ListName\", T0.\"ListNum\", T1.\"ItemCode\", T1.\"Price\" FROM OPLN T0 INNER JOIN ITM1 T1 ON T0.\"ListNum\" = T1.\"PriceList\"  WHERE  T0.\"ListName\" = '" + tb_PriceList.Text + "'");

            tb_ListNum.Text = Convert.ToString(orec.Fields.Item("ListNum").Value);
            tb_ItemCode.Text = Convert.ToString(orec.Fields.Item("ItemCode").Value);
            tb_Price.Text = Convert.ToString(orec.Fields.Item("Price").Value);
            //cmbBOM.SelectedValue = Convert.ToString(orec.Fields.Item("TreeType").Value);
            //cmbPROJECT.SelectedValue = Convert.ToString(orec.Fields.Item("Project").Value);

            for (int M = 0; M < orec.RecordCount; M++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[M].Cells["cListName"].Value = Convert.ToString(orec.Fields.Item("ListName").Value);
                dataGridView2.Rows[M].Cells["cListNum"].Value = Convert.ToString(orec.Fields.Item("ListNum").Value);
                dataGridView2.Rows[M].Cells["cItemCode"].Value = Convert.ToString(orec.Fields.Item("ItemCode").Value);
                dataGridView2.Rows[M].Cells["cPrice"].Value = Convert.ToString(orec.Fields.Item("Price").Value);
                orec.MoveNext();
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e) // DATA GRID KLIK
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            int CurrentIndex = dataGridView2.CurrentCell.RowIndex;
            string ItemCode = dataGridView2.Rows[CurrentIndex].Cells["cItemCode"].Value.ToString();
            string ListName = dataGridView2.Rows[CurrentIndex].Cells["cListName"].Value.ToString();
            string ListNum = dataGridView2.Rows[CurrentIndex].Cells["cListNum"].Value.ToString();
            string Price = dataGridView2.Rows[CurrentIndex].Cells["cPrice"].Value.ToString();

            tb_PriceList.Text = Convert.ToString(ListName);
            tb_ItemCode.Text = Convert.ToString(ItemCode);
            tb_ListNum.Text = Convert.ToString(ListNum);
            tb_Price.Text = Convert.ToString(Price);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            if (btn_Update.Text == "Update")// MODE UPDATE
            {
                int status = 0;
                int error = 0;
                string errorcode = "";
                
                SAPbobsCOM.Items aBP = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems);

                
                aBP.GetByKey(tb_ItemCode.Text);
                aBP.PriceList.Price = Convert.ToDouble(tb_Price.Text);

                status = aBP.Update();

                if (status != 0)
                {
                    ModGlobal.oSBOConnection.Company().GetLastError(out error, out errorcode);
                    MessageBox.Show(error + "-" + errorcode);
                }
                else
                {
                    MessageBox.Show("Success UPDATE!");

                    //btn_Update_Click(sender, e);
                    dataGridView1_Click(sender, e);
                    pricelist_Load(sender, e);
                }
            }
        }
    }
    
}
