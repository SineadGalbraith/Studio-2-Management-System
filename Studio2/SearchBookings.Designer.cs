namespace Studio2
{
    partial class SearchBookings
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
            this.dateTimePickerClass = new System.Windows.Forms.DateTimePicker();
            this.cbClassID = new System.Windows.Forms.ComboBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDisplayDay = new System.Windows.Forms.Label();
            this.lblDisplayPostCode = new System.Windows.Forms.Label();
            this.lblClassDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblDisplayBookingDate = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplayClassName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateTimePickerClass
            // 
            this.dateTimePickerClass.Location = new System.Drawing.Point(404, 495);
            this.dateTimePickerClass.Name = "dateTimePickerClass";
            this.dateTimePickerClass.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerClass.TabIndex = 3;
            // 
            // cbClassID
            // 
            this.cbClassID.FormattingEnabled = true;
            this.cbClassID.Location = new System.Drawing.Point(404, 355);
            this.cbClassID.Name = "cbClassID";
            this.cbClassID.Size = new System.Drawing.Size(175, 21);
            this.cbClassID.TabIndex = 2;
            this.cbClassID.SelectedIndexChanged += new System.EventHandler(this.cbClassID_SelectedIndexChanged);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(405, 180);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(175, 20);
            this.txtBookingID.TabIndex = 0;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.Teal;
            this.lblBookingDate.Location = new System.Drawing.Point(245, 215);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(127, 24);
            this.lblBookingDate.TabIndex = 141;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(760, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDisplayDay
            // 
            this.lblDisplayDay.AutoSize = true;
            this.lblDisplayDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDay.Location = new System.Drawing.Point(404, 425);
            this.lblDisplayDay.Name = "lblDisplayDay";
            this.lblDisplayDay.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayDay.TabIndex = 139;
            this.lblDisplayDay.Text = " ";
            // 
            // lblDisplayPostCode
            // 
            this.lblDisplayPostCode.AutoSize = true;
            this.lblDisplayPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPostCode.Location = new System.Drawing.Point(404, 320);
            this.lblDisplayPostCode.Name = "lblDisplayPostCode";
            this.lblDisplayPostCode.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayPostCode.TabIndex = 138;
            this.lblDisplayPostCode.Text = " ";
            // 
            // lblClassDate
            // 
            this.lblClassDate.AutoSize = true;
            this.lblClassDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDate.ForeColor = System.Drawing.Color.Teal;
            this.lblClassDate.Location = new System.Drawing.Point(269, 495);
            this.lblClassDate.Name = "lblClassDate";
            this.lblClassDate.Size = new System.Drawing.Size(103, 24);
            this.lblClassDate.TabIndex = 131;
            this.lblClassDate.Text = "Class Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(314, 460);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 24);
            this.lblTime.TabIndex = 129;
            this.lblTime.Text = "Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Teal;
            this.lblDay.Location = new System.Drawing.Point(324, 425);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(47, 24);
            this.lblDay.TabIndex = 128;
            this.lblDay.Text = "Day:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.Teal;
            this.lblClassID.Location = new System.Drawing.Point(294, 355);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(77, 24);
            this.lblClassID.TabIndex = 127;
            this.lblClassID.Text = "ClassID:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.ForeColor = System.Drawing.Color.Teal;
            this.lblPostCode.Location = new System.Drawing.Point(269, 320);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(102, 24);
            this.lblPostCode.TabIndex = 126;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(229, 285);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 24);
            this.lblName.TabIndex = 122;
            this.lblName.Text = "Member Name:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.Teal;
            this.lblMemberID.Location = new System.Drawing.Point(269, 250);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(103, 24);
            this.lblMemberID.TabIndex = 120;
            this.lblMemberID.Text = "MemberID:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.Teal;
            this.lblBookingID.Location = new System.Drawing.Point(125, 180);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(246, 24);
            this.lblBookingID.TabIndex = 119;
            this.lblBookingID.Text = "Search by BookingID (BKG):";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(404, 250);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(175, 20);
            this.txtMemberID.TabIndex = 1;
            // 
            // lblDisplayBookingDate
            // 
            this.lblDisplayBookingDate.AutoSize = true;
            this.lblDisplayBookingDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayBookingDate.Location = new System.Drawing.Point(405, 215);
            this.lblDisplayBookingDate.Name = "lblDisplayBookingDate";
            this.lblDisplayBookingDate.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayBookingDate.TabIndex = 148;
            this.lblDisplayBookingDate.Text = " ";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(404, 285);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayName.TabIndex = 149;
            this.lblDisplayName.Text = " ";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.Location = new System.Drawing.Point(404, 460);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayTime.TabIndex = 150;
            this.lblDisplayTime.Text = " ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(762, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(760, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(762, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplayClassName
            // 
            this.lblDisplayClassName.AutoSize = true;
            this.lblDisplayClassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayClassName.Location = new System.Drawing.Point(405, 390);
            this.lblDisplayClassName.Name = "lblDisplayClassName";
            this.lblDisplayClassName.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayClassName.TabIndex = 155;
            this.lblDisplayClassName.Text = " ";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Teal;
            this.lblClassName.Location = new System.Drawing.Point(305, 390);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(66, 24);
            this.lblClassName.TabIndex = 154;
            this.lblClassName.Text = "Name:";
            // 
            // SearchBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblDisplayClassName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblDisplayBookingDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dateTimePickerClass);
            this.Controls.Add(this.cbClassID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDisplayDay);
            this.Controls.Add(this.lblDisplayPostCode);
            this.Controls.Add(this.lblClassDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.btnBack);
            this.Name = "SearchBookings";
            this.Text = "SearchBookings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerClass;
        private System.Windows.Forms.ComboBox cbClassID;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDisplayDay;
        private System.Windows.Forms.Label lblDisplayPostCode;
        private System.Windows.Forms.Label lblClassDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblDisplayBookingDate;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplayClassName;
        private System.Windows.Forms.Label lblClassName;
    }
}