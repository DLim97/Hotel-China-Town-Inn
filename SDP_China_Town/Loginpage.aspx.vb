﻿Imports System.Data.OleDb
Public Class Loginpage
    Inherits System.Web.UI.Page
    Public Shared name As String
    Public Shared position As String
    Public Shared log As String

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.Jet.OleDb.4.0;" & "Data Source=|DataDirectory|Hote.mdb"
        Dim query As String
        Dim query1 As String
        query = ("SELECT Email, Password, MemName FROM CustomerDetails where Email = '" & TextBox1.Text & "';")
        query1 = ("SELECT StaffID, Password, pp FROM StaffDetails where StaffID = '" & TextBox1.Text & "';")
        Dim result As Boolean
        Dim result1 As Boolean
        Dim con As New OleDbConnection(connect)
        Dim cmd As New OleDbCommand(query, con)
        Dim cmd1 As New OleDbCommand(query1, con)

        result = False
        result1 = False

        con.Open()

        Dim rd As OleDbDataReader = cmd.ExecuteReader
        Dim dr As OleDbDataReader = cmd1.ExecuteReader

        While rd.Read
            If rd.Item("Email") = TextBox1.Text And rd.Item("Password") = TextBox2.Text Then
                name = rd.Item("MemName")
                result = True
                log = "Logged"
            End If
        End While
        While dr.Read
            If dr.Item("StaffID") = TextBox1.Text And dr.Item("Password") = TextBox2.Text Then
                result1 = True
            End If
            If dr.Item("pp") = "Manager" Then
                position = "M"
            ElseIf dr.Item("pp") = "Staff" Then
                position = "S"
            End If
        End While

        If (result = True) Then
            Response.Redirect("Mainpage.aspx")
        ElseIf (result1 = True) Then
            Response.Redirect("Staff_Manager/Add_Rooms.aspx")
        Else
            Label3.Text = "The Email or Password you entered is incorrect."
            TextBox1.Text = String.Empty
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Mainpage.aspx")
    End Sub
End Class
