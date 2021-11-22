Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports MvcDashboardDataSources.Configuration

Namespace MvcDashboardDataSources
    Public Module DashboardConfig
        Public Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")
            ' Configure Dashboard Storage:
            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

            ' Configure Data Source Storage:
            Dim dataSourceStorage As New DataSourceInMemoryStorage()

            SqlDataSourceConfigurator.ConfigureDataSource(dataSourceStorage)
            ExcelDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage)
            ObjectDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage)
            EFDataSourceConfigurator.ConfigureDataSource(dataSourceStorage)
            JsonDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage)
            ExtractDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage)
            OlapDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage)
            XpoDataSourceConfigurator.ConfigureDataSource(dataSourceStorage)

            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage)

            ' Uncomment this string to allow users to create new data sources based on predefined connection strings.
            ' DashboardConfigurator.Default.SetConnectionStringsProvider(New DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider())
        End Sub
    End Module
End Namespace
