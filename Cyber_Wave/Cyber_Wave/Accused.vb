Imports System.Data.OleDb
Public Class Accused
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

    Private Sub Accused_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Accused"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Accused")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub

    Public Sub AddRecords()
        dsNewRow.Item("Fir_ID") = txtID.Text
        dsNewRow.Item("Accused_Fname") = txtFname.Text
        dsNewRow.Item("Accused_Lname") = txtLname.Text
        dsNewRow.Item("Accused_Address") = txtAddress.Text
        dsNewRow.Item("Accused_Contract") = txtContact.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            dsNewRow = ds.Tables("Accused").NewRow()
            Call AddRecords()
            ds.Tables("Accused").Rows.Add(dsNewRow)
            da.Update(ds, "Accused")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class