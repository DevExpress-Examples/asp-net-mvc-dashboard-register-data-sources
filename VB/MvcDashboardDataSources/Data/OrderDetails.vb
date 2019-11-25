Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel.DataAnnotations
	Imports System.ComponentModel.DataAnnotations.Schema
	Imports System.Data.Entity.Spatial
Namespace MvcDashboardDataSources

	Partial Public Class OrderDetails
		Private privateOrderID As Integer
		<Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)> _
		Public Property OrderID() As Integer
			Get
				Return privateOrderID
			End Get
			Set(ByVal value As Integer)
				privateOrderID = value
			End Set
		End Property

		Private privateQuantity As Short
		<Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)> _
		Public Property Quantity() As Short
			Get
				Return privateQuantity
			End Get
			Set(ByVal value As Short)
				privateQuantity = value
			End Set
		End Property

		Private privateUnitPrice As Decimal
		<Key, Column(Order := 2, TypeName := "smallmoney")> _
		Public Property UnitPrice() As Decimal
			Get
				Return privateUnitPrice
			End Get
			Set(ByVal value As Decimal)
				privateUnitPrice = value
			End Set
		End Property

		Private privateDiscount As Single
		<Key, Column(Order := 3)> _
		Public Property Discount() As Single
			Get
				Return privateDiscount
			End Get
			Set(ByVal value As Single)
				privateDiscount = value
			End Set
		End Property

		Private privateProductName As String
		<Key, Column(Order := 4), StringLength(40)> _
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property

		Private privateSupplier As String
		<StringLength(217)> _
		Public Property Supplier() As String
			Get
				Return privateSupplier
			End Get
			Set(ByVal value As String)
				privateSupplier = value
			End Set
		End Property
	End Class
End Namespace
