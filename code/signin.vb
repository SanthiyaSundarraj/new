Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class signin
    ' Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim insertstring As String
    Private Sub SIGNINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNINToolStripMenuItem.Click
        Me.Show()
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
    ' OK button   
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        ConnectToSQL()

    End Sub
    Private Sub ConnectToSQL()

        conn = New MySqlConnection
        Dim reader As MySqlDataReader
        conn.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conn.Open()
            Dim query As String
            query = "select * from username where USERNAME='" & Username.Text & "' and PASSWORD='" & Password.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("SuccessFully logged in..")
                Me.Hide()
                mainformus.Show()
            ElseIf count > 1 Then
                MessageBox.Show("username and password are incorrect")
            Else
                MessageBox.Show("username and password are incorrect")
            End If
            conn.Close()
        Catch ex As MySqlException

            'exception if any
        Finally

        End Try

    End Sub
    ' Cancel button   
    Private Sub Cancel_Click(ByVal sender As System.Object,
                        ByVal e As System.EventArgs) Handles Cancel.Click
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        signup.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgotuse.Show()
    End Sub

End Class