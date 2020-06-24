<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewmed
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIGNINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIGNUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFERSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELIVERYLOCATIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEEDBACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWFEEDBACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.s1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LOGINToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.FEEDBACKToolStripMenuItem, Me.CONTACTUSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "HOME"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SIGNINToolStripMenuItem, Me.SIGNUPToolStripMenuItem, Me.ADMINToolStripMenuItem})
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'SIGNINToolStripMenuItem
        '
        Me.SIGNINToolStripMenuItem.Name = "SIGNINToolStripMenuItem"
        Me.SIGNINToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SIGNINToolStripMenuItem.Text = "SIGN IN"
        '
        'SIGNUPToolStripMenuItem
        '
        Me.SIGNUPToolStripMenuItem.Name = "SIGNUPToolStripMenuItem"
        Me.SIGNUPToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SIGNUPToolStripMenuItem.Text = "SIGN UP"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OFFERSToolStripMenuItem, Me.DELIVERYLOCATIONSToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'OFFERSToolStripMenuItem
        '
        Me.OFFERSToolStripMenuItem.Name = "OFFERSToolStripMenuItem"
        Me.OFFERSToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OFFERSToolStripMenuItem.Text = "OFFERS"
        '
        'DELIVERYLOCATIONSToolStripMenuItem
        '
        Me.DELIVERYLOCATIONSToolStripMenuItem.Name = "DELIVERYLOCATIONSToolStripMenuItem"
        Me.DELIVERYLOCATIONSToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DELIVERYLOCATIONSToolStripMenuItem.Text = "DELIVERY LOCATIONS"
        '
        'FEEDBACKToolStripMenuItem
        '
        Me.FEEDBACKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VIEWFEEDBACKToolStripMenuItem})
        Me.FEEDBACKToolStripMenuItem.Name = "FEEDBACKToolStripMenuItem"
        Me.FEEDBACKToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FEEDBACKToolStripMenuItem.Text = "FEEDBACK"
        '
        'VIEWFEEDBACKToolStripMenuItem
        '
        Me.VIEWFEEDBACKToolStripMenuItem.Name = "VIEWFEEDBACKToolStripMenuItem"
        Me.VIEWFEEDBACKToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.VIEWFEEDBACKToolStripMenuItem.Text = "VIEW FEEDBACK"
        '
        'CONTACTUSToolStripMenuItem
        '
        Me.CONTACTUSToolStripMenuItem.Name = "CONTACTUSToolStripMenuItem"
        Me.CONTACTUSToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.CONTACTUSToolStripMenuItem.Text = "CONTACT US"
        '
        's1
        '
        Me.s1.Location = New System.Drawing.Point(162, 235)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(226, 23)
        Me.s1.TabIndex = 26
        Me.s1.Text = "Check Availablity"
        Me.s1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "[OR]"
        '
        'n
        '
        Me.n.Location = New System.Drawing.Point(288, 188)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(141, 22)
        Me.n.TabIndex = 24
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(288, 93)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(141, 22)
        Me.id.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Enter the name of the medicine : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Enter the Id of the medicine : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fill any one of the fields to check the availablity "
        '
        'viewmed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.medicine.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 263)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "viewmed"
        Me.Text = "viewmed"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIGNINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIGNUPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFERSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELIVERYLOCATIONSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FEEDBACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWFEEDBACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTACTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents s1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents n As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
