<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectionMenu
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
        Me.lstHairdressers = New System.Windows.Forms.ListBox()
        Me.btnAddHairdresser = New System.Windows.Forms.Button()
        Me.btnCloseHairdresser = New System.Windows.Forms.Button()
        Me.lblSelectHairdresser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstHairdressers
        '
        Me.lstHairdressers.FormattingEnabled = True
        Me.lstHairdressers.ItemHeight = 16
        Me.lstHairdressers.Items.AddRange(New Object() {"Jane Samley", "Pat Johnson", "Ron Chambers", "Sue Pallon", "Laurie Renkins"})
        Me.lstHairdressers.Location = New System.Drawing.Point(16, 32)
        Me.lstHairdressers.Margin = New System.Windows.Forms.Padding(4)
        Me.lstHairdressers.Name = "lstHairdressers"
        Me.lstHairdressers.Size = New System.Drawing.Size(385, 308)
        Me.lstHairdressers.TabIndex = 0
        '
        'btnAddHairdresser
        '
        Me.btnAddHairdresser.Location = New System.Drawing.Point(16, 367)
        Me.btnAddHairdresser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddHairdresser.Name = "btnAddHairdresser"
        Me.btnAddHairdresser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddHairdresser.Size = New System.Drawing.Size(176, 85)
        Me.btnAddHairdresser.TabIndex = 6
        Me.btnAddHairdresser.Text = "Add Hairdresser"
        Me.btnAddHairdresser.UseVisualStyleBackColor = True
        '
        'btnCloseHairdresser
        '
        Me.btnCloseHairdresser.Location = New System.Drawing.Point(221, 367)
        Me.btnCloseHairdresser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCloseHairdresser.Name = "btnCloseHairdresser"
        Me.btnCloseHairdresser.Size = New System.Drawing.Size(181, 85)
        Me.btnCloseHairdresser.TabIndex = 7
        Me.btnCloseHairdresser.Text = "Close"
        Me.btnCloseHairdresser.UseVisualStyleBackColor = True
        '
        'lblSelectHairdresser
        '
        Me.lblSelectHairdresser.AutoSize = True
        Me.lblSelectHairdresser.Location = New System.Drawing.Point(15, 11)
        Me.lblSelectHairdresser.Name = "lblSelectHairdresser"
        Me.lblSelectHairdresser.Size = New System.Drawing.Size(125, 17)
        Me.lblSelectHairdresser.TabIndex = 8
        Me.lblSelectHairdresser.Text = "Select Hairdresser"
        '
        'frmSelectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 465)
        Me.Controls.Add(Me.lblSelectHairdresser)
        Me.Controls.Add(Me.btnCloseHairdresser)
        Me.Controls.Add(Me.btnAddHairdresser)
        Me.Controls.Add(Me.lstHairdressers)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSelectionMenu"
        Me.Text = "Perfect Hair Salon Hairdressers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstHairdressers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddHairdresser As System.Windows.Forms.Button
    Friend WithEvents btnCloseHairdresser As System.Windows.Forms.Button
    Friend WithEvents lblSelectHairdresser As System.Windows.Forms.Label
End Class
