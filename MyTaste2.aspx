<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTaste2.aspx.cs" Inherits="KitchenIn.MyTaste2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
&nbsp;</div>
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" DataKeyNames="Rid">
            <Columns>
                <asp:BoundField DataField="ing" HeaderText="ing" SortExpression="ing" />
                <asp:BoundField DataField="method" HeaderText="method" SortExpression="method" />
                <asp:BoundField DataField="Rid" HeaderText="Rid" InsertVisible="False" ReadOnly="True" SortExpression="Rid" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TestingConnectionString %>" SelectCommand="SELECT [ing], [method],[Rid] FROM [receipe] WHERE ([Rid] = @Rid)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Rid" QueryStringField="Rid" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
