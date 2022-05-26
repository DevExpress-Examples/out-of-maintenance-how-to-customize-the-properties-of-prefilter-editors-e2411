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
        Private Overloads Function CreateFilterColumnCollection() As IBoundPropertyCollection Implements IFilteredComponent.CreateFilterColumnCollection
            Dim collection As IBoundPropertyCollection = New FieldFilterColumnCollection(Fields, Prefilter.PrefilterColumnNames, MenuManager)
            For Each column As FieldFilterColumn In collection
                UpdateFieldFilterColumn(column)
            Next

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
