Imports System.Data.OleDb

Public Class Petitioner
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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Petitioner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Petitioner"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Petitioner")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("FIR_ID") = txtID.Text
        dsNewRow.Item("Petitioner_Fname") = txtfname.Text
        dsNewRow.Item("Petitioner_Lname") = txtlname.Text
        dsNewRow.Item("Petitioner_Address") = txtadd.Text
        dsNewRow.Item("Petitioner_Contact") = txtCon.Text
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Petitioner").NewRow()
            Call AddRecords()
            ds.Tables("Petitioner").Rows.Add(dsNewRow)
            da.Update(ds, "Petitioner")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class