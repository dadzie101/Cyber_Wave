Public Class Form4
    Private Sub First_Incident_ReportBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles First_Incident_ReportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.First_Incident_ReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Crime_WaveDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Crime_WaveDataSet.First_Incident_Report' table. You can move, or remove it, as needed.
        Me.First_Incident_ReportTableAdapter.Fill(Me.Crime_WaveDataSet.First_Incident_Report)

    End Sub
End Class