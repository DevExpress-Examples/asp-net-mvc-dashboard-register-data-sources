Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.ConnectionParameters

Namespace MvcDashboardDataSources.Configuration
	Public Class OlapDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal configurator As DashboardConfigurator, ByVal storage As DataSourceInMemoryStorage)
			' Registers an OLAP data source.
			Dim olapDataSource As New DashboardOlapDataSource("OLAP Data Source", "olapConnection")
			storage.RegisterDataSource("olapDataSource", olapDataSource.SaveToXml())

			AddHandler configurator.ConfigureDataConnection, AddressOf Configurator_ConfigureDataConnection
		End Sub


		Private Shared Sub Configurator_ConfigureDataConnection(ByVal sender As Object, ByVal e As ConfigureDataConnectionWebEventArgs)
			If e.ConnectionName = "olapConnection" Then
				Dim olapParams As New OlapConnectionParameters()
				olapParams.ConnectionString = "Provider=MSOLAP;Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" & "Initial catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"
				e.ConnectionParameters = olapParams
			End If
		End Sub
	End Class
End Namespace