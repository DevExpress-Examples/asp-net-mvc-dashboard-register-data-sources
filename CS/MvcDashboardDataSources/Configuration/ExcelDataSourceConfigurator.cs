using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Excel;
using System.Web.Hosting;

namespace MvcDashboardDataSources.Configuration {
    public class ExcelDataSourceConfigurator {
        public static void ConfigureDataSource(DashboardConfigurator configurator, DataSourceInMemoryStorage storage) {
            // Registers an Excel data source.
            DashboardExcelDataSource excelDataSource = new DashboardExcelDataSource("Excel Data Source");
            excelDataSource.ConnectionName = "excelDataConnection";
            excelDataSource.SourceOptions = new ExcelSourceOptions(new ExcelWorksheetSettings("Sheet1"));
            storage.RegisterDataSource("excelDataSource", excelDataSource.SaveToXml());

            configurator.ConfigureDataConnection += Configurator_ConfigureDataConnection;
        }

        private static void Configurator_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "excelDataConnection") {
                var excelParams = new ExcelDataSourceConnectionParameters(HostingEnvironment.MapPath(@"~/App_Data/Sales.xlsx"));
                e.ConnectionParameters = excelParams;
            }
        }
    }
}