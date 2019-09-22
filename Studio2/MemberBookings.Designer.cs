namespace Studio2
{
    partial class MemberBookings
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClassDate = new System.Windows.Forms.Label();
            this.lblDisplayBookingID = new System.Windows.Forms.Label();
            this.lblDisplayForename = new System.Windows.Forms.Label();
            this.lblDisplaySurname = new System.Windows.Forms.Label();
            this.lblDisplayStreet = new System.Windows.Forms.Label();
            this.lblDisplayTown = new System.Windows.Forms.Label();
            this.lblDisplayCounty = new System.Windows.Forms.Label();
            this.lblDisplayPostCode = new System.Windows.Forms.Label();
            this.lblDisplayTime = new System.Windows.Forms.Label();
            this.lblDisplayDay = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDisplayNumber = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.cbClassID = new System.Windows.Forms.ComboBox();
            this.dateTimePickerClass = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
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
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(300, 430);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(58, 24);
            this.lblTime.TabIndex = 41;
            this.lblTime.Text = "Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Teal;
            this.lblDay.Location = new System.Drawing.Point(10, 430);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(47, 24);
            this.lblDay.TabIndex = 40;
            this.lblDay.Text = "Day:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.Teal;
            this.lblClassID.Location = new System.Drawing.Point(10, 360);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(77, 24);
            this.lblClassID.TabIndex = 39;
            this.lblClassID.Text = "ClassID:";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.ForeColor = System.Drawing.Color.Teal;
            this.lblPostCode.Location = new System.Drawing.Point(300, 325);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(102, 24);
            this.lblPostCode.TabIndex = 38;
            this.lblPostCode.Text = "Post Code:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.ForeColor = System.Drawing.Color.Teal;
            this.lblCounty.Location = new System.Drawing.Point(10, 325);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(74, 24);
            this.lblCounty.TabIndex = 37;
            this.lblCounty.Text = "County:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.ForeColor = System.Drawing.Color.Teal;
            this.lblTown.Location = new System.Drawing.Point(300, 290);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(63, 24);
            this.lblTown.TabIndex = 36;
            this.lblTown.Text = "Town:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.Color.Teal;
            this.lblStreet.Location = new System.Drawing.Point(10, 290);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 24);
            this.lblStreet.TabIndex = 35;
            this.lblStreet.Text = "Street:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.Color.Teal;
            this.lblForename.Location = new System.Drawing.Point(10, 255);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(103, 24);
            this.lblForename.TabIndex = 33;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Teal;
            this.lblSurname.Location = new System.Drawing.Point(300, 255);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 24);
            this.lblSurname.TabIndex = 32;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.Teal;
            this.lblMemberID.Location = new System.Drawing.Point(10, 220);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(103, 24);
            this.lblMemberID.TabIndex = 31;
            this.lblMemberID.Text = "MemberID:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.Color.Teal;
            this.lblBookingID.Location = new System.Drawing.Point(10, 185);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(106, 24);
            this.lblBookingID.TabIndex = 30;
            this.lblBookingID.Text = "BookingID: ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(760, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClassDate
            // 
            this.lblClassDate.AutoSize = true;
            this.lblClassDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDate.ForeColor = System.Drawing.Color.Teal;
            this.lblClassDate.Location = new System.Drawing.Point(10, 465);
            this.lblClassDate.Name = "lblClassDate";
            this.lblClassDate.Size = new System.Drawing.Size(103, 24);
            this.lblClassDate.TabIndex = 56;
            this.lblClassDate.Text = "Class Date:";
            // 
            // lblDisplayBookingID
            // 
            this.lblDisplayBookingID.AutoSize = true;
            this.lblDisplayBookingID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayBookingID.Location = new System.Drawing.Point(120, 187);
            this.lblDisplayBookingID.Name = "lblDisplayBookingID";
            this.lblDisplayBookingID.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayBookingID.TabIndex = 57;
            this.lblDisplayBookingID.Text = " ";
            // 
            // lblDisplayForename
            // 
            this.lblDisplayForename.AutoSize = true;
            this.lblDisplayForename.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayForename.Location = new System.Drawing.Point(120, 257);
            this.lblDisplayForename.Name = "lblDisplayForename";
            this.lblDisplayForename.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayForename.TabIndex = 59;
            this.lblDisplayForename.Text = " ";
            // 
            // lblDisplaySurname
            // 
            this.lblDisplaySurname.AutoSize = true;
            this.lblDisplaySurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplaySurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySurname.Location = new System.Drawing.Point(435, 256);
            this.lblDisplaySurname.Name = "lblDisplaySurname";
            this.lblDisplaySurname.Size = new System.Drawing.Size(12, 18);
            this.lblDisplaySurname.TabIndex = 60;
            this.lblDisplaySurname.Text = " ";
            // 
            // lblDisplayStreet
            // 
            this.lblDisplayStreet.AutoSize = true;
            this.lblDisplayStreet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayStreet.Location = new System.Drawing.Point(120, 292);
            this.lblDisplayStreet.Name = "lblDisplayStreet";
            this.lblDisplayStreet.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayStreet.TabIndex = 61;
            this.lblDisplayStreet.Text = " ";
            // 
            // lblDisplayTown
            // 
            this.lblDisplayTown.AutoSize = true;
            this.lblDisplayTown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTown.Location = new System.Drawing.Point(435, 291);
            this.lblDisplayTown.Name = "lblDisplayTown";
            this.lblDisplayTown.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayTown.TabIndex = 62;
            this.lblDisplayTown.Text = " ";
            // 
            // lblDisplayCounty
            // 
            this.lblDisplayCounty.AutoSize = true;
            this.lblDisplayCounty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayCounty.Location = new System.Drawing.Point(120, 328);
            this.lblDisplayCounty.Name = "lblDisplayCounty";
            this.lblDisplayCounty.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayCounty.TabIndex = 63;
            this.lblDisplayCounty.Text = " ";
            // 
            // lblDisplayPostCode
            // 
            this.lblDisplayPostCode.AutoSize = true;
            this.lblDisplayPostCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPostCode.Location = new System.Drawing.Point(435, 326);
            this.lblDisplayPostCode.Name = "lblDisplayPostCode";
            this.lblDisplayPostCode.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayPostCode.TabIndex = 64;
            this.lblDisplayPostCode.Text = " ";
            // 
            // lblDisplayTime
            // 
            this.lblDisplayTime.AutoSize = true;
            this.lblDisplayTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTime.Location = new System.Drawing.Point(435, 430);
            this.lblDisplayTime.Name = "lblDisplayTime";
            this.lblDisplayTime.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayTime.TabIndex = 66;
            this.lblDisplayTime.Text = " ";
            // 
            // lblDisplayDay
            // 
            this.lblDisplayDay.AutoSize = true;
            this.lblDisplayDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDay.Location = new System.Drawing.Point(120, 430);
            this.lblDisplayDay.Name = "lblDisplayDay";
            this.lblDisplayDay.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayDay.TabIndex = 67;
            this.lblDisplayDay.Text = " ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(530, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDisplayNumber
            // 
            this.lblDisplayNumber.AutoSize = true;
            this.lblDisplayNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplayNumber.Location = new System.Drawing.Point(620, 465);
            this.lblDisplayNumber.Name = "lblDisplayNumber";
            this.lblDisplayNumber.Size = new System.Drawing.Size(13, 20);
            this.lblDisplayNumber.TabIndex = 109;
            this.lblDisplayNumber.Text = " ";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.ForeColor = System.Drawing.Color.Teal;
            this.lblBookingDate.Location = new System.Drawing.Point(300, 184);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(127, 24);
            this.lblBookingDate.TabIndex = 110;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(624, 190);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.Size = new System.Drawing.Size(240, 265);
            this.dataGridViewBooking.TabIndex = 5;
            this.dataGridViewBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooking_CellClick);
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(435, 184);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(175, 20);
            this.txtBookingDate.TabIndex = 111;
            this.txtBookingDate.TextChanged += new System.EventHandler(this.txtBookingDate_TextChanged);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(123, 220);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(175, 20);
            this.txtMemberID.TabIndex = 0;
            // 
            // cbClassID
            // 
            this.cbClassID.FormattingEnabled = true;
            this.cbClassID.Location = new System.Drawing.Point(123, 360);
            this.cbClassID.Name = "cbClassID";
            this.cbClassID.Size = new System.Drawing.Size(175, 21);
            this.cbClassID.TabIndex = 1;
            // 
            // dateTimePickerClass
            // 
            this.dateTimePickerClass.Location = new System.Drawing.Point(123, 465);
            this.dateTimePickerClass.Name = "dateTimePickerClass";
            this.dateTimePickerClass.Size = new System.Drawing.Size(175, 20);
            this.dateTimePickerClass.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(620, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(11, 16);
            this.lblName.TabIndex = 119;
            this.lblName.Text = " ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(530, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(120, 395);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(12, 18);
            this.lblDisplayName.TabIndex = 122;
            this.lblDisplayName.Text = " ";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Teal;
            this.lblClassName.Location = new System.Drawing.Point(10, 395);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(66, 24);
            this.lblClassName.TabIndex = 121;
            this.lblClassName.Text = "Name:";
            // 
            // MemberBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dateTimePickerClass);
            this.Controls.Add(this.cbClassID);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.txtBookingDate);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.lblDisplayNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDisplayDay);
            this.Controls.Add(this.lblDisplayTime);
            this.Controls.Add(this.lblDisplayPostCode);
            this.Controls.Add(this.lblDisplayCounty);
            this.Controls.Add(this.lblDisplayTown);
            this.Controls.Add(this.lblDisplayStreet);
            this.Controls.Add(this.lblDisplaySurname);
            this.Controls.Add(this.lblDisplayForename);
            this.Controls.Add(this.lblDisplayBookingID);
            this.Controls.Add(this.lblClassDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.btnBack);
            this.Name = "MemberBookings";
            this.Text = "MemberBookings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClassDate;
        private System.Windows.Forms.Label lblDisplayBookingID;
        private System.Windows.Forms.Label lblDisplayForename;
        private System.Windows.Forms.Label lblDisplaySurname;
        private System.Windows.Forms.Label lblDisplayStreet;
        private System.Windows.Forms.Label lblDisplayTown;
        private System.Windows.Forms.Label lblDisplayCounty;
        private System.Windows.Forms.Label lblDisplayPostCode;
        private System.Windows.Forms.Label lblDisplayTime;
        private System.Windows.Forms.Label lblDisplayDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDisplayNumber;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.ComboBox cbClassID;
        private System.Windows.Forms.DateTimePicker dateTimePickerClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblClassName;
    }
}