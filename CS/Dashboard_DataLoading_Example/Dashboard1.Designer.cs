namespace Dashboard_DataLoading_Example
{
    partial class Dashboard1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pieMapDashboardItem1 = new DevExpress.DashboardCommon.PieMapDashboardItem();
            this.dashboardObjectDataSource2 = new DevExpress.DashboardCommon.DashboardObjectDataSource();
            this.rangeFilterDashboardItem1 = new DevExpress.DashboardCommon.RangeFilterDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pieMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pieMapDashboardItem1
            // 
            this.pieMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.Europe;
            dimension1.DataMember = "Sector";
            this.pieMapDashboardItem1.Argument = dimension1;
            this.pieMapDashboardItem1.ComponentName = "pieMapDashboardItem1";
            dimension2.DataMember = "Latitude";
            dimension3.DataMember = "Longitude";
            measure1.DataMember = "Consumption";
            dimension4.DataMember = "Country";
            this.pieMapDashboardItem1.DataItemRepository.Clear();
            this.pieMapDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.pieMapDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.pieMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem2");
            this.pieMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem3");
            this.pieMapDashboardItem1.DataItemRepository.Add(dimension4, "DataItem4");
            this.pieMapDashboardItem1.DataSource = this.dashboardObjectDataSource2;
            this.pieMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pieMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Single;
            this.pieMapDashboardItem1.Latitude = dimension2;
            this.pieMapDashboardItem1.Legend.Visible = true;
            this.pieMapDashboardItem1.Longitude = dimension3;
            this.pieMapDashboardItem1.Name = "Energy Consumption by Sector";
            this.pieMapDashboardItem1.ShowCaption = true;
            this.pieMapDashboardItem1.TooltipDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension4});
            this.pieMapDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            this.pieMapDashboardItem1.Viewport.BottomLatitude = 38.465698798939975D;
            this.pieMapDashboardItem1.Viewport.CenterPointLatitude = 52.320720692307148D;
            this.pieMapDashboardItem1.Viewport.CenterPointLongitude = 28.021969019753598D;
            this.pieMapDashboardItem1.Viewport.CreateViewerPaddings = false;
            this.pieMapDashboardItem1.Viewport.LeftLongitude = -25.861615460567506D;
            this.pieMapDashboardItem1.Viewport.RightLongitude = 81.9055535000747D;
            this.pieMapDashboardItem1.Viewport.TopLatitude = 62.881388025112621D;
            // 
            // dashboardObjectDataSource2
            // 
            this.dashboardObjectDataSource2.ComponentName = "dashboardObjectDataSource2";
            this.dashboardObjectDataSource2.DataMember = "CountriesBySector";
            this.dashboardObjectDataSource2.DataSchema = resources.GetString("dashboardObjectDataSource2.DataSchema");
            this.dashboardObjectDataSource2.Name = "EnergyConsumptionBySector";
            // 
            // rangeFilterDashboardItem1
            // 
            dimension5.DataMember = "Year";
            this.rangeFilterDashboardItem1.Argument = dimension5;
            this.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1";
            measure2.DataMember = "Consumption";
            this.rangeFilterDashboardItem1.DataItemRepository.Clear();
            this.rangeFilterDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0");
            this.rangeFilterDashboardItem1.DataItemRepository.Add(measure2, "DataItem1");
            this.rangeFilterDashboardItem1.DataSource = this.dashboardObjectDataSource2;
            this.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = true;
            this.rangeFilterDashboardItem1.Name = "Range Filter 1";
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure2);
            this.rangeFilterDashboardItem1.Series.AddRange(new DevExpress.DashboardCommon.SimpleSeries[] {
            simpleSeries1});
            this.rangeFilterDashboardItem1.ShowCaption = false;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardObjectDataSource2});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.rangeFilterDashboardItem1,
            this.pieMapDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pieMapDashboardItem1;
            dashboardLayoutItem1.Weight = 83.877995642701521D;
            dashboardLayoutItem2.DashboardItem = this.rangeFilterDashboardItem1;
            dashboardLayoutItem2.Weight = 16.122004357298476D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardObjectDataSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeFilterDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardObjectDataSource dashboardObjectDataSource2;
        private DevExpress.DashboardCommon.RangeFilterDashboardItem rangeFilterDashboardItem1;
        private DevExpress.DashboardCommon.PieMapDashboardItem pieMapDashboardItem1;
    }
}
