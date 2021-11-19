using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;

namespace MvcDashboardDataSources.Configuration {
    public class XpoDataSourceConfigurator {
        public static void ConfigureDataSource(DataSourceInMemoryStorage storage) {
            // Registers an XPO data source.
            DashboardXpoDataSource xpoDataSource = new DashboardXpoDataSource("XPO Data Source");
            xpoDataSource.ConnectionStringName = "NWindConnectionStringSQLite";
            xpoDataSource.SetEntityType(typeof(Category));
            storage.RegisterDataSource("xpoDataSource", xpoDataSource.SaveToXml());
        }
    }
}