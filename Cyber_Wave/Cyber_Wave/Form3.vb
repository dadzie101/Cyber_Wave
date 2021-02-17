Public Class Form3
    Private Sub CriminalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CriminalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CriminalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Crime_WaveDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Crime_WaveDataSet.Criminal' table. You can move, or remove it, as needed.
        Me.CriminalTableAdapter.Fill(Me.Crime_WaveDataSet.Criminal)

    End Sub
End Class