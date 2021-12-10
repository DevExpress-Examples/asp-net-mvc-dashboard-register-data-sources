using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using MvcDashboardDataSources.Configuration;
using System.Web.Routing;

namespace MvcDashboardDataSources {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl", "DefaultDashboard");
            // Configure a dashboard storage:
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);

            // Configure a data source storage:
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            
            SqlDataSourceConfigurator.ConfigureDataSource(dataSourceStorage);
            ExcelDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage);
            ObjectDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage);
            EFDataSourceConfigurator.ConfigureDataSource(dataSourceStorage);
            JsonDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage);
            ExtractDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage);
            OlapDataSourceConfigurator.ConfigureDataSource(DashboardConfigurator.Default, dataSourceStorage);
            XpoDataSourceConfigurator.ConfigureDataSource(dataSourceStorage);

            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);

            // Uncomment the next line to allow users to create new data sources based on predefined connection strings.
            // DashboardConfigurator.Default.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());            
        }
    }
}
