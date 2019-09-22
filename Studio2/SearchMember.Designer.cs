namespace Studio2
{
    partial class SearchMember
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForname = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(20, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(250, 235);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(175, 20);
            this.txtDOB.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(580, 200);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(175, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(250, 200);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(175, 20);
            this.txtForename.TabIndex = 1;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(455, 165);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(175, 20);
            this.txtMemberID.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(770, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(770, 290);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(770, 440);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(770, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Teal;
            this.lblEmail.Location = new System.Drawing.Point(465, 375);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 104;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.ForeColor = System.Drawing.Color.Teal;
            this.lblPhoneNo.Location = new System.Drawing.Point(75, 375);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(101, 24);
            this.lblPhoneNo.TabIndex = 103;
            this.lblPhoneNo.Text = "Phone No:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.ForeColor = System.Drawing.Color.Teal;
            this.lblPostCode.Location = new System.Drawing.Point(465, 340);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(102, 24);
            this.lblPostCode.TabIndex = 102;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.ForeColor = System.Drawing.Color.Teal;
            this.lblCounty.Location = new System.Drawing.Point(75, 340);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(74, 24);
            this.lblCounty.TabIndex = 101;
            this.lblCounty.Text = "County:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.Teal;
            this.lblTown.Location = new System.Drawing.Point(465, 305);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(63, 24);
            this.lblTown.TabIndex = 100;
            this.lblTown.Text = "Town:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.Teal;
            this.lblStreet.Location = new System.Drawing.Point(75, 305);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 24);
            this.lblStreet.TabIndex = 99;
            this.lblStreet.Text = "Street:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Teal;
            this.lblGender.Location = new System.Drawing.Point(75, 270);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 24);
            this.lblGender.TabIndex = 98;
            this.lblGender.Text = "Gender:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Teal;
            this.lblDOB.Location = new System.Drawing.Point(75, 235);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(115, 24);
            this.lblDOB.TabIndex = 97;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Teal;
            this.lblSurname.Location = new System.Drawing.Point(465, 200);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 24);
            this.lblSurname.TabIndex = 96;
            this.lblSurname.Text = "Surname:";
            // 
            // lblForname
            // 
            this.lblForname.AutoSize = true;
            this.lblForname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForname.ForeColor = System.Drawing.Color.Teal;
            this.lblForname.Location = new System.Drawing.Point(75, 200);
            this.lblForname.Name = "lblForname";
            this.lblForname.Size = new System.Drawing.Size(103, 24);
            this.lblForname.TabIndex = 95;
            this.lblForname.Text = "Forename:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Teal;
            this.lblSearch.Location = new System.Drawing.Point(185, 165);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(261, 24);
            this.lblSearch.TabIndex = 94;
            this.lblSearch.Text = "Search by Member ID (MBR): ";
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.ForeColor = System.Drawing.Color.Teal;
            this.lblMembershipType.Location = new System.Drawing.Point(75, 410);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(169, 24);
            this.lblMembershipType.TabIndex = 120;
            this.lblMembershipType.Text = "Membership Type:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(250, 270);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(175, 20);
            this.txtGender.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(250, 305);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(175, 20);
            this.txtStreet.TabIndex = 5;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(580, 310);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(175, 20);
            this.txtTown.TabIndex = 6;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(250, 340);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(175, 20);
            this.txtCounty.TabIndex = 7;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(580, 340);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(175, 20);
            this.txtPostCode.TabIndex = 8;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(250, 375);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneNo.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(580, 375);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Location = new System.Drawing.Point(250, 410);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(175, 21);
            this.cbMembershipType.TabIndex = 11;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(580, 445);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(175, 20);
            this.txtExpiryDate.TabIndex = 13;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(250, 446);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(175, 20);
            this.txtStartDate.TabIndex = 12;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.Color.Teal;
            this.lblExpiryDate.Location = new System.Drawing.Point(465, 440);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(111, 24);
            this.lblExpiryDate.TabIndex = 130;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Teal;
            this.lblStartDate.Location = new System.Drawing.Point(75, 446);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 129;
            this.lblStartDate.Text = "Start Date:";
            // 
            // SearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cbMembershipType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblMembershipType);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForname);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnBack);
            this.Name = "SearchMember";
            this.Text = "SearchMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForname;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbMembershipType;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}