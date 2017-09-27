<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Name <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" /> 
            <label id="lblInsertSuccess" runat="server">Successfully Inserted!</label>
            <br />
            <asp:Button ID="btnTruncate" Text="Truncate Table" runat="server" OnClick="btnTruncate_Click" />
            <label id="lblTruncateSuccess" runat="server">Table Successfully Truncated!</label>
        </div>
    </form>
    
</body>
</html>
