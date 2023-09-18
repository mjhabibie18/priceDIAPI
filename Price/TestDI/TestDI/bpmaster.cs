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
    public partial class bpmaster : Form
    {
        public bpmaster()
        {
            InitializeComponent();
        }

        private void bpmaster_Load(object sender, EventArgs e)
        {
            btnADDUP.Text = "Add"; // MODE ADD
            cmbTYPE.Enabled = true;
            txtCODE.Enabled = true;


            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(string)), new DataColumn("Name", typeof(string)) });
            dt.Rows.Add("C", "Customer");
            dt.Rows.Add("S", "Vendor");
            dt.Rows.Add("L", "Lead");

            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            //Assign DataTable as DataSource.
            cmbTYPE.DataSource = dt;
            cmbTYPE.DisplayMember = "Name";
            cmbTYPE.ValueMember = "Id";



            DataTable dt2 = new DataTable();
            dt2.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(string)), new DataColumn("Name", typeof(string)) });
            dt2.Rows.Add("S", "Shipp To");
            dt2.Rows.Add("B", "Bill To");

            //Insert the Default Item to DataTable.
            DataRow row2 = dt2.NewRow();
            row2[0] = 0;
            row2[1] = "Please select";
            dt2.Rows.InsertAt(row2, 0);

            //Assign DataTable as DataSource.
            cADDTYPE.DataSource = dt2;
            cADDTYPE.DisplayMember = "Name";
            cADDTYPE.ValueMember = "Id";





            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            //DataTable DataSales;
            SAPbobsCOM.Recordset orec = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            orec.DoQuery("SELECT \"CardCode\", \"CardName\" FROM OCRD ORDER BY \"CardCode\" DESC");



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
                    dataGridView1.Rows[M].Cells["CardCode"].Value = orec.Fields.Item("CardCode").Value;
                    dataGridView1.Rows[M].Cells["CardName"].Value = orec.Fields.Item("CardName").Value;
                    orec.MoveNext();
                }
                dataGridView1.AutoResizeColumns(); //untuk adjust ukuran colum
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }

            dataGridView2.Rows.Clear();

            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;
            string ItemCode = dataGridView1.Rows[CurrentIndex].Cells["CardCode"].Value.ToString();
            string ItemName = dataGridView1.Rows[CurrentIndex].Cells["CardName"].Value.ToString();

            txtCODE.Text = Convert.ToString(ItemCode);
            txtNAME.Text = Convert.ToString(ItemName);

            SAPbobsCOM.Recordset orec = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            orec.DoQuery("SELECT T0.\"CardType\", T0.\"LicTradNum\", T0.\"Phone1\", T0.\"Cellular\", T1.\"AdresType\", T1.\"Address\", T1.\"Address2\", T1.\"Street\", T1.\"Block\", T1.\"City\", T1.\"ZipCode\" FROM OCRD T0  INNER JOIN CRD1 T1 ON T1.\"CardCode\" = T0.\"CardCode\"   WHERE  T0.\"CardCode\" = '" + txtCODE.Text + "'");

            cmbTYPE.SelectedValue = Convert.ToString(orec.Fields.Item("CardType").Value);
            txtTAX.Text = Convert.ToString(orec.Fields.Item("LicTradNum").Value);
            txtTEL.Text = Convert.ToString(orec.Fields.Item("Phone1").Value);
            txtMOBILE.Text = Convert.ToString(orec.Fields.Item("Cellular").Value);
            

            for (int M = 0; M < orec.RecordCount; M++)
            {
                dataGridView2.Rows.Add(); 
                dataGridView2.Rows[M].Cells["cADDTYPE"].Value = Convert.ToString(orec.Fields.Item("AdresType").Value);
                dataGridView2.Rows[M].Cells["cADDRESS"].Value = Convert.ToString(orec.Fields.Item("Address").Value);
                dataGridView2.Rows[M].Cells["cADDRNAME"].Value = Convert.ToString(orec.Fields.Item("Address2").Value);
                dataGridView2.Rows[M].Cells["cSTREET"].Value = Convert.ToString(orec.Fields.Item("Street").Value);
                dataGridView2.Rows[M].Cells["cBLOCK"].Value = Convert.ToString(orec.Fields.Item("Block").Value);
                dataGridView2.Rows[M].Cells["cCITY"].Value = Convert.ToString(orec.Fields.Item("City").Value);
                dataGridView2.Rows[M].Cells["cZIP"].Value = Convert.ToString(orec.Fields.Item("ZipCode").Value);
                orec.MoveNext();
            }

            btnADDUP.Text = "Update"; // MODE UPDATE
            cmbTYPE.Enabled = false;
            txtCODE.Enabled = false;
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            txtCODE.Text = "";
            txtNAME.Text = "";
            txtTAX.Text = "";
            txtTEL.Text = "";
            txtMOBILE.Text = "";
            dataGridView2.Rows.Clear();
            btnADDUP.Text = "Add"; // MODE ADD
            cmbTYPE.Enabled = true;
            txtCODE.Enabled = true;
        }

        private void cmbTYPE_DropDownClosed(object sender, EventArgs e)
        {
            SAPbobsCOM.Recordset orec = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            orec.DoQuery("SELECT * FROM OCRD ");

            string N = Convert.ToString(orec.RecordCount);


            if (cmbTYPE.SelectedValue == "C")
            {
                txtCODE.Text = "CST" + N;
            }
            if (cmbTYPE.SelectedValue == "S")
            {
                txtCODE.Text = "VND" + N;
            }
            if (cmbTYPE.SelectedValue == "L")
            {
                txtCODE.Text = "L1" + N;
            }
        }

        private void btnADDUP_Click(object sender, EventArgs e)
        {
            Boolean Status = ModGlobal.oSBOConnection.Connected();
            if (Status == false)
            {
                ModGlobal.oSBOConnection.Connect();
            }


            if (btnADDUP.Text == "Add") // MODE ADD
            {
                int status = 0;
                int error = 0;
                string errorcode = "";

                

                string cardtype = Convert.ToString(cmbTYPE.SelectedValue);
                
                if (cardtype == "C") // JIKA CUSTOMER
                {
                    SAPbobsCOM.BusinessPartners oBP = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
                    oBP.CardType = SAPbobsCOM.BoCardTypes.cCustomer;
                    oBP.CardCode = txtCODE.Text;
                    oBP.CardName = txtNAME.Text;
                    oBP.FederalTaxID = txtTAX.Text;
                    oBP.Phone1 = txtTEL.Text;
                    oBP.Cellular = txtMOBILE.Text;


                    int rowdetail = dataGridView2.RowCount - 1;
                    for (int i = 0; i < rowdetail; i++)
                    {
                        string addresType = Convert.ToString(dataGridView2.Rows[i].Cells["cADDTYPE"].Value);

                        if (addresType == "B")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_BillTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }
                        if (addresType == "S")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_ShipTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }


                    }

                    status = oBP.Add();

                    if (status != 0)
                    {
                        ModGlobal.oSBOConnection.Company().GetLastError(out error, out errorcode);
                        MessageBox.Show(error + "-" + errorcode);
                    }
                    else
                    {
                        MessageBox.Show("Success ADD!");

                        btnNEW_Click(sender, e);
                        bpmaster_Load(sender, e);
                    }
                }

                if (cardtype == "S") // JIKA VENDOR
                {
                    SAPbobsCOM.BusinessPartners oBP = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
                    oBP.CardType = SAPbobsCOM.BoCardTypes.cSupplier;
                    oBP.CardCode = txtCODE.Text;
                    oBP.CardName = txtNAME.Text;
                    oBP.FederalTaxID = txtTAX.Text;
                    oBP.Phone1 = txtTEL.Text;
                    oBP.Cellular = txtMOBILE.Text;


                    int rowdetail = dataGridView2.RowCount - 1;
                    for (int i = 0; i < rowdetail; i++)
                    {
                        string addresType = Convert.ToString(dataGridView2.Rows[i].Cells["cADDTYPE"].Value);

                        if (addresType == "B")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_BillTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }
                        if (addresType == "S")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_ShipTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }


                    }

                    status = oBP.Add();

                    if (status != 0)
                    {
                        ModGlobal.oSBOConnection.Company().GetLastError(out error, out errorcode);
                        MessageBox.Show(error + "-" + errorcode);
                    }
                    else
                    {
                        MessageBox.Show("Success ADD!");

                        btnNEW_Click(sender, e);
                        bpmaster_Load(sender, e);
                    }
                }

                if (cardtype == "L") // JIKA LEAD
                {
                    SAPbobsCOM.BusinessPartners oBP = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);
                    oBP.CardType = SAPbobsCOM.BoCardTypes.cLid;
                    oBP.CardCode = txtCODE.Text;
                    oBP.CardName = txtNAME.Text;
                    oBP.FederalTaxID = txtTAX.Text;
                    oBP.Phone1 = txtTEL.Text;
                    oBP.Cellular = txtMOBILE.Text;


                    int rowdetail = dataGridView2.RowCount - 1;
                    for (int i = 0; i < rowdetail; i++)
                    {
                        string addresType = Convert.ToString(dataGridView2.Rows[i].Cells["cADDTYPE"].Value);

                        if (addresType == "B")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_BillTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }
                        if (addresType == "S")
                        {
                            oBP.Addresses.SetCurrentLine(i);
                            oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_ShipTo;
                            oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                            oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                            oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                            oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                            oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                            oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                            oBP.Addresses.Add();
                        }


                    }

                    status = oBP.Add();

                    if (status != 0)
                    {
                        ModGlobal.oSBOConnection.Company().GetLastError(out error, out errorcode);
                        MessageBox.Show(error + "-" + errorcode);
                    }
                    else
                    {
                        MessageBox.Show("Success ADD!");

                        btnNEW_Click(sender, e);
                        bpmaster_Load(sender, e);
                    }
                }


                
            }

            if (btnADDUP.Text == "Update")// MODE UPDATE
            {
                int status = 0;
                int error = 0;
                string errorcode = "";

                SAPbobsCOM.BusinessPartners oBP = ModGlobal.oSBOConnection.Company().GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners);


                oBP.GetByKey(txtCODE.Text);
                //oBP.CardType = SAPbobsCOM.BoCardTypes.cSupplier;
                oBP.CardCode = txtCODE.Text;
                oBP.CardName = txtNAME.Text;
                oBP.FederalTaxID = txtTAX.Text;
                oBP.Phone1 = txtTEL.Text;
                oBP.Cellular = txtMOBILE.Text;


                int rowdetail = dataGridView2.RowCount - 1;
                for (int i = 0; i < rowdetail; i++)
                {
                    string addresType = Convert.ToString(dataGridView2.Rows[i].Cells["cADDTYPE"].Value);

                    if (addresType == "B")
                    {
                        oBP.Addresses.SetCurrentLine(i);
                        oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_BillTo;
                        oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                        oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                        oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                        oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                        oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                        oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                        oBP.Addresses.Add();
                    }
                    if (addresType == "S")
                    {
                        oBP.Addresses.SetCurrentLine(i);
                        oBP.Addresses.AddressType = SAPbobsCOM.BoAddressType.bo_ShipTo;
                        oBP.Addresses.AddressName = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRESS"].Value);
                        oBP.Addresses.AddressName2 = Convert.ToString(dataGridView2.Rows[i].Cells["cADDRNAME"].Value);
                        oBP.Addresses.Street = Convert.ToString(dataGridView2.Rows[i].Cells["cSTREET"].Value);
                        oBP.Addresses.Block = Convert.ToString(dataGridView2.Rows[i].Cells["cBLOCK"].Value);
                        oBP.Addresses.City = Convert.ToString(dataGridView2.Rows[i].Cells["cCITY"].Value);
                        oBP.Addresses.ZipCode = Convert.ToString(dataGridView2.Rows[i].Cells["cZIP"].Value);
                        oBP.Addresses.Add();
                    }


                }

                status = oBP.Update();

                if (status != 0)
                {
                    ModGlobal.oSBOConnection.Company().GetLastError(out error, out errorcode);
                    MessageBox.Show(error + "-" + errorcode);
                }
                else
                {
                    MessageBox.Show("Success UPDATE!");

                    btnNEW_Click(sender, e);
                    bpmaster_Load(sender, e);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
    
}
