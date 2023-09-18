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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            Boolean SBOConnected;
            Boolean DBConnected;
            int status = 0;
            int error = 0;
            string errorcode = "";
            try
            {
                //Connection to SAP
                ModGlobal.oSBOConnection = new SBOConnection("NDB@sbo-hana-sol", "30013", "SYSTEM", "P@ssw0rd", "HANA", "SOLTIUSDEMO", "SOLTIUSDEMO", txtUSERNAME.Text, txtPASSWORD.Text, "sbo-hana-sol:40000", "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056");
                SBOConnected = ModGlobal.oSBOConnection.Connect();
                if (SBOConnected == true)
                {
                    MessageBox.Show("Berhasil login SAP");

                }
                else
                {
                    MessageBox.Show("Gagal login SAP");
                }
                //CHECK SBO CONNECTION BERFORE USE IT
                //Boolean Status = ModGlobal.oSBOConnection.Connected();
                //if (Status == false)
                //{
                // ModGlobal.oSBOConnection.Connect();
                //}


                //DATABASE Connection
                ModGlobal.oDBConnection = new DBConnection("sbo-hana-sol", "30015", "SYSTEM", "P@ssw0rd");
                DBConnected = ModGlobal.oDBConnection.Connect();
                if (DBConnected == true)
                {
                    MessageBox.Show("Berhasil login DB");
                }
                else
                {
                    MessageBox.Show("Gagal login DB");
                }
                //CHECK HANA CONNECTION BEFORE USE IT
                //Boolean Status = ModGlobal.oDBConnection.Connected();
                //if (Status == false)
                //{
                // ModGlobal.oSBOConnection.Connect();
                //}


                if (SBOConnected == true && DBConnected == true)
                {
                    this.Hide();

                    //priceList PriceListMenu = new priceList();
                   //PriceListMenu.Show();

                    //bpmaster BPMasterMenu = new bpmaster();
                    //BPMasterMenu.Show();

                    pricelist PriceListMenu = new pricelist();
                    PriceListMenu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(string)), new DataColumn("Name", typeof(string)) });
            dt.Rows.Add("S", "SOLTIUSDEMO");

            //Insert the Default Item to DataTable.
            DataRow row = dt.NewRow();
            row[0] = 0;
            row[1] = "Please select";
            dt.Rows.InsertAt(row, 0);

            //Assign DataTable as DataSource.
            cmbDB.DataSource = dt;
            cmbDB.DisplayMember = "Name";
            cmbDB.ValueMember = "Id";
        }
    }
}
