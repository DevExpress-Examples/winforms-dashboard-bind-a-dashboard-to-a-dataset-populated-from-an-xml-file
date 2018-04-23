using System;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace Dashboard_DataLoading {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Dashboard dashboard = new Dashboard();
            DashboardObjectDataSource objectDataSource = new DashboardObjectDataSource();
            objectDataSource.DataSource = GetData();
            dashboard.DataSources.Add(objectDataSource);
            dashboardViewer1.Dashboard = dashboard; 

            // Creates a new grid dashboard item with two columns that display car models and prices.
            GridDashboardItem grid1 = new GridDashboardItem();
            grid1.DataSource = dashboard.DataSources[0];
            grid1.Columns.Add(new GridDimensionColumn(new Dimension("Model")));
            grid1.Columns.Add(new GridMeasureColumn(new Measure("Price")));
            dashboard.Items.Add(grid1);                       
        }

        // Handles the DashboardViewer.DataLoading event to provide the dashboard with new data.
        private void dashboardViewer1_DataLoading(object sender, DataLoadingEventArgs e) {
            if (e.DataSourceName == "Object Data Source 1") {
                e.Data = UpdateData();
            }
        }

        public DataTable GetData() {
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(@"..\..\Data\Cars_1.xml");
            return xmlDataSet.Tables["Cars"];
        }

        public DataTable UpdateData() {
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(@"..\..\Data\Cars_2.xml");
            return xmlDataSet.Tables["Cars"];
        }

        private void button1_Click(object sender, EventArgs e) {
            // Reloads data in data sources.
            dashboardViewer1.ReloadData();
        }
    }
}
