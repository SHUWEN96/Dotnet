<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 27px;
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p style="height: 22px; ">
            hello world</p>
        <p style="height: 22px; width: 180px">
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" ViewStateMode="Enabled"></asp:TextBox>
        </p>
        
        <asp:TextBox ID="TextBox2" runat="server" Width="158px"></asp:TextBox>
        
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
        </p>
    </form>
</body>
</html>
