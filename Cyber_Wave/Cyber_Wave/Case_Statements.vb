Imports System.Data.OleDb
Public Class Case_Statements
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim conString As String

    Dim dsNewRow As DataRow
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form As New Home
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Case_Statements").NewRow()
            Call AddRecords()
            ds.Tables("Case_Statements").Rows.Add(dsNewRow)
            da.Update(ds, "Case_Statements")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Case_Statements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Case_Statements"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Case_Statements")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("Case_ID") = txtID.Text
        dsNewRow.Item("Petitioner's_Statements") = txtPetSt.Text
        dsNewRow.Item("Victim's_Statements") = txtVicSt.Text
        dsNewRow.Item("Accused_Statements") = txtAccSt.Text

    End Sub


End Class