Imports System.Data.OleDb
Public Class WebForm10
    Inherits System.Web.UI.Page

    Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
    Dim con As New OleDbConnection(connect)
    Dim diff As Integer

    Dim cin As Date
    Dim cout As Date
    Dim d As Integer
    Dim type As String
    Dim id As Integer



    Private Sub Staff_Manager_Default_Load(sender As Object, e As EventArgs) Handles Me.Load
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query1 As String = ("SELECT * FROM CheckInOut WHERE ICNumber = " & TextBox2.Text & "")
        Dim da As New OleDbDataAdapter(query1, con)
        Dim cmd As New OleDbCommand(query1, con)
        Dim dt As New DataTable
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            cin = dr.Item("CheckIn")
            cout = dr.Item("CheckOut")
            type = dr.Item("RoomID")
            id = dr.Item("CheckInOutID")
        End While
        diff = DateDiff(DateInterval.Day, cin, cout)

        If type = "Luxury" Then
            d = diff * 20
        ElseIf type = "Presidential" Then
            d = diff * 30
        Else
            d = diff * 10
        End If
        Label1.Text = d
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ran As New Random
        Dim value As Integer
        Dim ic As Integer
        Dim query1 As String = ("SELECT * FROM CheckInOut WHERE ICNumber = " & TextBox2.Text & "")
        Dim da As New OleDbDataAdapter(query1, con)
        Dim cmd As New OleDbCommand(query1, con)
        Dim dt As New DataTable
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            cin = dr.Item("CheckIn")
            cout = dr.Item("CheckOut")
            type = dr.Item("RoomID")
            id = dr.Item("CheckInOutID")
            ic = dr.Item("ICNumber")
        End While
        diff = DateDiff(DateInterval.Day, cin, cout)
        If type = "Presidential" Then
            d = diff * 50
        ElseIf type = "Luxury" Then
            d = diff * 30
        Else
            d = diff * 20
        End If

        value = ran.Next(10000, 100000)
        Dim query2 As String = ("INSERT INTO Trans (TransactionID, CustomerIC, Duit, PayDay, CheckInOutID, RoomID) VALUES (@a, @z, @b, @c, @d, @e)")
        Dim cmd1 As New OleDbCommand(query2, con)
        cmd1.Parameters.AddWithValue("a", value)
        cmd1.Parameters.AddWithValue("z", ic)
        cmd1.Parameters.AddWithValue("b", d)
        cmd1.Parameters.AddWithValue("c", Date.Today)
        cmd1.Parameters.AddWithValue("d", id)
        cmd1.Parameters.AddWithValue("e", type)
        cmd1.ExecuteNonQuery()

    End Sub
End Class