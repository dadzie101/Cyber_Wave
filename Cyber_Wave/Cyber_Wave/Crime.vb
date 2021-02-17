Imports System.Data.OleDb
Public Class Crime
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

    Private Sub Crime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Crime"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Crime")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("Case_ID") = txtCaseID.Text
        dsNewRow.Item("Crime_Name") = txtCName.Text
        dsNewRow.Item("Court_Prosecution") = txtCPros.Text
        dsNewRow.Item("Date_Of_Conviction") = txtDateConv.Text
        dsNewRow.Item("Sentence_Span") = txtSentSpan.Text
        dsNewRow.Item("Criminal_ID") = txtCrimID.Text
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Crime").NewRow()
            Call AddRecords()
            ds.Tables("Crime").Rows.Add(dsNewRow)
            da.Update(ds, "Crime")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class