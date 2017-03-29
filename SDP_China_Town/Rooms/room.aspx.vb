Public Class room
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

End Class