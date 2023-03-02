namespace PharmacyManagementSystem
{
    partial class Catagories
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
            this.IsActivecomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CatagorytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Namelabel = new System.Windows.Forms.Label();
            this.IsActivelabel = new System.Windows.Forms.Label();
            this.CatagoryNamelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserIDlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Viewbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CatagoryIDDataGridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDataGridview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButtonDGV = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Leftpanel.Controls.Add(this.IsActivecomboBox);
            this.Leftpanel.Controls.Add(this.label5);
            this.Leftpanel.Controls.Add(this.panel3);
            this.Leftpanel.Controls.Add(this.CatagorytextBox);
            this.Leftpanel.Controls.Add(this.label2);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.Namelabel);
            this.Leftpanel.Controls.Add(this.IsActivelabel);
            this.Leftpanel.Controls.Add(this.CatagoryNamelabel);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(231, 601);
            this.Leftpanel.TabIndex = 1;
            // 
            // IsActivecomboBox
            // 
            this.IsActivecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsActivecomboBox.FormattingEnabled = true;
            this.IsActivecomboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.IsActivecomboBox.Location = new System.Drawing.Point(6, 207);
            this.IsActivecomboBox.Name = "IsActivecomboBox";
            this.IsActivecomboBox.Size = new System.Drawing.Size(218, 21);
            this.IsActivecomboBox.TabIndex = 33;
            this.IsActivecomboBox.Leave += new System.EventHandler(this.IsActivecomboBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Is Active";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 48);
            this.panel3.TabIndex = 7;
            // 
            // CatagorytextBox
            // 
            this.CatagorytextBox.Location = new System.Drawing.Point(6, 164);
            this.CatagorytextBox.Name = "CatagorytextBox";
            this.CatagorytextBox.Size = new System.Drawing.Size(218, 20);
            this.CatagorytextBox.TabIndex = 3;
            this.CatagorytextBox.Leave += new System.EventHandler(this.CatagorytextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Catagory Name";
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
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.Red;
            this.Namelabel.Location = new System.Drawing.Point(47, 142);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(21, 25);
            this.Namelabel.TabIndex = 30;
            this.Namelabel.Text = "*";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Namelabel.Visible = false;
            // 
            // IsActivelabel
            // 
            this.IsActivelabel.AutoSize = true;
            this.IsActivelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActivelabel.ForeColor = System.Drawing.Color.Red;
            this.IsActivelabel.Location = new System.Drawing.Point(202, 184);
            this.IsActivelabel.Name = "IsActivelabel";
            this.IsActivelabel.Size = new System.Drawing.Size(22, 30);
            this.IsActivelabel.TabIndex = 32;
            this.IsActivelabel.Text = "*";
            this.IsActivelabel.Visible = false;
            // 
            // CatagoryNamelabel
            // 
            this.CatagoryNamelabel.AutoSize = true;
            this.CatagoryNamelabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatagoryNamelabel.ForeColor = System.Drawing.Color.Red;
            this.CatagoryNamelabel.Location = new System.Drawing.Point(205, 125);
            this.CatagoryNamelabel.Name = "CatagoryNamelabel";
            this.CatagoryNamelabel.Size = new System.Drawing.Size(19, 30);
            this.CatagoryNamelabel.TabIndex = 34;
            this.CatagoryNamelabel.Text = "!";
            this.CatagoryNamelabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.UserIDlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 40);
            this.panel2.TabIndex = 2;
            // 
            // UserIDlabel
            // 
            this.UserIDlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDlabel.Location = new System.Drawing.Point(541, 0);
            this.UserIDlabel.Name = "UserIDlabel";
            this.UserIDlabel.Size = new System.Drawing.Size(311, 40);
            this.UserIDlabel.TabIndex = 3;
            this.UserIDlabel.Text = "User";
            this.UserIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tableLayoutPanel1.Controls.Add(this.Savebutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Updatebutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Viewbutton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Savebutton
            // 
            this.Savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Savebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Savebutton.FlatAppearance.BorderSize = 2;
            this.Savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebutton.Location = new System.Drawing.Point(3, 3);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(115, 42);
            this.Savebutton.TabIndex = 1;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Updatebutton.FlatAppearance.BorderSize = 2;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Location = new System.Drawing.Point(124, 3);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(115, 42);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Viewbutton
            // 
            this.Viewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viewbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewbutton.FlatAppearance.BorderSize = 2;
            this.Viewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbutton.Location = new System.Drawing.Point(245, 3);
            this.Viewbutton.Name = "Viewbutton";
            this.Viewbutton.Size = new System.Drawing.Size(115, 42);
            this.Viewbutton.TabIndex = 4;
            this.Viewbutton.Text = "View";
            this.Viewbutton.UseVisualStyleBackColor = true;
            this.Viewbutton.Click += new System.EventHandler(this.Viewbutton_Click);
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
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.CatagoryIDDataGridview,
            this.NameDataGridView,
            this.StatusDataGridview,
            this.DeleteButtonDGV});
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CatagoryIDDataGridview
            // 
            this.CatagoryIDDataGridview.HeaderText = "CatID";
            this.CatagoryIDDataGridview.Name = "CatagoryIDDataGridview";
            this.CatagoryIDDataGridview.ReadOnly = true;
            this.CatagoryIDDataGridview.Visible = false;
            // 
            // NameDataGridView
            // 
            this.NameDataGridView.HeaderText = "Name";
            this.NameDataGridView.Name = "NameDataGridView";
            this.NameDataGridView.ReadOnly = true;
            // 
            // StatusDataGridview
            // 
            this.StatusDataGridview.HeaderText = "Status";
            this.StatusDataGridview.Name = "StatusDataGridview";
            this.StatusDataGridview.ReadOnly = true;
            // 
            // DeleteButtonDGV
            // 
            this.DeleteButtonDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DeleteButtonDGV.HeaderText = "Action";
            this.DeleteButtonDGV.Name = "DeleteButtonDGV";
            this.DeleteButtonDGV.ReadOnly = true;
            this.DeleteButtonDGV.Text = "Delete";
            this.DeleteButtonDGV.UseColumnTextForButtonValue = true;
            this.DeleteButtonDGV.Width = 46;
            // 
            // Catagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Leftpanel);
            this.Name = "Catagories";
            this.Text = "Catagories";
            this.Load += new System.EventHandler(this.Catagories_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CatagorytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label IsActivelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserIDlabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox IsActivecomboBox;
        private System.Windows.Forms.Label CatagoryNamelabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Viewbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoryIDDataGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDataGridview;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SearchtextBox;

    }
}