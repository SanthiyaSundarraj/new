﻿Imports MySql.Data.MySqlClient
Public Class writefeed
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
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


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Thank you for purchasing...")
        mainformus.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim READER As MySqlDataReader
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into feedback (USERNAME,COMMENT,RATE) values ('" & signin.Username.Text & "','" & feed.Text & "','" & rate.Value & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Thank you For your feedback..")
            mainformus.Show()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class