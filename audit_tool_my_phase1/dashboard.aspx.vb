Public Class dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("Username")) Then
            Response.Redirect("login.aspx")
        Else
            Dim uname As String
            Dim role As String
            uname = Session("Username")
            role = Session("role")
            lblMsg.Text = "Welcome to Audit Dashboard " & uname & " " & role
        End If
    End Sub

End Class