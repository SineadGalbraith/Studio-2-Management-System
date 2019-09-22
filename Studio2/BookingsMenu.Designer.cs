namespace Studio2
{
    partial class BookingsMenu
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
            this.btnSearchBooking = new System.Windows.Forms.Button();
            this.btnAddNewBooking = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.BackColor = System.Drawing.Color.Teal;
            this.btnSearchBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchBooking.Location = new System.Drawing.Point(300, 350);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.Size = new System.Drawing.Size(300, 50);
            this.btnSearchBooking.TabIndex = 1;
            this.btnSearchBooking.Text = "Search Bookings";
            this.btnSearchBooking.UseVisualStyleBackColor = false;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // btnAddNewBooking
            // 
            this.btnAddNewBooking.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewBooking.Location = new System.Drawing.Point(300, 230);
            this.btnAddNewBooking.Name = "btnAddNewBooking";
            this.btnAddNewBooking.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewBooking.TabIndex = 0;
            this.btnAddNewBooking.Text = "Add New Booking";
            this.btnAddNewBooking.UseVisualStyleBackColor = false;
            this.btnAddNewBooking.Click += new System.EventHandler(this.btnAddNewBooking_Click);
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
            // BookingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchBooking);
            this.Controls.Add(this.btnAddNewBooking);
            this.Name = "BookingsMenu";
            this.Text = "BookingsMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchBooking;
        private System.Windows.Forms.Button btnAddNewBooking;
        private System.Windows.Forms.Button btnBack;
    }
}