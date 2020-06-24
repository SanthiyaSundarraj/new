
Imports MySql.Data.MySqlClient
    Public Class viewfeedback
        Dim conne As MySqlConnection
        Dim reader As MySqlDataReader
    Dim insertstring As String
    Dim conn As MySqlConnection
    Dim Str As String
    Private Sub SIGNINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNINToolStripMenuItem.Click
            signin.Show()
        End Sub

        Private Sub SIGNUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNUPToolStripMenuItem.Click
            signup.Show()
        End Sub

        Private Sub ADMINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINToolStripMenuItem.Click
            admin.Show()
        End Sub

        Private Sub OFFERSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFERSToolStripMenuItem.Click
            offer.Show()
        End Sub

        Private Sub DELIVERYLOCATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELIVERYLOCATIONSToolStripMenuItem.Click
            delivery.Show()
        End Sub

        Private Sub VIEWFEEDBACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWFEEDBACKToolStripMenuItem.Click
            Me.Show()
        End Sub

        Private Sub CONTACTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTUSToolStripMenuItem.Click
            contact.Show()
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
            home.Show()
        End Sub

        Private Sub Viewfeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                conn = New MySqlConnection
                conn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            '            Dim READER As MySqlDataReader
            Str = “SELECT * FROM feedback”
            conn.Open()
                Dim Search As New MySqlDataAdapter(Str, conn)
                Dim ds As DataSet = New DataSet
            Search.Fill(ds, “feedback”)
            fee.DataSource = ds.Tables(“feedback”)
            conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End Sub
    End Class