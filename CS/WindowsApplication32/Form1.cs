using DevExpress.XtraPivotGrid;
using System;
using System.Windows.Forms;

namespace WindowsApplication32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.CustomerReports' table. You can move, or remove it, as needed.
            this.customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);

            InitPivotGrid(pivotGridControl1);            
            pivotGridControl1.FieldsCustomization(splitContainer1.Panel1);
        }

        private void InitPivotGrid(PivotGridControl pivot)
        {
            pivot.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            pivot.RetrieveFields( PivotArea.FilterArea, false);

            pivot.Fields["ProductAmount"].Area = PivotArea.DataArea;
            pivot.Fields["ProductAmount"].Visible = true;
            pivot.Fields["CompanyName"].Area = PivotArea.RowArea;
            pivot.Fields["CompanyName"].Visible = true;

            (pivot.Fields["OrderDate"].DataBinding as DataSourceColumnBinding).GroupInterval = PivotGroupInterval.DateYear;
        }
    }
}