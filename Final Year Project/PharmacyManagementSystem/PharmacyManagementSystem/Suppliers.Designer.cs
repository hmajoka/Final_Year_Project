namespace PharmacyManagementSystem
{
    partial class Suppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.EMailtextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.EMaillabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.SupplierNamelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.USerIDlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveUserbutton = new System.Windows.Forms.Button();
            this.UpdateUserbutton = new System.Windows.Forms.Button();
            this.ViewUserbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCompanyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEMailDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPhoneDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAddressDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SStatusDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDatagridviewButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Leftpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Leftpanel.Controls.Add(this.StatuscomboBox);
            this.Leftpanel.Controls.Add(this.label6);
            this.Leftpanel.Controls.Add(this.Statuslabel);
            this.Leftpanel.Controls.Add(this.EMailtextBox);
            this.Leftpanel.Controls.Add(this.AddresstextBox);
            this.Leftpanel.Controls.Add(this.label8);
            this.Leftpanel.Controls.Add(this.PhonetextBox);
            this.Leftpanel.Controls.Add(this.label5);
            this.Leftpanel.Controls.Add(this.panel3);
            this.Leftpanel.Controls.Add(this.label4);
            this.Leftpanel.Controls.Add(this.SupplierNametextBox);
            this.Leftpanel.Controls.Add(this.label2);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.EMaillabel);
            this.Leftpanel.Controls.Add(this.Phonelabel);
            this.Leftpanel.Controls.Add(this.Addresslabel);
            this.Leftpanel.Controls.Add(this.SupplierNamelabel);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(231, 601);
            this.Leftpanel.TabIndex = 1;
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "In_Active"});
            this.StatuscomboBox.Location = new System.Drawing.Point(7, 376);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(218, 21);
            this.StatuscomboBox.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Status";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslabel.ForeColor = System.Drawing.Color.Red;
            this.Statuslabel.Location = new System.Drawing.Point(170, 351);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(21, 25);
            this.Statuslabel.TabIndex = 45;
            this.Statuslabel.Text = "*";
            this.Statuslabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Statuslabel.Visible = false;
            // 
            // EMailtextBox
            // 
            this.EMailtextBox.Location = new System.Drawing.Point(7, 167);
            this.EMailtextBox.Name = "EMailtextBox";
            this.EMailtextBox.Size = new System.Drawing.Size(218, 20);
            this.EMailtextBox.TabIndex = 43;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(6, 265);
            this.AddresstextBox.Multiline = true;
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(218, 76);
            this.AddresstextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Location = new System.Drawing.Point(6, 218);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(218, 20);
            this.PhonetextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 48);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "E Mail";
            // 
            // SupplierNametextBox
            // 
            this.SupplierNametextBox.Location = new System.Drawing.Point(6, 119);
            this.SupplierNametextBox.Name = "SupplierNametextBox";
            this.SupplierNametextBox.Size = new System.Drawing.Size(218, 20);
            this.SupplierNametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name/Comapny";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 40);
            this.panel1.TabIndex = 0;
            // 
            // Backbutton
            // 
            this.Backbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.Backbutton.FlatAppearance.BorderSize = 0;
            this.Backbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen;
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Image = global::PharmacyManagementSystem.Properties.Resources.icons8_back_to_3636;
            this.Backbutton.Location = new System.Drawing.Point(0, 0);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(40, 40);
            this.Backbutton.TabIndex = 2;
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // EMaillabel
            // 
            this.EMaillabel.AutoSize = true;
            this.EMaillabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMaillabel.ForeColor = System.Drawing.Color.Red;
            this.EMaillabel.Location = new System.Drawing.Point(170, 142);
            this.EMaillabel.Name = "EMaillabel";
            this.EMaillabel.Size = new System.Drawing.Size(23, 30);
            this.EMaillabel.TabIndex = 31;
            this.EMaillabel.Text = "*";
            this.EMaillabel.Visible = false;
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel.ForeColor = System.Drawing.Color.Red;
            this.Phonelabel.Location = new System.Drawing.Point(170, 185);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(22, 30);
            this.Phonelabel.TabIndex = 32;
            this.Phonelabel.Text = "*";
            this.Phonelabel.Visible = false;
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.ForeColor = System.Drawing.Color.Red;
            this.Addresslabel.Location = new System.Drawing.Point(170, 241);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(22, 30);
            this.Addresslabel.TabIndex = 35;
            this.Addresslabel.Text = "*";
            this.Addresslabel.Visible = false;
            // 
            // SupplierNamelabel
            // 
            this.SupplierNamelabel.AutoSize = true;
            this.SupplierNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNamelabel.ForeColor = System.Drawing.Color.Red;
            this.SupplierNamelabel.Location = new System.Drawing.Point(172, 99);
            this.SupplierNamelabel.Name = "SupplierNamelabel";
            this.SupplierNamelabel.Size = new System.Drawing.Size(21, 25);
            this.SupplierNamelabel.TabIndex = 30;
            this.SupplierNamelabel.Text = "*";
            this.SupplierNamelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SupplierNamelabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.USerIDlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 40);
            this.panel2.TabIndex = 2;
            // 
            // USerIDlabel
            // 
            this.USerIDlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.USerIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USerIDlabel.ForeColor = System.Drawing.Color.White;
            this.USerIDlabel.Location = new System.Drawing.Point(470, 0);
            this.USerIDlabel.Name = "USerIDlabel";
            this.USerIDlabel.Size = new System.Drawing.Size(382, 40);
            this.USerIDlabel.TabIndex = 3;
            this.USerIDlabel.Text = "User";
            this.USerIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(231, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 48);
            this.panel4.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.SaveUserbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UpdateUserbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewUserbutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SaveUserbutton
            // 
            this.SaveUserbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveUserbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveUserbutton.FlatAppearance.BorderSize = 2;
            this.SaveUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUserbutton.Location = new System.Drawing.Point(3, 3);
            this.SaveUserbutton.Name = "SaveUserbutton";
            this.SaveUserbutton.Size = new System.Drawing.Size(115, 42);
            this.SaveUserbutton.TabIndex = 1;
            this.SaveUserbutton.Text = "Save";
            this.SaveUserbutton.UseVisualStyleBackColor = true;
            this.SaveUserbutton.Click += new System.EventHandler(this.SaveUserbutton_Click);
            // 
            // UpdateUserbutton
            // 
            this.UpdateUserbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateUserbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateUserbutton.FlatAppearance.BorderSize = 2;
            this.UpdateUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateUserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserbutton.Location = new System.Drawing.Point(124, 3);
            this.UpdateUserbutton.Name = "UpdateUserbutton";
            this.UpdateUserbutton.Size = new System.Drawing.Size(115, 42);
            this.UpdateUserbutton.TabIndex = 2;
            this.UpdateUserbutton.Text = "Update";
            this.UpdateUserbutton.UseVisualStyleBackColor = true;
            this.UpdateUserbutton.Click += new System.EventHandler(this.UpdateUserbutton_Click);
            // 
            // ViewUserbutton
            // 
            this.ViewUserbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewUserbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewUserbutton.FlatAppearance.BorderSize = 2;
            this.ViewUserbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewUserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserbutton.Location = new System.Drawing.Point(245, 3);
            this.ViewUserbutton.Name = "ViewUserbutton";
            this.ViewUserbutton.Size = new System.Drawing.Size(115, 42);
            this.ViewUserbutton.TabIndex = 4;
            this.ViewUserbutton.Text = "View";
            this.ViewUserbutton.UseVisualStyleBackColor = true;
            this.ViewUserbutton.Click += new System.EventHandler(this.ViewUserbutton_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.SearchtextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(366, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchtextBox.Location = new System.Drawing.Point(3, 16);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(230, 20);
            this.SearchtextBox.TabIndex = 0;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIDDGV,
            this.SCompanyDGV,
            this.SEMailDGV,
            this.SPhoneDGV,
            this.SAddressDGV,
            this.SStatusDGV,
            this.DeleteDatagridviewButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(231, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(852, 513);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // SIDDGV
            // 
            this.SIDDGV.HeaderText = "SID";
            this.SIDDGV.Name = "SIDDGV";
            this.SIDDGV.ReadOnly = true;
            this.SIDDGV.Visible = false;
            // 
            // SCompanyDGV
            // 
            this.SCompanyDGV.HeaderText = "Company";
            this.SCompanyDGV.Name = "SCompanyDGV";
            this.SCompanyDGV.ReadOnly = true;
            // 
            // SEMailDGV
            // 
            this.SEMailDGV.HeaderText = "E Mail";
            this.SEMailDGV.Name = "SEMailDGV";
            this.SEMailDGV.ReadOnly = true;
            // 
            // SPhoneDGV
            // 
            this.SPhoneDGV.HeaderText = "Phone";
            this.SPhoneDGV.Name = "SPhoneDGV";
            this.SPhoneDGV.ReadOnly = true;
            // 
            // SAddressDGV
            // 
            this.SAddressDGV.HeaderText = "Address";
            this.SAddressDGV.Name = "SAddressDGV";
            this.SAddressDGV.ReadOnly = true;
            // 
            // SStatusDGV
            // 
            this.SStatusDGV.HeaderText = "Status";
            this.SStatusDGV.Name = "SStatusDGV";
            this.SStatusDGV.ReadOnly = true;
            // 
            // DeleteDatagridviewButton
            // 
            this.DeleteDatagridviewButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeleteDatagridviewButton.HeaderText = "Action";
            this.DeleteDatagridviewButton.Name = "DeleteDatagridviewButton";
            this.DeleteDatagridviewButton.ReadOnly = true;
            this.DeleteDatagridviewButton.Text = "Delete";
            this.DeleteDatagridviewButton.UseColumnTextForButtonValue = true;
            this.DeleteDatagridviewButton.Width = 46;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Leftpanel);
            this.Name = "Suppliers";
            this.ShowIcon = false;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label SupplierNamelabel;
        private System.Windows.Forms.Label EMaillabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label USerIDlabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox EMailtextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewUserbutton;
        private System.Windows.Forms.Button UpdateUserbutton;
        private System.Windows.Forms.Button SaveUserbutton;
        private System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCompanyDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEMailDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPhoneDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAddressDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SStatusDGV;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDatagridviewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchtextBox;
    }
}