<%@ Page Title="" Language="C#" MasterPageFile="~/Store/StoreMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Store_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitlePlaceHolder" Runat="Server">
    lbrooke.com Store - Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <h1>Select a Product Below To View More Details</h1>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <asp:PlaceHolder ID="itemsPlaceHolder" runat="server"></asp:PlaceHolder>
</asp:Content>

