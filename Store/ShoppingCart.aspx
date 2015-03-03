<%@ Page Title="" Language="C#" MasterPageFile="~/Store/StoreMaster.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Store_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    Shopping Cart
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <h1>Shopping Cart Details</h1>
    <div class="cart">
        <asp:PlaceHolder ID="TablePlaceHolder" runat="server"></asp:PlaceHolder>
        <asp:Button ID="btnCheckout" runat="server" Text="Check Out" OnClick="btnCheckout_Click" />
        <asp:Button ID="btnShop" runat="server" Text="Continue Shopping" OnClick="btnShop_Click" />
    </div>
</asp:Content>

