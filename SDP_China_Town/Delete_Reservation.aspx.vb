Imports System.Data.OleDb

Public Class Delete_Reservation
    Inherits System.Web.UI.Page
    Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
    Dim con As New OleDbConnection(connect)


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

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim a As Integer
        a = txtSearchID.Text


        Dim query As String = ("SELECT * FROM Reservation WHERE ReservationID = " & a & "")
        Dim cmd As New OleDbCommand(query, con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        While dr.Read
            txtName.Text = dr.Item("MemName")
            txtTypeofSuite.Text = dr.Item("RoomType")
            txtCheckIn.Text = dr.Item("CheckIn")
            txtCheckOut.Text = dr.Item("CheckOut")
            btnSubmit.Enabled = True

        End While
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim query1 As String = ("DELETE FROM Reservation WHERE ReservationID = @id")
        Dim cmd1 As New OleDbCommand(query1, con)

        cmd1.Parameters.AddWithValue("id", txtSearchID.Text)
        cmd1.ExecuteNonQuery()

        MsgBox("Delete Successful")

        txtSearchID.Text = ""
        txtTypeofSuite.Text = ""
        txtCheckIn.Text = ""
        txtCheckOut.Text = ""
        txtName.Text = ""

    End Sub
End Class