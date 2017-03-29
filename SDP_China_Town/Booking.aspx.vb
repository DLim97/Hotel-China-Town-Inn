Imports System.Data.OleDb
Public Class Booking
    Inherits System.Web.UI.Page
    Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
    Dim con As New OleDbConnection(connect)
    Dim ran As New Random
    Dim value As Integer = ran.Next(10000, 100000)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.Open()
        If Loginpage.log = "Logged" Then
            mdreservations.Visible = True
            logout.Visible = True
            login.Visible = False

        Else
            mdreservations.Visible = False
            logout.Visible = False
            login.Visible = True
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim query As String = ("INSERT INTO Reservation(ReservationID, ReservationDate, Occupancy, CheckIn, ICNumber, CheckOut, RoomType, MemName) VALUES (@a, @b, @c, @d, @e, @f, @g, @h)")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@a", value)
        cmd.Parameters.AddWithValue("@b", Date.Today)
        cmd.Parameters.AddWithValue("@c", txtOccupants.Text)
        cmd.Parameters.AddWithValue("@d", date_timepicker_start.Text)
        cmd.Parameters.AddWithValue("@e", txtICnumber.Text)
        cmd.Parameters.AddWithValue("@f", date_timepicker_end.Text)
        cmd.Parameters.AddWithValue("@g", DropDownList1.SelectedItem.ToString)
        cmd.Parameters.AddWithValue("@h", Loginpage.name)
        cmd.ExecuteNonQuery()

        Dim v As Integer
        Dim total As Integer
        Dim days As Integer
        Dim ran As New Random
        Dim value1 As Integer = ran.Next(10000, 100000)
        Dim amount As Integer


        If DropDownList1.SelectedItem.ToString = "Presidential" Then
            v = 50
        ElseIf DropDownList1.SelectedItem.ToString = "Luxury" Then
            v = 30
        Else
            v = 20
        End If

        Dim s As Date
        Dim game As Date
        game = DateTime.Parse(date_timepicker_end.Text)
        s = DateTime.Parse(date_timepicker_start.Text)

        days = DateDiff(DateInterval.Day, s, game)
        total = v * days

        amount = txtConfirmAmount.Text

        txtAmount.Text = total

        If total = amount Then
            Dim query1 As String = ("INSERT INTO Trans(TransactionID, CustomerIC, Duit, PayDay) VALUES (@a, @b, @c, @d)")
            Dim cmd1 As New OleDbCommand(query1, con)
            cmd1.Parameters.AddWithValue("@a", value1)
            cmd1.Parameters.AddWithValue("@b", txtICnumber.Text)
            cmd1.Parameters.AddWithValue("@a", total)
            cmd1.Parameters.AddWithValue("@a", Date.Today)
            cmd1.ExecuteNonQuery()
            MsgBox("Your reservation ID = " + value.ToString)
        Else
            MsgBox("Please Pay the exact amount")
        End If
    End Sub
End Class