Imports MySql.Data.MySqlClient
Public Class forgotadmin
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        home.Show()
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        conn = New MySqlConnection
        Dim reader As MySqlDataReader
        conn.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conn.Open()
            Dim query As String
            query = "select * from admin where USERNAME='" & Username.Text & "' and SPORT='" & sport.Text & "' And PET='" & pet.Text & "' "
            command = New MySqlCommand(query, conn)
            reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("SuccessFully logged in..")
                Me.Hide()
                newpassuser.Show()
            ElseIf count > 1 Then
                MessageBox.Show("INVALID ANSWERS")
            Else
                MessageBox.Show("INVALID ANSWERS")
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
        sport.Text = ""
        pet.Text = ""

    End Sub
End Class