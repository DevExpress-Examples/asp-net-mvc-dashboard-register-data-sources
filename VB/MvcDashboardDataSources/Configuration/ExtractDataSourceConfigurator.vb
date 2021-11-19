Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System.Web.Hosting

Namespace MvcDashboardDataSources.Configuration
	Public Class ExtractDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal configurator As DashboardConfigurator, ByVal storage As DataSourceInMemoryStorage)
			' Registers an Extract data source.
			Dim extractDataSource As New DashboardExtractDataSource("Extract Data Source")
			extractDataSource.Name = "Extract Data Source"
			extractDataSource.ConnectionName = "dataExtract"
			storage.RegisterDataSource("extractDataSource ", extractDataSource.SaveToXml())

			AddHandler configurator.ConfigureDataConnection, AddressOf Configurator_ConfigureDataConnection
		End Sub

		Private Shared Sub Configurator_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName ="dataExtract" Then
				Dim extractParams As New ExtractDataSourceConnectionParameters()
				extractParams.FileName = HostingEnvironment.MapPath("~/App_Data/SalesPersonExtract.dat")
				e.ConnectionParameters = extractParams
			End If
		End Sub
	End Class
End Namespace