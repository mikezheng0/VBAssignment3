﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lstServices = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblSelectService
        '
        Me.lblSelectService.AutoSize = True
        Me.lblSelectService.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectService.Name = "lblSelectService"
        Me.lblSelectService.Size = New System.Drawing.Size(98, 17)
        Me.lblSelectService.TabIndex = 12
        Me.lblSelectService.Text = "Select Service"
        '
        'btnCloseService
        '
        Me.btnCloseService.Location = New System.Drawing.Point(219, 366)
        Me.btnCloseService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCloseService.Name = "btnCloseService"
        Me.btnCloseService.Size = New System.Drawing.Size(181, 85)
        Me.btnCloseService.TabIndex = 11
        Me.btnCloseService.Text = "Close"
        Me.btnCloseService.UseVisualStyleBackColor = True
        '
        'btnAddService
        '
        Me.btnAddService.Location = New System.Drawing.Point(13, 366)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddService.Size = New System.Drawing.Size(176, 85)
        Me.btnAddService.TabIndex = 10
        Me.btnAddService.Text = "Add Service"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'lstServices
        '
        Me.lstServices.FormattingEnabled = True
        Me.lstServices.ItemHeight = 16
        Me.lstServices.Items.AddRange(New Object() {"Cut, Wash, Blowdry and Style", "Colour", "Highlights", "Extensions", "Up Do", "Wash, Blowdry and Style"})
        Me.lstServices.Location = New System.Drawing.Point(13, 30)
        Me.lstServices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstServices.Name = "lstServices"
        Me.lstServices.Size = New System.Drawing.Size(385, 308)
        Me.lstServices.TabIndex = 9
        '
        'frmServiceSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 466)
        Me.Controls.Add(Me.lblSelectService)
        Me.Controls.Add(Me.btnCloseService)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.lstServices)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmServiceSelection"
        Me.Text = "Perfect Hair Salon Services"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectService As System.Windows.Forms.Label
    Friend WithEvents btnCloseService As System.Windows.Forms.Button
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents lstServices As System.Windows.Forms.ListBox
End Class
