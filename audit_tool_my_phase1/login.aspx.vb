Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtid.Text = SystemInformation.UserDomainName + "\" + SystemInformation.UserName
    End Sub

    Protected Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim sqlConn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Phase2ConString").ConnectionString)
        Dim sql As String = "SELECT * FROM tbl_test WHERE DomainId=@DomainId"
        Dim cmd As New SqlCommand(sql, sqlConn)

        cmd.Parameters.AddWithValue("@DomainId", txtid.Text)

        Dim myReader As SqlDataReader
        sqlConn.Open()
        myReader = cmd.ExecuteReader
        While myReader.Read
            'session variable will store those values throughout the entire session
            Session("Username") = myReader("Username")
            Session("role") = ddlrole.SelectedItem.ToString()
        End While

        If myReader.HasRows Then
            Response.Redirect("createconfig.aspx")
            sqlConn.Close()
        Else
            HyperLink1.Visible = True
            HyperLink1.Text = "You are not registered yet!"
            HyperLink1.NavigateUrl = "register2.aspx"
            'lblstatus.Text = "You are not registered yet!"
        End If
    End Sub
End Class