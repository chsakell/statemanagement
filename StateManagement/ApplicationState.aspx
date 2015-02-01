<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="StateManagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span style="color: red; font-size: large">ApplicationState Example</span>
            <fieldset style="background-color: ghostwhite;width:283px">
                <legend>Entries</legend>
                <table>
                    <tr>
                        <th>Entry Name</th>
                        <th>Created At</th>
                    </tr>
                    <asp:Repeater ID="Repeater1" runat="server" ItemType="StateManagement.Model.Entry">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Name") %></td>
                                <td><%# Eval("EntryEnteredAt") %></td>
                            </tr>

                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                <br />
                <asp:Button ID="btnAddEntry" runat="server" Text="Add New Entry" OnClick="btnAddEntry_Click" />
            </fieldset>
    </div>
    </form>
</body>
</html>
