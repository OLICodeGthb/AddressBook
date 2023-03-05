namespace AddressBookProgram
{
    partial class AddressBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLContactsPresentCheck = new System.Windows.Forms.Label();
            this.LBContactList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageInformation = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNEAdd = new System.Windows.Forms.Button();
            this.NUDTelNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TabPageOptions = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTNClearAllContacts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHKBXDarkTheme = new System.Windows.Forms.CheckBox();
            this.CHKBXPinToTop = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelNo)).BeginInit();
            this.panel4.SuspendLayout();
            this.TabPageOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AddressBook";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.33858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.66142F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNRemove, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 591);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLContactsPresentCheck);
            this.groupBox1.Controls.Add(this.LBContactList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 535);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacts";
            // 
            // LBLContactsPresentCheck
            // 
            this.LBLContactsPresentCheck.AutoSize = true;
            this.LBLContactsPresentCheck.BackColor = System.Drawing.Color.White;
            this.LBLContactsPresentCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContactsPresentCheck.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LBLContactsPresentCheck.Location = new System.Drawing.Point(68, 259);
            this.LBLContactsPresentCheck.Name = "LBLContactsPresentCheck";
            this.LBLContactsPresentCheck.Size = new System.Drawing.Size(159, 20);
            this.LBLContactsPresentCheck.TabIndex = 1;
            this.LBLContactsPresentCheck.Text = "No Contacts found";
            // 
            // LBContactList
            // 
            this.LBContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBContactList.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBContactList.FormattingEnabled = true;
            this.LBContactList.ItemHeight = 20;
            this.LBContactList.Location = new System.Drawing.Point(3, 16);
            this.LBContactList.Name = "LBContactList";
            this.LBContactList.Size = new System.Drawing.Size(302, 516);
            this.LBContactList.TabIndex = 0;
            this.LBContactList.SelectedIndexChanged += new System.EventHandler(this.LBContactList_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageInformation);
            this.tabControl1.Controls.Add(this.TabPageOptions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(317, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 535);
            this.tabControl1.TabIndex = 2;
            // 
            // TabPageInformation
            // 
            this.TabPageInformation.Controls.Add(this.label7);
            this.TabPageInformation.Controls.Add(this.BTNEAdd);
            this.TabPageInformation.Controls.Add(this.NUDTelNo);
            this.TabPageInformation.Controls.Add(this.label4);
            this.TabPageInformation.Controls.Add(this.BTNSave);
            this.TabPageInformation.Controls.Add(this.label12);
            this.TabPageInformation.Controls.Add(this.txtAddress);
            this.TabPageInformation.Controls.Add(this.label11);
            this.TabPageInformation.Controls.Add(this.txtSurname);
            this.TabPageInformation.Controls.Add(this.label10);
            this.TabPageInformation.Controls.Add(this.txtFirstName);
            this.TabPageInformation.Controls.Add(this.label9);
            this.TabPageInformation.Controls.Add(this.txtTitle);
            this.TabPageInformation.Controls.Add(this.label8);
            this.TabPageInformation.Controls.Add(this.panel4);
            this.TabPageInformation.Location = new System.Drawing.Point(4, 22);
            this.TabPageInformation.Name = "TabPageInformation";
            this.TabPageInformation.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInformation.Size = new System.Drawing.Size(434, 509);
            this.TabPageInformation.TabIndex = 0;
            this.TabPageInformation.Text = "Information";
            this.TabPageInformation.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 68);
            this.label7.TabIndex = 21;
            this.label7.Text = "After entering details press \"ADD\"\r\n\r\nTo edit details change any values in textbo" +
    "xes\r\nthen press \"Save Changes\"\r\n";
            // 
            // BTNEAdd
            // 
            this.BTNEAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNEAdd.ForeColor = System.Drawing.Color.White;
            this.BTNEAdd.Location = new System.Drawing.Point(101, 458);
            this.BTNEAdd.Name = "BTNEAdd";
            this.BTNEAdd.Size = new System.Drawing.Size(103, 34);
            this.BTNEAdd.TabIndex = 20;
            this.BTNEAdd.Text = "Add contact";
            this.BTNEAdd.UseVisualStyleBackColor = false;
            this.BTNEAdd.Click += new System.EventHandler(this.BTNEAdd_Click);
            // 
            // NUDTelNo
            // 
            this.NUDTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDTelNo.Location = new System.Drawing.Point(139, 391);
            this.NUDTelNo.Name = "NUDTelNo";
            this.NUDTelNo.Size = new System.Drawing.Size(202, 22);
            this.NUDTelNo.TabIndex = 17;
            this.NUDTelNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Please enter contact details into the textboxes below";
            // 
            // BTNSave
            // 
            this.BTNSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNSave.ForeColor = System.Drawing.Color.White;
            this.BTNSave.Location = new System.Drawing.Point(210, 458);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(126, 34);
            this.BTNSave.TabIndex = 0;
            this.BTNSave.Text = "Save  changes";
            this.BTNSave.UseVisualStyleBackColor = false;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tel no:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(139, 342);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Address:";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.Black;
            this.txtSurname.Location = new System.Drawing.Point(139, 287);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(172, 22);
            this.txtSurname.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Surname:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(139, 235);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Firstname:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(139, 183);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(86, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Title:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 39);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Contact Details";
            // 
            // TabPageOptions
            // 
            this.TabPageOptions.BackColor = System.Drawing.Color.White;
            this.TabPageOptions.Controls.Add(this.groupBox3);
            this.TabPageOptions.Controls.Add(this.groupBox2);
            this.TabPageOptions.Controls.Add(this.panel3);
            this.TabPageOptions.Location = new System.Drawing.Point(4, 22);
            this.TabPageOptions.Name = "TabPageOptions";
            this.TabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOptions.Size = new System.Drawing.Size(434, 509);
            this.TabPageOptions.TabIndex = 1;
            this.TabPageOptions.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNClearAllContacts);
            this.groupBox3.Location = new System.Drawing.Point(23, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 167);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AddressBook data";
            // 
            // BTNClearAllContacts
            // 
            this.BTNClearAllContacts.BackColor = System.Drawing.Color.Maroon;
            this.BTNClearAllContacts.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClearAllContacts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNClearAllContacts.Location = new System.Drawing.Point(137, 59);
            this.BTNClearAllContacts.Name = "BTNClearAllContacts";
            this.BTNClearAllContacts.Size = new System.Drawing.Size(147, 44);
            this.BTNClearAllContacts.TabIndex = 0;
            this.BTNClearAllContacts.Text = "Clear all contacts";
            this.BTNClearAllContacts.UseVisualStyleBackColor = false;
            this.BTNClearAllContacts.Click += new System.EventHandler(this.BTNClearAllContacts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHKBXDarkTheme);
            this.groupBox2.Controls.Add(this.CHKBXPinToTop);
            this.groupBox2.Location = new System.Drawing.Point(23, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UI options";
            // 
            // CHKBXDarkTheme
            // 
            this.CHKBXDarkTheme.AutoSize = true;
            this.CHKBXDarkTheme.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKBXDarkTheme.Location = new System.Drawing.Point(137, 93);
            this.CHKBXDarkTheme.Name = "CHKBXDarkTheme";
            this.CHKBXDarkTheme.Size = new System.Drawing.Size(113, 25);
            this.CHKBXDarkTheme.TabIndex = 4;
            this.CHKBXDarkTheme.Text = "Dark theme";
            this.CHKBXDarkTheme.UseVisualStyleBackColor = true;
            this.CHKBXDarkTheme.CheckedChanged += new System.EventHandler(this.CHKBXDarkTheme_CheckedChanged);
            // 
            // CHKBXPinToTop
            // 
            this.CHKBXPinToTop.AutoSize = true;
            this.CHKBXPinToTop.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKBXPinToTop.Location = new System.Drawing.Point(137, 46);
            this.CHKBXPinToTop.Name = "CHKBXPinToTop";
            this.CHKBXPinToTop.Size = new System.Drawing.Size(101, 25);
            this.CHKBXPinToTop.TabIndex = 3;
            this.CHKBXPinToTop.Text = "Pin to top";
            this.CHKBXPinToTop.UseVisualStyleBackColor = true;
            this.CHKBXPinToTop.CheckedChanged += new System.EventHandler(this.CHKBXPinToTop_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(428, 38);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "AddressBook options\r\n";
            // 
            // BTNRemove
            // 
            this.BTNRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTNRemove.ForeColor = System.Drawing.Color.White;
            this.BTNRemove.Location = new System.Drawing.Point(3, 554);
            this.BTNRemove.Name = "BTNRemove";
            this.BTNRemove.Size = new System.Drawing.Size(308, 34);
            this.BTNRemove.TabIndex = 13;
            this.BTNRemove.Text = "Remove contact";
            this.BTNRemove.UseVisualStyleBackColor = false;
            this.BTNRemove.Click += new System.EventHandler(this.BTNRemove_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPageInformation.ResumeLayout(false);
            this.TabPageInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTelNo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.TabPageOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBContactList;
        private System.Windows.Forms.Label LBLContactsPresentCheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageInformation;
        private System.Windows.Forms.TabPage TabPageOptions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNSave;
        private System.Windows.Forms.Button BTNRemove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDTelNo;
        private System.Windows.Forms.Button BTNEAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CHKBXDarkTheme;
        private System.Windows.Forms.CheckBox CHKBXPinToTop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTNClearAllContacts;
    }
}

