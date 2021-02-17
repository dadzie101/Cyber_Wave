Public Class Home
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form As New Crime
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Form As New FIR
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form As New Cases
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Form As New Victim
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Form As New Criminal
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Form As New About
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form As New Case_Statements
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Form As New Station
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Form As New Petitioner
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form As New Accused
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim Form As New Form2
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim Form As New Form3
        Me.Hide()

        Form.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim Form As New Form4
        Me.Hide()

        Form.Show()
    End Sub
End Class