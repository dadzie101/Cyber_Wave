Public Class Form2
    Private Sub CrimeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CrimeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CrimeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Crime_WaveDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Crime_WaveDataSet.Crime' table. You can move, or remove it, as needed.
        Me.CrimeTableAdapter.Fill(Me.Crime_WaveDataSet.Crime)

    End Sub
End Class