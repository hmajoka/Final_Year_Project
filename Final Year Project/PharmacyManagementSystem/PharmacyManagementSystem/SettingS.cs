using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PharmacyManagementSystem
{
    public partial class SettingS : Form
    {
        public SettingS()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                UserIDtextBox.Enabled = false;
                PasswordtextBox.Enabled = false;
                UserIDtextBox.Text = "";
                PasswordtextBox.Text = "";
            }
            else
            {
                UserIDtextBox.Enabled = true;
                PasswordtextBox.Enabled = true;
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            String ConnectionString;
            String Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(checkBox1.Checked)
            {
                if(ServertextBox.Text!="" && DatabasetextBox.Text!="")
                {
                    ConnectionString = "Data Source=" + ServertextBox.Text + ";Initial Catalog=" + DatabasetextBox.Text + ";Integrated Security=true;";
                    File.WriteAllText(Path+"//ConnectionString",ConnectionString);
                    DialogResult Dr = MessageBox.Show("Connection String Successfully Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Dr == DialogResult.OK)
                    {
                        LogIn Login = new LogIn();
                        MainClass.ShowWindow(Login, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    Serverlabel.Visible = true;
                    DataBaselabel.Visible = true;
                    MessageBox.Show("Please Fill Both TextBoxeS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ServertextBox.Text!="" && DatabasetextBox.Text!="" && UserIDtextBox.Text!="" && PasswordtextBox.Text!="")
                {
                    ConnectionString = "Data Source=" + ServertextBox.Text + "Initial Catalog=" + DatabasetextBox.Text + ";User ID=" + UserIDtextBox.Text + ";Password" + PasswordtextBox.Text + ";";
                    File.WriteAllText(Path+"//ConnectionString", ConnectionString);
                    DialogResult Dr = MessageBox.Show("Connection String Successfully Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Dr == DialogResult.OK)
                    {
                        LogIn Login = new LogIn();
                        MainClass.ShowWindow(Login, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill Both TextboxeS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void SettingS_Load(object sender, EventArgs e)
        {

        }
    }
}
