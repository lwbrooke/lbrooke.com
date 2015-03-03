<%@ Page Title="" Language="C#" MasterPageFile="~/Store/StoreMaster.master" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="Store_CheckOut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" runat="Server">
    Check Out
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="Server">
    <h1>Check Out</h1>
    <asp:Panel ID="checkOutBase" runat="server" style="display: inline-block">
        <asp:Panel ID="orderSummaryPanel" runat="server">
            <h2>Order Summary</h2>
        </asp:Panel>
        <asp:Panel ID="shippingInfoPanel" runat="server">
            <h2>Shipping Information</h2>
            <ul>
                <li>
                    <asp:Label ID="Label1" runat="server" Text="Name:" />
                    <asp:TextBox ID="txtName" runat="server"/>
                    <asp:CustomValidator ID="validatorName" runat="server" ErrorMessage="" ControlToValidate="txtName" OnServerValidate="validatorName_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
                <li>
                    <asp:Label ID="Label2" runat="server" Text="Street:"/>
                    <asp:TextBox ID="txtStreet" runat="server"/>
                    <asp:CustomValidator ID="validatorStreet" runat="server" ErrorMessage="" ControlToValidate="txtStreet" OnServerValidate="validatorStreet_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
                <li>
                    <asp:Label ID="Label3" runat="server" Text="City:"/>
                    <asp:TextBox ID="txtCity" runat="server"/>
                    <asp:CustomValidator ID="validatorCity" runat="server" ErrorMessage="" ControlToValidate="txtCity" OnServerValidate="validatorCity_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
                <li>
                    <asp:Label ID="Label4" runat="server" Text="State:"/>
                    <asp:TextBox ID="txtState" runat="server" />
                    <asp:CustomValidator ID="validatorState" runat="server" ErrorMessage="" ControlToValidate="txtState" OnServerValidate="validatorState_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
                <li>
                    <asp:Label ID="Label5" runat="server" Text="Zip:" />
                    <asp:TextBox ID="txtZip" runat="server" />
                    <asp:CustomValidator ID="validatorZip" runat="server" ErrorMessage="" ControlToValidate="txtZip" OnServerValidate="validatorZip_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
                <li>
                    <asp:Label ID="Label6" runat="server" Text="Email:" />
                    <asp:TextBox ID="txtEmail" runat="server"/>
                    <asp:CustomValidator ID="validatorEmail" runat="server" ErrorMessage="" ControlToValidate="txtEmail" OnServerValidate="validatorEmail_ServerValidate" CssClass="validator" ValidateEmptyText="True" />
                </li>
            </ul>
        </asp:Panel>
        <asp:Panel id="buttonGroup" runat="server">
            <asp:Button ID="btnSubmitOrder" runat="server" Text="Submit Order" OnClick="btnSubmitOrder_Click" />
            <asp:Button ID="btnCart" runat="server" Text="Shopping Cart" OnClick="btnCart_Click" />
            <asp:Button ID="btnShop" runat="server" Text="Continue Shopping" OnClick="btnShop_Click" />
        </asp:Panel>
    </asp:Panel>
</asp:Content>

