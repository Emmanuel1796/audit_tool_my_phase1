Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class test_page
    Inherits System.Web.UI.Page

    'Dim sqlConn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Phase2ConString").ConnectionString)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'sqlConn.Open()
        'Dim sqlcmd As New SqlCommand("select * from tbl_test", sqlConn)
        'Dim myreader As SqlDataReader
        'myreader = sqlcmd.ExecuteReader()
        'myreader.Read()
        'If myreader.HasRows Then


        'Label1.Text = myreader.Item("Username").ToString
        'Label2.Text = myreader.Item("Email").ToString
        'Label3.Text = myreader.Item("DomainId").ToString
        'End If
        'sqlConn.Close()

        'Label4.Text = SystemInformation.UserDomainName + "\" + SystemInformation.UserName

    End Sub


End Class