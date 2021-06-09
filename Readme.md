*Files to look at*:

* [Form1.cs](./CS/Dashboard_DataLoading_Example/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_DataLoading_Example/Form1.vb))

# How to Load XML Data from a File at Runtime


This example contains a dashboard bound to an object data source with fake data whose structure is defined by an XML schema. The actual data is loaded at runtime from an XML file.

To load the data, click the **Load Data** custom button in the [dashboard title](https://docs.devexpress.com/Dashboard/15618/creating-dashboards/creating-dashboards-in-the-winforms-designer/dashboard-layout/dashboard-title). The button is created by handling the [CustomizeDashboardTitle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomizeDashboardTitle) event.
Its click action calls the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ReloadData) method that triggers the [DashboardViewer.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataLoading) event. The actual data are obtained within the event handler and assigned to the [e.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataLoadingEventArgs.Data) property.

![screenshot](/images/Screenshot.png)


The dashboard class is created in Visual Studio designer. The dashboard is bound to an object data source built from XML schema contained in an XSD file. The dashboard designer displays auto-generated fake data. 

The data source is created using the Data Source Wizard...

![DataSourceWizard](/images/DataSourceWizard.png)

... and set up as illustrated in the picture below:

![DataSource](/images/DataSource.png)

## Documentation

[Data Sources](https://docs.devexpress.com/Dashboard/116522/)
