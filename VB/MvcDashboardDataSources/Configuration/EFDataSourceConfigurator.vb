Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.EntityFramework

Namespace MvcDashboardDataSources.Configuration
	Public Class EFDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal storage As DataSourceInMemoryStorage)
			' Registers an Entity Framework data source.
			Dim efDataSource As New DashboardEFDataSource("EF Data Source")
			efDataSource.ConnectionParameters = New EFConnectionParameters(GetType(OrderContext))
			storage.RegisterDataSource("efDataSource", efDataSource.SaveToXml())
		End Sub
	End Class
End Namespace