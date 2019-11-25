Imports Microsoft.VisualBasic
	Imports System.Data.Entity
Namespace MvcDashboardDataSources

	Partial Public Class OrderContext
		Inherits DbContext
		Public Sub New()
			MyBase.New("name=OrderContext")
		End Sub

		Private privateOrderDetails As DbSet(Of OrderDetails)
		Public Overridable Property OrderDetails() As DbSet(Of OrderDetails)
			Get
				Return privateOrderDetails
			End Get
			Set(ByVal value As DbSet(Of OrderDetails))
				privateOrderDetails = value
			End Set
		End Property

		Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
			modelBuilder.Entity(Of OrderDetails)().Property(Function(e) e.UnitPrice).HasPrecision(10, 4)
		End Sub
	End Class
End Namespace
