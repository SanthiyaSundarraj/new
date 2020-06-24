Imports MySql.Data.MySqlClient
Public Class offer
    Dim conne As MySqlConnection
    Dim reader As MySqlDataReader
    Dim insertstring As String
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
        Me.Show()
    End Sub

    Private Sub DELIVERYLOCATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELIVERYLOCATIONSToolStripMenuItem.Click
        delivery.Show()
    End Sub

    Private Sub VIEWFEEDBACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWFEEDBACKToolStripMenuItem.Click
        viewfeedback.Show()
    End Sub

    Private Sub CONTACTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTUSToolStripMenuItem.Click
        contact.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        home.Show()
    End Sub

    Private Sub Offer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim MysqlConn As MySqlConnection
        Dim Command As MySqlCommand
        conne = New MySqlConnection
        Dim reader As MySqlDataReader
        conne.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conne.open()
            Dim query As String
            query = "select * from offer where 1"
            Command = New MySqlCommand(query, conne)
            reader = Command.ExecuteReader
            While reader.Read
                off.Text = reader("OFFER")

            End While
            conne.Close()
        Catch ex As MySqlException

            'exception if any
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class