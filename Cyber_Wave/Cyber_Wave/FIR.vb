Imports System.Data.OleDb
Public Class FIR
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim conString As String

    Dim dsNewRow As DataRow
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form As New Home
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("First Incident Report").NewRow()
            Call AddRecords()
            ds.Tables("First Incident Report").Rows.Add(dsNewRow)
            da.Update(ds, "First Incident Report")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub FIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from First_Incident_Report"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "First_Incident_Report")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub

    Public Sub AddRecords()
        dsNewRow.Item("Investigator_ID") = txtID.Text
        dsNewRow.Item("Inc_Name") = txtIncName.Text
        dsNewRow.Item("Incident_Date") = txtDate.Text
        dsNewRow.Item("Incident_Place") = txtIncPlace.Text
        dsNewRow.Item("Description") = txtDes.Text
        dsNewRow.Item("Date_Lodged") = txtDateLodged.Text
        dsNewRow.Item("Status") = txtStatus.Text
    End Sub
End Class