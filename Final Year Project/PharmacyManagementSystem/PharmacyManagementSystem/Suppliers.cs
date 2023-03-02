using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Suppliers : Form
    {
        Int16 SupplierID;
        String Gender;
        short Status;
        int DeleteVlaidation,Count;
        Retrivel R = new Retrivel();
        Deletion DU = new Deletion();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void SaveUserbutton_Click(object sender, EventArgs e)
        {
            if(StatuscomboBox.SelectedIndex==0)
            {
                Status=1;
            }
            else if(StatuscomboBox.SelectedIndex==1)
            {
                Status=1;
            }
            Insertion ISupplier = new Insertion();
            ISupplier.InsertSuppliers(SupplierNametextBox.Text, EMailtextBox.Text, PhonetextBox.Text, AddresstextBox.Text, Status);
            R.GetSuppliers(dataGridView1, SIDDGV, SCompanyDGV, SEMailDGV, SPhoneDGV, SAddressDGV, SStatusDGV);
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            USerIDlabel.Text = Retrivel.Name;
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {
            if (StatuscomboBox.SelectedIndex == 0)
            {
                Status = 1;
            }
            else if (StatuscomboBox.SelectedIndex == 1)
            {
                Status = 1;
            }
            Updation USuppliers = new Updation();
            USuppliers.UpdateSuppliers(SupplierNametextBox.Text, EMailtextBox.Text, PhonetextBox.Text, AddresstextBox.Text, Status, SupplierID);
            R.GetSuppliers(dataGridView1, SIDDGV, SCompanyDGV, SEMailDGV, SPhoneDGV, SAddressDGV, SStatusDGV);
        }

        private void ViewUserbutton_Click(object sender, EventArgs e)
        {
            R.GetSuppliers(dataGridView1, SIDDGV, SCompanyDGV, SEMailDGV, SPhoneDGV, SAddressDGV, SStatusDGV);
            Console.Beep();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DeleteVlaidation = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SupplierID = Convert.ToInt16(row.Cells["SIDDGV"].Value);
                SupplierNametextBox.Text = row.Cells["SCompanyDGV"].Value.ToString();
                EMailtextBox.Text = row.Cells["SEMailDGV"].Value.ToString();
                PhonetextBox.Text = row.Cells["SPhoneDGV"].Value.ToString();
                AddresstextBox.Text = row.Cells["SAddressDGV"].Value.ToString();
                StatuscomboBox.SelectedItem = row.Cells["SStatusDGV"].Value.ToString();
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            if (Retrivel.UType == "Admin")
            {
                Home HomeScreen = new Home();
                MainClass.ShowWindow(HomeScreen, this, MDI.ActiveForm);
            }
            else
            {
                Home1 Home1 = new Home1();
                MainClass.ShowWindow(Home1, this, MDI.ActiveForm);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DeleteVlaidation = 1;
                SupplierID = Convert.ToInt16(row.Cells[1].Value);
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {

                    if (DeleteVlaidation == 1)
                    {

                        DialogResult Dresult = MessageBox.Show("Are you Sure you Want to Delete " + row.Cells[2].Value.ToString() + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Dresult == DialogResult.Yes)
                        {
                            
                           Count +=DU.Delete(SupplierID, "DeleteSuppliers", "@S_ID");
                           if (Count > 0)
                           {
                               MessageBox.Show(row.Cells[2].Value.ToString() + "" + " Successfully Deleted","InforMation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                               R.GetSuppliers(dataGridView1, SIDDGV, SCompanyDGV, SEMailDGV, SPhoneDGV, SAddressDGV, SStatusDGV);
                           } 
                            DeleteVlaidation = 0;
                        }
                    }
                }
            }
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            R.GetSuppliers(dataGridView1, SIDDGV, SCompanyDGV, SEMailDGV, SPhoneDGV, SAddressDGV, SStatusDGV,SearchtextBox.Text);
        }
    }
}
