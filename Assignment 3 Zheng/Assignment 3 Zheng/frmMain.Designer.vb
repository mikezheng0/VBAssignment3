<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HairDresserSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyDiscountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstHairAndServices = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblPriceStatic = New System.Windows.Forms.Label()
        Me.lblHairdresserAndServiceStatic = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.lblPriceStatic2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblVisitDiscount = New System.Windows.Forms.Label()
        Me.lblVisitDiscountStatic = New System.Windows.Forms.Label()
        Me.lblClientTypeDiscount = New System.Windows.Forms.Label()
        Me.lblClientTypeDiscountStatic = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblTotalPriceStatic = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HairDresserSelectionToolStripMenuItem, Me.ServiceSelectionToolStripMenuItem, Me.ApplyDiscountsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HairDresserSelectionToolStripMenuItem
        '
        Me.HairDresserSelectionToolStripMenuItem.Name = "HairDresserSelectionToolStripMenuItem"
        Me.HairDresserSelectionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.HairDresserSelectionToolStripMenuItem.Text = "Hairdresser Selection"
        '
        'ServiceSelectionToolStripMenuItem
        '
        Me.ServiceSelectionToolStripMenuItem.Name = "ServiceSelectionToolStripMenuItem"
        Me.ServiceSelectionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ServiceSelectionToolStripMenuItem.Text = "Service Selection"
        '
        'ApplyDiscountsToolStripMenuItem
        '
        Me.ApplyDiscountsToolStripMenuItem.Name = "ApplyDiscountsToolStripMenuItem"
        Me.ApplyDiscountsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ApplyDiscountsToolStripMenuItem.Text = "Apply Discounts"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "He&lp"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'lstHairAndServices
        '
        Me.lstHairAndServices.FormattingEnabled = True
        Me.lstHairAndServices.Location = New System.Drawing.Point(20, 53)
        Me.lstHairAndServices.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstHairAndServices.Name = "lstHairAndServices"
        Me.lstHairAndServices.Size = New System.Drawing.Size(202, 316)
        Me.lstHairAndServices.TabIndex = 1
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(239, 53)
        Me.lstPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(173, 316)
        Me.lstPrice.TabIndex = 2
        '
        'lblPriceStatic
        '
        Me.lblPriceStatic.AutoSize = True
        Me.lblPriceStatic.Location = New System.Drawing.Point(237, 37)
        Me.lblPriceStatic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceStatic.Name = "lblPriceStatic"
        Me.lblPriceStatic.Size = New System.Drawing.Size(31, 13)
        Me.lblPriceStatic.TabIndex = 3
        Me.lblPriceStatic.Text = "Price"
        '
        'lblHairdresserAndServiceStatic
        '
        Me.lblHairdresserAndServiceStatic.AutoSize = True
        Me.lblHairdresserAndServiceStatic.Location = New System.Drawing.Point(18, 37)
        Me.lblHairdresserAndServiceStatic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHairdresserAndServiceStatic.Name = "lblHairdresserAndServiceStatic"
        Me.lblHairdresserAndServiceStatic.Size = New System.Drawing.Size(125, 13)
        Me.lblHairdresserAndServiceStatic.TabIndex = 4
        Me.lblHairdresserAndServiceStatic.Text = "Hairdresser and Services"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(20, 380)
        Me.btnCalculateTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(111, 69)
        Me.btnCalculateTotal.TabIndex = 5
        Me.btnCalculateTotal.Text = "Calculate Total Price"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(155, 380)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 69)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(291, 380)
        Me.btnRemoveItem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(120, 69)
        Me.btnRemoveItem.TabIndex = 7
        Me.btnRemoveItem.Text = "Removal Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'lblPriceStatic2
        '
        Me.lblPriceStatic2.AutoSize = True
        Me.lblPriceStatic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceStatic2.Location = New System.Drawing.Point(416, 53)
        Me.lblPriceStatic2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceStatic2.Name = "lblPriceStatic2"
        Me.lblPriceStatic2.Size = New System.Drawing.Size(40, 17)
        Me.lblPriceStatic2.TabIndex = 8
        Me.lblPriceStatic2.Text = "Price"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(416, 73)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblPrice.TabIndex = 9
        Me.lblPrice.Text = "$0.00"
        '
        'lblVisitDiscount
        '
        Me.lblVisitDiscount.AutoSize = True
        Me.lblVisitDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.lblVisitDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitDiscount.Location = New System.Drawing.Point(416, 136)
        Me.lblVisitDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisitDiscount.Name = "lblVisitDiscount"
        Me.lblVisitDiscount.Size = New System.Drawing.Size(44, 17)
        Me.lblVisitDiscount.TabIndex = 11
        Me.lblVisitDiscount.Text = "$0.00"
        '
        'lblVisitDiscountStatic
        '
        Me.lblVisitDiscountStatic.AutoSize = True
        Me.lblVisitDiscountStatic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitDiscountStatic.Location = New System.Drawing.Point(416, 116)
        Me.lblVisitDiscountStatic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisitDiscountStatic.Name = "lblVisitDiscountStatic"
        Me.lblVisitDiscountStatic.Size = New System.Drawing.Size(93, 17)
        Me.lblVisitDiscountStatic.TabIndex = 10
        Me.lblVisitDiscountStatic.Text = "Visit Discount"
        '
        'lblClientTypeDiscount
        '
        Me.lblClientTypeDiscount.AutoSize = True
        Me.lblClientTypeDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.lblClientTypeDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientTypeDiscount.Location = New System.Drawing.Point(416, 211)
        Me.lblClientTypeDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientTypeDiscount.Name = "lblClientTypeDiscount"
        Me.lblClientTypeDiscount.Size = New System.Drawing.Size(44, 17)
        Me.lblClientTypeDiscount.TabIndex = 13
        Me.lblClientTypeDiscount.Text = "$0.00"
        '
        'lblClientTypeDiscountStatic
        '
        Me.lblClientTypeDiscountStatic.AutoSize = True
        Me.lblClientTypeDiscountStatic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientTypeDiscountStatic.Location = New System.Drawing.Point(416, 191)
        Me.lblClientTypeDiscountStatic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientTypeDiscountStatic.Name = "lblClientTypeDiscountStatic"
        Me.lblClientTypeDiscountStatic.Size = New System.Drawing.Size(138, 17)
        Me.lblClientTypeDiscountStatic.TabIndex = 12
        Me.lblClientTypeDiscountStatic.Text = "Client Type Discount"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(416, 281)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(44, 17)
        Me.lblTotalPrice.TabIndex = 15
        Me.lblTotalPrice.Text = "$0.00"
        '
        'lblTotalPriceStatic
        '
        Me.lblTotalPriceStatic.AutoSize = True
        Me.lblTotalPriceStatic.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceStatic.Location = New System.Drawing.Point(416, 261)
        Me.lblTotalPriceStatic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPriceStatic.Name = "lblTotalPriceStatic"
        Me.lblTotalPriceStatic.Size = New System.Drawing.Size(76, 17)
        Me.lblTotalPriceStatic.TabIndex = 14
        Me.lblTotalPriceStatic.Text = "Total Price"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 459)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotalPriceStatic)
        Me.Controls.Add(Me.lblClientTypeDiscount)
        Me.Controls.Add(Me.lblClientTypeDiscountStatic)
        Me.Controls.Add(Me.lblVisitDiscount)
        Me.Controls.Add(Me.lblVisitDiscountStatic)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblPriceStatic2)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.lblHairdresserAndServiceStatic)
        Me.Controls.Add(Me.lblPriceStatic)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstHairAndServices)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "Perfect Hair Salon"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HairDresserSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyDiscountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstHairAndServices As System.Windows.Forms.ListBox
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lblPriceStatic As System.Windows.Forms.Label
    Friend WithEvents lblHairdresserAndServiceStatic As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents lblPriceStatic2 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblVisitDiscount As System.Windows.Forms.Label
    Friend WithEvents lblVisitDiscountStatic As System.Windows.Forms.Label
    Friend WithEvents lblClientTypeDiscount As System.Windows.Forms.Label
    Friend WithEvents lblClientTypeDiscountStatic As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblTotalPriceStatic As System.Windows.Forms.Label

End Class
