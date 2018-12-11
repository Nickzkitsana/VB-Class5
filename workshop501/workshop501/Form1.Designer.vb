<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkCourse = New System.Windows.Forms.CheckedListBox()
        Me.ChkEnroll = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(167, 42)
        Me.txtid.MaxLength = 13
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(310, 20)
        Me.txtid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลขบัตรประชาชน"
        '
        'ChkCourse
        '
        Me.ChkCourse.FormattingEnabled = True
        Me.ChkCourse.Items.AddRange(New Object() {"English for speaking", "English for reading", "English for writing", "English for listening", "Grammar Course", "Vocabulary Course"})
        Me.ChkCourse.Location = New System.Drawing.Point(49, 111)
        Me.ChkCourse.Name = "ChkCourse"
        Me.ChkCourse.Size = New System.Drawing.Size(162, 169)
        Me.ChkCourse.TabIndex = 2
        '
        'ChkEnroll
        '
        Me.ChkEnroll.FormattingEnabled = True
        Me.ChkEnroll.Location = New System.Drawing.Point(315, 111)
        Me.ChkEnroll.Name = "ChkEnroll"
        Me.ChkEnroll.Size = New System.Drawing.Size(162, 169)
        Me.ChkEnroll.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(235, 152)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 35)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = ">>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(235, 204)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(54, 35)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "<<"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(49, 309)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(182, 35)
        Me.btnEnroll.TabIndex = 6
        Me.btnEnroll.Text = "ลงทะเบียนเรียน"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(295, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(182, 35)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "ยกเลิกการลงทะเบียน"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTotalPrice.Location = New System.Drawing.Point(52, 358)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(425, 34)
        Me.lblTotalPrice.TabIndex = 8
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "คอร์สเรียน:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 411)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ChkEnroll)
        Me.Controls.Add(Me.ChkCourse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtid)
        Me.Name = "Form1"
        Me.Text = "English Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkCourse As CheckedListBox
    Friend WithEvents ChkEnroll As CheckedListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label2 As Label
End Class
