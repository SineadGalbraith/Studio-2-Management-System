namespace Studio2
{
    partial class MembersMenu
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
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMemberCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewMember.Location = new System.Drawing.Point(300, 200);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewMember.TabIndex = 0;
            this.btnAddNewMember.Text = "Add New Member";
            this.btnAddNewMember.UseVisualStyleBackColor = false;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(300, 290);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(300, 50);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search Members";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMemberCard
            // 
            this.btnMemberCard.BackColor = System.Drawing.Color.Teal;
            this.btnMemberCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMemberCard.Location = new System.Drawing.Point(300, 380);
            this.btnMemberCard.Name = "btnMemberCard";
            this.btnMemberCard.Size = new System.Drawing.Size(300, 50);
            this.btnMemberCard.TabIndex = 2;
            this.btnMemberCard.Text = "Create Member Card";
            this.btnMemberCard.UseVisualStyleBackColor = false;
            this.btnMemberCard.Click += new System.EventHandler(this.btnMemberCard_Click);
            // 
            // MembersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnMemberCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddNewMember);
            this.Name = "MembersMenu";
            this.Text = "MembersMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMemberCard;
    }
}