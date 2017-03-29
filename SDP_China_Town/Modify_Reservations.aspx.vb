Imports System.Data.OleDb
Imports System.Drawing

Public Class WebForm9
    Inherits System.Web.UI.Page
    Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
    Dim con As New OleDbConnection(connect)
    Dim diff As Integer
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
            txtType.Text = dr.Item("RoomType")
            txtCheckin.Text = dr.Item("CheckIn")
            txtCheckout.Text = dr.Item("CheckOut")
            btnSubmit.Enabled = True

        End While
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim query1 As String = ("UPDATE Reservation SET MemName = '" & txtName.Text & "' WHERE ReservationID = @id")
        Dim cmd1 As New OleDbCommand(query1, con)



        cmd1.Parameters.AddWithValue("id", txtSearchID.Text)

        cmd1.ExecuteNonQuery()
        con.Close()
        MsgBox("Modify Successful")


    End Sub
End Class