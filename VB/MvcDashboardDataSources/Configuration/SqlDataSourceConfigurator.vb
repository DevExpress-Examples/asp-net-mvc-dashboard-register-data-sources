Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Sql
Imports System

Namespace MvcDashboardDataSources.Configuration
	Public Class SqlDataSourceConfigurator
		Public Shared Sub ConfigureDataSource(ByVal storage As DataSourceInMemoryStorage)
			' Registers an SQL data source.
			Dim sqlDataSource As New DashboardSqlDataSource("SQL Data Source", "NWindConnectionString")
			Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("SalesPerson").SelectAllColumnsFromTable().Build("Sales Person")
			sqlDataSource.Queries.Add(query)
			storage.RegisterDataSource("sqlDataSource", sqlDataSource.SaveToXml())
		End Sub
	End Class
End Namespace