<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assign3.aspx.cs" Inherits="Assign3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 2 - DB Interface Part 2</title>
    <style>
        .invoice {
            border: 1px solid black;
            margin: 10px;
            padding: 10px;
        }
        .customer {
            border: 1px solid black;
            padding: 10px;
            display: inline-block;
        }
        .details {
            border: 1px solid black;
            padding: 10px;
            display: inline-block;
            float: right;
        }
        table, td, th {
            font-weight: normal;
            border: 1px solid black;
            padding: 5px;
        }
        .finalRow {
            border: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <asp:Panel ID="pnlContent" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
