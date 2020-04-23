*Files to look at*:

* [DashboardConfig.cs](./CS/MvcDashboardDataSources/App_Start/DashboardConfig.cs)
* [DashboardConfig.vb](./VB/MvcDashboardDataSources/App_Start/DashboardConfig.vb)

## How to Register Data Sources for ASP.NET MVC Dashboard Extension
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/223808621/)**
<!-- run online end -->

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

## See Also

- [How to Register Data Sources for ASP.NET Web Forms Dashboard Control](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-register-data-sources)
- [How to Register Data Sources for ASP.NET Core Dashboard Control](https://github.com/DevExpress-Examples/asp-net-core-dashboard-register-data-sources)
