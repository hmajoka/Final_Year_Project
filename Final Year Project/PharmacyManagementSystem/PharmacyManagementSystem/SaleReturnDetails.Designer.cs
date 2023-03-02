namespace PharmacyManagementSystem
{
    partial class SaleReturnDetails
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.USerIDlabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SessionIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnByDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDateDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnQtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnAmountDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leftpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Leftpanel.Controls.Add(this.panel3);
            this.Leftpanel.Controls.Add(this.Searchbutton);
            this.Leftpanel.Controls.Add(this.TodateTimePicker);
            this.Leftpanel.Controls.Add(this.label2);
            this.Leftpanel.Controls.Add(this.FromdateTimePicker);
            this.Leftpanel.Controls.Add(this.label1);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(231, 617);
            this.Leftpanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 29);
            this.panel3.TabIndex = 13;
            // 
            // Searchbutton
            // 
            this.Searchbutton.FlatAppearance.BorderSize = 2;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbutton.Location = new System.Drawing.Point(7, 195);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(218, 34);
            this.Searchbutton.TabIndex = 12;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker.Location = new System.Drawing.Point(6, 158);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.ShowUpDown = true;
            this.TodateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.TodateTimePicker.TabIndex = 11;
            this.TodateTimePicker.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(6, 109);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.ShowUpDown = true;
            this.FromdateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.FromdateTimePicker.TabIndex = 9;
            this.FromdateTimePicker.Value = new System.DateTime(2020, 6, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.USerIDlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(231, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 40);
            this.panel2.TabIndex = 6;
            // 
            // USerIDlabel
            // 
            this.USerIDlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.USerIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USerIDlabel.Location = new System.Drawing.Point(570, 0);
            this.USerIDlabel.Name = "USerIDlabel";
            this.USerIDlabel.Size = new System.Drawing.Size(310, 40);
            this.USerIDlabel.TabIndex = 3;
            this.USerIDlabel.Text = "User";
            this.USerIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(231, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 29);
            this.panel4.TabIndex = 9;
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
            this.SessionIDDGV,
            this.ReturnByDGV,
            this.ReturnDateDGV,
            this.PNameDGV,
            this.ReturnQtyDGV,
            this.ReturnAmountDGV,
            this.DescriptionDGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(880, 548);
            this.dataGridView1.TabIndex = 26;
            // 
            // SessionIDDGV
            // 
            this.SessionIDDGV.HeaderText = "Session ID";
            this.SessionIDDGV.Name = "SessionIDDGV";
            this.SessionIDDGV.ReadOnly = true;
            // 
            // ReturnByDGV
            // 
            this.ReturnByDGV.HeaderText = "Return By";
            this.ReturnByDGV.Name = "ReturnByDGV";
            this.ReturnByDGV.ReadOnly = true;
            // 
            // ReturnDateDGV
            // 
            this.ReturnDateDGV.HeaderText = "Return Date";
            this.ReturnDateDGV.Name = "ReturnDateDGV";
            this.ReturnDateDGV.ReadOnly = true;
            // 
            // PNameDGV
            // 
            this.PNameDGV.HeaderText = "P Name";
            this.PNameDGV.Name = "PNameDGV";
            this.PNameDGV.ReadOnly = true;
            // 
            // ReturnQtyDGV
            // 
            this.ReturnQtyDGV.HeaderText = "Return Qty";
            this.ReturnQtyDGV.Name = "ReturnQtyDGV";
            this.ReturnQtyDGV.ReadOnly = true;
            // 
            // ReturnAmountDGV
            // 
            this.ReturnAmountDGV.HeaderText = "Return Anount";
            this.ReturnAmountDGV.Name = "ReturnAmountDGV";
            this.ReturnAmountDGV.ReadOnly = true;
            // 
            // DescriptionDGV
            // 
            this.DescriptionDGV.HeaderText = "Description";
            this.DescriptionDGV.Name = "DescriptionDGV";
            this.DescriptionDGV.ReadOnly = true;
            // 
            // SaleReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 617);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Leftpanel);
            this.Name = "SaleReturnDetails";
            this.ShowIcon = false;
            this.Text = "Sale Return Details";
            this.Load += new System.EventHandler(this.SaleReturnDetails_Load);
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
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label USerIDlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnByDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDateDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnQtyDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnAmountDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionDGV;
    }
}