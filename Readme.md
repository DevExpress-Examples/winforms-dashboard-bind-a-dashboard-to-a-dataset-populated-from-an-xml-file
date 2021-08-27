<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580794/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4857)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to load XML data from a file to the dashboard at runtime


This example contains a dashboard bound to an object data source with fake data whose structure is defined by an XML schema. The actual data is loaded at runtime from an XML file.

To load the data, click the **Load Data** custom button in the [dashboard title](https://docs.devexpress.com/Dashboard/15618/creating-dashboards/creating-dashboards-in-the-winforms-designer/dashboard-layout/dashboard-title). The button is created by handling the [CustomizeDashboardTitle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomizeDashboardTitle) event.
Its click action calls the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ReloadData) method that triggers the [DashboardViewer.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataLoading) event. The actual data are obtained within the event handler and assigned to the [e.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataLoadingEventArgs.Data) property.

![](https://github.com/DevExpress-Examples/how-to-bind-a-dashboard-to-a-dataset-populated-from-an-xml-file-e4857/blob/18.2.3%2B/images/Screenshot.png)


The dashboard class is created in Visual Studio designer. The dashboard is bound to an object data source built from XML schema contained in an XSD file. The dashboard designer displays auto-generated fake data. 

The data source is created using the Data Source Wizard...

![](https://github.com/DevExpress-Examples/how-to-bind-a-dashboard-to-a-dataset-populated-from-an-xml-file-e4857/blob/18.2.3%2B/images/DataSourceWizard.png)

... and set up as illustrated in the picture below:

![](https://github.com/DevExpress-Examples/how-to-bind-a-dashboard-to-a-dataset-populated-from-an-xml-file-e4857/blob/18.2.3%2B/images/DataSource.png)
