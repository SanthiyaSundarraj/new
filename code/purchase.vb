Imports MySql.Data.MySqlClient
Public Class purchase
    Dim conne As MySqlConnection
    Dim reader As MySqlDataReader
    Dim insertstring As String
    Dim P As Integer
    Dim med As String
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
    Dim conn As MySqlConnection
    Dim Str As String
    Public Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adding()
    End Sub
    Function adding()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            '            Dim READER As MySqlDataReader
            Str = “SELECT * FROM stock”
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, “stock”)
            avail.DataSource = ds.Tables(“stock”)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            '            Dim READER As MySqlDataReader
            Str = “SELECT * FROM bill”
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, “bill”)
            billtab.DataSource = ds.Tables(“bill”)
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Function

    Dim MysqlConn As MySqlConnection
    'Dim Command As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Command As MySqlCommand
        conne = New MySqlConnection
        Dim reader As MySqlDataReader
        conne.ConnectionString = "server=localhost;userid=root;password=;database=login;"
        Try
            conne.open()
            Dim query As String
            Dim price As Integer
            query = "select NAME,PRICE from stock where CODE='" & pid.Text & "'"
            Command = New MySqlCommand(query, conne)
            reader = Command.ExecuteReader
            While reader.Read
                pri.Text = reader("PRICE")
                price = Integer.Parse(pri.Text) * Integer.Parse(pq.Text)
                pri.Text = price.ToString()
                medi.Text = reader("NAME")
            End While
            conn.Close()
        Catch ex As MySqlException

            'exception if any
            MessageBox.Show(ex.Message)
        End Try


        MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
            Dim READI As MySqlDataReader
            Dim Comm As MySqlCommand
            MysqlConn.Open()
        Try
            Dim Que As String
            Que = "insert into bill (ID,NAME,QUANTITY,PRICE) values ('" & pid.Text & "','" & medi.Text & "','" & pq.Text & "','" & pri.Text & "')"
            Comm = New MySqlCommand(Que, MysqlConn)
            READI = Comm.ExecuteReader

            MessageBox.Show("Item Added")
            MysqlConn.Close()

        Catch ex As MySqlException

            'exception if any
            MessageBox.Show(ex.Message)
        Finally
            pid.Text = ""
            pq.Text = ""
        End Try
        adding()
        'purchase.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=login"
        Dim READI As MySqlDataReader
        Dim Comm As MySqlCommand
        MysqlConn.Open()
        Try
            Dim Que As String
            Que = "DELETE FROM `bill` WHERE ID='" & pid.Text & "'"
            Comm = New MySqlCommand(Que, MysqlConn)
            READI = Comm.ExecuteReader

            MessageBox.Show("Item Removed")
            MysqlConn.Close()

        Catch ex As MySqlException

            'exception if any
            MessageBox.Show(ex.Message)
        Finally
            pid.Text = ""
            pq.Text = ""
        End Try
        adding()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        billing.show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        mainformus.Show()
    End Sub
End Class