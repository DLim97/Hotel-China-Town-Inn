Public Class Mainpage2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Loginpage.log = "Logged" Then
            Loginpage.log = "Out"

        Else
            mdreservations.Visible = False
            logout.Visible = False
            login.Visible = True
        End If
    End Sub

End Class