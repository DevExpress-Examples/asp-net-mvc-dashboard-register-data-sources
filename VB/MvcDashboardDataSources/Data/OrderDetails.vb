Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System

Namespace MvcDashboardDataSources

	Partial Public Class OrderDetails
		<Key, Column(Order := 0), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property OrderID() As Integer

		<Key, Column(Order := 1), DatabaseGenerated(DatabaseGeneratedOption.None)>
		Public Property Quantity() As Short

		<Key, Column(Order := 2, TypeName := "smallmoney")>
		Public Property UnitPrice() As Decimal

		<Key, Column(Order := 3)>
		Public Property Discount() As Single

		<Key, Column(Order := 4), StringLength(40)>
		Public Property ProductName() As String

		<StringLength(217)>
		Public Property Supplier() As String
	End Class
End Namespace
