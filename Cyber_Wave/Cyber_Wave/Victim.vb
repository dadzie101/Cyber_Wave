﻿Imports System.Data.OleDb
Public Class Victim
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

    Private Sub Victim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Crime_Wave.mdb "
            con = New OleDbConnection(conString)
            con.Open()
            sql = "select * from Victim"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Victim")
            con.Close()

        Catch EXP As Exception

            MessageBox.Show(EXP.ToString)
        End Try

    End Sub


    Public Sub AddRecords()
        dsNewRow.Item("FIR_ID") = txtID.Text
        dsNewRow.Item("Victim_Fname") = txtfname.Text
        dsNewRow.Item("Victim_Lname") = txtlname.Text
        dsNewRow.Item("Victim_Address") = txtadd.Text
        dsNewRow.Item("Victim_Contact") = txtCon.Text

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Victim").NewRow()
            Call AddRecords()
            ds.Tables("Victim").Rows.Add(dsNewRow)
            da.Update(ds, "Victim")
            MessageBox.Show("New Record added to the Database")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class