namespace Studio2
{
    partial class AddNewClassMenu
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
            this.btnAddNewStudio2Class = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNewTherapyClass = new System.Windows.Forms.Button();
            this.btnAddNewExternalClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewStudio2Class
            // 
            this.btnAddNewStudio2Class.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewStudio2Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStudio2Class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewStudio2Class.Location = new System.Drawing.Point(300, 200);
            this.btnAddNewStudio2Class.Name = "btnAddNewStudio2Class";
            this.btnAddNewStudio2Class.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewStudio2Class.TabIndex = 0;
            this.btnAddNewStudio2Class.Text = "Add New Studio2 Class";
            this.btnAddNewStudio2Class.UseVisualStyleBackColor = false;
            this.btnAddNewStudio2Class.Click += new System.EventHandler(this.btnAddNewStudio2Class_Click);
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
            // btnAddNewTherapyClass
            // 
            this.btnAddNewTherapyClass.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewTherapyClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTherapyClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewTherapyClass.Location = new System.Drawing.Point(300, 290);
            this.btnAddNewTherapyClass.Name = "btnAddNewTherapyClass";
            this.btnAddNewTherapyClass.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewTherapyClass.TabIndex = 1;
            this.btnAddNewTherapyClass.Text = "Add New Therapy Class";
            this.btnAddNewTherapyClass.UseVisualStyleBackColor = false;
            // 
            // btnAddNewExternalClass
            // 
            this.btnAddNewExternalClass.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewExternalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewExternalClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewExternalClass.Location = new System.Drawing.Point(300, 380);
            this.btnAddNewExternalClass.Name = "btnAddNewExternalClass";
            this.btnAddNewExternalClass.Size = new System.Drawing.Size(300, 50);
            this.btnAddNewExternalClass.TabIndex = 2;
            this.btnAddNewExternalClass.Text = "Add New External Class";
            this.btnAddNewExternalClass.UseVisualStyleBackColor = false;
            // 
            // AddNewClassMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnAddNewExternalClass);
            this.Controls.Add(this.btnAddNewTherapyClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNewStudio2Class);
            this.Name = "AddNewClassMenu";
            this.Text = "AddNewClassMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewStudio2Class;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNewTherapyClass;
        private System.Windows.Forms.Button btnAddNewExternalClass;
    }
}