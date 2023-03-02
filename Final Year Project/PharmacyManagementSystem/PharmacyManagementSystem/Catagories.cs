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
    public partial class Catagories : Form
    {
        Int16 CatID;
        String Gender;
        Int16 Status;
        Int16 DeleteVlaidation;
        Retrivel R = new Retrivel();
        int Count;
        public Catagories()
        {
            InitializeComponent();
        }

        private void Catagories_Load(object sender, EventArgs e)
        {
            UserIDlabel.Text = Retrivel.Name;
        }

        

        private void CatagorytextBox_Leave(object sender, EventArgs e)
        {
            if (CatagorytextBox.Text == "")
            {
                CatagoryNamelabel.Visible = true;
                CatagorytextBox.Focus();
            }
            else
            {
                CatagoryNamelabel.Visible = false;
            }
        }

        private void IsActivecomboBox_Leave(object sender, EventArgs e)
        {
            if (IsActivecomboBox.SelectedIndex == -1)
            {
                IsActivecomboBox.Focus();
                IsActivelabel.Visible = true;
            }
            else
            {
                IsActivelabel.Visible = false;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (IsActivecomboBox.SelectedIndex == 0)
                {
                    Status = 1;
                }
                else if (IsActivecomboBox.SelectedIndex == 1)
                {
                    Status = 0;
                }
                Insertion I = new Insertion();
                I.InsertCatagory(CatagorytextBox.Text, Status);
                R.ShowCatagories(dataGridView1, CatagoryIDDataGridview, NameDataGridView, StatusDataGridview);
            }
        }

        private bool IsValid()
        {
            if (CatagorytextBox.Text.Trim() == String.Empty)
            {
                CatagorytextBox.Focus();
                CatagoryNamelabel.Visible = true;
                return false;
            }
            else if (IsActivecomboBox.SelectedIndex == -1)
            {
                IsActivecomboBox.Focus();
                IsActivelabel.Visible = true;
                return false;
            }
            return true;
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (IsActivecomboBox.SelectedIndex == 0)
            {
                Status = 1;
            }
            else if (IsActivecomboBox.SelectedIndex == 1)
            {
                Status = 0;
            }
            if (IsValid())
            {
                Updation UC = new Updation();
                UC.UpdateCatagory(CatagorytextBox.Text, Status,CatID);
                R.ShowCatagories(dataGridView1, CatagoryIDDataGridview, NameDataGridView, StatusDataGridview);
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            R.ShowCatagories(dataGridView1, CatagoryIDDataGridview, NameDataGridView, StatusDataGridview);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DeleteVlaidation = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CatID =Convert.ToInt16( row.Cells["CatagoryIDDataGridview"].Value.ToString());
                CatagorytextBox.Text = row.Cells["NameDataGridView"].Value.ToString();
                IsActivecomboBox.SelectedItem = row.Cells["StatusDataGridview"].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DeleteVlaidation = 1;
                CatID = Convert.ToInt16(row.Cells[1].Value);
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {

                    if (DeleteVlaidation == 1)
                    {

                        DialogResult Dresult = MessageBox.Show("Are you Sure you Want to Delete " + row.Cells[2].Value.ToString() + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Dresult == DialogResult.Yes)
                        {
                            Deletion DU = new Deletion();
                          Count +=DU.Delete(CatID, "DeleteCatagories", "@Cat_Id");
                          if (Count > 0)
                          {
                              MessageBox.Show(row.Cells[2].Value.ToString() + " Successfully Deleted", "InforMAtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              R.ShowCatagories(dataGridView1, CatagoryIDDataGridview, NameDataGridView, StatusDataGridview);
                          }                           
                            DeleteVlaidation = 0;
                        }
                    }
                }
            }
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            if (Retrivel.UType == "Admin")
            {
                Home Home = new Home();
                MainClass.ShowWindow(Home, this, MDI.ActiveForm);
            }
            else
            {
                Home1 Home1 = new Home1();
                MainClass.ShowWindow(Home1, this, MDI.ActiveForm);
            }
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            R.ShowCatagories(dataGridView1, CatagoryIDDataGridview, NameDataGridView, StatusDataGridview,SearchtextBox.Text);
        }
    }
}
