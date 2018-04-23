# How to bind a dashboard to a DataSet populated from an XML file


<p>The following example demonstrates how to bind a dashboard to a DataSet populated from an XML file.</p>
<p>In this example, an XML file provides data about car models and corresponding prices. The data source is created for the 'Cars' data table and added to the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_DataSourcestopic"><u>Dashboard.DataSources</u></a> collection on the first load.</p>
<p>To update the displayed data, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_ReloadDatatopic"><u>DashboardViewer.ReloadData</u></a> method is called. This raises the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardDesigner_DataLoadingtopic"><u>DashboardViewer.DataLoading</u></a> event and allows supplying the dashboard with updated data.</p>

<br/>


