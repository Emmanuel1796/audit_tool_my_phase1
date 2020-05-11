Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class register2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'will retreive the id of your laptop
        txtid.Text = SystemInformation.UserDomainName + "\" + SystemInformation.UserName

    End Sub

    Protected Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'database connection through web.config
        Dim sqlConn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Phase2ConString").ConnectionString)
        Dim sql As String = "SELECT DomainId FROM tbl_test WHERE DomainId=@DomainId"
        Dim cmd As New SqlCommand(sql, sqlConn)

        Dim sqlConn1 As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Phase2ConString").ConnectionString)
        Dim sql1 As String = "INSERT INTO tbl_test(Username, Email, DomainId) VALUES (@Username, @Email, @DomainId)"
        Dim cmd1 As New SqlCommand(sql1, sqlConn1)

        cmd.Parameters.AddWithValue("@DomainId", txtid.Text)
        Dim myReader As SqlDataReader
        sqlConn.Open()
        myReader = cmd.ExecuteReader

        If myReader.HasRows Then
            HyperLink1.Visible = True
            HyperLink1.Text = "DomainId Already Exist, login here"
            HyperLink1.NavigateUrl = "login.aspx"
            'lblstatus.Text = "DomainId Already Exist" & Hyp
            txtName.Focus()

        Else
            With cmd1.Parameters
                .AddWithValue("@Username", txtName.Text)
                .AddWithValue("@Email", txtEmail.Text)
                .AddWithValue("@DomainId", txtid.Text)
            End With
            cmd1.CommandType = CommandType.Text
            sqlConn1.Open()
            cmd1.ExecuteNonQuery()
            sqlConn1.Close()
            Response.Redirect("login.aspx?flag=true")
        End If
    End Sub
End Class