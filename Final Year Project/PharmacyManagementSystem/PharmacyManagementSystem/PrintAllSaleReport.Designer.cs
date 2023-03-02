namespace PharmacyManagementSystem
{
    partial class PrintAllSaleReport
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
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.USerIDlabel = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Leftpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkOliveGreen;
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
            this.Leftpanel.TabIndex = 3;
            // 
            // Searchbutton
            // 
            this.Searchbutton.FlatAppearance.BorderSize = 2;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Location = new System.Drawing.Point(7, 194);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(218, 32);
            this.Searchbutton.TabIndex = 12;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker.Location = new System.Drawing.Point(6, 157);
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
            this.panel2.Size = new System.Drawing.Size(852, 40);
            this.panel2.TabIndex = 4;
            // 
            // USerIDlabel
            // 
            this.USerIDlabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.USerIDlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USerIDlabel.Location = new System.Drawing.Point(542, 0);
            this.USerIDlabel.Name = "USerIDlabel";
            this.USerIDlabel.Size = new System.Drawing.Size(310, 40);
            this.USerIDlabel.TabIndex = 3;
            this.USerIDlabel.Text = "User";
            this.USerIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(231, 40);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(852, 577);
            this.crystalReportViewer1.TabIndex = 5;
            // 
            // PrintAllSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 617);
            this.ControlBox = false;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Leftpanel);
            this.Name = "PrintAllSaleReport";
            this.ShowIcon = false;
            this.Text = "PrintAllSaleReport";
            this.Load += new System.EventHandler(this.PrintAllSaleReport_Load);
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}