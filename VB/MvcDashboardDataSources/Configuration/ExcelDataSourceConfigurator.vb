Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Excel
Imports System.Web.Hosting

Namespace MvcDashboardDataSources.Configuration
	Public Class ExcelDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal configurator As DashboardConfigurator, ByVal storage As DataSourceInMemoryStorage)
			' Registers an Excel data source.
			Dim excelDataSource As New DashboardExcelDataSource("Excel Data Source")
			excelDataSource.ConnectionName = "excelDataConnection"
			excelDataSource.SourceOptions = New ExcelSourceOptions(New ExcelWorksheetSettings("Sheet1"))
			storage.RegisterDataSource("excelDataSource", excelDataSource.SaveToXml())

			AddHandler configurator.ConfigureDataConnection, AddressOf Configurator_ConfigureDataConnection
		End Sub

		Private Shared Sub Configurator_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "excelDataConnection" Then
				Dim excelParams = New ExcelDataSourceConnectionParameters(HostingEnvironment.MapPath("~/App_Data/Sales.xlsx"))
				e.ConnectionParameters = excelParams
			End If
		End Sub
	End Class
End Namespace