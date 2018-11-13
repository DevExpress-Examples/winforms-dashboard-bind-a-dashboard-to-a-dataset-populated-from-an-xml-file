Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.XtraEditors
Imports System
Imports System.Data

Namespace Dashboard_DataLoading_Example
	Partial Public Class Form1
		Inherits XtraForm

		Private dataFileName As String = String.Empty
		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.CustomizeDashboardTitle, AddressOf DashboardViewer1_CustomizeDashboardTitle
			dashboardViewer1.Dashboard = New Dashboard1()
			AddHandler dashboardViewer1.DataLoading, AddressOf DashboardViewer1_DataLoading
		End Sub

		Private Sub DashboardViewer1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs)
			If e.DataSourceName = "EnergyConsumptionBySector" Then
				e.Data = GetData()
			End If
		End Sub

		Public Function GetData() As DataTable
			Dim xmlDataSet As New DataSet()
			xmlDataSet.ReadXml("..\..\Data\DashboardEnergyConsumptionBySector.xml")
			Return xmlDataSet.Tables("CountriesBySector")
		End Function

		Private Sub DashboardViewer1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
			Dim titleButton As DashboardToolbarItem = New DashboardToolbarItem("Load Data", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
				LoadNewData()
			End Sub))
			titleButton.Caption = "Load Data"
			e.Items.Add(titleButton)
		End Sub
		Private Sub LoadNewData()
			dataFileName = "..\..\Data\DashboardEnergyConsumptionBySector.xml"
			dashboardViewer1.ReloadData()
		End Sub
	End Class
End Namespace
