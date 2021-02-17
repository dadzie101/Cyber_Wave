Imports System.Data.OleDb

Public Class Login
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim conString As String
 
    Dim dsNewRow As DataRow

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form As New Home
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Login"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Login")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("Investigator_FName") = txtFname.Text
        dsNewRow.Item("Investigator_FName") = txtLname.Text
        dsNewRow.Item("Login_Date") = txtLogDate.Text
        dsNewRow.Item("User_ID") = txtUserID.Text
        dsNewRow.Item("Password") = txtPassword.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Login").NewRow()
            Call AddRecords()
            ds.Tables("Login").Rows.Add(dsNewRow)
            da.Update(ds, "Login")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class