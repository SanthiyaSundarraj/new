﻿Imports MySql.Data.MySqlClient
Public Class signup
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub SIGNINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNINToolStripMenuItem.Click
        signin.Show()
    End Sub

    Private Sub SIGNUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIGNUPToolStripMenuItem.Click
        Me.Show()
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

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into username (USERNAME,NAME,PASSWORD,PET,SPORT,ADDRESS,PHONE) values ('" & user.Text & "','" & cusname.Text & "','" & pass1.Text & "','" & pet.Text & "','" & sport.Text & "','" & address.Text & "','" & phone.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

            MessageBox.Show("you are successfully added..")
            MysqlConn.Close()
            signin.Show()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class