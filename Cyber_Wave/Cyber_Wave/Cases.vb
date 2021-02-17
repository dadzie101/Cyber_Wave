Imports System.Data.OleDb
Public Class Cases
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

    Private Sub Cases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Cases"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Cases")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("Station_ID") = txtID.Text
        dsNewRow.Item("Case_Name") = txtName.Text
        dsNewRow.Item("Section_Of_Law") = txtSecLaw.Text
        dsNewRow.Item("Incident_Date") = txtIncDate.Text
        dsNewRow.Item("Incident_Time") = txtIncTime.Text
        dsNewRow.Item("Incident_Place") = txtIncPlace.Text
        dsNewRow.Item("Description") = txtDesc.Text
        dsNewRow.Item("INvestigator_ID") = txtInvID.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Cases").NewRow()
            Call AddRecords()
            ds.Tables("Cases").Rows.Add(dsNewRow)
            da.Update(ds, "Cases")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class