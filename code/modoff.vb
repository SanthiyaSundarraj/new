Imports MySql.Data.MySqlClient
Public Class modoff
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
        offer.Show()
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
    Dim MysqlConn As MySqlConnection
    Private Sub Modoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim MysqlConn As MySqlConnection
        Dim Command As MySqlCommand
        conne = New MySqlConnection
        Dim reader As MySqlDataReader
        conne.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conne.Open()
            Dim query As String
            query = "select * from offer where 1"
            Command = New MySqlCommand(query, conne)
            reader = Command.ExecuteReader
            While reader.Read
                ae.Text = reader("OFFER")

            End While
            conne.Close()
        Catch ex As MySqlException

            'exception if any
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        home.Show()
    End Sub
    'Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim ABC As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Dim del As String
            del = "DELETE FROM offer WHERE 1"
            ABC = New MySqlCommand(del, MysqlConn)
            READER = COMMAND.ExecuteReader
            Query = "insert into offer (OFFER) values ('" & newof.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

            MessageBox.Show("Offers udated")
            mainformad.Show()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        mainformad.Show()
    End Sub
End Class