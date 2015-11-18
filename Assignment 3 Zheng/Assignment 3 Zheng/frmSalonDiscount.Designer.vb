<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalonDiscount
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
        Me.components = New System.ComponentModel.Container()
        Me.lstClientType = New System.Windows.Forms.ListBox()
        Me.txtNumberOfVisits = New System.Windows.Forms.TextBox()
        Me.lblNumOfVisitsStatic = New System.Windows.Forms.Label()
        Me.lblClientTypeStatic = New System.Windows.Forms.Label()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.btnCalculateTypeDiscount = New System.Windows.Forms.Button()
        Me.btnCloseDiscounts = New System.Windows.Forms.Button()
        Me.lblVisitDiscountAmountStatic = New System.Windows.Forms.Label()
        Me.lblVisitDiscount = New System.Windows.Forms.Label()
        Me.lblClientTypeDiscount = New System.Windows.Forms.Label()
        Me.lblClientTypeDiscountStatic = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'lstClientType
        '
        Me.lstClientType.FormattingEnabled = True
        Me.lstClientType.ItemHeight = 16
        Me.lstClientType.Items.AddRange(New Object() {"Standard Adult", "Child (12 And Under)", "Student", "Senior (Over 85)"})
        Me.lstClientType.Location = New System.Drawing.Point(12, 104)
        Me.lstClientType.Name = "lstClientType"
        Me.lstClientType.Size = New System.Drawing.Size(178, 116)
        Me.lstClientType.TabIndex = 0
        '
        'txtNumberOfVisits
        '
        Me.txtNumberOfVisits.Location = New System.Drawing.Point(12, 37)
        Me.txtNumberOfVisits.Name = "txtNumberOfVisits"
        Me.txtNumberOfVisits.Size = New System.Drawing.Size(100, 22)
        Me.txtNumberOfVisits.TabIndex = 1
        '
        'lblNumOfVisitsStatic
        '
        Me.lblNumOfVisitsStatic.AutoSize = True
        Me.lblNumOfVisitsStatic.Location = New System.Drawing.Point(12, 9)
        Me.lblNumOfVisitsStatic.Name = "lblNumOfVisitsStatic"
        Me.lblNumOfVisitsStatic.Size = New System.Drawing.Size(149, 17)
        Me.lblNumOfVisitsStatic.TabIndex = 2
        Me.lblNumOfVisitsStatic.Text = "Enter Number of Visits"
        '
        'lblClientTypeStatic
        '
        Me.lblClientTypeStatic.AutoSize = True
        Me.lblClientTypeStatic.Location = New System.Drawing.Point(12, 75)
        Me.lblClientTypeStatic.Name = "lblClientTypeStatic"
        Me.lblClientTypeStatic.Size = New System.Drawing.Size(122, 17)
        Me.lblClientTypeStatic.TabIndex = 3
        Me.lblClientTypeStatic.Text = "Select Client Type"
        '
        'btnAddService
        '
        Me.btnAddService.Location = New System.Drawing.Point(12, 235)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddService.Size = New System.Drawing.Size(122, 85)
        Me.btnAddService.TabIndex = 11
        Me.btnAddService.Text = "Calculate Visit Discount"
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'btnCalculateTypeDiscount
        '
        Me.btnCalculateTypeDiscount.Location = New System.Drawing.Point(140, 235)
        Me.btnCalculateTypeDiscount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculateTypeDiscount.Name = "btnCalculateTypeDiscount"
        Me.btnCalculateTypeDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculateTypeDiscount.Size = New System.Drawing.Size(117, 85)
        Me.btnCalculateTypeDiscount.TabIndex = 12
        Me.btnCalculateTypeDiscount.Text = "Calculate Type Discount"
        Me.btnCalculateTypeDiscount.UseVisualStyleBackColor = True
        '
        'btnCloseDiscounts
        '
        Me.btnCloseDiscounts.Location = New System.Drawing.Point(263, 235)
        Me.btnCloseDiscounts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCloseDiscounts.Name = "btnCloseDiscounts"
        Me.btnCloseDiscounts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCloseDiscounts.Size = New System.Drawing.Size(130, 85)
        Me.btnCloseDiscounts.TabIndex = 13
        Me.btnCloseDiscounts.Text = "Close"
        Me.btnCloseDiscounts.UseVisualStyleBackColor = True
        '
        'lblVisitDiscountAmountStatic
        '
        Me.lblVisitDiscountAmountStatic.AutoSize = True
        Me.lblVisitDiscountAmountStatic.Location = New System.Drawing.Point(206, 9)
        Me.lblVisitDiscountAmountStatic.Name = "lblVisitDiscountAmountStatic"
        Me.lblVisitDiscountAmountStatic.Size = New System.Drawing.Size(145, 17)
        Me.lblVisitDiscountAmountStatic.TabIndex = 14
        Me.lblVisitDiscountAmountStatic.Text = "Visit Discount Amount"
        '
        'lblVisitDiscount
        '
        Me.lblVisitDiscount.AutoSize = True
        Me.lblVisitDiscount.Location = New System.Drawing.Point(206, 37)
        Me.lblVisitDiscount.Name = "lblVisitDiscount"
        Me.lblVisitDiscount.Size = New System.Drawing.Size(44, 17)
        Me.lblVisitDiscount.TabIndex = 15
        Me.lblVisitDiscount.Text = "$0.00"
        '
        'lblClientTypeDiscount
        '
        Me.lblClientTypeDiscount.AutoSize = True
        Me.lblClientTypeDiscount.Location = New System.Drawing.Point(206, 103)
        Me.lblClientTypeDiscount.Name = "lblClientTypeDiscount"
        Me.lblClientTypeDiscount.Size = New System.Drawing.Size(44, 17)
        Me.lblClientTypeDiscount.TabIndex = 17
        Me.lblClientTypeDiscount.Text = "$0.00"
        '
        'lblClientTypeDiscountStatic
        '
        Me.lblClientTypeDiscountStatic.AutoSize = True
        Me.lblClientTypeDiscountStatic.Location = New System.Drawing.Point(206, 75)
        Me.lblClientTypeDiscountStatic.Name = "lblClientTypeDiscountStatic"
        Me.lblClientTypeDiscountStatic.Size = New System.Drawing.Size(138, 17)
        Me.lblClientTypeDiscountStatic.TabIndex = 16
        Me.lblClientTypeDiscountStatic.Text = "Client Type Discount"
        Me.lblClientTypeDiscountStatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(67, 4)
        '
        'frmSalonDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 334)
        Me.Controls.Add(Me.lblClientTypeDiscount)
        Me.Controls.Add(Me.lblClientTypeDiscountStatic)
        Me.Controls.Add(Me.lblVisitDiscount)
        Me.Controls.Add(Me.lblVisitDiscountAmountStatic)
        Me.Controls.Add(Me.btnCloseDiscounts)
        Me.Controls.Add(Me.btnCalculateTypeDiscount)
        Me.Controls.Add(Me.btnAddService)
        Me.Controls.Add(Me.lblClientTypeStatic)
        Me.Controls.Add(Me.lblNumOfVisitsStatic)
        Me.Controls.Add(Me.txtNumberOfVisits)
        Me.Controls.Add(Me.lstClientType)
        Me.Name = "frmSalonDiscount"
        Me.Text = "Perfect Hair Salon Discounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstClientType As System.Windows.Forms.ListBox
    Friend WithEvents txtNumberOfVisits As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfVisitsStatic As System.Windows.Forms.Label
    Friend WithEvents lblClientTypeStatic As System.Windows.Forms.Label
    Friend WithEvents btnAddService As System.Windows.Forms.Button
    Friend WithEvents btnCalculateTypeDiscount As System.Windows.Forms.Button
    Friend WithEvents btnCloseDiscounts As System.Windows.Forms.Button
    Friend WithEvents lblVisitDiscountAmountStatic As System.Windows.Forms.Label
    Friend WithEvents lblVisitDiscount As System.Windows.Forms.Label
    Friend WithEvents lblClientTypeDiscount As System.Windows.Forms.Label
    Friend WithEvents lblClientTypeDiscountStatic As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class
