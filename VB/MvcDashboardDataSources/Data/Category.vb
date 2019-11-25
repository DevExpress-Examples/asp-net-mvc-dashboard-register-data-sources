Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace MvcDashboardDataSources
	<Persistent("Categories"), DeferredDeletion(False)> _
	Public Class Category
		Inherits XPCustomObject
		Private categoryId_Renamed As Integer
		Private categoryName_Renamed As String
		Private description_Renamed As String
		<Key> _
		Public Property CategoryID() As Integer
			Get
				Return categoryId_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("CategoryID", categoryId_Renamed, value)
			End Set
		End Property
		Public Property CategoryName() As String
			Get
				Return categoryName_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CategoryName", categoryName_Renamed, value)
			End Set
		End Property
		Public Property Description() As String
			Get
				Return description_Renamed
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Description", description_Renamed, value)
			End Set
		End Property
	End Class
End Namespace