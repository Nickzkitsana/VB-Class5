Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim countItem As Integer = ChkCourse.Items.Count - 1
        If ChkCourse.CheckedItems.Count < 1 Then
            MessageBox.Show("กรุณาเลือกคอสเรียน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i = countItem To 0 Step -1
            If ChkCourse.GetItemChecked(i) Then
                ChkEnroll.Items.Add(ChkCourse.Items(i))
                ChkCourse.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim countItem As Integer = ChkEnroll.Items.Count - 1
        If ChkEnroll.CheckedItems.Count < 1 Then
            MessageBox.Show("กรุณาเลือกคอสเรียน", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i = countItem To 0 Step -1
            If ChkEnroll.GetItemChecked(i) Then
                ChkCourse.Items.Add(ChkEnroll.Items(i))
                ChkEnroll.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Course() As String = {"English for speaking", "English for reading", "English for writing",
                                  "English for listening", "Grammar Course", "Vocabulary Course"}
        ChkEnroll.Items.Clear()
        txtid.Clear()
        ChkCourse.Items.Clear()
        ChkCourse.Items.AddRange(Course)
        lblTotalPrice.Text = "0.00 Baht"
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

        If txtid.TextLength < 13 Then
            txtid.BackColor = Color.Red
        Else
            For i = 0 To txtid.TextLength() - 1 Step 1
                If IsNumeric(txtid.Text(i)) = False Then
                    txtid.BackColor = Color.Red
                    Exit Sub
                End If
            Next
            txtid.BackColor = DefaultBackColor
        End If

    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim countItem As Integer = ChkEnroll.Items.Count
        Dim price As Double = 2500 * countItem

        If txtid.TextLength > 0 And txtid.BackColor = DefaultBackColor And ChkEnroll.Items.Count > 0 Then
            lblTotalPrice.Text = String.Format("{0:n}", ChkEnroll.Items.Count * 2500) & " Baht."
        Else
            MessageBox.Show("กรุณาเลือกคอสเรียน และ/หรือ ป้อนเลขบัตรประชาชนให้ถูกต้อง", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim Course() As String = {"English for speaking", "English for reading", "English for writing",
                                  "English for listening", "Grammar Course", "Vocabulary Course"}
        ChkEnroll.Items.Clear()
        txtid.Clear()
        txtid.BackColor = DefaultBackColor
        lblTotalPrice.Text = "0.00 Baht"
        ChkCourse.Items.Clear()
        ChkCourse.Items.AddRange(Course)
    End Sub
End Class
