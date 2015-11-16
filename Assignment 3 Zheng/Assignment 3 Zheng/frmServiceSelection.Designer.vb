<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceSelection
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
        Me.lblSelectService = New System.Windows.Forms.Label()
        Me.btnCloseService = New System.Windows.Forms.Button()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.lblServices = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSelectService
        '
        Me.lblSelectService.AutoSize = True
        Me.lblSelectService.Location = New System.Drawing.Point(9, 7)
        Me.lblSelectService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectService.Name = "lblSelectService"
        Me.lblSelectService.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectService.TabIndex = 12
        Me.lblSelectService.Text = "Select Service"
        '
        'btnCloseService
        '
        Me.btnCloseService.Location = New System.Drawing.Point(164, 297)
        Me.btnCloseService.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCloseService.Name = "btnCloseService"
        Me.btnCloseService.Size = New System.Drawing.Size(136, 69)
        Me.btnCloseService.TabIndex = 11
        Me.btnCloseService.Text = "Close"
        Me.btnCloseService.UseVisualStyleBackColor = True
        '
        'btnAddService
        '
        Me.btnAddService.Location = New System.Drawing.Point(10, 297)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddService.Size = New System.Drawing.Size(132, 69)
        Me.btnAddService.TabIndex = 10
        Me.btnAddService.Text = "Add Service"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'lblServices
        '
        Me.lblServices.FormattingEnabled = True
        Me.lblServices.Location = New System.Drawing.Point(10, 24)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(290, 251)
        Me.lblServices.TabIndex = 9
        '
        'frmServiceSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 379)
        Me.Controls.Add(Me.lblSelectService)
        Me.Controls.Add(Me.btnCloseService)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.lblServices)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmServiceSelection"
        Me.Text = "Perfect Hair Salon Services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectService As System.Windows.Forms.Label
    Friend WithEvents btnCloseService As System.Windows.Forms.Button
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents lblServices As System.Windows.Forms.ListBox
End Class
