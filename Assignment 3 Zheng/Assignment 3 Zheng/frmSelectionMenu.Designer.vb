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
        Me.lblHairdressers = New System.Windows.Forms.ListBox()
        Me.btnAddHairdresser = New System.Windows.Forms.Button()
        Me.btnCloseHairdresser = New System.Windows.Forms.Button()
        Me.lblSelectHairdresser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHairdressers
        '
        Me.lblHairdressers.FormattingEnabled = True
        Me.lblHairdressers.Location = New System.Drawing.Point(12, 26)
        Me.lblHairdressers.Name = "lblHairdressers"
        Me.lblHairdressers.Size = New System.Drawing.Size(290, 251)
        Me.lblHairdressers.TabIndex = 0
        '
        'btnAddHairdresser
        '
        Me.btnAddHairdresser.Location = New System.Drawing.Point(12, 298)
        Me.btnAddHairdresser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddHairdresser.Name = "btnAddHairdresser"
        Me.btnAddHairdresser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddHairdresser.Size = New System.Drawing.Size(132, 69)
        Me.btnAddHairdresser.TabIndex = 6
        Me.btnAddHairdresser.Text = "Add Hairdresser"
        Me.btnAddHairdresser.UseVisualStyleBackColor = True
        '
        'btnCloseHairdresser
        '
        Me.btnCloseHairdresser.Location = New System.Drawing.Point(166, 298)
        Me.btnCloseHairdresser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCloseHairdresser.Name = "btnCloseHairdresser"
        Me.btnCloseHairdresser.Size = New System.Drawing.Size(136, 69)
        Me.btnCloseHairdresser.TabIndex = 7
        Me.btnCloseHairdresser.Text = "Close"
        Me.btnCloseHairdresser.UseVisualStyleBackColor = True
        '
        'lblSelectHairdresser
        '
        Me.lblSelectHairdresser.AutoSize = True
        Me.lblSelectHairdresser.Location = New System.Drawing.Point(11, 9)
        Me.lblSelectHairdresser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectHairdresser.Name = "lblSelectHairdresser"
        Me.lblSelectHairdresser.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectHairdresser.TabIndex = 8
        Me.lblSelectHairdresser.Text = "Select Hairdresser"
        '
        'frmSelectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 378)
        Me.Controls.Add(Me.lblSelectHairdresser)
        Me.Controls.Add(Me.btnCloseHairdresser)
        Me.Controls.Add(Me.btnAddHairdresser)
        Me.Controls.Add(Me.lblHairdressers)
        Me.Name = "frmSelectionMenu"
        Me.Text = "Perfect Hair Salon Hairdressers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHairdressers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddHairdresser As System.Windows.Forms.Button
    Friend WithEvents btnCloseHairdresser As System.Windows.Forms.Button
    Friend WithEvents lblSelectHairdresser As System.Windows.Forms.Label
End Class
