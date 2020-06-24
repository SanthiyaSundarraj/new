<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchase
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
        Me.avail = New System.Windows.Forms.DataGridView()
        Me.billtab = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.pq = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pri = New System.Windows.Forms.TextBox()
        Me.medi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.avail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billtab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LOGINToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.FEEDBACKToolStripMenuItem, Me.CONTACTUSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1155, 24)
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
        'avail
        '
        Me.avail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.avail.Location = New System.Drawing.Point(25, 44)
        Me.avail.Name = "avail"
        Me.avail.Size = New System.Drawing.Size(364, 446)
        Me.avail.TabIndex = 15
        '
        'billtab
        '
        Me.billtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billtab.Location = New System.Drawing.Point(779, 44)
        Me.billtab.Name = "billtab"
        Me.billtab.Size = New System.Drawing.Size(364, 446)
        Me.billtab.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id of the medicine : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Quantity Needed : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add To Bill"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(585, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Delete From Bill"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(489, 393)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Calculate Total Bill"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pid
        '
        Me.pid.Location = New System.Drawing.Point(596, 177)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(100, 22)
        Me.pid.TabIndex = 22
        '
        'pq
        '
        Me.pq.Location = New System.Drawing.Point(596, 224)
        Me.pq.Name = "pq"
        Me.pq.Size = New System.Drawing.Size(100, 22)
        Me.pq.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 32)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "By clicking the calculate total bill button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " you will be directed to a final bil" &
    "l"
        '
        'pri
        '
        Me.pri.Location = New System.Drawing.Point(12, 483)
        Me.pri.Name = "pri"
        Me.pri.Size = New System.Drawing.Size(10, 22)
        Me.pri.TabIndex = 25
        '
        'medi
        '
        Me.medi.Location = New System.Drawing.Point(0, 483)
        Me.medi.Name = "medi"
        Me.medi.Size = New System.Drawing.Size(10, 22)
        Me.medi.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(435, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 32)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Fill the id and quantity of the medicine " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    to be purchased"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(599, 438)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(49, 16)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BACK"
        '
        'purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.medicine.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 502)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.medi)
        Me.Controls.Add(Me.pri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pq)
        Me.Controls.Add(Me.pid)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.billtab)
        Me.Controls.Add(Me.avail)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "purchase"
        Me.Text = "purchase"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.avail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billtab, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents avail As DataGridView
    Friend WithEvents billtab As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pid As TextBox
    Friend WithEvents pq As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pri As TextBox
    Friend WithEvents medi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
