Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Loginpage.position = "M" Then
            Panel1.Visible = False
        ElseIf Loginpage.position = "S" Then
            Panel2.Visible = False
        End If

    End Sub

End Class