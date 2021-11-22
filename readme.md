<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/223808621/21.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T835533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

## Dashboard for MVC - How to Register Data Sources

The following example displays how to supply a Web Dashboard with a set of predefined data sources available for users.

![](web-dashboard-data-sources.png)

The [DashboardConfigurator.SetDataSourceStorage](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDataSourceStorage.overloads) method is used to register the added data sources in a data source storage.

The [DashboardConfigurator.ConfigureDataConnection](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.ConfigureDataConnection) event is handled to customize connection parameters before the Web Dashboard connects to a data store (database, OLAP cube, etc.).

<!-- default file list -->
## Files to Look At

* [EFDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/EFDataSourceConfigurator.cs) (VB: [EFDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/EFDataSourceConfigurator.vb))
* [ExcelDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/ExcelDataSourceConfigurator.cs) (VB: [ExcelDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/ExcelDataSourceConfigurator.vb))
* [ExtractDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/ExtractDataSourceConfigurator.cs) (VB: [ExtractDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/ExtractDataSourceConfigurator.vb))
* [JsonDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/JsonDataSourceConfigurator.cs) (VB: [JsonDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/JsonDataSourceConfigurator.vb))
* [ObjectDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/ObjectDataSourceConfigurator.cs) (VB: [ObjectDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/ObjectDataSourceConfigurator.vb))
* [OlapDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/OlapDataSourceConfigurator.cs) (VB: [OlapDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/OlapDataSourceConfigurator.vb))
* [SqlDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/SqlDataSourceConfigurator.cs) (VB: [SqlDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/SqlDataSourceConfigurator.vb))
* [XpoDataSourceConfigurator.cs](./CS/MvcDashboardDataSources/Configuration/XpoDataSourceConfigurator.cs) (VB: [XpoDataSourceConfigurator.vb](./VB/MvcDashboardDataSources/Configuration/XpoDataSourceConfigurator.vb))
* [DashboardConfig.cs](./CS/MvcDashboardDataSources/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboardDataSources/App_Start/DashboardConfig.vb))
<!-- default file list end -->

## Documentation

- [Entity Framework data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardEFDataSource/)
- [Excel data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExcelDataSource/)
- [Extract data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExtractDataSource/)
- [JSON data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardJsonDataSource/)
- [Object data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardObjectDataSource/)
- [OLAP data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardOLAPDataSource/)
- [SQL data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardSqlDataSource/)
- [XPO data source](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardXpoDataSource/)

## More Examples

- [How to Register Data Sources for ASP.NET Web Forms Dashboard Control](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-register-data-sources)
- [How to Register Data Sources for ASP.NET Core Dashboard Control](https://github.com/DevExpress-Examples/asp-net-core-dashboard-register-data-sources)
