using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class AddUserS : Form
    {
        Int16 UserID;
        String Gender;
        short Status;
        int DeleteVlaidation;
        int EmailValidation;
        public AddUserS()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

            
        }

        private bool IsValid()
        {
            if (UserNametextBox.Text.Trim() ==String.Empty)
            {
                UserNametextBox.Focus();
                Namelabel.Visible = true;
                return false;
            }
            else if (comboBox1.SelectedIndex==-1)
            {
                comboBox1.Focus(); 
                UserTypelabel.Visible = true;
                return false;
            }
            else if (FulltextBox.Text.Trim() == String.Empty)
            {
                FulltextBox.Focus();
                FullNamelabel.Visible = true;
                return false;
            }
            else if (PasswordtextBox.Text.Trim() ==String.Empty)
            {
                PasswordtextBox.Focus();
                Passwordlabel.Visible = true;
                return false;
            }
            else if (ContacttextBox.Text.Trim() == String.Empty)
            {
                ContacttextBox.Focus();
                Contactlabel.Visible = true;
                return false;
            }
          else  if (AddresstextBox.Text.Trim() == String.Empty)
            {
                AddresstextBox.Focus();
                Addresslabel.Visible = true;
                return false;
            }
            return true;
        }

        private void AddUserS_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            UserIDlabel.Text = Retrivel.Name;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
           
        }

        private void UserNametextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UserNametextBox.Text))
            {
                UserNametextBox.Focus();
                Namelabel.Visible = true;
            }
            else
            {
                Namelabel.Visible = false;
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                comboBox1.Focus();
                UserTypelabel.Visible = true;
            }
            else
            {
                UserTypelabel.Visible = false;
            }
        }

        private void FulltextBox_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FulltextBox.Text))
            {
                FulltextBox.Focus();
                FullNamelabel.Visible = true;
            }
            else
            {
                FullNamelabel.Visible = false;
            }
        }

        private void PasswordtextBox_MouseLeave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(PasswordtextBox.Text))
            {
                PasswordtextBox.Focus();
                Passwordlabel.Visible=true;
            }
            else
            {
                Passwordlabel.Visible=false;
            }
        }

        private void ContacttextBox_MouseLeave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ContacttextBox.Text))
            {
                ContacttextBox.Focus();
                Contactlabel.Visible = true;
            }
            else
            {
                Contactlabel.Visible = false;
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            
        }
        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {/*
            i=e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            UserID=Convert.ToInt32( row.Cells[0].Value);
            UserNametextBox.Text = row.Cells[1].Value.ToString();
            comboBox1.SelectedItem = row.Cells[2].Value.ToString();
            FulltextBox.Text = row.Cells[3].Value.ToString();
            PasswordtextBox.Text = row.Cells[4].Value.ToString();
            ContacttextBox.Text = row.Cells[5].Value.ToString();
            AddresstextBox.Text = row.Cells[6].Value.ToString();
            Gender = row.Cells[7].Value.ToString();
            StatuscomboBox.SelectedItem = row.Cells[8].Value.ToString();
            if (Gender=="Male")
	        {
             MaleradioButton.Checked = true;
	        }
            else
            {
                FemaleradioButton.Checked = true;
            }*/
        }

        private void Addbutton_Click_1(object sender, EventArgs e)
        {
        }

        private void SaveUserbutton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (StatuscomboBox.SelectedIndex==0)
                {
                    Status = 1;
                }
                else if(StatuscomboBox.SelectedIndex==1)
                {
                    Status = 0;
                }
                Insertion I = new Insertion();
                I.InsertIntoUser(UserNametextBox.Text, comboBox1.Text, FulltextBox.Text, PasswordtextBox.Text, ContacttextBox.Text, AddresstextBox.Text,Gender,Status);
                //MainClass.Disable_Rest(Leftpanel);
            }
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (StatuscomboBox.SelectedIndex == 0)
                {
                    Status = 1;
                }
                else if (StatuscomboBox.SelectedIndex == 1)
                {
                    Status = 0;
                }
                Updation UD = new Updation();
                //U.UpdateUser(UserNametextBox.Text, comboBox1.SelectedItem, FulltextBox.Text, PasswordtextBox.Text, ContacttextBox.Text, AddresstextBox.Text, Gender, UserID);
                UD.UpdateUser(UserNametextBox.Text, comboBox1.Text, FulltextBox.Text, PasswordtextBox.Text, ContacttextBox.Text, AddresstextBox.Text, Gender, UserID,Status);
                Retrivel Retrivel = new Retrivel();
                Retrivel.ShowUsers(dataGridView1, UserIDGV, NameGridView, UserTypeGridview, UserNameDataGridView, PasswordDatagridView, ContactDataGridView, AddressDataGridView, GenderDatagridView, StatusDatagridView);

            }
        }

        private void ViewUserbutton_Click(object sender, EventArgs e)
        {
            Retrivel Retrivel = new Retrivel();
            Retrivel.ShowUsers(dataGridView1, UserIDGV, NameGridView, UserTypeGridview, UserNameDataGridView, PasswordDatagridView, ContactDataGridView, AddressDataGridView, GenderDatagridView, StatusDatagridView);
            DeleteVlaidation = 0;
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

        private void MaleradioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender= "Male";
        }

        private void FemaleradioButton_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DeleteVlaidation = 1;
                //  MainClass.Disable(Leftpanel);   
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt16(row.Cells[1].Value);
                UserNametextBox.Text = row.Cells[2].Value.ToString();
                comboBox1.SelectedItem = row.Cells[3].Value.ToString();
                FulltextBox.Text = row.Cells[4].Value.ToString();
                PasswordtextBox.Text = row.Cells[5].Value.ToString();
                ContacttextBox.Text = row.Cells[6].Value.ToString();
                AddresstextBox.Text = row.Cells[7].Value.ToString();
                Gender = row.Cells[8].Value.ToString();
                StatuscomboBox.SelectedItem = row.Cells[9].Value.ToString();

                if (Gender == "Male")
                {
                    MaleradioButton.Checked = true;
                }
                else
                {
                    FemaleradioButton.Checked = true;
                }

            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contactlabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DeleteVlaidation = 1;
                UserID = Convert.ToInt16(row.Cells[1].Value);
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {

                    if (DeleteVlaidation == 1)
                    {

                        DialogResult Dresult = MessageBox.Show("Are you Sure you Want to Delete "+row.Cells[2].Value.ToString()+"", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Dresult == DialogResult.Yes)
                        {
                            Deletion DU = new Deletion();
                            DU.Delete(UserID, "DeleteUserS", "@UserId");
                            Retrivel Retrivel = new Retrivel();
                            Retrivel.ShowUsers(dataGridView1, UserIDGV, NameGridView, UserTypeGridview, UserNameDataGridView, PasswordDatagridView, ContactDataGridView, AddressDataGridView, GenderDatagridView, StatusDatagridView);
                            DeleteVlaidation = 0;
                        }
                    }
                }
            }
        }

        private void DeleteUserbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Retrivel RUser = new Retrivel();
                RUser.ShowUsers(dataGridView1, UserIDGV, NameGridView, UserTypeGridview, UserNameDataGridView, PasswordDatagridView, ContactDataGridView, AddressDataGridView, GenderDatagridView, StatusDatagridView, textBox2.Text);
            }
            else
            {
                Retrivel Retrivel = new Retrivel();
                Retrivel.ShowUsers(dataGridView1, UserIDGV, NameGridView, UserTypeGridview, UserNameDataGridView, PasswordDatagridView, ContactDataGridView, AddressDataGridView, GenderDatagridView, StatusDatagridView);
            }
        }
        public void Disable()
        {

        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            
           
        }

        private void EmailtextBox_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void EmailtextBox_Leave(object sender, EventArgs e)
        {
            EmailValidation = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
