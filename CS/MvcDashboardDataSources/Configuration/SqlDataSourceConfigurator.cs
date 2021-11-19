using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Sql;
using System;

namespace MvcDashboardDataSources.Configuration {
    public class SqlDataSourceConfigurator {
        public static void ConfigureDataSource(DataSourceInMemoryStorage storage) {
            // Registers an SQL data source.
            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("SQL Data Source", "NWindConnectionString");
            SelectQuery query = SelectQueryFluentBuilder
                .AddTable("SalesPerson")
                .SelectAllColumnsFromTable()
                .Build("Sales Person");
            sqlDataSource.Queries.Add(query);
            storage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml());
        }
    }
}