Imports System.Data.Entity

Namespace MvcDashboardDataSources

	Partial Public Class OrderContext
		Inherits DbContext

		Public Sub New()
			MyBase.New("name=OrderContext")
		End Sub

		Public Overridable Property OrderDetails() As DbSet(Of OrderDetails)

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
			modelBuilder.Entity(Of OrderDetails)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)
		End Sub
	End Class
End Namespace
