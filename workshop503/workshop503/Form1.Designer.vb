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
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.rdSpade = New System.Windows.Forms.RadioButton()
        Me.rdHeart = New System.Windows.Forms.RadioButton()
        Me.rdClub = New System.Windows.Forms.RadioButton()
        Me.rdDiamond = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCard
        '
        Me.picCard.Image = Global.workshop503.My.Resources.Resources.back
        Me.picCard.Location = New System.Drawing.Point(39, 38)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(193, 268)
        Me.picCard.TabIndex = 0
        Me.picCard.TabStop = False
        '
        'rdSpade
        '
        Me.rdSpade.AutoSize = True
        Me.rdSpade.Location = New System.Drawing.Point(283, 52)
        Me.rdSpade.Name = "rdSpade"
        Me.rdSpade.Size = New System.Drawing.Size(56, 17)
        Me.rdSpade.TabIndex = 1
        Me.rdSpade.TabStop = True
        Me.rdSpade.Text = "Spade"
        Me.rdSpade.UseVisualStyleBackColor = True
        '
        'rdHeart
        '
        Me.rdHeart.AutoSize = True
        Me.rdHeart.Location = New System.Drawing.Point(283, 95)
        Me.rdHeart.Name = "rdHeart"
        Me.rdHeart.Size = New System.Drawing.Size(51, 17)
        Me.rdHeart.TabIndex = 2
        Me.rdHeart.TabStop = True
        Me.rdHeart.Text = "Heart"
        Me.rdHeart.UseVisualStyleBackColor = True
        '
        'rdClub
        '
        Me.rdClub.AutoSize = True
        Me.rdClub.Location = New System.Drawing.Point(283, 137)
        Me.rdClub.Name = "rdClub"
        Me.rdClub.Size = New System.Drawing.Size(46, 17)
        Me.rdClub.TabIndex = 3
        Me.rdClub.TabStop = True
        Me.rdClub.Text = "Club"
        Me.rdClub.UseVisualStyleBackColor = True
        '
        'rdDiamond
        '
        Me.rdDiamond.AutoSize = True
        Me.rdDiamond.Location = New System.Drawing.Point(283, 179)
        Me.rdDiamond.Name = "rdDiamond"
        Me.rdDiamond.Size = New System.Drawing.Size(67, 17)
        Me.rdDiamond.TabIndex = 4
        Me.rdDiamond.TabStop = True
        Me.rdDiamond.Text = "Diamond"
        Me.rdDiamond.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(39, 347)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 40)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Location = New System.Drawing.Point(226, 347)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(150, 40)
        Me.btnAnswer.TabIndex = 6
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 418)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.rdDiamond)
        Me.Controls.Add(Me.rdClub)
        Me.Controls.Add(Me.rdHeart)
        Me.Controls.Add(Me.rdSpade)
        Me.Controls.Add(Me.picCard)
        Me.Name = "Form1"
        Me.Text = "Guess The Card"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCard As PictureBox
    Friend WithEvents rdSpade As RadioButton
    Friend WithEvents rdHeart As RadioButton
    Friend WithEvents rdClub As RadioButton
    Friend WithEvents rdDiamond As RadioButton
    Friend WithEvents btnStart As Button
    Friend WithEvents btnAnswer As Button
End Class
