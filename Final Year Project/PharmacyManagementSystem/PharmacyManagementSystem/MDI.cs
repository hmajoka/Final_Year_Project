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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            try
            {

                String Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (File.Exists(Path + "//ConnectionString"))
                {
                    LogIn Login = new LogIn();
                    MainClass.ShowWindow(Login, this);
                }
                else
                {
                    SettingS SettingS = new SettingS();
                    MainClass.ShowWindow(SettingS, this);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingS SettingS = new SettingS();
            MainClass.ShowWindow(SettingS, this);
        }
    }
}
