namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            lbMemberID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbCity = new Label();
            lbPassword = new Label();
            lbCountry = new Label();
            dgvMemberList = new DataGridView();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            grSearch = new GroupBox();
            cboSearchCity = new ComboBox();
            cboCountry = new ComboBox();
            lbSearchCity = new Label();
            lbSearchCountry = new Label();
            grFilter = new GroupBox();
            txtSearchValue = new TextBox();
            btnSearch = new Button();
            radioByName = new RadioButton();
            radioByID = new RadioButton();
            lbSearch = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            grSearch.SuspendLayout();
            grFilter.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(103, 293);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(129, 32);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(351, 293);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 32);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(594, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(83, 32);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(63, 15);
            lbMemberID.TabIndex = 3;
            lbMemberID.Text = "MemberID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(83, 80);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(87, 15);
            lbMemberName.TabIndex = 4;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(83, 128);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(83, 212);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 6;
            lbCity.Text = "City";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(83, 170);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(83, 255);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 8;
            lbCountry.Text = "Country";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(65, 350);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(688, 210);
            dgvMemberList.TabIndex = 15;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(188, 29);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(189, 23);
            txtMemberID.TabIndex = 10;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(188, 77);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(189, 23);
            txtMemberName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(188, 209);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(189, 23);
            txtCity.TabIndex = 14;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(188, 252);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(189, 23);
            txtCountry.TabIndex = 15;
            // 
            // grSearch
            // 
            grSearch.Controls.Add(cboSearchCity);
            grSearch.Controls.Add(cboCountry);
            grSearch.Controls.Add(lbSearchCity);
            grSearch.Controls.Add(lbSearchCountry);
            grSearch.Location = new Point(508, 37);
            grSearch.Name = "grSearch";
            grSearch.Size = new Size(245, 100);
            grSearch.TabIndex = 16;
            grSearch.TabStop = false;
            grSearch.Text = "Search";
            
            // 
            // cboSearchCity
            // 
            cboSearchCity.FormattingEnabled = true;
            cboSearchCity.Location = new Point(94, 59);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new Size(121, 23);
            cboSearchCity.TabIndex = 3;
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(94, 22);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(121, 23);
            cboCountry.TabIndex = 2;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // lbSearchCity
            // 
            lbSearchCity.AutoSize = true;
            lbSearchCity.Location = new Point(22, 62);
            lbSearchCity.Name = "lbSearchCity";
            lbSearchCity.Size = new Size(28, 15);
            lbSearchCity.TabIndex = 1;
            lbSearchCity.Text = "City";
            // 
            // lbSearchCountry
            // 
            lbSearchCountry.AutoSize = true;
            lbSearchCountry.Location = new Point(22, 25);
            lbSearchCountry.Name = "lbSearchCountry";
            lbSearchCountry.Size = new Size(50, 15);
            lbSearchCountry.TabIndex = 0;
            lbSearchCountry.Text = "Country";
            // 
            // grFilter
            // 
            grFilter.Controls.Add(txtSearchValue);
            grFilter.Controls.Add(btnSearch);
            grFilter.Controls.Add(radioByName);
            grFilter.Controls.Add(radioByID);
            grFilter.Controls.Add(lbSearch);
            grFilter.Location = new Point(464, 175);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(322, 100);
            grFilter.TabIndex = 17;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
          
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(88, 25);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(120, 23);
            txtSearchValue.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(88, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // radioByName
            // 
            radioByName.AutoSize = true;
            radioByName.Location = new Point(222, 64);
            radioByName.Name = "radioByName";
            radioByName.Size = new Size(73, 19);
            radioByName.TabIndex = 23;
            radioByName.TabStop = true;
            radioByName.Text = "By Name";
            radioByName.UseVisualStyleBackColor = true;
            // 
            // radioByID
            // 
            radioByID.AutoSize = true;
            radioByID.Location = new Point(222, 25);
            radioByID.Name = "radioByID";
            radioByID.Size = new Size(52, 19);
            radioByID.TabIndex = 22;
            radioByID.TabStop = true;
            radioByID.Text = "By ID";
            radioByID.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(24, 26);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(47, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(362, 275);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 599);
            Controls.Add(grFilter);
            Controls.Add(grSearch);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(dgvMemberList);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(groupBox3);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            grSearch.ResumeLayout(false);
            grSearch.PerformLayout();
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbCity;
        private Label lbPassword;
        private Label lbCountry;
        private DataGridView dgvMemberList;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private GroupBox grSearch;
        private Label lbSearchCity;
        private Label lbSearchCountry;
        private GroupBox grFilter;

        private Label lbSearch;
        private GroupBox groupBox3;
        private Button btnSearch;
        private RadioButton radioByName;
        private RadioButton radioByID;
        private ComboBox cboSearchCity;
        private ComboBox cboCountry;
        private TextBox txtSearchValue;
    }
}