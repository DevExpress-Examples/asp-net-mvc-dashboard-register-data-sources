Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace MvcDashboardDataSources.Configuration
	Public Class ObjectDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal configurator As DashboardConfigurator, ByVal storage As DataSourceInMemoryStorage)
			' Registers an Object data source.
			Dim objDataSource As New DashboardObjectDataSource("Object Data Source")
			objDataSource.DataId = "objectDataSource"
			storage.RegisterDataSource("objDataSource", objDataSource.SaveToXml())

			AddHandler configurator.DataLoading, AddressOf DataLoading

		End Sub
		Private Shared Sub DataLoading(ByVal sender As Object, ByVal e As DataLoadingWebEventArgs)
			If e.DataId = "objectDataSource" Then
				e.Data = Invoices.CreateData()
			End If
		End Sub
	End Class
End Namespace