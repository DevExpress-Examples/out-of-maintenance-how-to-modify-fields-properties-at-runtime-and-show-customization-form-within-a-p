Namespace WindowsApplication32
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet = New WindowsApplication32.nwindDataSet()
			Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.customerReportsTableAdapter = New WindowsApplication32.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.pivotGridControl1)
			Me.splitContainer1.Size = New System.Drawing.Size(780, 535)
			Me.splitContainer1.SplitterDistance = 248
			Me.splitContainer1.TabIndex = 0
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.customerReportsBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(528, 535)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customerReportsBindingSource
			' 
			Me.customerReportsBindingSource.DataMember = "CustomerReports"
			Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
			' 
			' customerReportsTableAdapter
			' 
			Me.customerReportsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(780, 535)
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private customerReportsBindingSource As System.Windows.Forms.BindingSource
		Private customerReportsTableAdapter As WindowsApplication32.nwindDataSetTableAdapters.CustomerReportsTableAdapter
	End Class
End Namespace

