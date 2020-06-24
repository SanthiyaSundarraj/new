Imports MySql.Data.MySqlClient
Public Class newpassadmin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    '  Public Class newpassadmin
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        home.Show()
    End Sub

    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        If pass1.Text = pass2.Text Then
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            Dim READER As MySqlDataReader


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE admin SET PASSWORD='" & pass1.Text & "' WHERE USERNAME= '" & Username.Text & "'"
                command = New MySqlCommand(Query, MysqlConn)
                READER = command.ExecuteReader

                MessageBox.Show("Password Updated")
                MysqlConn.Close()
                admin.Show()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        Else
            MessageBox.Show("Passwords doesnt match..")
        End If
    End Sub
End Class