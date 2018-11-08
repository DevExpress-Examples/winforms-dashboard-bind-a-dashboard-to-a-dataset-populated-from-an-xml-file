using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.XtraEditors;
using System;
using System.Data;

namespace Dashboard_DataLoading_Example
{
    public partial class Form1 : XtraForm
    {

        string dataFileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
            dashboardViewer1.CustomizeDashboardTitle += DashboardViewer1_CustomizeDashboardTitle;
            dashboardViewer1.Dashboard = new Dashboard1();
            dashboardViewer1.DataLoading += DashboardViewer1_DataLoading;
        }

        private void DashboardViewer1_DataLoading(object sender, DataLoadingEventArgs e)
        {
            if (e.DataSourceName == "EnergyConsumptionBySector")
            {
                e.Data = GetData();
            }
        }

        public DataTable GetData()
        {
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(@"..\..\Data\DashboardEnergyConsumptionBySector.xml");
            return xmlDataSet.Tables["CountriesBySector"];
        }

        private void DashboardViewer1_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            DashboardToolbarItem titleButton = new DashboardToolbarItem("Load Data",
                new Action<DashboardToolbarItemClickEventArgs>((args) =>
                {
                    LoadNewData();
                }));
            titleButton.Caption = "Load Data";
            e.Items.Add(titleButton);
        }
        private void LoadNewData()
        {
            dataFileName = @"..\..\Data\DashboardEnergyConsumptionBySector.xml";
            dashboardViewer1.ReloadData();
        }
    }
}
