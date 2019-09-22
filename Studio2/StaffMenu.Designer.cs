namespace Studio2
{
    partial class StaffMenu
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
            this.btnAddNewStaff = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewStaff
            // 
            this.btnAddNewStaff.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewStaff.Location = new System.Drawing.Point(300, 230);
            this.btnAddNewStaff.Name = "btnAddNewStaff";
            this.btnAddNewStaff.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewStaff.TabIndex = 0;
            this.btnAddNewStaff.Text = "Add New Staff Member";
            this.btnAddNewStaff.UseVisualStyleBackColor = false;
            this.btnAddNewStaff.Click += new System.EventHandler(this.btnAddNewStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.BackColor = System.Drawing.Color.Teal;
            this.btnSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchStaff.Location = new System.Drawing.Point(300, 340);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(300, 50);
            this.btnSearchStaff.TabIndex = 1;
            this.btnSearchStaff.Text = "Search Staff";
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
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
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.btnAddNewStaff);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Button btnBack;
    }
}