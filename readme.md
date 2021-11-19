<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/223808621/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T835533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

## Dashboard for MVC - How to Register Data Sources

The following example displays how to provide a Web Dashboard with a set of predefined data sources available for end users.

![](web-dashboard-data-sources.png)

Supported data sources:

- [SQL data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardSqlDataSource/)
- [OLAP data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardOLAPDataSource/)
- [Excel data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExcelDataSource/)
- [Object data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardObjectDataSource/)
- [Entity Framework data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardEFDataSource/)
- [Extract data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExtractDataSource/)
- [JSON data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource/)
- [XPO data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardXpoDataSource/)

The [DashboardConfigurator.SetDataSourceStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDataSourceStorage.overloads) method is used to register the added data sources in a data source storage. 

<!-- default file list -->
## Files to Look At

* [DashboardConfig.cs](./CS/MvcDashboardDataSources/App_Start/DashboardConfig.cs)(VB: [DashboardConfig.vb](./VB/MvcDashboardDataSources/App_Start/DashboardConfig.vb))
<!-- default file list end -->
## See Also

- [How to Register Data Sources for ASP.NET Web Forms Dashboard Control](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-register-data-sources)
- [How to Register Data Sources for ASP.NET Core Dashboard Control](https://github.com/DevExpress-Examples/asp-net-core-dashboard-register-data-sources)
