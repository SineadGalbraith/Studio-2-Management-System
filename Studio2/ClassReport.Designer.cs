namespace Studio2
{
    partial class ClassReport
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClass = new Studio2.DataSetClass();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.reportViewerClass = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new Studio2.DataSetClassTableAdapters.DataTable1TableAdapter();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtClassDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClass)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetClass;
            // 
            // DataSetClass
            // 
            this.DataSetClass.DataSetName = "DataSetClass";
            this.DataSetClass.EnforceConstraints = false;
            this.DataSetClass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Teal;
            this.lblMessage.Location = new System.Drawing.Point(185, 200);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(218, 24);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Please enter the ClassID:";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(410, 202);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(175, 20);
            this.txtClassID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(600, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
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
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // reportViewerClass
            // 
            reportDataSource1.Name = "DataSetClass";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewerClass.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerClass.LocalReport.ReportEmbeddedResource = "Studio2.ClassReport.rdlc";
            this.reportViewerClass.Location = new System.Drawing.Point(245, 260);
            this.reportViewerClass.Name = "reportViewerClass";
            this.reportViewerClass.Size = new System.Drawing.Size(398, 246);
            this.reportViewerClass.TabIndex = 3;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.Teal;
            this.lblEnter.Location = new System.Drawing.Point(160, 230);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(244, 24);
            this.lblEnter.TabIndex = 6;
            this.lblEnter.Text = "Please enter the Class Date:";
            // 
            // txtClassDate
            // 
            this.txtClassDate.Location = new System.Drawing.Point(410, 233);
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.Size = new System.Drawing.Size(175, 20);
            this.txtClassDate.TabIndex = 1;
            // 
            // ClassReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studio2.Properties.Resources.Studio2Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtClassDate);
            this.Controls.Add(this.reportViewerClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.btnSearch);
            this.Name = "ClassReport";
            this.Text = "ClassReport";
            this.Load += new System.EventHandler(this.ClassReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerClass;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetClass DataSetClass;
        private DataSetClassTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtClassDate;
    }
}