namespace Studio2
{
    partial class AllocateStaff
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblStaffRole = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbStaffID = new System.Windows.Forms.ComboBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.cbStaffRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.Teal;
            this.lblStaffID.Location = new System.Drawing.Point(145, 200);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(76, 24);
            this.lblStaffID.TabIndex = 61;
            this.lblStaffID.Text = "Staff ID: ";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.Teal;
            this.lblClassID.Location = new System.Drawing.Point(145, 150);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(77, 24);
            this.lblClassID.TabIndex = 60;
            this.lblClassID.Text = "ClassID:";
            // 
            // lblStaffRole
            // 
            this.lblStaffRole.AutoSize = true;
            this.lblStaffRole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaffRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffRole.ForeColor = System.Drawing.Color.Teal;
            this.lblStaffRole.Location = new System.Drawing.Point(145, 300);
            this.lblStaffRole.Name = "lblStaffRole";
            this.lblStaffRole.Size = new System.Drawing.Size(93, 24);
            this.lblStaffRole.TabIndex = 64;
            this.lblStaffRole.Text = "Staff Role:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID.Location = new System.Drawing.Point(280, 150);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 20);
            this.lblID.TabIndex = 66;
            this.lblID.Text = " ";
            // 
            // cbStaffID
            // 
            this.cbStaffID.FormattingEnabled = true;
            this.cbStaffID.Location = new System.Drawing.Point(280, 200);
            this.cbStaffID.Name = "cbStaffID";
            this.cbStaffID.Size = new System.Drawing.Size(175, 21);
            this.cbStaffID.TabIndex = 0;
            this.cbStaffID.SelectedIndexChanged += new System.EventHandler(this.cbStaffID_SelectedIndexChanged);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDisplayName.Location = new System.Drawing.Point(280, 250);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(13, 20);
            this.lblDisplayName.TabIndex = 68;
            this.lblDisplayName.Text = " ";
            // 
            // cbStaffRole
            // 
            this.cbStaffRole.FormattingEnabled = true;
            this.cbStaffRole.Items.AddRange(new object[] {
            "Supporting",
            "Main"});
            this.cbStaffRole.Location = new System.Drawing.Point(280, 305);
            this.cbStaffRole.Name = "cbStaffRole";
            this.cbStaffRole.Size = new System.Drawing.Size(175, 21);
            this.cbStaffRole.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(480, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(15, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.Color.Teal;
            this.lblStaffName.Location = new System.Drawing.Point(145, 250);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(105, 24);
            this.lblStaffName.TabIndex = 74;
            this.lblStaffName.Text = "Staff Name:";
            // 
            // AllocateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 406);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbStaffRole);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.cbStaffID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblStaffRole);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblClassID);
            this.Name = "AllocateStaff";
            this.Text = "AllocateStaff";
            this.Load += new System.EventHandler(this.AllocateStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblStaffRole;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cbStaffID;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.ComboBox cbStaffRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStaffName;
    }
}