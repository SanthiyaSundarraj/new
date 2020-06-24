<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class writefeed
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
        Me.feed = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rate = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.rate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LOGINToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.FEEDBACKToolStripMenuItem, Me.CONTACTUSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(495, 24)
        Me.MenuStrip1.TabIndex = 16
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
        'feed
        '
        Me.feed.Location = New System.Drawing.Point(110, 79)
        Me.feed.Name = "feed"
        Me.feed.Size = New System.Drawing.Size(294, 96)
        Me.feed.TabIndex = 17
        Me.feed.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Write your feedback here : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Enter your Ratings(1 to 5) :"
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(218, 185)
        Me.rate.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(120, 22)
        Me.rate.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Submit "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(416, 33)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 16)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Skip"
        '
        'writefeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.medicine.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 246)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.feed)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "writefeed"
        Me.Text = "writefeed"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.rate, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents feed As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rate As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
