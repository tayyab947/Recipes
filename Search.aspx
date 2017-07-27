<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="KitchenIn.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Search Taste</h1>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp; OR&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View All Recipes" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:HyperLinkField DataNavigateUrlFields="Srid" DataNavigateUrlFormatString="Receipe.aspx?Srid=[0]" HeaderText="Taste" Text="Receipe" />
                </Columns>
            </asp:GridView>
        </p>
    </div>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Profile" />
    </form>
</body>
</html>
