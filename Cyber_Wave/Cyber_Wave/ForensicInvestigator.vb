Imports System.Data.OleDb
Public Class ForensicInvestigator
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

    Private Sub ForensicInvestigator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Forensic_Investigator"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Forensic_Investigator")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()

        dsNewRow.Item("Station_ID") = txtID.Text
        dsNewRow.Item("Investigator_Fname") = txtFname.Text
        dsNewRow.Item("Investigator_Lname") = txtLname.Text
        dsNewRow.Item("Rank") = txtRank.Text
        dsNewRow.Item("Paswword") = txtPassword.Text
        dsNewRow.Item("Authentication_Level") = txtAccess.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Forensic_Investigator").NewRow()
            Call AddRecords()
            ds.Tables("Forensic_Investigator").Rows.Add(dsNewRow)
            da.Update(ds, "Forensic_Investigator")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class