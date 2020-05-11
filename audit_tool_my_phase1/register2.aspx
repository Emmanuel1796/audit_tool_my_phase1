<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="register2.aspx.vb" Inherits="audit_tool_my_phase1.register2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link href="assets/css/register.css" rel="stylesheet" />
</head>
<body>
    <div class="loginbox">
        <img src="assets/image/logoceridian.jpg" alt="Alternate Text" class="user" />
        <form id="form1" runat="server">
             <h2>Sign In Here</h2>
            <div>
                <asp:Label ID="lblId" runat="server" CssClass="lblId" Text="ID" AssociatedControlID="txtid"></asp:Label>
                <br />
                <asp:TextBox ID="txtid" runat="server" CssClass="txtid" ReadOnly="True"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvid" runat="server" ControlToValidate="txtid" ErrorMessage="Id is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="lblName" runat="server" CssClass="lblName" Text="Username" AssociatedControlID="txtName"></asp:Label>
                <br />
                <asp:TextBox ID="txtName" CssClass="txtName" runat="server" placeholder="Enter Username"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvusername" runat="server" ControlToValidate="txtName" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator><br />
                <asp:RegularExpressionValidator ID="revusername" runat="server" ControlToValidate="txtName" ValidationExpression="[A-Za-z][A-Za-z0-9._]{5,14}" ErrorMessage="Username must be between 6 to 15 characters" ForeColor="Red"></asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="lblEmail" runat="server" CssClass="lblEmail" Text="Email" AssociatedControlID="txtEmail"></asp:Label>
                <br />
                <asp:TextBox ID="txtEmail" CssClass="txtEmail" runat="server" placeholder="Enter Email"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvemail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator><br />
                <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Invalid Email Address" ForeColor="Red"></asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="lblstatus" runat="server" ForeColor="Red"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Aqua" Visible="False">[HyperLink1]</asp:HyperLink>
                <br />
                <asp:Button ID="btnRegister" runat="server" CssClass="btnsubmit" Text="Register Me" />
                <br />
                <br />
            </div>
        </form>
    </div>
</body>
</html>
