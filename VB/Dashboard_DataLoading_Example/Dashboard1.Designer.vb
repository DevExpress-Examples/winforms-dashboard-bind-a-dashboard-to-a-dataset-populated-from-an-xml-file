Namespace Dashboard_DataLoading_Example

    Partial Class Dashboard1

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension2 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim dimension3 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim dimension4 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard_DataLoading_Example.Dashboard1))
            Dim dimension5 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim simpleSeries1 As DevExpress.DashboardCommon.SimpleSeries = New DevExpress.DashboardCommon.SimpleSeries()
            Dim dashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.pieMapDashboardItem1 = New DevExpress.DashboardCommon.PieMapDashboardItem()
            Me.dashboardObjectDataSource2 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.rangeFilterDashboardItem1 = New DevExpress.DashboardCommon.RangeFilterDashboardItem()
            CType((Me.pieMapDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dashboardObjectDataSource2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeFilterDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' pieMapDashboardItem1
            ' 
            Me.pieMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.Europe
            dimension1.DataMember = "Sector"
            Me.pieMapDashboardItem1.Argument = dimension1
            Me.pieMapDashboardItem1.ComponentName = "pieMapDashboardItem1"
            dimension2.DataMember = "Latitude"
            dimension3.DataMember = "Longitude"
            measure1.DataMember = "Consumption"
            dimension4.DataMember = "Country"
            Me.pieMapDashboardItem1.DataItemRepository.Clear()
            Me.pieMapDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
            Me.pieMapDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
            Me.pieMapDashboardItem1.DataItemRepository.Add(measure1, "DataItem2")
            Me.pieMapDashboardItem1.DataItemRepository.Add(dimension1, "DataItem3")
            Me.pieMapDashboardItem1.DataItemRepository.Add(dimension4, "DataItem4")
            Me.pieMapDashboardItem1.DataSource = Me.dashboardObjectDataSource2
            Me.pieMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pieMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.[Single]
            Me.pieMapDashboardItem1.Latitude = dimension2
            Me.pieMapDashboardItem1.Legend.Visible = True
            Me.pieMapDashboardItem1.Longitude = dimension3
            Me.pieMapDashboardItem1.Name = "Energy Consumption by Sector"
            Me.pieMapDashboardItem1.ShowCaption = True
            Me.pieMapDashboardItem1.TooltipDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() {dimension4})
            Me.pieMapDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() {measure1})
            Me.pieMapDashboardItem1.Viewport.BottomLatitude = 38.465698798939975R
            Me.pieMapDashboardItem1.Viewport.CenterPointLatitude = 52.320720692307148R
            Me.pieMapDashboardItem1.Viewport.CenterPointLongitude = 28.021969019753598R
            Me.pieMapDashboardItem1.Viewport.CreateViewerPaddings = False
            Me.pieMapDashboardItem1.Viewport.LeftLongitude = -25.861615460567506R
            Me.pieMapDashboardItem1.Viewport.RightLongitude = 81.9055535000747R
            Me.pieMapDashboardItem1.Viewport.TopLatitude = 62.881388025112621R
            ' 
            ' dashboardObjectDataSource2
            ' 
            Me.dashboardObjectDataSource2.ComponentName = "dashboardObjectDataSource2"
            Me.dashboardObjectDataSource2.DataMember = "CountriesBySector"
            Me.dashboardObjectDataSource2.DataSchema = resources.GetString("dashboardObjectDataSource2.DataSchema")
            Me.dashboardObjectDataSource2.Name = "EnergyConsumptionBySector"
            ' 
            ' rangeFilterDashboardItem1
            ' 
            dimension5.DataMember = "Year"
            Me.rangeFilterDashboardItem1.Argument = dimension5
            Me.rangeFilterDashboardItem1.ComponentName = "rangeFilterDashboardItem1"
            measure2.DataMember = "Consumption"
            Me.rangeFilterDashboardItem1.DataItemRepository.Clear()
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(dimension5, "DataItem0")
            Me.rangeFilterDashboardItem1.DataItemRepository.Add(measure2, "DataItem1")
            Me.rangeFilterDashboardItem1.DataSource = Me.dashboardObjectDataSource2
            Me.rangeFilterDashboardItem1.InteractivityOptions.IgnoreMasterFilters = True
            Me.rangeFilterDashboardItem1.Name = "Range Filter 1"
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
            simpleSeries1.AddDataItem("Value", measure2)
            Me.rangeFilterDashboardItem1.Series.AddRange(New DevExpress.DashboardCommon.SimpleSeries() {simpleSeries1})
            Me.rangeFilterDashboardItem1.ShowCaption = False
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardObjectDataSource2})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.rangeFilterDashboardItem1, Me.pieMapDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pieMapDashboardItem1
            dashboardLayoutItem1.Weight = 83.877995642701521R
            dashboardLayoutItem2.DashboardItem = Me.rangeFilterDashboardItem1
            dashboardLayoutItem2.Weight = 16.122004357298476R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            dashboardLayoutGroup1.Weight = 100R
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType((dimension1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pieMapDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dashboardObjectDataSource2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeFilterDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private dashboardObjectDataSource2 As DevExpress.DashboardCommon.DashboardObjectDataSource

        Private rangeFilterDashboardItem1 As DevExpress.DashboardCommon.RangeFilterDashboardItem

        Private pieMapDashboardItem1 As DevExpress.DashboardCommon.PieMapDashboardItem
    End Class
End Namespace
