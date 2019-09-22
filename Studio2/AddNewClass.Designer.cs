namespace Studio2
{
    partial class AddNewClass
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.btnAllocate = new System.Windows.Forms.Button();
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
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Teal;
            this.lblLevel.Location = new System.Drawing.Point(230, 410);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 24);
            this.lblLevel.TabIndex = 37;
            this.lblLevel.Text = "Level:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(230, 360);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 24);
            this.lblTime.TabIndex = 36;
            this.lblTime.Text = "Start Time:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.Teal;
            this.lblClassID.Location = new System.Drawing.Point(230, 210);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(77, 24);
            this.lblClassID.TabIndex = 34;
            this.lblClassID.Text = "ClassID:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Teal;
            this.lblDay.Location = new System.Drawing.Point(230, 310);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(47, 24);
            this.lblDay.TabIndex = 45;
            this.lblDay.Text = "Day:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.Teal;
            this.lblClassName.Location = new System.Drawing.Point(230, 260);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(116, 24);
            this.lblClassName.TabIndex = 44;
            this.lblClassName.Text = "Class Name:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(435, 210);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(175, 20);
            this.txtClassID.TabIndex = 0;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(435, 260);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(175, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDay.Location = new System.Drawing.Point(435, 310);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(175, 21);
            this.cbDay.TabIndex = 2;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cbTime.Location = new System.Drawing.Point(435, 360);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(175, 21);
            this.cbTime.TabIndex = 3;
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate ",
            "Advanced"});
            this.cbLevel.Location = new System.Drawing.Point(435, 410);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(175, 21);
            this.cbLevel.TabIndex = 4;
            // 
            // btnAllocate
            // 
            this.btnAllocate.BackColor = System.Drawing.Color.Teal;
            this.btnAllocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllocate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllocate.Location = new System.Drawing.Point(680, 490);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(186, 51);
            this.btnAllocate.TabIndex = 5;
            this.btnAllocate.Text = "Allocate Staff Member";
            this.btnAllocate.UseVisualStyleBackColor = false;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // AddNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.btnBack);
            this.Name = "AddNewClass";
            this.Text = "AddNewClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button btnAllocate;
    }
}