namespace PharmacyManagementSystem
{
    partial class SaleDetails
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
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.USerIDlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InvoiceDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDateDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTotalDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintButtonDGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Leftpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Leftpanel.Controls.Add(this.TodateTimePicker);
            this.Leftpanel.Controls.Add(this.FromdateTimePicker);
            this.Leftpanel.Controls.Add(this.Searchbutton);
            this.Leftpanel.Controls.Add(this.label4);
            this.Leftpanel.Controls.Add(this.label2);
            this.Leftpanel.Controls.Add(this.panel3);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(231, 663);
            this.Leftpanel.TabIndex = 3;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker.Location = new System.Drawing.Point(5, 145);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.ShowUpDown = true;
            this.TodateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.TodateTimePicker.TabIndex = 14;
            this.TodateTimePicker.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(4, 97);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.ShowUpDown = true;
            this.FromdateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.FromdateTimePicker.TabIndex = 13;
            this.FromdateTimePicker.Value = new System.DateTime(2020, 6, 10, 0, 0, 0, 0);
            // 
            // Searchbutton
            // 
            this.Searchbutton.FlatAppearance.BorderSize = 2;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(6, 189);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(218, 31);
            this.Searchbutton.TabIndex = 12;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 29);
            this.panel3.TabIndex = 7;
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(231, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 29);
            this.panel4.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.USerIDlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 40);
            this.panel2.TabIndex = 9;
            // 
            // USerIDlabel
            // 
            this.USerIDlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.USerIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USerIDlabel.Location = new System.Drawing.Point(470, 0);
            this.USerIDlabel.Name = "USerIDlabel";
            this.USerIDlabel.Size = new System.Drawing.Size(382, 40);
            this.USerIDlabel.TabIndex = 3;
            this.USerIDlabel.Text = "User";
            this.USerIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.InvoiceDGV,
            this.InvoiceDateDGV,
            this.SubTotalDGV,
            this.DisDGV,
            this.NetTotalDGV,
            this.PrintButtonDGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(231, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(852, 594);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // InvoiceDGV
            // 
            this.InvoiceDGV.HeaderText = "Invoice";
            this.InvoiceDGV.Name = "InvoiceDGV";
            this.InvoiceDGV.ReadOnly = true;
            this.InvoiceDGV.Visible = false;
            // 
            // InvoiceDateDGV
            // 
            this.InvoiceDateDGV.HeaderText = "Date";
            this.InvoiceDateDGV.Name = "InvoiceDateDGV";
            this.InvoiceDateDGV.ReadOnly = true;
            // 
            // SubTotalDGV
            // 
            this.SubTotalDGV.HeaderText = "SubTotal";
            this.SubTotalDGV.Name = "SubTotalDGV";
            this.SubTotalDGV.ReadOnly = true;
            // 
            // DisDGV
            // 
            this.DisDGV.HeaderText = "Dis";
            this.DisDGV.Name = "DisDGV";
            this.DisDGV.ReadOnly = true;
            // 
            // NetTotalDGV
            // 
            this.NetTotalDGV.HeaderText = "Net Total";
            this.NetTotalDGV.Name = "NetTotalDGV";
            this.NetTotalDGV.ReadOnly = true;
            // 
            // PrintButtonDGV
            // 
            this.PrintButtonDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrintButtonDGV.HeaderText = "Action";
            this.PrintButtonDGV.Name = "PrintButtonDGV";
            this.PrintButtonDGV.ReadOnly = true;
            this.PrintButtonDGV.Text = "Print";
            this.PrintButtonDGV.UseColumnTextForButtonValue = true;
            this.PrintButtonDGV.Width = 46;
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 663);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Leftpanel);
            this.Name = "SaleDetails";
            this.ShowIcon = false;
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.SaleDetails_Load);
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label USerIDlabel;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDateDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotalDGV;
        private System.Windows.Forms.DataGridViewButtonColumn PrintButtonDGV;
    }
}