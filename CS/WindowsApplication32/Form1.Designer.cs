namespace WindowsApplication32
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet = new WindowsApplication32.nwindDataSet();
            this.customerReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerReportsTableAdapter = new WindowsApplication32.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pivotGridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(780, 535);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.customerReportsBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(528, 535);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerReportsBindingSource
            // 
            this.customerReportsBindingSource.DataMember = "CustomerReports";
            this.customerReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // customerReportsTableAdapter
            // 
            this.customerReportsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource customerReportsBindingSource;
        private WindowsApplication32.nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter;
    }
}

