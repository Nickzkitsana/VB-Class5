Public Class Form1
    Private Sub Numeric_ValueChanged(sender As Object, e As EventArgs) Handles Numeric.ValueChanged
        Dim number As Integer = Numeric.Value
        LabelNumeric.Text = number
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim number As Integer = Numeric.Value
        LabelNumeric.Text = number
    End Sub
End Class
