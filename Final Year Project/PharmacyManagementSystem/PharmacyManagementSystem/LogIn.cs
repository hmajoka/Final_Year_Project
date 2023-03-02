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
    public partial class LogIn : Form
    {
        Retrivel R = new Retrivel();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Rightpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (R.Login(UserNametextBox.Text, comboBox1, PasswordtextBox.Text))
                {
                    if (comboBox1.Text == "Admin")
                    {
                        Home Home=new Home();
                        MainClass.ShowWindow(Home, this, MDI.ActiveForm);
                    }
                    else if (comboBox1.Text == "Sale Man")
                    {
                        Home1 Home1 = new Home1();
                        MainClass.ShowWindow(Home1, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (UserNametextBox.Text.Trim() == String.Empty)
            {
                UserNamelabel.Visible = true;
                return false;
            }
            else if (UserTypelabel.Text.Trim() == String.Empty)
            {
                UserTypelabel.Visible = true;
                return false;
            }
            else if (PasswordtextBox.Text.Trim() == String.Empty)
            {
                Passwordlabel.Visible = true;
                return false;
            }
            return true;
        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserNametextBox_Leave(object sender, EventArgs e)
        {
            if (UserNametextBox.Text.Trim() == String.Empty)
            {
                UserNamelabel.Visible = true;
            }
            else
            {
                UserTypelabel.Visible = false;
            }
        }

        private void PasswordtextBox_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text.Trim() == String.Empty)
            {
                Passwordlabel.Visible = true;
            }
            else
            {
                Passwordlabel.Visible = false;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
