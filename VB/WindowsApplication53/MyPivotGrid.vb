Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid.ViewInfo
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication53
	Public Class MyPivotGridControl
		Inherits PivotGridControl
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal viewInfoData As PivotGridViewInfoData)
			MyBase.New(viewInfoData)
		End Sub

		Protected Overrides Function CreateData() As PivotGridViewInfoData
			Return New MyPivotGridViewInfoData(Me)
		End Function
	End Class

	Public Class MyPivotGridViewInfoData
		Inherits PivotGridViewInfoData
		Implements IFilteredComponent
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal control As IViewInfoControl)
			MyBase.New(control)
		End Sub


		#Region "IFilteredComponent Members"

		Private Function CreateFilterColumnCollection() As FilterColumnCollection Implements IFilteredComponent.CreateFilterColumnCollection
			Dim collection As New FilterColumnCollection()
			For i As Integer = 0 To Fields.Count - 1
				If Fields(i).CanShowInPrefilter Then
					Dim filterColumn As New FieldFilterColumn(Fields(i), MenuManager)
					UpdateFieldFilterColumn(filterColumn)
					collection.Add(filterColumn)
				End If
			Next i
			Return collection
		End Function

		Private Sub UpdateFieldFilterColumn(ByVal filterColumn As FieldFilterColumn)
			Dim comboBox As RepositoryItemComboBox = TryCast(filterColumn.ColumnEditor, RepositoryItemComboBox)
			If comboBox IsNot Nothing Then
				comboBox.AutoComplete = False
			End If
		End Sub
		#End Region


	End Class

End Namespace
