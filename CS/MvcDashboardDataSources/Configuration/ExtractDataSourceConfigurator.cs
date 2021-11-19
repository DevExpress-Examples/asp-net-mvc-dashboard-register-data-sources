using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System.Web.Hosting;

namespace MvcDashboardDataSources.Configuration {
    public class ExtractDataSourceConfigurator {
        public static void ConfigureDataSource(DashboardConfigurator configurator, DataSourceInMemoryStorage storage) {
            // Registers an Extract data source.
            DashboardExtractDataSource extractDataSource = new DashboardExtractDataSource("Extract Data Source");
            extractDataSource.Name = "Extract Data Source";
            extractDataSource.ConnectionName = "dataExtract";
            storage.RegisterDataSource("extractDataSource ", extractDataSource.SaveToXml());

            configurator.ConfigureDataConnection += Configurator_ConfigureDataConnection;
        }

        private static void Configurator_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName =="dataExtract") {
                ExtractDataSourceConnectionParameters extractParams = new ExtractDataSourceConnectionParameters();
                extractParams.FileName = HostingEnvironment.MapPath(@"~/App_Data/SalesPersonExtract.dat");
                e.ConnectionParameters = extractParams;
            }
        }
    }
}