<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="audit_tool_my_phase1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <link href="assets/css/login.css" rel="stylesheet" />
</head>
<body>
    <div class="loginbox">
        <img src="assets/image/logoceridian.jpg" alt="Alternate Text" class="user" />
        <form id="form1" runat="server">
            <h2>Login Here</h2>
            <div>
                <asp:Label ID="lblid" runat="server" CssClass="lblId" Text="ID" AssociatedControlID="txtid"></asp:Label>
                <br />
                <asp:TextBox ID="txtid" runat="server" CssClass="txtid" ReadOnly="True"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvid" ControlToValidate="txtid" runat="server" ErrorMessage="Id is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lblrole" runat="server" CssClass="lblrole" Text="Choose Role" AssociatedControlID="ddlrole"></asp:Label>
                <br />
                <br />
                <asp:DropDownList ID="ddlrole" runat="server" CssClass="ddlrole" BackColor="#669999">
                    <asp:ListItem Selected="True" Value="-1">Select</asp:ListItem>
                    <asp:ListItem Value="1">IC</asp:ListItem>
                    <asp:ListItem Value="2">SO</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator ID="rfvrole" runat="server" InitialValue="-1" ControlToValidate="ddlrole" ErrorMessage="Select a role" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="lblstatus" runat="server" ForeColor="Red"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#66FFFF" Visible="False">HyperLink</asp:HyperLink>
                <br />
                <br />
                <asp:Button ID="btnlogin" runat="server" CssClass="btnsubmit" Text="Login" />

            </div>
        </form>
    </div>
</body>
</html>
