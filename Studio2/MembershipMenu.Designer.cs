namespace Studio2
{
    partial class MembershipMenu
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
            this.btnAddNewMembership = new System.Windows.Forms.Button();
            this.btnSearchMemberships = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewMembership
            // 
            this.btnAddNewMembership.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMembership.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewMembership.Location = new System.Drawing.Point(300, 230);
            this.btnAddNewMembership.Name = "btnAddNewMembership";
            this.btnAddNewMembership.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewMembership.TabIndex = 0;
            this.btnAddNewMembership.Text = "Add New Membership";
            this.btnAddNewMembership.UseVisualStyleBackColor = false;
            this.btnAddNewMembership.Click += new System.EventHandler(this.btnAddNewMembership_Click);
            // 
            // btnSearchMemberships
            // 
            this.btnSearchMemberships.BackColor = System.Drawing.Color.Teal;
            this.btnSearchMemberships.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMemberships.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchMemberships.Location = new System.Drawing.Point(300, 350);
            this.btnSearchMemberships.Name = "btnSearchMemberships";
            this.btnSearchMemberships.Size = new System.Drawing.Size(300, 50);
            this.btnSearchMemberships.TabIndex = 1;
            this.btnSearchMemberships.Text = "Search Membership Types";
            this.btnSearchMemberships.UseVisualStyleBackColor = false;
            this.btnSearchMemberships.Click += new System.EventHandler(this.btnSearchMemberships_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MembershipMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchMemberships);
            this.Controls.Add(this.btnAddNewMembership);
            this.Name = "MembershipMenu";
            this.Text = "MembershipMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMembership;
        private System.Windows.Forms.Button btnSearchMemberships;
        private System.Windows.Forms.Button btnBack;
    }
}