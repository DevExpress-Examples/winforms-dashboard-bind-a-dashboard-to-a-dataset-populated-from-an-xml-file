<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580794/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4857)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# BI Dashboard for WinForms - How to Load XML Data from a File at Runtime

This example contains a dashboard bound to an object data source with fake data whose structure is defined by an XML schema. The actual data is loaded at runtime from an XML file.

To load the data, click the **Load Data** custom button in the [dashboard title](https://docs.devexpress.com/Dashboard/15618/creating-dashboards/creating-dashboards-in-the-winforms-designer/dashboard-layout/dashboard-title). The button is created by handling the [CustomizeDashboardTitle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.CustomizeDashboardTitle) event.
Its click action calls the [DashboardViewer.ReloadData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.ReloadData) method that triggers the [DashboardViewer.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DataLoading) event. The actual data are obtained within the event handler and assigned to the [e.Data](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DataLoadingEventArgs.Data) property.

![screenshot](/images/Screenshot.png)

The dashboard class is created in Visual Studio designer. The dashboard is bound to an object data source built from XML schema contained in an XSD file. The dashboard designer displays auto-generated fake data. 

## Files to Review

* [Form1.cs](./CS/Dashboard_DataLoading_Example/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_DataLoading_Example/Form1.vb))

## Documentation

- [Data Sources](https://docs.devexpress.com/Dashboard/116522/)
- [Providing Data](https://docs.devexpress.com/Dashboard/16914)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-bind-a-dashboard-to-a-dataset-populated-from-an-xml-file&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-bind-a-dashboard-to-a-dataset-populated-from-an-xml-file&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
