namespace PharmacyManagementSystem
{
    partial class LogIn
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
            this.Rightpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Passwordlabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.UserTypelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rightpanel.SuspendLayout();
            this.Leftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rightpanel
            // 
            this.Rightpanel.Controls.Add(this.pictureBox1);
            this.Rightpanel.Controls.Add(this.panel2);
            this.Rightpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rightpanel.Location = new System.Drawing.Point(231, 0);
            this.Rightpanel.Name = "Rightpanel";
            this.Rightpanel.Size = new System.Drawing.Size(718, 558);
            this.Rightpanel.TabIndex = 3;
            this.Rightpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Rightpanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Leftpanel
            // 
            this.Leftpanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Leftpanel.Controls.Add(this.label1);
            this.Leftpanel.Controls.Add(this.comboBox1);
            this.Leftpanel.Controls.Add(this.button1);
            this.Leftpanel.Controls.Add(this.PasswordtextBox);
            this.Leftpanel.Controls.Add(this.label4);
            this.Leftpanel.Controls.Add(this.UserNametextBox);
            this.Leftpanel.Controls.Add(this.label2);
            this.Leftpanel.Controls.Add(this.panel1);
            this.Leftpanel.Controls.Add(this.Passwordlabel);
            this.Leftpanel.Controls.Add(this.UserNamelabel);
            this.Leftpanel.Controls.Add(this.UserTypelabel);
            this.Leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Leftpanel.ForeColor = System.Drawing.Color.White;
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(231, 558);
            this.Leftpanel.TabIndex = 2;
            this.Leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Leftpanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Sale Man"});
            this.comboBox1.Location = new System.Drawing.Point(7, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(7, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(7, 313);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(218, 20);
            this.PasswordtextBox.TabIndex = 5;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            this.PasswordtextBox.Layout += new System.Windows.Forms.LayoutEventHandler(this.PasswordtextBox_Layout);
            this.PasswordtextBox.Leave += new System.EventHandler(this.PasswordtextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(7, 223);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(218, 20);
            this.UserNametextBox.TabIndex = 3;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            this.UserNametextBox.Leave += new System.EventHandler(this.UserNametextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Passwordlabel
            // 
            this.Passwordlabel.AutoSize = true;
            this.Passwordlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlabel.ForeColor = System.Drawing.Color.Red;
            this.Passwordlabel.Location = new System.Drawing.Point(206, 289);
            this.Passwordlabel.Name = "Passwordlabel";
            this.Passwordlabel.Size = new System.Drawing.Size(18, 25);
            this.Passwordlabel.TabIndex = 33;
            this.Passwordlabel.Text = "!";
            this.Passwordlabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Passwordlabel.Visible = false;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelabel.ForeColor = System.Drawing.Color.Red;
            this.UserNamelabel.Location = new System.Drawing.Point(206, 201);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(18, 25);
            this.UserNamelabel.TabIndex = 31;
            this.UserNamelabel.Text = "!";
            this.UserNamelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UserNamelabel.Visible = false;
            // 
            // UserTypelabel
            // 
            this.UserTypelabel.AutoSize = true;
            this.UserTypelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypelabel.ForeColor = System.Drawing.Color.Red;
            this.UserTypelabel.Location = new System.Drawing.Point(206, 242);
            this.UserTypelabel.Name = "UserTypelabel";
            this.UserTypelabel.Size = new System.Drawing.Size(18, 25);
            this.UserTypelabel.TabIndex = 32;
            this.UserTypelabel.Text = "!";
            this.UserTypelabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UserTypelabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PharmacyManagementSystem.Properties.Resources._116682836_291631402065909_6318486516683855070_n;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 558);
            this.ControlBox = false;
            this.Controls.Add(this.Rightpanel);
            this.Controls.Add(this.Leftpanel);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.Rightpanel.ResumeLayout(false);
            this.Leftpanel.ResumeLayout(false);
            this.Leftpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rightpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label UserTypelabel;
        private System.Windows.Forms.Label Passwordlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}