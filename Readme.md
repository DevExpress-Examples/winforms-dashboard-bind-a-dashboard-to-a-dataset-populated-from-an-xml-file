<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580794/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4857)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_DataLoading/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_DataLoading/Form1.vb))
<!-- default file list end -->
# How to bind a dashboard to a DataSet populated from an XML file


<p>The following example demonstrates how to bind a dashboard to a DataSet populated from an XML file.</p>
<p>In this example, an XML file provides data about car models and corresponding prices. The data source is created for the 'Cars' data table and added to the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_DataSourcestopic"><u>Dashboard.DataSources</u></a> collection on the first load.</p>
<p>To update the displayed data, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ReloadDatatopic"><u>DashboardViewer.ReloadData</u></a> method is called. This raises the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DataLoadingtopic"><u>DashboardViewer.DataLoading</u></a> event and allows supplying the dashboard with updated data.</p>

<br/>


