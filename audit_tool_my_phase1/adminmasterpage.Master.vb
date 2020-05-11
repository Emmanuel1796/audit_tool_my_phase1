Public Class adminmasterpage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(Session("Username")) Then
            Response.Redirect("login.aspx")
        Else
            Dim uname As String
            Dim role As String
            'retreive data stored since login
            uname = Session("Username")
            role = Session("role")
            lblusername.Text = uname
            lblrole.Text = role
        End If
    End Sub

End Class