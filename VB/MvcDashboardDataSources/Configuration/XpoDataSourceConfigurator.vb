Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace MvcDashboardDataSources.Configuration
	Public Class XpoDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal storage As DataSourceInMemoryStorage)
			' Registers an XPO data source.
			Dim xpoDataSource As New DashboardXpoDataSource("XPO Data Source")
			xpoDataSource.ConnectionStringName = "NWindConnectionStringSQLite"
			xpoDataSource.SetEntityType(GetType(Category))
			storage.RegisterDataSource("xpoDataSource", xpoDataSource.SaveToXml())
		End Sub
	End Class
End Namespace