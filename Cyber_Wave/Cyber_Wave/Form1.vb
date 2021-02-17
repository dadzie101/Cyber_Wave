Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Form As New Home
        Me.Hide()

        Form.Show()
    End Sub
End Class
