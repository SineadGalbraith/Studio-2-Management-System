namespace Studio2
{
    partial class SearchMembership
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbPaymentType = new System.Windows.Forms.ComboBox();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMembershipTypeID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(440, 440);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(175, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // cbPaymentType
            // 
            this.cbPaymentType.FormattingEnabled = true;
            this.cbPaymentType.Items.AddRange(new object[] {
            "Pay Monthly",
            "Single Payment "});
            this.cbPaymentType.Location = new System.Drawing.Point(440, 385);
            this.cbPaymentType.Name = "cbPaymentType";
            this.cbPaymentType.Size = new System.Drawing.Size(175, 21);
            this.cbPaymentType.TabIndex = 3;
            // 
            // cbLength
            // 
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Items.AddRange(new object[] {
            "6 Months",
            "12 Months"});
            this.cbLength.Location = new System.Drawing.Point(440, 330);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(175, 21);
            this.cbLength.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(440, 275);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtMembershipTypeID
            // 
            this.txtMembershipTypeID.Location = new System.Drawing.Point(440, 220);
            this.txtMembershipTypeID.Name = "txtMembershipTypeID";
            this.txtMembershipTypeID.Size = new System.Drawing.Size(175, 20);
            this.txtMembershipTypeID.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Teal;
            this.lblAmount.Location = new System.Drawing.Point(250, 440);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(154, 24);
            this.lblAmount.TabIndex = 38;
            this.lblAmount.Text = "Total Amount (£):";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.ForeColor = System.Drawing.Color.Teal;
            this.lblPaymentType.Location = new System.Drawing.Point(250, 385);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(136, 24);
            this.lblPaymentType.TabIndex = 37;
            this.lblPaymentType.Text = "Payment Type:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.Teal;
            this.lblLength.Location = new System.Drawing.Point(250, 330);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(73, 24);
            this.lblLength.TabIndex = 36;
            this.lblLength.Text = "Length:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Teal;
            this.lblDescription.Location = new System.Drawing.Point(250, 275);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 24);
            this.lblDescription.TabIndex = 35;
            this.lblDescription.Text = "Description:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Teal;
            this.lblSearch.Location = new System.Drawing.Point(130, 220);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(286, 24);
            this.lblSearch.TabIndex = 34;
            this.lblSearch.Text = "Search by Membership Type ID: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(645, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(645, 285);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(645, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(645, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbPaymentType);
            this.Controls.Add(this.cbLength);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMembershipTypeID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnBack);
            this.Name = "SearchMembership";
            this.Text = "SearchMembership";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbPaymentType;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtMembershipTypeID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}