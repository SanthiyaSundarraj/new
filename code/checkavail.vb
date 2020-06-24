Imports MySql.Data.MySqlClient
Public Class checkavail
    ' Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String
    'Public Class checkavail
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

    Private Sub S1_Click(sender As Object, e As EventArgs) Handles s1.Click
        conn = New MySqlConnection
        Dim reader As MySqlDataReader
        conn.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conn.Open()
            Dim query As String
            query = "select QUANTITY from stock where CODE='" & id.Text & "' or NAME='" & n.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                If reader("QUANTITY") > 0 Then

                    MessageBox.Show("Medicine is available..")
                Else
                    MessageBox.Show("Medicine is not available..")
                End If
            End While
            conn.Close()
        Catch ex As MySqlException

            'exception if any
        Finally

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        purchase.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
        mainformus.Show()
    End Sub

    Private Sub Checkavail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class