namespace Studio2
{
    partial class MemberCardReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MemberTableAdapter = new Studio2.DataSetMemberTableAdapters.MemberTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MemberBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Studio2.MemberCardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 182);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(655, 291);
            this.reportViewer1.TabIndex = 0;
            // 
            // MemberTableAdapter
            // 
            this.MemberTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(730, 335);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(697, 309);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(175, 20);
            this.txtMemberID.TabIndex = 52;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage.Location = new System.Drawing.Point(681, 227);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(204, 20);
            this.lblMessage.TabIndex = 53;
            this.lblMessage.Text = "Please enter the MemberID";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage2.Location = new System.Drawing.Point(681, 258);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(193, 20);
            this.lblMessage2.TabIndex = 54;
            this.lblMessage2.Text = "to make the Member Card";
            // 
            // MemberCardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MemberCardReport";
            this.Text = "MemberCardReport";
            this.Load += new System.EventHandler(this.MemberCardReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MemberBindingSource;
        private DataSetMember DataSetMember;
        private DataSetMemberTableAdapters.MemberTableAdapter MemberTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessage2;
    }
}