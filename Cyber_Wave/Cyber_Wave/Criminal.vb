Imports System.Data.OleDb
Public Class Criminal
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

    Private Sub Criminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Criminal"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Criminal")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub

    Public Sub AddRecords()
        dsNewRow.Item("Criminal_Fname") = txtfname.Text
        dsNewRow.Item("Criminal_Lname") = txtlname.Text
        dsNewRow.Item("Criminal_Middle_Name") = txtmname.Text
        dsNewRow.Item("Date_Of_Birth") = txtdob.Text
        dsNewRow.Item("Address") = txtadd.Text
        dsNewRow.Item("Country_Of_Origin") = txtorigin.Text
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Criminal").NewRow()
            Call AddRecords()
            ds.Tables("Criminal").Rows.Add(dsNewRow)
            da.Update(ds, "Criminal")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class