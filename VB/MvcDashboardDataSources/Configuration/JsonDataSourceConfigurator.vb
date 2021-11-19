Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Json
Imports System
Imports System.Web.Hosting

Namespace MvcDashboardDataSources.Configuration
	Public Class JsonDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal configurator As DashboardConfigurator, ByVal storage As DataSourceInMemoryStorage)
			' Registers a JSON data source from URL.
			Dim jsonDataSourceUrl As New DashboardJsonDataSource("JSON Data Source (URL)")
			jsonDataSourceUrl.JsonSource = New UriJsonSource(New Uri("https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json"))
			jsonDataSourceUrl.RootElement = "Customers"
			jsonDataSourceUrl.Fill()
			storage.RegisterDataSource("jsonDataSourceUrl", jsonDataSourceUrl.SaveToXml())

			' Registers a JSON data source from a JSON file.
			Dim jsonDataSourceFile As New DashboardJsonDataSource("JSON Data Source (File)")

			jsonDataSourceFile.ConnectionName = "jsonConnection"
			jsonDataSourceFile.RootElement = "Customers"
			storage.RegisterDataSource("jsonDataSourceFile", jsonDataSourceFile.SaveToXml())

			' Registers a JSON data source from JSON string.
			Dim jsonDataSourceString As New DashboardJsonDataSource("JSON Data Source (String)")
			Dim json As String = "{""Customers"":[{""Id"":""ALFKI"",""CompanyName"":""Alfreds Futterkiste"",""ContactName"":""Maria Anders"",""ContactTitle"":""Sales Representative"",""Address"":""Obere Str. 57"",""City"":""Berlin"",""PostalCode"":""12209"",""Country"":""Germany"",""Phone"":""030-0074321"",""Fax"":""030-0076545""}],""ResponseStatus"":{}}"
			jsonDataSourceString.JsonSource = New CustomJsonSource(json)
			jsonDataSourceString.RootElement = "Customers"
			storage.RegisterDataSource("jsonDataSourceString", jsonDataSourceString.SaveToXml())

			AddHandler configurator.ConfigureDataConnection, AddressOf Configurator_ConfigureDataConnection
		End Sub

		Private Shared Sub Configurator_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "jsonConnection" Then
				Dim fileUri As New Uri(HostingEnvironment.MapPath("~/App_Data/customers.json"), UriKind.RelativeOrAbsolute)
				Dim jsonParams As New JsonSourceConnectionParameters()
				jsonParams.JsonSource = New UriJsonSource(fileUri)
				e.ConnectionParameters = jsonParams
			End If
		End Sub
	End Class
End Namespace