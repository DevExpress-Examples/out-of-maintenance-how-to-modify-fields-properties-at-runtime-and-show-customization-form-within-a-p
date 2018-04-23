Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication32
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
			Me.customerReportsTableAdapter.Fill(Me.nwindDataSet.CustomerReports)

			InitPivotGrid(pivotGridControl1)
			pivotGridControl1.FieldsCustomization(splitContainer1.Panel1)


		End Sub

		Private Sub InitPivotGrid(ByVal pivot As DevExpress.XtraPivotGrid.PivotGridControl)
			pivot.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			pivot.RetrieveFields(PivotArea.FilterArea, False)

			pivot.Fields("ProductAmount").Area = PivotArea.DataArea
			pivot.Fields("ProductAmount").Visible = True
			pivot.Fields("CompanyName").Area = PivotArea.RowArea
			pivot.Fields("CompanyName").Visible = True

			pivot.Fields("OrderDate").GroupInterval = PivotGroupInterval.DateYear
		End Sub
	End Class
End Namespace