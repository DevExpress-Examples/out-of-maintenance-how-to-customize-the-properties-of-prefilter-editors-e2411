Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 7})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), 4})
            myTable.Rows.Add(New Object() {"AAA", Date.Today, 12})
            myTable.Rows.Add(New Object() {"AAA", Date.Today.AddDays(1), 14})
            myTable.Rows.Add(New Object() {"aaa", Date.Today, 11})
            myTable.Rows.Add(New Object() {"aaa", Date.Today.AddDays(1), 10})
        End Sub
    End Class
End Namespace
