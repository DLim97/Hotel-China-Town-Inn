Imports System.Data.OleDb
Imports System.Drawing


Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
    Dim con As New OleDbConnection(connect)


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String
        Dim ic As Integer
        Dim suite As String
        Dim cin As Date = Calendar1.TodaysDate
        Dim cout As Date = Calendar1.SelectedDate
        Dim ranum As New Random
        Dim value As Integer
        Dim type As String

        value = ranum.Next(10000, 100000)
        name = TextBox1.Text
        ic = TextBox2.Text
        suite = DropDownList1.SelectedItem.ToString
        type = DropDownList2.SelectedItem.ToString

        checkin(value, cin, cout, suite, name, ic, type)
    End Sub
    Private Sub checkin(ByVal value As String, ByVal cin As String, ByVal cout As String, ByVal suite As String, ByVal name As String, ByVal ic As String, ByVal type As String)
        Dim query As String = ("INSERT INTO CheckInOut (CheckInOutID , CheckIn, CheckOut, CustomerID, RoomID, ReservationID, CustomerName, ICNumber, Status, RoomType) VALUES ( @value, @cin, @cout, NULL, @suite, NULL, @name, @ic, 'NEW', @type)")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("value", value)
        cmd.Parameters.AddWithValue("cin", cin)
        cmd.Parameters.AddWithValue("cout", cout)
        cmd.Parameters.AddWithValue("suite", type)
        cmd.Parameters.AddWithValue("name", name)
        cmd.Parameters.AddWithValue("ic", ic)
        cmd.Parameters.AddWithValue("type", suite)
        cmd.ExecuteNonQuery()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        con.Open()

        TextBox3.Text = Calendar1.TodaysDate
        TextBox3.Enabled = False

        Dim query As String = ("SELECT * FROM RoomDetails WHERE RoomType = '" & DropDownList1.SelectedItem.ToString & "'")

        Dim cmd As New OleDbCommand(query, con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        DropDownList2.Items.Clear()

        While dr.Read
            DropDownList2.Items.Add(dr.Item("RoomID"))
        End While

    End Sub

    Private Sub Calendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles Calendar1.DayRender
        If e.Day.Date >= Calendar1.TodaysDate And e.Day.Date <= Calendar1.SelectedDate Then
            e.Cell.BackColor = Color.LightBlue
        End If
        If e.Day.Date < Calendar1.TodaysDate Then
            e.Day.IsSelectable = False
            e.Cell.BackColor = Color.IndianRed
        End If
        Dim wcin As Date
        Dim wcout As Date

        Dim query2 As String = ("SELECT CheckIn, CheckOut FROM CheckInOut WHERE RoomType = '" & DropDownList1.SelectedItem.ToString & "'")
        Dim cmd2 As New OleDbCommand(query2, con)
        Dim rd As OleDbDataReader = cmd2.ExecuteReader
        While rd.Read
            wcin = rd.Item("CheckIn")
            wcout = rd.Item("CheckOut")
            If e.Day.Date >= wcin And e.Day.Date <= wcout Then
                e.Day.IsSelectable = False
                e.Cell.BackColor = Color.Red
            End If
        End While

    End Sub
End Class