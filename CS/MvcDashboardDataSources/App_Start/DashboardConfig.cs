using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.EntityFramework;
using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.Sql;
using System;
using System.Web.Hosting;
using System.Web.Routing;

namespace MvcDashboardDataSources {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("dashboardControl");

            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage);

            // Uncomment this string to allow end users to create new data sources based on predefined connection strings.
            DashboardConfigurator.Default.SetConnectionStringsProvider(new DevExpress.DataAccess.Web.ConfigFileConnectionStringsProvider());
            
            DashboardConfigurator.Default.SetDataSourceStorage(CreateDataSourceStorage());
            DashboardConfigurator.Default.DataLoading += DataLoading;
            DashboardConfigurator.Default.ConfigureDataConnection += Default_ConfigureDataConnection;
        }

        private static void Default_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            switch(e.ConnectionName) {
                case "olapConnection":
                    OlapConnectionParameters olapParams = new OlapConnectionParameters();
                    olapParams.ConnectionString = "Provider=MSOLAP;Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;"
                        + "Initial catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;";
                    e.ConnectionParameters = olapParams;
                break;
                case "jsonConnection":
                    Uri fileUri = new Uri(HostingEnvironment.MapPath(@"~/App_Data/customers.json"), UriKind.RelativeOrAbsolute);
                    JsonSourceConnectionParameters jsonParams = new JsonSourceConnectionParameters();
                    jsonParams.JsonSource = new UriJsonSource(fileUri);
                    e.ConnectionParameters = jsonParams;
                break;
            }
            if(e.DataSourceName.Contains("Extract Data Source")) {
                ExtractDataSourceConnectionParameters extractParams = new ExtractDataSourceConnectionParameters();
                extractParams.FileName = HostingEnvironment.MapPath(@"~/App_Data/SalesPersonExtract.dat");
                e.ConnectionParameters = extractParams;
            }
            if(e.DataSourceName.Contains("Excel Data Source")) {
                ExcelDataSourceConnectionParameters excelParams = new ExcelDataSourceConnectionParameters(HostingEnvironment.MapPath(@"~/App_Data/Sales.xlsx"));
                e.ConnectionParameters = excelParams;
            }
        }

        private static void DataLoading(object sender, DataLoadingWebEventArgs e) {
            if(e.DataSourceName.Contains("Object Data Source")) {
                e.Data = Invoices.CreateData();
            }
        }
        public static DataSourceInMemoryStorage CreateDataSourceStorage()
        {
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();

            // Registers an SQL data source.
            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("SQL Data Source", "NWindConnectionString");
            SelectQuery query = SelectQueryFluentBuilder
                .AddTable("SalesPerson")
                .SelectAllColumns()
                .Build("Sales Person");
            sqlDataSource.Queries.Add(query);
            dataSourceStorage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml());

            // Registers an Object data source.
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source");
            dataSourceStorage.RegisterDataSource("objDataSource", objDataSource.SaveToXml());

            // Registers an Excel data source.
            DashboardExcelDataSource excelDataSource = new DashboardExcelDataSource("Excel Data Source");
            excelDataSource.SourceOptions = new ExcelSourceOptions(new ExcelWorksheetSettings("Sheet1"));
            dataSourceStorage.RegisterDataSource("excelDataSource", excelDataSource.SaveToXml());

            // Registers an OLAP data source.
            DashboardOlapDataSource olapDataSource = new DashboardOlapDataSource("OLAP Data Source", "olapConnection");
            dataSourceStorage.RegisterDataSource("olapDataSource", olapDataSource.SaveToXml());

            // Registers an Entity Framework data source.
            DashboardEFDataSource efDataSource = new DashboardEFDataSource("EF Core Data Source");
            efDataSource.ConnectionParameters = new EFConnectionParameters(typeof(OrderContext));
            dataSourceStorage.RegisterDataSource("efDataSource", efDataSource.SaveToXml());

            // Registers an Extract data source.
            DashboardExtractDataSource extractDataSource = new DashboardExtractDataSource("Extract Data Source");
            extractDataSource.Name = "Extract Data Source";
            dataSourceStorage.RegisterDataSource("extractDataSource ", extractDataSource.SaveToXml());

            // Registers a JSON data source from URL.
            DashboardJsonDataSource jsonDataSourceUrl = new DashboardJsonDataSource("JSON Data Source (URL)");
            jsonDataSourceUrl.JsonSource = new UriJsonSource(new Uri("https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json"));
            jsonDataSourceUrl.RootElement = "Customers";
            jsonDataSourceUrl.Fill();
            dataSourceStorage.RegisterDataSource("jsonDataSourceUrl", jsonDataSourceUrl.SaveToXml());

            // Registers a JSON data source from a JSON file.
            DashboardJsonDataSource jsonDataSourceFile = new DashboardJsonDataSource("JSON Data Source (File)");

            jsonDataSourceFile.ConnectionName = "jsonConnection";
            jsonDataSourceFile.RootElement = "Customers";
            jsonDataSourceFile.Fill();
            dataSourceStorage.RegisterDataSource("jsonDataSourceFile", jsonDataSourceFile.SaveToXml());

            // Registers a JSON data source from JSON string.
            DashboardJsonDataSource jsonDataSourceString = new DashboardJsonDataSource("JSON Data Source (String)");
            string json = "{\"Customers\":[{\"Id\":\"ALFKI\",\"CompanyName\":\"Alfreds Futterkiste\",\"ContactName\":\"Maria Anders\",\"ContactTitle\":\"Sales Representative\",\"Address\":\"Obere Str. 57\",\"City\":\"Berlin\",\"PostalCode\":\"12209\",\"Country\":\"Germany\",\"Phone\":\"030-0074321\",\"Fax\":\"030-0076545\"}],\"ResponseStatus\":{}}";
            jsonDataSourceString.JsonSource = new CustomJsonSource(json);
            jsonDataSourceString.RootElement = "Customers";
            jsonDataSourceString.Fill();
            dataSourceStorage.RegisterDataSource("jsonDataSourceString", jsonDataSourceString.SaveToXml());

            // Registers an XPO data source.
            DashboardXpoDataSource xpoDataSource = new DashboardXpoDataSource("XPO Data Source");
            xpoDataSource.ConnectionStringName = "NWindConnectionStringSQLite";
            xpoDataSource.SetEntityType(typeof(Category));            
            dataSourceStorage.RegisterDataSource("xpoDataSource", xpoDataSource.SaveToXml());
            return dataSourceStorage;
        }
    }
}
