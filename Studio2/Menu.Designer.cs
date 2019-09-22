namespace Studio2
{
    partial class Menu
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
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(37, 48);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(75, 23);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnMembership
            // 
            this.btnMembership.Location = new System.Drawing.Point(37, 92);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(75, 23);
            this.btnMembership.TabIndex = 1;
            this.btnMembership.Text = "Membership";
            this.btnMembership.UseVisualStyleBackColor = true;
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(37, 139);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(75, 23);
            this.btnMembers.TabIndex = 2;
            this.btnMembers.Text = "Members";
            this.btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnClasses
            // 
            this.btnClasses.Location = new System.Drawing.Point(37, 187);
            this.btnClasses.Name = "btnClasses";
            this.btnClasses.Size = new System.Drawing.Size(75, 23);
            this.btnClasses.TabIndex = 3;
            this.btnClasses.Text = "Classes";
            this.btnClasses.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClasses);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnMembership);
            this.Controls.Add(this.btnStaff);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnClasses;
    }
}