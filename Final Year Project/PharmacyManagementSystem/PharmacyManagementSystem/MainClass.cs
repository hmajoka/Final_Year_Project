using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PharmacyManagementSystem
{
    class MainClass
    {
        public static String StrInv = "";
        public static String ReprintPurchase = "";
       // public static Int16 InvoiceNo;
        public static void ShowWindow(Form OpenWindow, Form CloseWindow, Form MdiWindow)
        {
            OpenWindow.MdiParent = MdiWindow;
            OpenWindow.WindowState = FormWindowState.Maximized;
            OpenWindow.Show();
            CloseWindow.Close();
        }
        public static void ShowWindow(Form OpenWindow, Form MdiWindow)
        {
            OpenWindow.MdiParent = MdiWindow;
            OpenWindow.WindowState = FormWindowState.Maximized;
            OpenWindow.Show();
        }
        public static DialogResult ShowMessage(String Message, String Heading, String type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(Message, Heading, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                return MessageBox.Show(Message, Heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Disable_Rest(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                if (C is TextBox)
                {
                    TextBox t = (TextBox)C;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (C is ComboBox)
                {
                    ComboBox Cb = (ComboBox)C;
                    Cb.Enabled = false;
                    Cb.SelectedIndex = -1;
                }
                if (C is RadioButton)
                {
                    RadioButton Rb = (RadioButton)C;
                    Rb.Enabled = false;
                    Rb.Checked = false;
                }
                if (C is CheckBox)
                {
                    CheckBox Cb = (CheckBox)C;
                    Cb.Enabled = false;
                    Cb.Checked = false;
                }
                if (C is DateTimePicker)
                {
                    DateTimePicker DateTime = (DateTimePicker)C;
                    DateTime.Enabled = false;
                }
            }
        }
        public static void Disable(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                if (C is TextBox)
                {
                    TextBox t = (TextBox)C;
                    t.Enabled = false;
                }
                if (C is ComboBox)
                {
                    ComboBox Cb = (ComboBox)C;
                    Cb.Enabled = false;
                }
                if (C is RadioButton)
                {
                    RadioButton Rb = (RadioButton)C;
                    Rb.Enabled = false;
                }
                if (C is CheckBox)
                {
                    CheckBox Cb = (CheckBox)C;
                    Cb.Enabled = false;
                }
                if (C is DateTimePicker)
                {
                    DateTimePicker DTP = (DateTimePicker)C;
                    DTP.Enabled = false;
                }
            }
        }
        public static void EnAble_Rest(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                if (C is TextBox)
                {
                    TextBox t = (TextBox)C;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (C is ComboBox)
                {
                    ComboBox Cb = (ComboBox)C;
                    Cb.Enabled = true;
                    Cb.SelectedIndex = -1;
                }
                if (C is RadioButton)
                {
                    RadioButton Rb = (RadioButton)C;
                    Rb.Enabled = true;
                    Rb.Checked = false;
                }
                if (C is CheckBox)
                {
                    CheckBox Cb = (CheckBox)C;
                    Cb.Enabled = true;
                    Cb.Checked = false;
                }
                if (C is DateTimePicker)
                {
                    DateTimePicker datetime = (DateTimePicker)C;
                    datetime.Enabled = true;
                }
            }
        }
        public static void EnAble(Panel P)
        {
            foreach (Control C in P.Controls)
            {
                if (C is TextBox)
                {
                    TextBox t = (TextBox)C;
                    t.Enabled = true;
                }
                if (C is ComboBox)
                {
                    ComboBox Cb = (ComboBox)C;
                    Cb.Enabled = true;
                }
                if (C is RadioButton)
                {
                    RadioButton Rb = (RadioButton)C;
                    Rb.Enabled = true;
                }
                if (C is CheckBox)
                {
                    CheckBox Cb = (CheckBox)C;
                    Cb.Enabled = true;
                }
                if (C is DateTimePicker)
                {
                    DateTimePicker DTP = (DateTimePicker)C;
                    DTP.Enabled = true;
                }
            }
        }
    }
}
