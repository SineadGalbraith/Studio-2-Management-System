namespace Studio2
{
    partial class MemberCard
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMember = new Studio2.DataSetMember();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.reportViewerMember = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MemberTableAdapter = new Studio2.DataSetMemberTableAdapters.MemberTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMember)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberBindingSource
            // 
            this.MemberBindingSource.DataMember = "Member";
            this.MemberBindingSource.DataSource = this.DataSetMember;
            // 
            // DataSetMember
            // 
            this.DataSetMember.DataSetName = "DataSetMember";
            this.DataSetMember.EnforceConstraints = false;
            this.DataSetMember.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(655, 185);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(465, 194);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(175, 20);
            this.txtMemberID.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage.Location = new System.Drawing.Point(155, 190);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(302, 24);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Please enter the MemberID (MBR):";
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
            // reportViewerMember
            // 
            reportDataSource1.Name = "DataSetMember";
            reportDataSource1.Value = this.MemberBindingSource;
            this.reportViewerMember.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMember.LocalReport.ReportEmbeddedResource = "Studio2.MemberCard.rdlc";
            this.reportViewerMember.Location = new System.Drawing.Point(145, 230);
            this.reportViewerMember.Name = "reportViewerMember";
            this.reportViewerMember.Size = new System.Drawing.Size(631, 253);
            this.reportViewerMember.TabIndex = 2;
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // MemberCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.reportViewerMember);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.btnSearch);
            this.Name = "MemberCard";
            this.Text = "MemberCard";
            this.Load += new System.EventHandler(this.MemberCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMember;
        private System.Windows.Forms.BindingSource MemberBindingSource;
        private DataSetMember DataSetMember;
        private DataSetMemberTableAdapters.MemberTableAdapter MemberTableAdapter;
    }
}