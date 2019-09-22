namespace Studio2
{
    partial class ClassMenu
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
            this.btnAddNewClass = new System.Windows.Forms.Button();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewClass
            // 
            this.btnAddNewClass.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewClass.Location = new System.Drawing.Point(300, 230);
            this.btnAddNewClass.Name = "btnAddNewClass";
            this.btnAddNewClass.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewClass.TabIndex = 0;
            this.btnAddNewClass.Text = "Add New Class";
            this.btnAddNewClass.UseVisualStyleBackColor = false;
            this.btnAddNewClass.Click += new System.EventHandler(this.btnAddNewClass_Click);
            // 
            // btnSearchClass
            // 
            this.btnSearchClass.BackColor = System.Drawing.Color.Teal;
            this.btnSearchClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchClass.Location = new System.Drawing.Point(300, 340);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(300, 50);
            this.btnSearchClass.TabIndex = 1;
            this.btnSearchClass.Text = "Search Class";
            this.btnSearchClass.UseVisualStyleBackColor = false;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);
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
            // ClassMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchClass);
            this.Controls.Add(this.btnAddNewClass);
            this.Name = "ClassMenu";
            this.Text = "ClassMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnBack;
    }
}