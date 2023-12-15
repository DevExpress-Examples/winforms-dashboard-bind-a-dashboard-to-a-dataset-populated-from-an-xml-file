Imports System
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardCommon

Namespace Dashboard_DataLoading

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Specifies a new dashboard as a currently opened dashboard.
            dashboardViewer1.Dashboard = New Dashboard()
            ' Creates a data source for the dashboard.
            dashboardViewer1.Dashboard.AddDataSource("Data Source 1", GetData())
            ' Creates a new grid dashboard item with two columns that display car models and prices.
            Dim grid1 As GridDashboardItem = New GridDashboardItem()
            grid1.DataSource = dashboardViewer1.Dashboard.DataSources(0)
            grid1.Columns.Add(New GridDimensionColumn(New Dimension("Model")))
            grid1.Columns.Add(New GridMeasureColumn(New Measure("Price")))
            dashboardViewer1.Dashboard.Items.Add(grid1)
        End Sub

        ' Handles the DashboardViewer.DataLoading event to provide the dashboard with new data.
        Private Sub dashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DevExpress.DataAccess.DataLoadingEventArgs)
            If Equals(e.DataSourceName, "Data Source 1") Then
                e.Data = UpdateData()
            End If
        End Sub

        Public Function GetData() As DataTable
            Dim xmlDataSet As DataSet = New DataSet()
            xmlDataSet.ReadXml("..\..\Data\Cars_1.xml")
            Return xmlDataSet.Tables("Cars")
        End Function

        Public Function UpdateData() As DataTable
            Dim xmlDataSet As DataSet = New DataSet()
            xmlDataSet.ReadXml("..\..\Data\Cars_2.xml")
            Return xmlDataSet.Tables("Cars")
        End Function

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Reloads data in data sources.
            dashboardViewer1.ReloadData()
        End Sub
    End Class
End Namespace
